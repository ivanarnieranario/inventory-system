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
    public partial class frmAllItems : Form
    {
        public Wahventory.controls.ctrl_Reports reportsForm { set; private get; }

        private db_reports reports;
        

        public frmAllItems()
        {
            InitializeComponent();
            reports = new db_reports();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                try
                {
                    int rowIndex = dgvItems.CurrentCell.RowIndex;

                    if (rowIndex > -1)
                    {
                        String id = dgvItems.Rows[rowIndex].Cells[0].Value.ToString();
                        reportsForm.filterByItems(id);
                        this.Close();
                    }
                }
                catch (Exception) { }
            }
        }

        private void frmAllItems_Load(object sender, EventArgs e)
        {
            if (Database.getConnection() != null)
            {
                initCurrentBookValue();
                loadItems();
                txtSearch.Focus();
            }
        }

        private void loadItems()
        {
            dgvItems.DataSource = reports.getAllItems();
            dgvItems.Columns[0].Visible = false;
            dgvItems.Columns[1].Visible = false;
            dgvItems.Columns[2].Visible = false;
            lblItemCount.Text = dgvItems.RowCount.ToString();
            dgvItems.ClearSelection();
        }

        private void initCurrentBookValue()
        {
            Database.set("SELECT tbldepreciation.depreciation_id,tblitem.date_procured,tblitem.price,tbldepreciation.depreciation FROM tblitem INNER JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id;");
            DataTable table = new DataTable();
            table = Database.executeResultSet();

            foreach (DataRow row in table.Rows)
            {
                String id = row["depreciation_id"].ToString();
                String dateProcured = row["date_procured"].ToString();
                double cost = double.Parse(row["price"].ToString());
                double deprec = double.Parse(row["depreciation"].ToString());
                double percentage = 0.0;
                double bookValue = Depreciation.getCurrentBookValue(dateProcured, cost, deprec);

                if (bookValue <= 0)
                    bookValue = 0.00;

                percentage = (bookValue / cost) * 100;

                using (MySql.Data.MySqlClient.MySqlConnection con = Database.getConnection())
                {
                    try
                    {
                        con.Open();
                        String sql = "UPDATE tbldepreciation SET book_value = @bookValue,current_percent = @currentPercent WHERE depreciation_id = @id;";
                        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql,con);
                        command.Parameters.AddWithValue("@bookValue",bookValue);
                        command.Parameters.AddWithValue("@currentPercent",percentage.ToString("N2"));
                        command.Parameters.AddWithValue("@id",id);
                        command.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException exception)
                    {
                        System.Windows.Forms.MessageBox.Show(exception.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.DataSource != null && dgvItems.RowCount > 0)
            {
                int rowIndex = dgvItems.CurrentCell.RowIndex;
                String depreciationId = dgvItems.Rows[rowIndex].Cells[1].Value.ToString();
                String dateProcured = dgvItems.Rows[rowIndex].Cells[6].Value.ToString();
                String cost = dgvItems.Rows[rowIndex].Cells[9].Value.ToString();


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

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var grid = (DataGridView)sender;
            var column = grid.Columns[e.ColumnIndex];


            if (column.Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
            }

            if (column.Name == "Type" || column.Name == "Details" || column.Name == "DateProcured")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;


            if (column.Name == "Method")
            {
                Int32 val = Convert.ToInt32(e.Value);
                if (val == 1)
                    e.Value = "Donation";
                else
                    e.Value = "Purchased";
            }

            if (column.Name == "from_name")
                column.HeaderText = "FROM";

            if (column.Name == "COST")
            {
                double cost = double.Parse(e.Value.ToString());
                e.Value = Format.formatToPeso(cost);
            }

            if (column.Name == "Depreciation")
            {
                double deprec = 0.0;
                if(e.Value.ToString() != "")
                    deprec = double.Parse(e.Value.ToString());
                e.Value = Format.formatToPeso(deprec);
            }


            if (column.Name == "Lifespan")
            {
                if (e.Value.ToString() == "")
                    e.Value = 0;
            }

            if (column.Name == "CurrentBookValue")
            {
                double bookValue = 0.0;
                if (e.Value.ToString() != "")
                   bookValue = double.Parse(e.Value.ToString());

                e.Value = Format.formatToPeso(bookValue);
            }

            if (column.Name == "CurrentPercent")
            {
                double percentage = 0;
                if (e.Value.ToString() == "")
                    e.Value = "0%";
                else
                {
                    percentage = double.Parse(e.Value.ToString());
                    e.Value = percentage + "%";
                }

                if (percentage >= 0.0 && percentage <= 20)
                    e.CellStyle.ForeColor = Color.Red;
                else if (percentage > 20 && percentage <= 50)
                    e.CellStyle.ForeColor = Color.DarkOrange;
                else if (percentage > 50)
                    e.CellStyle.ForeColor = Color.Green;
            }

            
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.text))
                loadItems();
            else
            {
                dgvItems.DataSource = reports.searchAllItems(txtSearch.text);
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                lblItemCount.Text = dgvItems.RowCount.ToString();
                dgvItems.ClearSelection();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPercentFilter_Click(object sender, EventArgs e)
        {
            if (nupPercent.Value > 0)
            {
                dgvItems.DataSource = reports.filterItemPercent(nupPercent.Value.ToString());
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                lblItemCount.Text = dgvItems.RowCount.ToString();
                dgvItems.ClearSelection();
            }
        }

        
    }
}
