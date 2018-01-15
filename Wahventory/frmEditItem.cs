using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wahventory.classes;

namespace Wahventory
{
    public partial class frmEditItem : Form
    {


        private db_from from;
        private db_type types;
        public ctrl_Inventory inventory { set; private get; }
        public String itemId { set; private get; }
        private double cost = 0.0;
        private string depreciationId = null;
        public frmEditItem()
        {
            InitializeComponent();

            types = new db_type();
            from = new db_from();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void loadTypes()
        {
            cbType.Items.Clear();
            foreach (DataRow row in types.getType().Rows)
            {
                cbType.Items.Add(
                    new ComboBoxItem(row["type_name"].ToString(), row["type_id"].ToString())
                    );
            }
        }

        private void loadFrom()
        {
            cbFrom.Items.Clear();
            foreach (DataRow row in from.getFroms().Rows)
            {
                String fromName = row["from_name"].ToString();
                String fromId = row["from_id"].ToString();
                cbFrom.Items.Add(new ComboBoxItem(fromName, fromId));
            }
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {

            loadTypes();
            loadFrom();

            Database.set("SELECT tbltype.type_name,tblitem.isdonated,tblitem.price,tblitem.details,tblitem.depreciation_id,tblitem.date_procured,tblfrom.from_name,tblitem.property_no FROM ((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) LEFT JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) WHERE tblitem.item_id = @itemId;", new String[] { itemId });

            DataTable table = Database.executeResultSet();

            if (table != null)
            {
                DataRow row = table.Rows[0];

                txtPropertyNo.Text = row["property_no"].ToString();
                cbType.Text = row["type_name"].ToString();
                rtDetails.Text = row["details"].ToString();
                dtpProcured.Value = DateTime.Parse(row["date_procured"].ToString());
                cbFrom.Text = row["from_name"].ToString();
                cost = Double.Parse(row["price"].ToString());
                txtCost.Text = Format.formatToPeso(cost);

                if (row["isdonated"].ToString() == "1")
                    rbDonated.Checked = true;
                else
                    rbPurchased.Checked = true;



                Database.set("SELECT tblitem.depreciation_id FROM tblitem WHERE tblitem.item_id = @itemId;", new String[] { itemId });
                depreciationId = Database.executeString();
            }


        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {

           
                txtCost.Text = Format.formatToPeso(cost);

                if (txtCost.Text == "0.00" || txtCost.Text == '\u20B1' + "0.00")
                {
                    MessageBox.Show(null, "Enter the cost of the item first.", "Depreciation item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCost.Focus();
                    txtCost.Select();
                }
                else
                {
                    frmDepreciation depreciation = new frmDepreciation();
                    depreciation.DateProcured = dtpProcured.Value.ToString("MM/dd/yyyy");
                    depreciation.Cost = Format.formatToDecimal(txtCost.Text);
                    depreciation.editItem = this;
                    if (depreciationId == "")
                        depreciation.isAdd = true;
                    else
                    {
                        depreciation.isEdit = true;
                        depreciation.depreciationId = depreciationId;
                        depreciation.isLoad = true;
                    }
                    depreciation.ShowDialog();
                }
            


        }

        private void txtCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Double.TryParse(txtCost.Text, out cost) || cost < 0)
                txtCost.Text = "0.00";
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            txtCost.Text = Format.formatToPeso(cost);
        }

        public void addDepreciation(String depreciationId)
        {
            btnDepreciation.BackColor = Color.Lime;
            btnDepreciation.Enabled = false;
            this.depreciationId = depreciationId;
            txtCost.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            txtCost.Text = Format.formatToPeso(cost);

            String typeId = null, fromId = null;


            if (String.IsNullOrEmpty(cbType.Text))
                cbType.Focus();
            else if (String.IsNullOrEmpty(cbFrom.Text))
                cbFrom.Focus();
            else
            {
                DialogResult result = MessageBox.Show(null, "You want to save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;

                
                //Type
                if (cbType.SelectedIndex < 0)
                {
                    types.TypeName = cbType.Text;


                    Database.set("SELECT type_id FROM tbltype WHERE type_name = @typeName;",new String[]{cbType.Text});
                    String id = Database.executeString();
                    if (String.IsNullOrEmpty(id))
                    {
                        if (types.addType())
                        {
                            typeId = types.getLastinserted();
                            cbType.Items.Add(new ComboBoxItem(cbType.Text, typeId));
                            cbType.SelectedIndex = cbType.Items.Count - 1;
                        }
                    }
                    else
                        typeId = id;
                }
                else
                    typeId = ((ComboBoxItem)cbType.SelectedItem).HiddenValue;


                //From
                if (cbFrom.SelectedIndex < 0)
                {
                    from.FromName = cbFrom.Text;
                    if (from.addFrom())
                    {
                        fromId = from.getLastInserted();
                        cbFrom.Items.Add(new ComboBoxItem(cbFrom.Text, fromId));
                        cbFrom.SelectedIndex = cbFrom.Items.Count - 1;
                    }
                }
                else
                    fromId = ((ComboBoxItem)cbFrom.SelectedItem).HiddenValue;


                using (MySql.Data.MySqlClient.MySqlConnection connection = Database.getConnection())
                {
                    try
                    {
                        connection.Open();

                        int isDonated = 0;
                        if (rbDonated.Checked == true)
                            isDonated = 1;
                        else
                            isDonated = 0;


                        //format date procured
                        String dateProcured = dtpProcured.Value.ToString("yyyy-MM-dd");

                        if (depreciationId == "")
                            depreciationId = null;

                        String sql = "UPDATE tblitem SET isdonated = @isDonated,price = @cost,details = @details,depreciation_id = @deprecId, date_procured = @dateProcured, from_id = @fromId,property_no = @propertyNo WHERE item_id = @itemId;";
                        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@isDonated",isDonated);
                        command.Parameters.AddWithValue("@cost",Format.formatToDecimal(txtCost.Text));
                        command.Parameters.AddWithValue("@details",rtDetails.Text);
                        command.Parameters.AddWithValue("@deprecId",depreciationId);
                        command.Parameters.AddWithValue("@dateProcured",dateProcured);
                        command.Parameters.AddWithValue("@fromId",fromId);
                        command.Parameters.AddWithValue("@propertyNo",txtPropertyNo.Text);
                        command.Parameters.AddWithValue("@itemId",itemId);

                        if (command.ExecuteNonQuery() == 1)
                        {
                            Database.set("SELECT itemtype_id FROM tblitemtype WHERE type_id = @typeId AND item_id = @itemId;",new String[]{typeId,itemId});
                            String itemtypeid = Database.executeString();

                            if (String.IsNullOrEmpty(itemtypeid))
                            {
                                Database.set("INSERT INTO tblitemtype VALUES (null,@typeId,@itemId);",new String[]{typeId,itemId});
                            }
                            else
                            {
                                Database.set("UPDATE tblitemtype SET type_id = @typeId WHERE item_id = @itemId;", new String[] { typeId, itemId });
                            }

                            if (Database.executeNonQuery())
                            {
                                Database.set("UPDATE tblbagitem SET property_no = @propertyNo WHERE item_id = @itemId;", new String[] { txtPropertyNo.Text, itemId });
                                if (Database.executeNonQuery())
                                {
                                    Database.set("UPDATE tbldispose SET property_no = @propertyNo WHERE item_id = @itemId;", new String[] { txtPropertyNo.Text,itemId });
                                    if (Database.executeNonQuery())
                                    {
                                        Database.set("UPDATE tblinventory SET property_no = @propertyNo WHERE item_id = @itemId;", new String[] { txtPropertyNo.Text, itemId });
                                        if (Database.executeNonQuery())
                                        {
                                            Database.set("UPDATE tbltechbag SET property_no = @propertyNo WHERE item_id = @itemId;", new String[] { txtPropertyNo.Text, itemId });
                                            if (Database.executeNonQuery())
                                            {
                                                MessageBox.Show(null, "Changes in the item was Successfully saved.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                                inventory.loadItems();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }
    }
}
