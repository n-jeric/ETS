using ETS.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelethonSystemWin
{
    public partial class FrmDashboard : Form
    {
        ETSManager manager;
        string dirPath;
        public FrmDashboard()
        {
            InitializeComponent();
        }
        public FrmDashboard(ETSManager manager, string dirPath)
        {
            InitializeComponent();
            this.manager = manager;
            this.dirPath = dirPath;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            btnSponsors.Text = manager.numberOfSponsors().ToString();
            btnDonors.Text = manager.numberOfDonors().ToString();
            btnPrizes.Text = manager.numberOfPrizes().ToString();
            btnDonations.Text = manager.donationTotal().ToString("N2");
           
        }

        private void btnSponsors_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;
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
                dataGVDash.DataSource = dt;
            }
        }
        private void btnDonors_Click(object sender, EventArgs e)
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
                dataGVDash.DataSource = dt;
            }
        }
        private void btnPrizes_Click(object sender, EventArgs e)
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
                dataGVDash.DataSource = dt1;
            }
        }
        private void btnDonations_Click(object sender, EventArgs e)
        {
            List<List<string>> uInput;
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
                dataGVDash.DataSource = dt;
            }
        }

    }
}
