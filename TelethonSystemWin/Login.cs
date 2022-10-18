using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using TelethonSystemWin.CusControls;

namespace TelethonSystemWin
{
    public partial class Login : Form
    {
        static string dirPath = @".\TextFolder\";
        static string filePath = dirPath + "Login.txt";
        public Login()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            var path = new GraphicsPath();

            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
            txtPassword.PasswordChar = true;
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Violet;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Gainsboro;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ReadLogin())
            {
                CusMessageBox.Show("Wrong User Name or Password.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            else
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Violet;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Gainsboro;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Move Form
        //import using System.Runtime.InteropServices > allowing to use native operating system libraries
        //user32.dll allows to move form with mouse event
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public bool ReadLogin()
        {
            using (StreamReader textIn = new StreamReader(filePath))
            {
                while (textIn.Peek() != -1)
                {
                    string[] strArr;
                    strArr = textIn.ReadLine().Split(',');
                    if (strArr[0].Equals(txtUserName.Texts))
                    {
                        if (strArr[1].Equals(txtPassword.Texts))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogin.ForeColor = Color.MediumPurple;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.MediumPurple;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor= Color.DarkGray;
        }
    }
}
