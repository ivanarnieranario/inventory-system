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
    public partial class frmDepreciation : Form 
    {
        public String depreciationId { set; get; }

        public ctrl_Inventory inventory { set; private get; }
        public frmEditItem editItem { set; private get; }
        public Wahventory.controls.ctrl_Dispose dispose { set; get; }
        private double salvageValue = 0.00;
        private int lifeSpan = 0;

        public double Cost { set;  get; }
        public String DateProcured { set; private get; }
        public Boolean isLoad = false;
        public Boolean isLost = false;
        public Boolean isAdd = false;
        public Boolean isEdit = false;


        Depreciation depreciation;

        public frmDepreciation()
        {
            InitializeComponent();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalvageValue_Leave(object sender, EventArgs e)
        {
            txtSalvageValue.Text = Wahventory.classes.Format.formatToPeso(salvageValue);
        }

        private void txtSalvageValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Double.TryParse(txtSalvageValue.Text, out salvageValue) || salvageValue < 0)
                txtSalvageValue.Text = "0.00";
        }

        private void txtLifespan_KeyUp(object sender, KeyEventArgs e)
        {
            if (!int.TryParse(txtLifespan.Text, out lifeSpan) || lifeSpan< 0)
                txtLifespan.Text = "0";
        }

        private void frmDepreciation_Load(object sender, EventArgs e)
        {
            if (isLost)
            {
                dgvBookValues.Visible = false;
                pnlLost.Visible = true;
                btnLost.Visible = true;
                isLoad = true;
                
            }

            if (isLoad)
            {

                btnAddDepreciation.Visible = false;
                Database.set("SELECT salvage_value,lifespan FROM tbldepreciation WHERE depreciation_id = @id;",new String[]{depreciationId});
                DataTable deprec = Database.executeResultSet();

                salvageValue = double.Parse(deprec.Rows[0]["salvage_value"].ToString());
                lifeSpan = int.Parse(deprec.Rows[0]["lifespan"].ToString());

                lblCost.Text = Format.formatToPeso(Cost);
                lblDateProcured.Text = DateProcured;
                txtSalvageValue.Text = Format.formatToPeso(salvageValue);
                if (isEdit == false)
                {
                    txtSalvageValue.Enabled = false;
                    txtLifespan.Enabled = false;
                }
                else
                    btnSave.Visible = true;
                txtLifespan.Text = lifeSpan.ToString();
                generate();
            }
            else
            {
                lblCost.Text = Format.formatToPeso(Cost);
                lblDateProcured.Text = DateProcured;
            }


        }

        private void btnAddDepreciation_Click(object sender, EventArgs e)
        {
            if (lblDepreciation.Text.Equals("0.00"))
            {
                MessageBox.Show(null, "I suggest you to click the generate icon FIRST (beside the lifespan), before you click the add to item.", "Depreciation warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                generate();
                return;
            }


            DialogResult result = MessageBox.Show(null,"Are you sure you want to add the " + txtSalvageValue.Text + " salvage value and " + txtLifespan.Text + " lifespan to your item?","Add depreciation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Database.set("INSERT INTO tbldepreciation (salvage_value,lifespan,depreciation) VALUES (@salvageValue,@lifespan,@depreciation);",new String[]{
                    salvageValue.ToString(),
                    lifeSpan.ToString(),
                    Format.formatToDecimal(lblDepreciation.Text).ToString()});
                if (Database.executeNonQuery())
                {
                    MessageBox.Show(null,"Depreciation was successfully added to your item.","Depreciation added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Database.set("SELECT MAX(depreciation_id) FROM tbldepreciation;");
                    if (isAdd == true)
                        editItem.addDepreciation(Database.executeString());
                    else
                        inventory.addDepreciation(Database.executeString());

                    this.Close();
                }
            }

        }

        private void generate()
        {
            depreciation = new Depreciation(
              Cost,
              salvageValue,
              lifeSpan,
              DateProcured
              );

            lblTotal.Text = Format.formatToPeso(depreciation.getTotal());
            lblDepreciation.Text = Format.formatToPeso(depreciation.getDepreciation());

            try
            {
                double percentage = depreciation.getPercentage();
                Math.Round(percentage, 0);
                Math.Round((decimal)percentage, 0);

                gPercentage.Value = Convert.ToInt32(percentage);
                lblPercentage.Text = percentage.ToString("0.00") + "%";
                if (isLost == false)
                {
                    dgvBookValues.DataSource = depreciation.getBookValues();
                    dgvBookValues.ClearSelection();
                }
                else
                {
                    int years = depreciation.getYearsBeetween();
                    double bookValue = 0.0, discount = 0.0;

                    if (years > lifeSpan)
                    {
                        lblYear.ForeColor = Color.Red;
                        lblYear.Text = years + " (exceed the expected lifespan) ";
                    }
                    else
                    {
                        bookValue = depreciation.getCurrentBookValue();
                        discount = (bookValue * 0.1) + bookValue;
                        lblYear.Text = years.ToString();
                    }

                    lblBookValue.Text = Format.formatToPeso(bookValue);
                    lblPlusten.Text = Format.formatToPeso(discount);
                }
            }
            catch (Exception) { }

        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generate();
        }

    

        private void dgvBookValues_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null,"Are you sure that the item is lost?","Lost item",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                dispose.markAsLost();
                this.Close();
            }
            else
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            txtSalvageValue.Text = Wahventory.classes.Format.formatToPeso(salvageValue);
            generate();
            DialogResult result = MessageBox.Show(null, "Are you sure you want to update the depreciation to your item?", "Update depreciation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (MySql.Data.MySqlClient.MySqlConnection connection = Database.getConnection())
                {
                    try
                    {
                        connection.Open();
                       String sql = "UPDATE tbldepreciation SET salvage_value = @salvageValue,lifespan = @lifeSpan,depreciation = @deprec WHERE depreciation_id = @deprecId;";
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql,connection);
                    command.Parameters.AddWithValue("@salvageValue",Format.formatToDecimal(txtSalvageValue.Text));
                    command.Parameters.AddWithValue("@lifeSpan",txtLifespan.Text);
                    command.Parameters.AddWithValue("@deprecId", depreciationId);
                    command.Parameters.AddWithValue("@deprec", Format.formatToDecimal(lblDepreciation.Text));
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show(null, "Depreciation was successfully updated to your item.", "Depreciation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }finally{
                        connection.Close();
                    }
                }
            }



        }

       

    }
}
