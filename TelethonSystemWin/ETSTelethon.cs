using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using FontAwesome.Sharp;
using ETS.Business;
using TelethonSystemWin.CusControls;

namespace TelethonSystemWin
{
    public partial class ETSTelethon : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        ETSManager manager = new ETSManager();
        static string dirPath = @".\TextFolder\";

        private void ETSTelethon_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        public ETSTelethon()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.DoubleBuffered = true;
        }

        #region Menu Buttons
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
        }
        private void ActivateButton(object senderBtn, Color color) //to highlight active button
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(48, 46, 73);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentButton.Text;
            }
        }
        private void DisableButton() //to disable button highlighting (reset to default)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(40, 45, 64);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //have only one form opened at a time
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            OpenChildForm(new FrmDashboard(manager, dirPath));
        }
        private void btnSponsors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            OpenChildForm(new FrmSponsors(manager));
        }
        private void btnDonors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new FrmDonors(manager));
        }
        private void btnFiles_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }
        private void Reset() //back to main form close all childForms and reset all buttons
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = lblTitleChildForm.Tag.ToString();
        }
        #endregion

        #region Move Form
        //import using System.Runtime.InteropServices > allowing to use native operating system libraries
        //user32.dll allows to move form with mouse event
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Exit Buttons

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Violet;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Gainsboro;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CusMessageBox.Show("Do you want to exit the app.? \n Did you save the changes to file?",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2).ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    Reset();
                }
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (CusMessageBox.Show("Do you want to exit the app.? \n Did you save the changes to file?",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2).ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                    Reset();
                }
            }
        }

        #endregion

        #region Read From File
        private void btnLoadSponsor_Click(object sender, EventArgs e)
        {
            manager.ReadSposor(dirPath);
        }

        private void btnLoadDonor_Click(object sender, EventArgs e)
        {
            manager.ReadDonor(dirPath);
        }

        private void btnLoadPrize_Click(object sender, EventArgs e)
        {
            manager.ReadPrize(dirPath);
        }

        private void btnLoadDonation_Click(object sender, EventArgs e)
        {
            manager.ReadDonation(dirPath);
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            manager.ReadSposor(dirPath);
            manager.ReadDonor(dirPath);
            manager.ReadPrize(dirPath);
            manager.ReadDonation(dirPath);
        }
        #endregion

        #region Save to File
        private void btnSaveSponsor_Click(object sender, EventArgs e)
        {
            string msg = manager.WriteSponsor(dirPath);
            CusMessageBox.Show(msg);
        }

        private void btnSaveDonor_Click(object sender, EventArgs e)
        {
            string msg = manager.WriteDonor(dirPath);
            CusMessageBox.Show(msg);
        }

        private void btnSavePrize_Click(object sender, EventArgs e)
        {
            string msg = manager.WritePrize(dirPath);
            CusMessageBox.Show(msg);
        }

        private void btnSaveDonation_Click(object sender, EventArgs e)
        {
            string msg = manager.WriteDonation(dirPath);
            CusMessageBox.Show(msg);

        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            string msg = manager.WriteSponsor(dirPath);
            if (!msg.Contains("Saved"))
            {
                CusMessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            msg = manager.WriteDonor(dirPath);
            if (!msg.Contains("Saved"))
            {
                CusMessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            msg = manager.WritePrize(dirPath);
            if (!msg.Contains("Saved"))
            {
                CusMessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            msg = manager.WriteDonation(dirPath);
            CusMessageBox.Show(msg);

        }
        #endregion

    }
}
