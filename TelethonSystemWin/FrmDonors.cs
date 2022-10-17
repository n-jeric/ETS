﻿using ETS.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
//using System.Windows.Media;
using TelethonSystemWin.CusControls;

namespace TelethonSystemWin
{
    public partial class FrmDonors : Form
    {
        ETSManager manager;
        //private List<CusTextBox> textBoxes_ = null;
        public FrmDonors()
        {
            InitializeComponent();
        }
        public FrmDonors(ETSManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        #region KeyPress Input Control
        private void txtDonorFName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDonorLName_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9, -,
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void txtCreditCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtExpiration_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9, /,
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '/')
            {
                e.Handled = true;
            }
    }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get reference to calling control
            CusTextBox textBox1 = sender as CusTextBox;
            // Only allow 0-9
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        //private void validateModuleDetails()
        //{
        //    bool validData = true;
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is CusTextBox)
        //        {
        //            CusTextBox textbox = control as CusTextBox;
        //            validData &= !string.IsNullOrWhiteSpace(textbox.Texts);
        //        }
        //    }

        //    btnSaveDonor.Enabled = validData;
        //}
        private void DnClear()
        {

            txtDonorFName.Texts = "*";
            txtDonorLName.Texts = "*";
            txtAddress.Texts = "*";
            txtPhone.Texts = "*";
            txtCreditCard.Texts = "*";
            txtExpiration.Texts = "*";
        } 
        private void NumClear()
        {
            txtNumber.Texts = "*";
            txtNumber.ForeColor = Color.DarkGray;
        }
        private void DonorClear()
        {
            txtDonorID.Clear();
            txtDonorID.PlaceholderText = txtDonorID.PlaceholderText;
            txtDonorFName.Clear();
            txtDonorFName.PlaceholderText = txtDonorFName.PlaceholderText;
            txtDonorLName.Clear();
            txtDonorLName.PlaceholderText = txtDonorLName.PlaceholderText;
            txtAddress.Clear();
            txtAddress.PlaceholderText = txtAddress.PlaceholderText;
            txtPhone.Clear();
            txtPhone.PlaceholderText = txtPhone.PlaceholderText;
            gbCardType.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            txtCreditCard.Clear();
            txtCreditCard.PlaceholderText = txtCreditCard.PlaceholderText;
            txtExpiration.Clear();
            txtExpiration.PlaceholderText = txtExpiration.PlaceholderText;
        }
        private void DonationClear()
        {
            txtDonationID.Clear();
            txtDonationID.PlaceholderText = txtDonationID.PlaceholderText;
            txtAmount.Clear();
            txtAmount.PlaceholderText = txtAmount.PlaceholderText;
            txtNumber.Clear();
            txtNumber.PlaceholderText = txtNumber.PlaceholderText;
            txtNumber.ForeColor = Color.DarkGray;
            comBoxPrize.Items.Clear();
            comBoxPrize.ResetText();

        }
        private string SelectedRadioButton(Control group)
        {
            List<CusRadioButton> buttons = new List<CusRadioButton>();
            string selectedTag = "";

            foreach (Control c in group.Controls)
            {
                if (c.GetType() == typeof(CusRadioButton))
                {
                    buttons.Add((CusRadioButton)c);
                }
            }
            var selectedRb = (from rb in buttons where rb.Checked == true select rb).FirstOrDefault();

            if (selectedRb != null)
            {
                selectedTag = selectedRb.Tag.ToString();
            }
            return selectedTag;
        }
        private void SelectRadioButton(Control group, string tag)
        {
            List<CusRadioButton> buttons = new List<CusRadioButton>();

            foreach (Control c in group.Controls)
            {
                if (c.GetType() == typeof(CusRadioButton))
                {
                    buttons.Add((CusRadioButton)c);
                }
            }
            var selectedRb = (from rb in buttons where rb.Tag.ToString() == tag select rb).FirstOrDefault();

            if (selectedRb != null)
            {
                selectedRb.Checked = true;
            }
        }
        private void btnSaveDonor_Click(object sender, EventArgs e)
        {
            char CardType;
            try
            {
                CardType = char.Parse(SelectedRadioButton(gbCardType));
            }
            catch (Exception ex)
            {
                CusMessageBox.Show("Please select Credit Card Type.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            string msg = manager.AddDonor(txtDonorID.Texts.Trim(), txtDonorFName.Texts.Trim(), txtDonorLName.Texts.Trim(),txtAddress.Texts.Trim(), txtPhone.Texts, CardType, txtCreditCard.Texts, txtExpiration.Texts);

            CusMessageBox.Show(msg);
            if (msg.Contains("ID")) { txtDonorID.Focus(); return; }
            else if (msg.Contains("First")) { txtDonorFName.Focus(); return; }
            else if (msg.Contains("Last")) { txtDonorLName.Focus(); return; }
            else if (msg.Contains("Address")) { txtAddress.Focus(); return; }
            else if (msg.Contains("phone")) { txtPhone.Focus(); return; }
            else if (msg.Contains("credit")) { txtCreditCard.Focus(); return; }
            else if (msg.Contains("expir")) { txtExpiration.Focus(); return; }
            else { DonorClear(); }
        }
        private void btnSaveDonation_Click(object sender, EventArgs e)
        {
            if(comBoxPrize.SelectedItem != null)
            {
                string prize = comBoxExtract();
                string msg = manager.AddDonation(txtDonationID.Texts, txtDonorID.Texts, double.Parse(txtAmount.Texts), prize, int.Parse(txtNumber.Texts));

                CusMessageBox.Show(msg);
                if (msg.Contains("Donation")) { txtDonationID.Focus(); return; }
                else if (msg.Contains("Donor")) { txtDonorID.Focus(); return; }
                else if (msg.Contains("Minimum")) { txtAmount.Focus(); return; }
                else if (msg.Contains("Prize")) { comBoxPrize.Focus(); txtNumber.Clear(); return; }
                else { DonationClear(); DonorClear();}
            }
            else
            {
                CusMessageBox.Show("Select prize from DropDown List","Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
        }

        private void btnViewDonors_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;// = new List<List<string>>();
            DataTable dt = new DataTable();
            string[] usIn = new string[7];

            uInput = manager.ListingDonors();

            dt.Columns.Add("Donor ID", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Card Type", typeof(string));
            dt.Columns.Add("Donation Total", typeof(string));



            for (int i = 0; i < uInput.Count; i++)
            {
                for (int j = 0; j < usIn.Length; j++)
                {
                    usIn[j] = uInput[i][j];
                }
                dt.Rows.Add(usIn);
                dataGVDonors.DataSource = dt;
            }
        }
        private void btnViewDonations_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;// = new List<List<string>>();
            DataTable dt = new DataTable();
            string[] usIn = new string[6];

            uInput = manager.ListingDonations();

            dt.Columns.Add("Donation ID", typeof(string));
            dt.Columns.Add("Donation Date", typeof(string));
            dt.Columns.Add("Donation Amount", typeof(string));
            dt.Columns.Add("Donor ID", typeof(string));
            dt.Columns.Add("Prize ID", typeof(string));
            dt.Columns.Add("Num Prizes", typeof(string));


            for (int i = 0; i < uInput.Count; i++)
            {
                for (int j = 0; j < usIn.Length; j++)
                {
                    usIn[j] = uInput[i][j];
                }
                dt.Rows.Add(usIn);
                dataGVDonors.DataSource = dt;
            }
        }
        private void btnClearDonor_Click(object sender, EventArgs e)
        {
            DonorClear();
        }
        private void txtDonorID_Leave(object sender, EventArgs e)
        {
            string info = manager.FindDonor(txtDonorID.Texts);
            if (info != "")
            {
                string[] strArr;
                strArr = info.Split(',');

                DnClear();
                txtDonorFName.Texts = strArr[0];
                txtDonorLName.Texts = strArr[1];
                txtAddress.Texts = strArr[2];
                txtPhone.Texts = strArr[3];
                SelectRadioButton(gbCardType, strArr[4]);
                txtCreditCard.Texts = strArr[5];
                txtExpiration.Texts = strArr[6];

                txtDonationID.Focus();

            }
        }

        private void btnShowPrizes_Click(object sender, EventArgs e)
        {
            if(txtAmount.Texts != "")
            {
                List<List<string>> uInput;// = new List<List<string>>();
                DataTable dt1 = new DataTable();
                string[] usIn = new string[6];
                //Object[] usIn = new Object[6];

                uInput = manager.ListingPrizes(Convert.ToDouble(txtAmount.Texts));

                dt1.Columns.Add("Prize ID", typeof(string));
                dt1.Columns.Add("Description", typeof(string));
                dt1.Columns.Add("Value", typeof(string));
                dt1.Columns.Add("Donation Limit", typeof(string));
                dt1.Columns.Add("Current Available", typeof(string));
                dt1.Columns.Add("Number", typeof(string));


                //for (int i = 0; i < uInput.Count; i++)
                //{

                //    usIn[0] = uInput[i][0];
                //    usIn[1] = uInput[i][1];
                //    usIn[2] = uInput[i][2];
                //    usIn[3] = uInput[i][3];
                //    usIn[4] = uInput[i][4];
                //    usIn[5] = int.Parse(uInput[i][5]);

                //    dt1.Rows.Add(usIn);
                //    dataGVDonors.DataSource = dt1;
                //}


                for (int i = 0; i < uInput.Count; i++)
                {
                    for (int j = 0; j < usIn.Length; j++)
                    {
                        usIn[j] = uInput[i][j];
                    }
                    dt1.Rows.Add(usIn);
                    dataGVDonors.DataSource = dt1;
                }
                ShowPrizesComboBox();
            }
            
        }
        private void ShowPrizesComboBox()
        {
            comBoxPrize.Items.Clear();
            comBoxPrize.ResetText();
            txtNumber.PlaceholderText = txtNumber.PlaceholderText;
            comBoxPrize.Texts = comBoxPrize.Tag.ToString();
            List<string> prizeListCombo;
            prizeListCombo = manager.ListQualifiedPrizes(Convert.ToDouble(txtAmount.Texts));
            prizeListCombo.ForEach(p => { comBoxPrize.Items.Add(p); });
        }

        private string comBoxExtract()
        {
            
                string pr = comBoxPrize.SelectedItem.ToString();
                string prize = pr.Split(' ')[0];
                return prize;

        }
        private void comBoxPrize_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string prize = comBoxExtract();
            int num = manager.numberOfPrizes(prize, double.Parse(txtAmount.Texts));
            int numAvailable = manager.numberAvilable(prize);

            NumClear();

            if (num < numAvailable)
            {
                txtNumber.Texts = num.ToString();
                comBoxPrize.ForeColor = Color.Gainsboro;
            }
            else 
            { 
                txtNumber.Texts = $"{num.ToString()} Avail:({numAvailable})";
                txtNumber.ForeColor = Color.FromArgb(249, 88, 155);
                comBoxPrize.ForeColor = Color.Gainsboro;
            }
        }

        private void btnClearDonation_Click(object sender, EventArgs e)
        {
            DonationClear();
        }
        
        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            if(txtDonorID.Texts != "")
            {
                if (CusMessageBox.Show($"Do you want to delete Donor {txtDonorID.Texts}? ",
              "Delete Donor", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    string msg = manager.RemoveDonor(txtDonorID.Texts);
                    CusMessageBox.Show(msg);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
