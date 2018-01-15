using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wahventory.classes;

namespace Wahventory.controls
{
    public partial class ctrl_Techbag : UserControl
    {
        db_techbag techbag;
        db_inventory inventory;

        public ctrl_Techbag()
        {
            InitializeComponent();
            techbag = new db_techbag();
            inventory = new db_inventory();
        }

        public void init()
        {
            loadBags();
            loadHolders();
            clearRelease();
        }

        private void loadBags()
        {
            cbBags.Items.Clear();
            foreach (DataRow row in techbag.getBags().Rows)
            {
                cbBags.Items.Add(
                    new ComboBoxItem(row["bag_name"].ToString(), row["bag_id"].ToString())
                    );
            }
        }
   
        private void cbBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTechbags();
        }

        private void loadTechbags()
        {
            if (cbBags.SelectedIndex > -1)
            {
                String id = ((ComboBoxItem)cbBags.SelectedItem).HiddenValue;
                dgvItems.DataSource = techbag.getTechBagItems(id);
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                dgvItems.ClearSelection();
            }
        }


        private void loadHolders()
        {
            cbHolderName.Items.Clear();
            foreach (DataRow row in inventory.getHolders(true).Rows)
            {
                cbHolderName.Items.Add(
                    new ComboBoxItem(row["holder_name"].ToString(), row["holder_id"].ToString())
                    );
            }
            cbHolderName.SelectedIndex = -1;
            cbHolderName.Text = string.Empty;
        }
            
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbHolderName.Text))
                cbHolderName.Focus();
            else if (cbBags.SelectedIndex == -1)
                cbBags.Focus();
            else if (String.IsNullOrEmpty(txtLocation.Text))
                txtLocation.Focus();
            else
            {
                if (dgvItems.RowCount < 1)
                {
                    MessageBox.Show(null, cbBags.Text + " is empty.", "Release bag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearRelease();
                    return;
                }


                if (dgvItems.RowCount > 0)
                {
                    if (dgvItems.Rows[0].Cells[8].Value.ToString().Equals("OUT"))
                    {
                        MessageBox.Show(null,"Sorry, but the bag is currently OUT.","Release bag",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        clearRelease();
                        return;
                    }
                }

                DialogResult result = MessageBox.Show(null, "Make sure to double check the items, because you cannot alter the records for security purposes.", "Release bag", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                    return;

                String holderId = null;
                String bagId = ((ComboBoxItem)cbBags.SelectedItem).HiddenValue;
                //Holders
                if (cbHolderName.SelectedIndex < 0)
                {
                    if (inventory.addHolders(cbHolderName.Text, "1"))
                    {
                        holderId = inventory.getLastHolderId();
                        cbHolderName.Items.Add(new ComboBoxItem(cbHolderName.Text, holderId));
                    }
                }
                else
                    holderId = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;


                if (techbag.insertTechBagInfo(holderId, bagId, txtLocation.Text, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd")))
                {
                    String infoId = techbag.getLastInfoId();
                    Boolean ok = false;

                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        String itemId = row.Cells[1].Value.ToString();
                        String propertyNo = row.Cells[2].Value.ToString();
                        String status = row.Cells[8].Value.ToString();
                        String condition = row.Cells[9].Value.ToString();
                        String qty = row.Cells[3].Value.ToString();
                        String bagItemId = row.Cells[0].Value.ToString();

                        if (techbag.insertTechBagLogs(bagItemId,"Release", infoId, itemId, propertyNo, condition, qty,""))
                        {
                            ok = true;
                        }
                    }
                    if (ok)
                    {
                        MessageBox.Show(null, "Bag was successfully released.", "Release bag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadTechbags();
                        clearRelease();
                    }

                }

            }
        }




        private void loadTravelInfo()
        {
            dgvTravelHistory.DataSource = techbag.getTravelInfo();
            dgvTravelHistory.Columns[0].Visible = false;
        }

        private void clearRelease()
        {
            cbBags.SelectedIndex = -1;
            cbBags.Text = string.Empty;
            cbHolderName.SelectedIndex = -1;
            cbHolderName.Text = String.Empty;
            txtLocation.Text = String.Empty;
            dgvItems.DataSource = null;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                clearRelease();
            }

            if (tabControl1.SelectedIndex == 1)
            {
                loadTravelInfo();
                dgvTravelHistory.ClearSelection();
                dgvTravelItems.DataSource = null;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                dgvTravelRecords.DataSource = techbag.getTravelRecords();
                dgvTravelRecords.Columns[0].Visible = false;
                dgvTravelRecords.ClearSelection();
                dgvRelease.DataSource = dgvReturn.DataSource = null;
            }
        }

        private void dgvTravelHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTravelHistory.RowCount > 0)
            {
                int rowIndex = dgvTravelHistory.CurrentCell.RowIndex;
                String id = dgvTravelHistory.Rows[rowIndex].Cells[0].Value.ToString();
                dgvTravelItems.DataSource = techbag.getItemsByTravelInfo(id);

                dgvTravelItems.ClearSelection();

                dgvTravelItems.Columns[4].ReadOnly = dgvTravelItems.Columns[5].ReadOnly = dgvTravelItems.Columns[6].ReadOnly = dgvTravelItems.Columns[7].ReadOnly = true;
                dgvTravelItems.Columns[0].DisplayIndex = 7;
                dgvTravelItems.Columns[1].DisplayIndex = 7;
                dgvTravelItems.Columns[2].Visible = false;
                dgvTravelItems.Columns[3].Visible = false;
                dgvTravelItems.ClearSelection();
            }
        }


        private void dgvTravelItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int currentQuantity = Convert.ToInt32(dgvTravelItems.Rows[e.RowIndex].Cells[5].Value.ToString());

                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    dgvTravelItems.Rows[e.RowIndex].Cells[5].Value = currentQuantity;
                }
            }

        }

        private void dgvTravelItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTravelItems.CurrentCell.ColumnIndex == 0 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentcell = dgvTravelItems.CurrentCellAddress;
            ComboBox comboBox = (ComboBox)sender;
            
            if (comboBox.SelectedIndex == 1)
            {
                dgvTravelItems.Rows[currentcell.Y].DefaultCellStyle.BackColor = Color.Red;
                dgvTravelItems.Rows[currentcell.Y].DefaultCellStyle.ForeColor = Color.White;
            }

            dgvTravelItems.ClearSelection();
        }

        private void dgvTravelItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
        }

        private void btnReturnBag_Click(object sender, EventArgs e)
        {
            if (dgvTravelHistory.RowCount > 0)
            {

                Boolean ok = false;


                foreach (DataGridViewRow row in dgvTravelItems.Rows)
                {
                    try
                    {
                        String condition = row.Cells[0].Value.ToString();
                    }
                    catch (Exception) {
                        MessageBox.Show(null, "Please make sure to select 1 row (to update the condition) before returning the bag and also fill all the condition.", "Return bag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                    DialogResult result = MessageBox.Show(null, "Make sure to double check the items, because you cannot alter the records for security purposes.", "Return bag", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Cancel)
                        return;


                    int rowIndex = dgvTravelHistory.CurrentCell.RowIndex;
                    String infoId = dgvTravelHistory.Rows[rowIndex].Cells[0].Value.ToString();
                    String bagName = dgvTravelHistory.Rows[rowIndex].Cells[2].Value.ToString();

                    foreach (DataGridViewRow row in dgvTravelItems.Rows)
                    {
                        String condition = row.Cells[0].Value.ToString();
                        String property = row.Cells[4].Value.ToString();
                        String qty = row.Cells[5].Value.ToString();
                        String bagItemId = row.Cells[3].Value.ToString();
                        String itemId = row.Cells[2].Value.ToString();

                        if (condition == "OUT OF STOCK")
                            qty = "0";

                        if (techbag.insertTechBagLogs(bagItemId, "Return", infoId, itemId, property, condition, qty,bagName))
                        {
                            ok = true;
                        }
                    }



                    if (ok)
                    {
                        MessageBox.Show(null, "Bag was successfully returned.", "Return bag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadTravelInfo();
                        loadTechbags();
                        dgvTravelItems.DataSource = null;
                    }

                
               

            }
        }

        private void dgvTravelItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvTravelRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "isdone")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "";
                if (e.Value.ToString() == "1")
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Blue;
                }

                e.Value = "";
            }
        }

        private void dgvTravelRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTravelRecords.RowCount > 0)
            {
                int rowIndex = dgvTravelRecords.CurrentCell.RowIndex;
                String infoId = dgvTravelRecords.Rows[rowIndex].Cells[0].Value.ToString();

                dgvRelease.DataSource = techbag.getTravelRecordsItem("Release", infoId);
                dgvReturn.DataSource = techbag.getTravelRecordsItem("Return", infoId);
                dgvRelease.ClearSelection();
                dgvReturn.ClearSelection();
            }
        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
            }

            if (grid.Columns[e.ColumnIndex].Name == "from_name")
                grid.Columns[e.ColumnIndex].HeaderText = "FROM";
            
            if (grid.Columns[e.ColumnIndex].Name == "status")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "STATUS";
                if (e.Value.ToString() == "IN")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "item_condition")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "Condition";
            }
        }

        private void dgvRelease_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";

            if (grid.Columns[e.ColumnIndex].Name == "item_condition")
                grid.Columns[e.ColumnIndex].HeaderText = "Condition";

        }

        private void dgvReturn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";

            if (grid.Columns[e.ColumnIndex].Name == "item_condition")
            {
                String val = (String)e.Value;
                if (val == "LOST")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (val == "OUT OF STOCK")
                {
                    e.CellStyle.ForeColor = Color.OrangeRed;
                }
                
                grid.Columns[e.ColumnIndex].HeaderText = "Condition";
            }
            
        }







    
    }
}
