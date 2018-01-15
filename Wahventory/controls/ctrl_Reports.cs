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
    public partial class ctrl_Reports : UserControl
    {
        private db_reports reports;
        private db_inventory inventory;
        private db_techbag techbag;

        public ctrl_Reports()
        {
            InitializeComponent();
            reports = new db_reports();
            inventory = new db_inventory();
            techbag = new db_techbag();
        }


        public void init()
        {
            if (Database.getConnection() != null)
            {
                loadAllReports();
                loadHolderName();
            }
        }

        private void loadDisposedItems()
        {
            dgvDisposedItems.DataSource = inventory.getDisposedItems();
            dgvDisposedItems.Columns[0].Visible = false;
            dgvDisposedItems.Columns[1].Visible = false;
            lblReportsCount.Text = dgvDisposedItems.RowCount.ToString();
            dgvDisposedItems.ClearSelection();
        }

        private void loadTechBags()
        {
            dgvTechbagReports.DataSource = techbag.getTravelRecords();
            dgvTechbagReports.Columns[0].Visible = false;
            lblReportsCount.Text = dgvTechbagReports.RowCount.ToString();
            dgvTechbagReports.ClearSelection();
        }

        private void loadAllReports()
        {
            dgvReports.DataSource = reports.getAllReports();
            loadOthers();
            if(cbHolderName.Items.Count > 0)
                cbHolderName.SelectedIndex = -1;
        }

        private void loadOthers()
        {
            try
            {
                dgvReports.Columns[0].Visible = false;
                dgvReports.Columns[1].Visible = false;
                dgvReports.Columns[2].Visible = false;
                lblReportsCount.Text = dgvReports.RowCount.ToString();
            }
            catch (Exception) { }
        }

        private void loadHolderName()
        {
            cbHolderName.Items.Clear();
            foreach (DataRow row in reports.getHolders(switchHolder.Value).Rows)
            {
                cbHolderName.Items.Add(new ComboBoxItem(row["holder_name"].ToString(),row["holder_id"].ToString()));
            }
        }


        private void ctrl_Reports_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Action")
            {
                String val = (String)e.Value.ToString();
                if (val == "1")
                {
                    e.Value = "Returned";
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    e.Value = "Assigned";
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "DateReceived")
            {
                String date = (String)e.Value.ToString();
                if (date == "0000-00-00")
                    e.Value = "WAH OFFICE";
            }

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }

            if (grid.Columns[e.ColumnIndex].HeaderText == "Remarks")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;

            if (grid.Columns[e.ColumnIndex].HeaderText == "Details")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;

            if (grid.Columns[e.ColumnIndex].HeaderText == "Type")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;

            if (grid.Columns[e.ColumnIndex].Name == "holder_name")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "AssignedTo/ReturnedBy";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }

            if (grid.Columns[e.ColumnIndex].Name == "islost")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "";
                grid.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (e.Value.ToString() == "LOST")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

        }

        private void dgvReports_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReports.ClearSelection();
        }

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReports.DataSource != null && dgvReports.RowCount > 0)
            {
                int rowIndex = dgvReports.CurrentCell.RowIndex;
                String depreciationId = dgvReports.Rows[rowIndex].Cells[1].Value.ToString();
                String dateProcured = dgvReports.Rows[rowIndex].Cells[8].Value.ToString();
                String cost = dgvReports.Rows[rowIndex].Cells[2].Value.ToString();


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
                    MessageBox.Show(null,"No depreciation assigned to this item.","Depreciation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void switchHolder_OnValueChange(object sender, EventArgs e)
        {
            if (switchHolder.Value == false)
                lblHolderName.Text = "Name/Group/Facility:";
            else
                lblHolderName.Text = "Employee Name:";

            loadHolderName();
            cbHolderName.Text = string.Empty;
            cbHolderName.SelectedIndex = -1;
        }

        private void cbHolderName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHolderName.SelectedIndex > -1 && dgvReports.RowCount > 0)
            {
                String id = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;
                dgvReports.DataSource = reports.filterByHolder(id);
                loadOthers();
            }
            
        }

        private void tblFilterDate_Click(object sender, EventArgs e)
        {
            String id = "";
            String from = dtpFrom.Value.ToString("yyyy-MM-dd");
            String to = dtpTo.Value.ToString("yyyy-MM-dd");

            if (cbHolderName.SelectedIndex > -1)
                id = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;

            dgvReports.DataSource = reports.filterByDate(from, to,rbProcured.Checked,id);
            loadOthers();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.text))
            {
                String id = "";
                if (cbHolderName.SelectedIndex > -1)
                    id = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;
                
                dgvReports.DataSource = reports.searchReturnReports(txtSearch.text,id);
                loadOthers();
            }
            else
                loadAllReports();
        }

        private void cbHolderName_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbHolderName.SelectedIndex < 0)
                loadAllReports();
        }

        private void cbWahOfficeOnly_OnChange(object sender, EventArgs e)
        {
            if (cbWahOfficeOnly.Checked == true)
            {
                String id = "";
                if (cbHolderName.SelectedIndex > -1)
                    id = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;

                dgvReports.DataSource = reports.getWahOfficeOnly(id);
                loadOthers();
            }
            else
                loadAllReports();
        }


        public void filterByItems(String itemId)
        {
            dgvReports.DataSource = reports.filterByItems(itemId);
            loadOthers();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text))
            {
                Export export = new Export();
                if (tabControl1.SelectedIndex == 0)
                    export.ExportToExcel(dgvReports, txtTitle.Text, 0);
                else if (tabControl1.SelectedIndex == 1)
                    export.ExportToExcel(dgvDisposedItems, txtTitle.Text, 1);
                else if (tabControl1.SelectedIndex == 2)
                    export.ExportToExcel(dgvTechbagReports, txtTitle.Text, 2);
            }
            else
                MessageBox.Show(null,"Enter the title first","Export reports",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            frmAllItems allItems = new frmAllItems();
            allItems.reportsForm = this;
            allItems.ShowDialog();
        }

        private void dgvReports_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvReports.RowCount > 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    try
                    {
                        int rowIndex = dgvReports.CurrentCell.RowIndex;
                        String isLost = dgvReports.Rows[rowIndex].Cells[12].Value.ToString();

                        if (isLost != "")
                        {
                            String property  = dgvReports.Rows[rowIndex].Cells[4].Value.ToString();
                            tabControl1.SelectedIndex = 1;

                            foreach (DataGridViewRow row in dgvDisposedItems.Rows)
                            {
                                if (row.Cells[3].Value.ToString() == property)
                                {
                                    dgvDisposedItems.Rows[row.Index].Cells[3].Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception) { }
                }
            }
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

            if (grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "LastUsedBy" || grid.Columns[e.ColumnIndex].Name == "Reason" || grid.Columns[e.ColumnIndex].Name == "Remarks")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
               
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblReportsCount.Text = dgvReports.RowCount.ToString();
                pnlHolders.Visible = btnViewItems.Visible = lblWahOfficeOnly.Visible = cbWahOfficeOnly.Visible = rbProcured.Visible = rbReceived.Visible = true;
                txtSearchDispose.Visible = btnFilterDisposeDate.Visible = txtSearchTechBag.Visible = false;
                rbReleased.Visible = rbReturned.Visible = false;
                txtSearch.Visible = btnFilterDate.Visible = true;
                rbProcured.Checked = true;
                loadAllReports();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                loadDisposedItems();
                pnlHolders.Visible = btnViewItems.Visible = lblWahOfficeOnly.Visible = cbWahOfficeOnly.Visible = rbProcured.Visible = rbReceived.Visible = false;
                txtSearch.Visible = btnFilterDate.Visible = btnTechBagFilterDate.Visible = txtSearchTechBag.Visible = false;
                rbReleased.Visible = rbReturned.Visible = false;
                txtSearchDispose.Visible = btnFilterDisposeDate.Visible = true;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                loadTechBags();
                pnlHolders.Visible = btnViewItems.Visible = lblWahOfficeOnly.Visible = cbWahOfficeOnly.Visible = rbProcured.Visible = rbReceived.Visible = false;
                txtSearchDispose.Visible = btnFilterDisposeDate.Visible = btnFilterDate.Visible = txtSearchDispose.Visible = btnTechBagFilterDate.Visible = false;
                txtSearchTechBag.Visible = btnTechBagFilterDate.Visible = true;

                rbReleased.Visible = rbReturned.Visible = true;
                rbReleased.Checked = true;
            }

        }

        private void txtSearchDispose_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchDispose.text))
            {
                loadDisposedItems();
            }
            else
            {
                dgvDisposedItems.DataSource = inventory.searchDisposeItems(txtSearchDispose.text);
                dgvDisposedItems.Columns[0].Visible = false;
                dgvDisposedItems.Columns[1].Visible = false;
                lblReportsCount.Text = dgvDisposedItems.RowCount.ToString();
                dgvDisposedItems.ClearSelection();
            }
        }

        private void btnFilterDisposeDate_Click(object sender, EventArgs e)
        {

            String from = dtpFrom.Value.ToString("yyyy-MM-dd");
            String to = dtpTo.Value.ToString("yyyy-MM-dd");

            dgvDisposedItems.DataSource = reports.filterDisposeByDate(from,to);
            dgvDisposedItems.Columns[0].Visible = false;
            dgvDisposedItems.Columns[1].Visible = false;
            lblReportsCount.Text = dgvDisposedItems.RowCount.ToString();
            dgvDisposedItems.ClearSelection();
        }

        private void dgvTechbagReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

            if (grid.Columns[e.ColumnIndex].Name == "Employee" || grid.Columns[e.ColumnIndex].Name == "Bag" || grid.Columns[e.ColumnIndex].Name == "Destination")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
        }

        private void txtSearchTechBag_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchTechBag.text))
            {
                loadTechBags();
            }
            else
            {
                dgvTechbagReports.DataSource = techbag.searchTravelRecords(txtSearchTechBag.text);
                dgvTechbagReports.Columns[0].Visible = false;
                lblReportsCount.Text = dgvTechbagReports.RowCount.ToString();
                dgvTechbagReports.ClearSelection();
            }
        }

        private void btnTechBagFilterDate_Click(object sender, EventArgs e)
        {
            String from = dtpFrom.Value.ToString("yyyy-MM-dd");
            String to = dtpTo.Value.ToString("yyyy-MM-dd");

            dgvTechbagReports.DataSource = techbag.filterTravelRecords(from, to,rbReleased.Checked);
            dgvTechbagReports.Columns[0].Visible = false;
            lblReportsCount.Text = dgvTechbagReports.RowCount.ToString();
            dgvTechbagReports.ClearSelection();
            
        }

        private void dgvTechbagReports_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTechbagReports.RowCount > 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    int rowIndex = dgvTechbagReports.CurrentCell.RowIndex;
                    String id = dgvTechbagReports.Rows[rowIndex].Cells[0].Value.ToString();
                    String employee = dgvTechbagReports.Rows[rowIndex].Cells[1].Value.ToString();
                    String bag = dgvTechbagReports.Rows[rowIndex].Cells[2].Value.ToString();
                    String destination = dgvTechbagReports.Rows[rowIndex].Cells[3].Value.ToString();
                    String release = dgvTechbagReports.Rows[rowIndex].Cells[4].Value.ToString();
                    String returned = dgvTechbagReports.Rows[rowIndex].Cells[5].Value.ToString();
                    new frmTechBagItems(id,employee,bag,destination,release,returned).ShowDialog();
                }
            }
        }


    }
}
