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
            DataTable dt = manager.SponsorDataTable();
            dataGVDash.DataSource = dt;
            dataGVDash.Columns["TotalPrizeValue"].DefaultCellStyle.Format = "C2";
        }
        private void btnDonors_Click(object sender, EventArgs e)
        {
            DataTable dt = manager.DonorDataTable();
            dataGVDash.DataSource = dt;
            dataGVDash.Columns["DonationTotal"].DefaultCellStyle.Format = "C2";
        }
        private void btnPrizes_Click(object sender, EventArgs e)
        {
            DataTable dt = manager.PrizeDataTable();
            dataGVDash.DataSource = dt;
            dataGVDash.Columns["Value"].DefaultCellStyle.Format = "C2";
            dataGVDash.Columns["DonationLimit"].DefaultCellStyle.Format = "C2";
        }
        private void btnDonations_Click(object sender, EventArgs e)
        {
            DataTable dt = manager.DonationDataTable();
            dataGVDash.DataSource = dt;
            dataGVDash.Columns["DonationAmount"].DefaultCellStyle.Format = "C2";
        }
    }
}
