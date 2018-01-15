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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void loadUsers()
        {
            Database.set("SELECT user_id,fullname AS Fullname,username AS Username,fullcontrol AS UserAccess FROM tblusers WHERE fullcontrol = 0;");
            dgvUsers.DataSource = Database.executeResultSet();
            dgvUsers.Columns[0].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFullName.Text))
                txtFullName.Focus();
            else if (String.IsNullOrEmpty(txtUserName.Text))
                txtUserName.Focus();
            else if (String.IsNullOrEmpty(txtPassword.Text))
                txtPassword.Focus();
            else
            {
                Database.set("INSERT INTO tblusers (fullname,username,password,fullcontrol) VALUES (@fullname,@username,@password,@fullcontrol);",new String[]{txtFullName.Text,txtUserName.Text,Hash.sha256(txtPassword.Text),"0"});
                if (Database.executeNonQuery())
                {
                    MessageBox.Show(null,"New user was successfully added.","Add new user",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadUsers();
                }
            }
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "UserAccess")
            {
                String val = (String)e.Value;
                if (val == "1")
                    e.Value = "Full Control";
                else
                    e.Value = "View Reports";
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.RowCount > 0)
            {
                DialogResult result = MessageBox.Show(null, "Are you sure you want to remove this user?", "Remove user", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int rowIndex = dgvUsers.CurrentCell.RowIndex;
                    String id = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();

                    Database.set("DELETE FROM tblusers WHERE user_id = @userId;", new String[] { id });
                    if (Database.executeNonQuery())
                    {
                        MessageBox.Show(null, "User was successfully removed.", "Remove user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadUsers();
                    }
                }
            }
        }

        

       
        
        


    }
}
