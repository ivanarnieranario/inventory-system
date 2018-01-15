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
    public partial class frmLogin : Form
    {
        public frmHome homeForm { set; private get; }
        public static String UserId { private set; get; }
        public static String UserFullName { private set; get; }
        public static Boolean switchAccount = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (switchAccount)
                this.Close();
            else
                Environment.Exit(0);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
                txtUsername.Focus();
            else if (String.IsNullOrEmpty(txtPassword.Text))
                txtPassword.Focus();
            else
            {
                Database.set("SELECT user_id,fullname,fullcontrol FROM tblusers WHERE BINARY username = @username AND password = @password;", new String[] { txtUsername.Text, Hash.sha256(txtPassword.Text) });
                DataTable user = new DataTable();
                user = Database.executeResultSet();

                if (user.Rows.Count > 0)
                {
                    foreach (DataRow row in user.Rows)
                    {
                        UserId = row["user_id"].ToString();
                        UserFullName = row["fullname"].ToString();

                        if (row["fullcontrol"].ToString() == "1")
                            homeForm.checkLogin(true);
                        else
                            homeForm.checkLogin(false);

                        this.Close();
                    }
                }
                else
                {
                    txtUsername.Focus();
                    txtUsername.Select();
                    lblInvalid.Visible = true;
                    UserId = "0";
                    UserFullName = String.Empty;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

     
    }
}
