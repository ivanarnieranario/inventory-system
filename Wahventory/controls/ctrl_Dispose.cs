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
    public partial class ctrl_Dispose : UserControl
    {
        private db_item items;
        private db_inventory inventory;

        public ctrl_Dispose()
        {
            InitializeComponent();
            items = new db_item();
            inventory = new db_inventory();
        }

        public void init()
        {
            if (Database.getConnection() != null)
            {
                loadItems();
                loadDisposedItems();

                cbOption.SelectedIndex = 0;
            }
        }

        private void loadDisposedItems()
        {
            dgvDisposedItems.DataSource = inventory.getDisposedItems();
            dgvDisposedItems.Columns[0].Visible = false;
            dgvDisposedItems.Columns[1].Visible = false;
            lblHistoryCount.Text = dgvDisposedItems.RowCount.ToString();
            dgvDisposedItems.ClearSelection();
        }

        private void loadItems()
        {
            dgvItems.DataSource = items.getItems();
            dgvItems.Columns[0].Visible = false;
            dgvItems.Columns[1].Visible = false;
            lblItemCount.Text = dgvItems.RowCount.ToString();
            dgvItems.ClearSelection();
        }


        private void ctrl_Dispose_Load(object sender, EventArgs e)
        {
           
        }
  
        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "isreturn")
            {

                grid.Columns[e.ColumnIndex].HeaderText = "";
                if (e.Value.ToString() == "1" && dgvItems.Rows[e.RowIndex].Cells[6].Value.ToString() != "WAH OFFICE")
                {
                    dgvItems.Rows[e.RowIndex].Cells[6].Value = "WAH OFFICE";
                }


                if (e.Value.ToString() == "1")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.White;
                }
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
           
            
            if (grid.Columns[e.ColumnIndex].Name == "COST")
            {
                try
                {
                    double price = double.Parse(e.Value.ToString());
                    e.Value = Format.formatToPeso(price);
                }
                catch (Exception) { }
            }
           
            if (grid.Columns[e.ColumnIndex].Name == "Depreciation")
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

            if (grid.Columns[e.ColumnIndex].Name == "from_name")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "FROM";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }
            
            if(grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" )
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;

        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.DataSource != null && dgvItems.RowCount > 0)
            {
                int rowIndex = dgvItems.CurrentCell.RowIndex;
                String depreciationId = dgvItems.Rows[rowIndex].Cells[1].Value.ToString();
                String dateProcured = dgvItems.Rows[rowIndex].Cells[7].Value.ToString();
                String cost = dgvItems.Rows[rowIndex].Cells[10].Value.ToString();


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

        private void dgvDisposedItems_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDisposedItems.ClearSelection();
        }

        private void dgvDisposedItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }


            if (grid.Columns[e.ColumnIndex].Name == "dispose_option")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "Action";
                int option = Convert.ToInt32(e.Value);
                switch (option)
                {
                    case 0:
                        e.Value = "Throw";
                        e.CellStyle.BackColor = Color.Black;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case 1:
                        e.Value = "Sell";
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case 2:
                        e.Value = "Donate";
                        e.CellStyle.BackColor = Color.Blue;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case 3:
                        e.Value = "LOST";
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                }
            }

            if(grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "LastUsedBy" || grid.Columns[e.ColumnIndex].Name == "Reason" || grid.Columns[e.ColumnIndex].Name == "Remarks")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
               
        }

        private void txtSearchItems_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchItems.text))
                loadItems();
            else
            {
                dgvItems.DataSource = items.searchDisposeItems(txtSearchItems.text);
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                lblItemCount.Text = dgvItems.RowCount.ToString();
                dgvItems.ClearSelection();
            }
        }

        private void txtSearchHistory_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchHistory.text))
            {
                loadDisposedItems();
            }
            else
            {
                dgvDisposedItems.DataSource = inventory.searchDisposeItems(txtSearchHistory.text);
                dgvDisposedItems.Columns[0].Visible = false;
                dgvDisposedItems.Columns[1].Visible = false;
                lblHistoryCount.Text = dgvDisposedItems.RowCount.ToString();
                dgvDisposedItems.ClearSelection();
            }
        }

        private void btnDisposeItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                if (cbOption.SelectedIndex < 0)
                    cbOption.Focus();
                else
                {

                    int rowIndex = -1;

                    try
                    {
                        rowIndex = dgvItems.CurrentCell.RowIndex;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please select an item.");
                        return;
                    }

                    String propertyNo = dgvItems.Rows[rowIndex].Cells[3].Value.ToString();
                    String action = cbOption.SelectedItem.ToString().ToLower();
                    String holderName = dgvItems.Rows[rowIndex].Cells[6].Value.ToString();

                    if (dgvItems.Rows[rowIndex].Cells[2].Value.ToString() == "0")
                    {
                        MessageBox.Show(null,"Sorry, you can't " + action + " this item. Because the item was currently used by " + holderName,"Dispose item",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show(null, "Are you sure you want to " + action + " this item?", "Dispose item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.No)
                        return;

                    String option = cbOption.SelectedIndex.ToString();
                    String date = dtpDateDisposed.Value.ToString("yyyy-MM-dd");
                    String itemId = dgvItems.Rows[rowIndex].Cells[0].Value.ToString();

                    if (inventory.insertDispose(option, itemId,"WAH OFFICE", date, rtReason.Text, rtRemarks.Text,propertyNo))
                    {
                        MessageBox.Show(null, "Item was succcessfully disposed.", action + " item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDisposedItems();
                        loadItems();
                        tabControl1.SelectedIndex = 1;
                        rtReason.Text = string.Empty;
                        rtRemarks.Text = string.Empty;
                        cbOption.SelectedIndex = -1;
                    }

                }
            }
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                int rowIndex = -1;

                try
                {
                    rowIndex = dgvItems.CurrentCell.RowIndex;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }

                if (rowIndex > -1)
                {
                   
                    String depreciationId = dgvItems.Rows[rowIndex].Cells[1].Value.ToString();
                    String dateProcured = dgvItems.Rows[rowIndex].Cells[7].Value.ToString();
                    String cost = dgvItems.Rows[rowIndex].Cells[10].Value.ToString();

                    if (depreciationId != "")
                    {
                        frmDepreciation depreciation = new frmDepreciation();
                        depreciation.isLost = true;
                        depreciation.dispose = this;
                        depreciation.Cost = double.Parse(cost);
                        depreciation.DateProcured = dateProcured;
                        depreciation.depreciationId = depreciationId;
                        depreciation.ShowDialog();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(null,"Are you sure that the item is lost?","Lost item",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                            markAsLost();
                    }
                    
                }
            }
        }

        public void markAsLost()
        {
            if (dgvItems.RowCount > 0)
            {
                    int rowIndex = dgvItems.CurrentCell.RowIndex;
                    String propertyNo = dgvItems.Rows[rowIndex].Cells[3].Value.ToString();


                    String holderName = dgvItems.Rows[rowIndex].Cells[6].Value.ToString();
                    String isReturn = dgvItems.Rows[rowIndex].Cells[11].Value.ToString();
                    if (isReturn == "1")
                        holderName = "WAH OFFICE";

                    String date = dtpDateDisposed.Value.ToString("yyyy-MM-dd");
                    String itemId = dgvItems.Rows[rowIndex].Cells[0].Value.ToString();

                    if (inventory.insertDispose("3", itemId, holderName, date, rtReason.Text, rtRemarks.Text, propertyNo))
                    {
                        if (holderName != "WAH OFFICE")
                        {

                            using (MySql.Data.MySqlClient.MySqlConnection con = Database.getConnection())
                            {

                                try
                                {
                                    con.Open();
                                    String sql = "UPDATE tblinventory SET islost = 'LOST' WHERE (property_no = @propertyNo AND tblinventory.holder_id = (SELECT tblholders.holder_id FROM tblholders WHERE tblholders.holder_name = @holderName) AND tblinventory.isreturn = 0);";
                                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                                    command.Parameters.AddWithValue("@propertyNo",propertyNo);
                                    command.Parameters.AddWithValue("@holderName",holderName);
                                    command.ExecuteNonQuery();
                                }
                                catch (MySql.Data.MySqlClient.MySqlException exception)
                                {
                                    MessageBox.Show(exception.Message);
                                }
                                finally
                                {
                                    con.Close();
                                }
                            }
                        }
                            MessageBox.Show(null, "Item was successfully marked as Lost.", "Lost item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDisposedItems();
                            loadItems();
                            tabControl1.SelectedIndex = 1;
                            rtReason.Text = string.Empty;
                            rtRemarks.Text = string.Empty;
                            cbOption.SelectedIndex = -1;
                    }
            }
        }
      
        
    
    }
}
