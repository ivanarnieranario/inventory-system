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
using Wahventory.Properties;
using System.Globalization;
using AutoUpdaterDotNET;

namespace Wahventory
{
    public partial class frmHome : Form
    {
        DateTime dateTime = DateTime.Now;

        public static int LIMIT_RECORD = 20;

        public frmHome()
        {
            InitializeComponent();
            ctrl_Settings1.homeForm = this;
            loadConnection();
        }

        public void loadConnection()
        {
            if (Database.getConnection() == null)
            {
                setVisibleControl(false, false);
                setVisibleButton(false);
                lblConnection.Text = "Connection failed! Please check the settings.";
                lblConnection.ForeColor = Color.FromArgb(255, 128, 128);
                ctrl_Settings1.Visible = true;
                lblTitle.Text = "     SETTINGS";
                btnSettings.selected = true;
                lblUserFullName.Text = String.Empty;
                ctrl_Settings1.disableUser();
                lblUser.Visible = false;
                btnSwitchAccount.Visible = false;
                lblLimitRecords.Visible = false;
                cbLimiteRecords.Visible = false;
            }
            else
            {
                setVisibleControl(true, false);
                setVisibleButton(true);
                lblConnection.Text = "Successfully Connected.";
                lblConnection.ForeColor = Color.Lime;
                lblTitle.Text = "     REPORTS";
                btnReports.selected = true;
                btnSettings.selected = false;
                btnSwitchAccount.Visible = true;
                frmLogin.switchAccount = false;
                loginUser();
                lblLimitRecords.Visible = true;
                cbLimiteRecords.Visible = true;
                cbLimiteRecords.SelectedIndex = 4;
            }
        }

        private void loginUser()
        {
            frmLogin login = new frmLogin();
            login.homeForm = this;
            login.ShowDialog();
            lblUserFullName.Text = frmLogin.UserFullName;
            lblUser.Visible = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDateTime.Start();
            lblDate.Text = dateTime.ToString("MM/dd/yyyy");

            setVisibleControl(false, true);
            lblTitle.Text = "     Wireless Access for Health Inventory";

            lblUserFullName.Text = frmLogin.UserFullName;


            checkForUpdates();
        }



        private void checkForUpdates()
        {
            //Uncomment below line to see Russian version

            //AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            //If you want to open download page when user click on download button uncomment below line.

            //AutoUpdater.OpenDownloadPage = true;

            //Don't want user to select remind later time in AutoUpdater notification window then uncomment 3 lines below so default remind later time will be set to 2 days.

            //AutoUpdater.LetUserSelectRemindLater = false;
            //AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            //AutoUpdater.RemindLaterAt = 2;

            AutoUpdater.Start("https://www.dropbox.com/s/vay5gn18fmjidjw/updates.xml?dl=0");
        }



        private void setVisibleControl(Boolean visible,Boolean includeSetting)
        {
            ctrl_Reports1.Visible = visible;
            ctrl_Inventory1.Visible = visible;
            ctrl_Return1.Visible = visible;
            ctrl_Dispose1.Visible = visible;
            ctrl_Techbag1.Visible = visible;
            if (includeSetting)
                ctrl_Settings1.Visible = visible;
        }

        private void setVisibleButton(Boolean visible)
        {
            btnReports.Visible = visible;
            btnInventory.Visible = visible;
            btnReturn.Visible = visible;
            btnDisposeItem.Visible = visible;
            btnTechBag.Visible = visible;
        }

      
        public void checkLogin(Boolean check)
        {
            if (check == true)
            {
                setVisibleControl(true,true);
                setVisibleButton(true);
                ctrl_Settings1.enabledUserAccount(true);
            }
            else
            {
                setVisibleButton(false);
                setVisibleControl(false, false);
                btnReports.Visible = true;
                ctrl_Reports1.Visible = true;
                ctrl_Techbag1.Visible = false;
                ctrl_Settings1.enabledUserAccount(false);
            }
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ctrl_Reports1.Visible = true;
            setVisibleControl(false, true);
            transitionReports.ShowSync(ctrl_Reports1);
            lblTitle.Text = "     REPORTS";
            ctrl_Reports1.init();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null,"Are you sure you want to close this application?","Closing Appication",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Environment.Exit(0);
           
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            ctrl_Inventory1.Visible = true;
            setVisibleControl(false, true);
            transitionInventory.ShowSync(ctrl_Inventory1);
            lblTitle.Text = "     INVENTORY";
            ctrl_Inventory1.init();
        }

        private void loadDispose()
        {
            try
            {
                ctrl_Dispose1.Visible = true;
                setVisibleControl(false, true);
                transitionDispose.ShowSync(ctrl_Dispose1);
                lblTitle.Text = "     LOST & DISPOSE ITEM";
                ctrl_Dispose1.init();
            }
            catch (Exception) { }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            maximize();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximize();
        }

        private void maximize()
        {
            String icon = null;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                icon = "restore";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                icon = "max";
            }
            object restore = Resources.ResourceManager.GetObject(icon);
            btnMaximize.Iconimage = (Image)restore;
        }

        private void ctrl_Reports1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisposeItem_Click_1(object sender, EventArgs e)
        {
                loadDispose();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            ctrl_Return1.Visible = true;
            setVisibleControl(false, true);
            transitionReturn.ShowSync(ctrl_Return1);
            lblTitle.Text = "     RETURN ITEM";
            ctrl_Return1.init();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ctrl_Settings1.Visible = true;
            setVisibleControl(false, true);
            transitionSettings.ShowSync(ctrl_Settings1);
            lblTitle.Text = "     SETTINGS";
            ctrl_Settings1.init();
        }

        private void btnTechBag_Click(object sender, EventArgs e)
        {
            ctrl_Techbag1.Visible = true;
            setVisibleControl(false, true);
            transitionTechBag.ShowSync(ctrl_Techbag1);
            lblTitle.Text = "     TECH BAG";
            ctrl_Techbag1.init();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //    frmLogin.switchAccount = true;
            //    loginUser();

            try
            {
                Application.Restart();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cbLimiteRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLimiteRecords.SelectedIndex == 0)
                LIMIT_RECORD = 0;
            else
                LIMIT_RECORD = int.Parse(cbLimiteRecords.SelectedItem.ToString());
        }

       

    }
}
