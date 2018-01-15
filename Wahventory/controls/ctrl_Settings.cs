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
    public partial class ctrl_Settings : UserControl
    {
        public frmHome homeForm { set; private get; }

        public ctrl_Settings()
        {
            InitializeComponent();
        }

        public void init()
        {
            txtServer.Text = Properties.Settings.Default.server;
            txtPort.Text = Properties.Settings.Default.port;
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
            txtDatabase.Text = Properties.Settings.Default.database;
            clearPassword();
        }

        public void disableUser()
        {
            gbChangePassword.Visible = false;
            btnUserAccount.Visible = false;
        }


        
        private void warningMessage(String warning, WindowsFormsControlLibrary1.BunifuCustomTextbox txt)
        {
            lblWarning.Text = warning;
            txt.BorderColor = Color.Red;
            txt.Focus();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServer.Text))
                warningMessage("Server is empty! ", txtServer);
            else if (string.IsNullOrWhiteSpace(txtPort.Text))
                warningMessage("Port number is empty!", txtPort);
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
                warningMessage("Username is empty!", txtUsername);
            else if (string.IsNullOrWhiteSpace(txtDatabase.Text))
                warningMessage("Configuration Name is empty!", txtDatabase);
            else
            {
                int parsedValue;
                if (!int.TryParse(txtPort.Text, out parsedValue)) //if the port is not a number
                    warningMessage("Invalid port number!", txtPort);
                else
                {
                    Properties.Settings.Default.server = txtServer.Text;
                    Properties.Settings.Default.port = txtPort.Text;
                    Properties.Settings.Default.username = txtUsername.Text;
                    Properties.Settings.Default.password = txtPassword.Text;
                    Properties.Settings.Default.database = txtDatabase.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show(null, "Successfully Updated.", "Configuration Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    homeForm.loadConnection();
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Database.getConnection() == null)
            {
                MessageBox.Show(null,"Sorry, you can't change your password if the connection is failed.","Change password",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrEmpty(txtCurrentPassword.Text))
                    txtCurrentPassword.Focus();
                else if (String.IsNullOrEmpty(txtNewPassword.Text))
                    txtNewPassword.Focus();
                else if (String.IsNullOrEmpty(txtConfirmPassword.Text))
                    txtConfirmPassword.Focus();
                else
                {
                    String password = Hash.sha256(txtCurrentPassword.Text);
                    Database.set("SELECT BINARY user_id FROM tblusers WHERE password = @password AND user_id = @userId;",new String[]{password,frmLogin.UserId});
                    String id = Database.executeString();
                    if (id == "")
                    {
                        MessageBox.Show(null, "Invalid password, please enter the correct password.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCurrentPassword.Focus();
                        txtCurrentPassword.SelectAll();
                    }
                    else
                    {
                        if (lblConfirm.Visible == true)
                        {
                            txtNewPassword.Focus();
                            txtNewPassword.SelectAll();
                        }
                        else
                        {
                            Database.set("UPDATE tblusers SET password = @password WHERE user_id = @id;", new String[] { Hash.sha256(txtNewPassword.Text), frmLogin.UserId });
                            if (Database.executeNonQuery())
                                MessageBox.Show(null, "Password was successfully changed.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearPassword();
                            lblWarning.Visible = false;
                        }
                    }
                }
            }
        }

        private void clearPassword()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                lblConfirm.Visible = true;
            else
                lblConfirm.Visible = false;
        }

        public void enabledUserAccount(Boolean enable)
        {
            gbChangePassword.Visible = true;
            btnUserAccount.Visible = enable;
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();
        }

      

    }
}
