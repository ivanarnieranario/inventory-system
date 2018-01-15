using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wahventory
{
    public partial class frmTechBagItems : Form
    {
        private String travelId;
        private String employeeName;
        private String bagName;
        private String destination;
        private String dateReleased;
        private String dateReturned;

        private Wahventory.classes.db_techbag techbag;
        public frmTechBagItems(String travelId,String employeeName,String bagName,String destination,String dateReleased,String dateReturned)
        {
            InitializeComponent();
            this.travelId = travelId;
            this.employeeName = employeeName;
            this.bagName = bagName;
            this.destination = destination;
            this.dateReleased = dateReleased;
            this.dateReturned = dateReturned;
            techbag = new classes.db_techbag();
        }

        private void frmTechBagItems_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = employeeName;
            lblBagName.Text = bagName;
            lblDestination.Text = destination;
            lblDateReleased.Text = dateReleased;
            lblDateReturned.Text = dateReturned;
            dgvRelease.DataSource = techbag.getTravelRecordsItem("Release", travelId);
            dgvReturn.DataSource = techbag.getTravelRecordsItem("Return", travelId);
            dgvRelease.ClearSelection();
            dgvReturn.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDrag_Paint(object sender, PaintEventArgs e)
        {

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
