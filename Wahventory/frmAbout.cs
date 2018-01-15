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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblOsVersion.Text = Environment.OSVersion.ToString(); 
        }

        private void openLink(String link)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch { }
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            openLink("http://www.facebook.com/ivanarnie");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            openLink("https://www.facebook.com/ryanx21");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            openLink("https://www.facebook.com/kaptain0925");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            openLink("http://www.tsu.edu.ph/");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            openLink("http://www.tsu.edu.ph/colleges/college-of-computer-studies/overview/");
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            openLink("http://wah.ph/");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null,"You can email me through gmail: ivanarnietorresranario@gmail.com","Ivan Arnie Ranario",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(null, "You can email me through gmail: rydc21.rc@gmail.com", "Ryan Conception", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "You can email me through gmail: qbryan45@gmail.com", "Bryan Quiambao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblOsVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }


        

        
    }     
}
