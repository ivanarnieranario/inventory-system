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
    public partial class ctrl_Return : UserControl
    {
        db_inventory inventory;
        db_item items;

        public ctrl_Return()
        {
            InitializeComponent();
            inventory = new db_inventory();
            items = new db_item();
        }

        public void init()
        {
            if (Database.getConnection() != null)
            {
                loadStatus();
                loadReturnItems();
                loadReturnHistory();
            }
        }



        private void loadStatus()
        {
            cbStatus.Items.Clear();
            foreach (DataRow row in inventory.getStatus().Rows)
            {
                cbStatus.Items.Add(new ComboBoxItem(
                    row["status_name"].ToString(), row["status_id"].ToString()
                    ));
            }
        }

        private void loadReturnItems()
        {
                dgvReturnItems.DataSource = items.getReturnItems();
                dgvReturnItems.Columns[0].Visible = false;
                dgvReturnItems.Columns[1].Visible = false;
                dgvReturnItems.Columns[2].Visible = false;
                lblReturnItemsCount.Text = dgvReturnItems.RowCount.ToString();
                dgvReturnItems.ClearSelection();
        }

        private void loadReturnHistory()
        {
            dgvReturnHistory.DataSource = inventory.getInventory("1");
            loadOthers();
            lblHistoryCount.Text = dgvReturnHistory.RowCount.ToString();
        }

        private void loadOthers()
        {
            dgvReturnHistory.ClearSelection();
            if (dgvReturnHistory.DataSource != null && dgvReturnHistory.RowCount > 0)
            {
                dgvReturnHistory.Columns[0].Visible = false;
                dgvReturnHistory.Columns[1].Visible = false;
            }
        }

        //Methods
        private String getAutoProperty(String type)
        {
            String generated = null;
            String last = null;
            String no = "0";
            char[] strRemove = { ' ' };

            if (!type.Contains(" ") && type.Length > 3)
                last = type.Substring(1, 2).ToUpper();
            else if (type.Length < 3)
                last = type.Substring(0, 2);

            string[] strWords = type.Split(strRemove);

            foreach (string a in strWords)
            {
                generated += a[0];
            }

            Database.set("SELECT (MAX(inventory_id) + 1) FROM tblinventory;");
            no += Database.executeString();

            generated = generated.Insert(0, "WAH-RTND-");
            return generated + last + no;
        }

        private void ctrl_Return_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvReturnItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }

            if (grid.Columns[e.ColumnIndex].Name == "Method")
            {
                try
                {
                    String val = (String)e.Value;
                    if (val == "1")
                        e.Value = "Donation";
                    else
                        e.Value = "Purchased";
                }
                catch (Exception) { }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "COST")
            {
                try
                {
                    double price = double.Parse(e.Value.ToString());
                    e.Value = Format.formatToPeso(price);
                }
                catch (Exception) { }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "Depreciation")
            {
                String deprec = e.Value.ToString();
                if (deprec.Equals(""))
                {
                    e.Value = Format.formatToPeso(0.00);
                }
                else
                {
                    e.Value = Format.formatToPeso(double.Parse(deprec));
                }
            }

            else if (grid.Columns[e.ColumnIndex].Name == "from_name")
                grid.Columns[e.ColumnIndex].HeaderText = "FROM";

            else if (grid.Columns[e.ColumnIndex].Name == "DateReceived")
            {
                String date = (String)e.Value;
                if (date.Equals("0000-00-00"))
                    e.Value = "WAH OFFICE";
            }


            if (grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "ReceivedBy")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;    


        }

        private void dgvReturnItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReturnItems.DataSource != null && dgvReturnItems.RowCount > 0)
            {
                int rowIndex = dgvReturnItems.CurrentCell.RowIndex;
                String depreciationId = dgvReturnItems.Rows[rowIndex].Cells[1].Value.ToString();
                String dateProcured = dgvReturnItems.Rows[rowIndex].Cells[8].Value.ToString();
                String cost = dgvReturnItems.Rows[rowIndex].Cells[11].Value.ToString();


                if (depreciationId != "")
                {
                    frmDepreciation depreciation = new frmDepreciation();
                    depreciation.isLoad = true;
                    depreciation.Cost = double.Parse(cost);
                    depreciation.DateProcured = dateProcured;
                    depreciation.depreciationId = depreciationId;
                    depreciation.ShowDialog();
                }
                else
                    MessageBox.Show(null, "No depreciation assigned to this item.", "Depreciation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvReturnHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }
            if (grid.Columns[e.ColumnIndex].Name == "AssignedTo")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "ReturnedBy";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }
            if (grid.Columns[e.ColumnIndex].Name == "DateReceived")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "DateReturned";
                String date = (String)e.Value.ToString();
                if (date == "0000-00-00")
                    e.Value = "WAH OFFICE";
            }

            if(grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "Remarks")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.text))
                loadReturnItems();
            else
            {
                dgvReturnItems.DataSource = items.searchReturnItems(txtSearch.text);
                dgvReturnItems.Columns[0].Visible = false;
                dgvReturnItems.Columns[1].Visible = false;
                dgvReturnItems.Columns[2].Visible = false;
                lblReturnItemsCount.Text = dgvReturnItems.RowCount.ToString();
                dgvReturnItems.ClearSelection();
            }
        }

        private void txtSearchHistory_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchHistory.text))
                loadReturnHistory();
            else
            {
                dgvReturnHistory.DataSource = inventory.searchInventory(txtSearchHistory.text, "1");
                loadOthers();
                lblHistoryCount.Text = dgvReturnHistory.RowCount.ToString();
            }
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            if (dgvReturnItems.RowCount > 0 && dgvReturnItems.DataSource != null)
            {
                int rowIndex = -1;
                try
                {
                    rowIndex = dgvReturnItems.CurrentCell.RowIndex;
                }
                catch (Exception)
                {
                    MessageBox.Show(null, "Please select an item.", "Return item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                String itemId = dgvReturnItems.Rows[rowIndex].Cells[0].Value.ToString();
                String propertyNo = dgvReturnItems.Rows[rowIndex].Cells[3].Value.ToString();
                if (cbStatus.SelectedIndex < 0)
                    cbStatus.Focus();

                else if (itemId == "")
                {
                    MessageBox.Show(null, "Please select an item to return.", "Select an item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    String dateReturn = dtpDateReturn.Value.ToString("yyyy-MM-dd");

                    DialogResult result = MessageBox.Show(null, "Does " + dgvReturnItems.Rows[rowIndex].Cells[6].Value.ToString() + " returned the " + dgvReturnItems.Rows[rowIndex].Cells[4].Value.ToString() + " to you on the date " + dateReturn + "?", "Return item", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        String statusId = ((ComboBoxItem)cbStatus.SelectedItem).HiddenValue;
                        String holderId = dgvReturnItems.Rows[rowIndex].Cells[2].Value.ToString();


                        if (inventory.insertInventory(propertyNo, statusId, holderId, dateReturn, txtRemarks.Text, itemId, "1"))
                        {
                            MessageBox.Show(null, "Item was successfully returned to the wah office.", "Return item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadReturnItems();
                            loadReturnHistory();
                            txtRemarks.Text = string.Empty;
                            cbStatus.SelectedIndex = -1;
                            tabControl1.SelectedIndex = 1;
                        }
                    }
                }

            }
        }

        private void dgvReturnHistory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dgvReturnHistory.ClearSelection();
        }
    


        





    
    }
}
