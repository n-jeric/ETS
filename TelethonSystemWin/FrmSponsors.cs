using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Markup;
using ETS.Business;
using TelethonSystemWin.CusControls;

namespace TelethonSystemWin
{
    public partial class FrmSponsors : Form
    {
        ETSManager manager;
        public FrmSponsors()
        {
            InitializeComponent();
        }
        public FrmSponsors(ETSManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void txtSponID_Leave(object sender, EventArgs e)
        {
            string info = manager.FindSponsor(txtSponID.Texts);
            if(info != "")
            {
                string[] strArr;
                strArr = info.Split(',');

                SpClear();
                txtSponFName.Texts = strArr[0];
                txtSponLName.Texts = strArr[1];

                txtPrizeID.Focus();
            }
        }
        private void SpClear()
        {
            
            txtSponFName.Texts = "*";
            txtSponLName.Texts = "*";
        }
        private void SponsorClear()
        {
            txtSponID.Clear();
            txtSponID.PlaceholderText = txtSponID.PlaceholderText;
            txtSponFName.Clear();
            txtSponFName.PlaceholderText = txtSponFName.PlaceholderText;
            txtSponLName.Clear();
            txtSponLName.PlaceholderText = txtSponLName.PlaceholderText;
        }
        private void PrizeClear()
        {
            txtPrizeID.Clear();
            txtPrizeID.PlaceholderText = txtPrizeID.PlaceholderText;
            txtPrizeDesc.Clear();
            txtPrizeDesc.PlaceholderText = txtPrizeDesc.PlaceholderText;
            txtPrizeValue.Clear();
            txtPrizeValue.PlaceholderText = txtPrizeValue.PlaceholderText;
            txtQty.Clear();
            txtQty.PlaceholderText = txtQty.PlaceholderText;
            txtDonationLimit.Clear();
            txtDonationLimit.PlaceholderText = txtDonationLimit.PlaceholderText;
        }

        private void btnSaveSpon_Click(object sender, EventArgs e)
        {
            
            string msg = manager.AddSponsor(txtSponID.Texts, txtSponFName.Texts, txtSponLName.Texts);

            CusMessageBox.Show(msg);
            if (msg.Contains("ID")) { txtSponID.Focus(); return; }
            else if (msg.Contains("Error!")) { txtSponFName.Focus(); return; }
            else if (msg.Contains("Error.")) { txtSponLName.Focus(); return; }
            else { SponsorClear(); }
        }
        private void btnSavePrize_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = manager.AddPrize(txtPrizeID.Texts, txtPrizeDesc.Texts, double.Parse(txtPrizeValue.Texts), double.Parse(txtDonationLimit.Texts), int.Parse(txtQty.Texts), txtSponID.Texts);

                CusMessageBox.Show(msg);
                if(msg.Contains("Sponsor")) { txtSponID.Focus(); return; }
                else if (msg.Contains("ID")) { txtPrizeID.Focus(); return; }
                else if (msg.Contains("value")) { txtPrizeValue.Focus(); return; }
                else if (msg.Contains("quantity")) { txtQty.Focus(); return; }
                else { PrizeClear(); SponsorClear(); }
            }
            catch(Exception ex)
            {
                //CusMessageBox.Show(ex.Message, "Enter values");
                CusMessageBox.Show(ex.Message + "\nPlease fill in all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewSponsor_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;// = new List<List<string>>();
            DataTable dt = new DataTable();
            string[] usIn = new string[4];

            uInput = manager.ListingSponsor();

            dt.Columns.Add("Sponsor ID", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Tot. Prize Value", typeof(string));



            for (int i = 0; i < uInput.Count; i++)
            {
                for (int j = 0; j < usIn.Length; j++)
                {
                    usIn[j] = uInput[i][j];
                }
                dt.Rows.Add(usIn);
                dataGVSponsors.DataSource = dt;
            }
        }
        private void btnViewPrize_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;
            DataTable dt1 = new DataTable();
            string[] usIn = new string[5];

            uInput = manager.ListingPrizes();

            dt1.Columns.Add("Prize ID", typeof(string));
            dt1.Columns.Add("Description", typeof(string));
            dt1.Columns.Add("Value", typeof(string));
            dt1.Columns.Add("Donation Limit", typeof(string));
            dt1.Columns.Add("Current Available", typeof(string));

            for (int i = 0; i < uInput.Count; i++)
            {
                for (int j = 0; j < usIn.Length; j++)
                {
                    usIn[j] = uInput[i][j];
                }
                dt1.Rows.Add(usIn);
                dataGVSponsors.DataSource = dt1;
            }
        }

        private void btnClearSponsor_Click(object sender, EventArgs e)
        {
            SponsorClear();
        }
        private void btnClearPrize_Click(object sender, EventArgs e)
        {
            PrizeClear();
        }
        private void txtPrizeValue_Leave(object sender, EventArgs e)
        {
            if(txtPrizeValue.Texts != "")
            {
                int dLimit = (int)Math.Round((double.Parse(txtPrizeValue.Texts) * 10) / 5.0) * 5;
                txtDonationLimit.Texts = "*";
                txtDonationLimit.Texts = dLimit.ToString("N2");
            }
        }

        private void btnDeleteSponsor_Click(object sender, EventArgs e)
        {
            if (txtSponID.Texts != "")
            {
                if (CusMessageBox.Show($"Do you want to delete Sponsor {txtSponID.Texts}? ",
              "Delete Sponsor", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    string msg = manager.RemoveSponsor(txtSponID.Texts);
                    CusMessageBox.Show(msg);
                }
                else
                {
                    return;
                }
            }
        }

        #region Key Press Control
        private void txtPrizeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            //TextBox textBox = sender as TextBox;
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9, .
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Avoid double decimals
            if (e.KeyChar == '.' && textBox1.Texts.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow 0-9
            if (!char.IsControl(e.KeyChar) &&
               !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDonationLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9, .
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Avoid double decimals
            if (e.KeyChar == '.' && textBox1.Texts.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtSponFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow a-z, -,.
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtSponLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow a-z, -,.
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
