namespace TelethonSystemWin
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSponsors = new FontAwesome.Sharp.IconButton();
            this.btnDonors = new FontAwesome.Sharp.IconButton();
            this.btnPrizes = new FontAwesome.Sharp.IconButton();
            this.btnDonations = new FontAwesome.Sharp.IconButton();
            this.pnSponsors = new System.Windows.Forms.Panel();
            this.pnDonors = new System.Windows.Forms.Panel();
            this.pnPrizes = new System.Windows.Forms.Panel();
            this.pnDonations = new System.Windows.Forms.Panel();
            this.txtDonations = new TelethonSystemWin.CusTextBox();
            this.txtPrizes = new TelethonSystemWin.CusTextBox();
            this.txtDonors = new TelethonSystemWin.CusTextBox();
            this.txtSponsors = new TelethonSystemWin.CusTextBox();
            this.panelDashData = new System.Windows.Forms.Panel();
            this.dataGVDash = new System.Windows.Forms.DataGridView();
            this.pnSponsors.SuspendLayout();
            this.pnDonors.SuspendLayout();
            this.pnPrizes.SuspendLayout();
            this.pnDonations.SuspendLayout();
            this.panelDashData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDash)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSponsors
            // 
            this.btnSponsors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSponsors.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSponsors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSponsors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnSponsors.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnSponsors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSponsors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSponsors.IconSize = 120;
            this.btnSponsors.Location = new System.Drawing.Point(0, 0);
            this.btnSponsors.Name = "btnSponsors";
            this.btnSponsors.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.btnSponsors.Size = new System.Drawing.Size(162, 208);
            this.btnSponsors.TabIndex = 0;
            this.btnSponsors.Text = "Sponsors";
            this.btnSponsors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSponsors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSponsors.UseVisualStyleBackColor = false;
            this.btnSponsors.Click += new System.EventHandler(this.btnSponsors_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDonors.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnDonors.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnDonors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDonors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonors.IconSize = 120;
            this.btnDonors.Location = new System.Drawing.Point(0, 0);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.btnDonors.Size = new System.Drawing.Size(162, 208);
            this.btnDonors.TabIndex = 2;
            this.btnDonors.Text = "Donors";
            this.btnDonors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDonors.UseVisualStyleBackColor = true;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnPrizes
            // 
            this.btnPrizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrizes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnPrizes.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.btnPrizes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPrizes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrizes.IconSize = 120;
            this.btnPrizes.Location = new System.Drawing.Point(0, 0);
            this.btnPrizes.Name = "btnPrizes";
            this.btnPrizes.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.btnPrizes.Size = new System.Drawing.Size(162, 208);
            this.btnPrizes.TabIndex = 4;
            this.btnPrizes.Text = "Prizes";
            this.btnPrizes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrizes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrizes.UseVisualStyleBackColor = true;
            this.btnPrizes.Click += new System.EventHandler(this.btnPrizes_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDonations.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.btnDonations.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnDonations.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDonations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonations.IconSize = 120;
            this.btnDonations.Location = new System.Drawing.Point(0, 0);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.btnDonations.Size = new System.Drawing.Size(162, 208);
            this.btnDonations.TabIndex = 6;
            this.btnDonations.Text = "Donations";
            this.btnDonations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDonations.UseVisualStyleBackColor = true;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // pnSponsors
            // 
            this.pnSponsors.Controls.Add(this.txtSponsors);
            this.pnSponsors.Controls.Add(this.btnSponsors);
            this.pnSponsors.Location = new System.Drawing.Point(54, 28);
            this.pnSponsors.Name = "pnSponsors";
            this.pnSponsors.Size = new System.Drawing.Size(162, 208);
            this.pnSponsors.TabIndex = 9;
            // 
            // pnDonors
            // 
            this.pnDonors.Controls.Add(this.txtDonors);
            this.pnDonors.Controls.Add(this.btnDonors);
            this.pnDonors.Location = new System.Drawing.Point(260, 27);
            this.pnDonors.Name = "pnDonors";
            this.pnDonors.Size = new System.Drawing.Size(162, 208);
            this.pnDonors.TabIndex = 10;
            // 
            // pnPrizes
            // 
            this.pnPrizes.Controls.Add(this.txtPrizes);
            this.pnPrizes.Controls.Add(this.btnPrizes);
            this.pnPrizes.Location = new System.Drawing.Point(464, 27);
            this.pnPrizes.Name = "pnPrizes";
            this.pnPrizes.Size = new System.Drawing.Size(162, 208);
            this.pnPrizes.TabIndex = 11;
            // 
            // pnDonations
            // 
            this.pnDonations.Controls.Add(this.txtDonations);
            this.pnDonations.Controls.Add(this.btnDonations);
            this.pnDonations.Location = new System.Drawing.Point(668, 27);
            this.pnDonations.Name = "pnDonations";
            this.pnDonations.Size = new System.Drawing.Size(162, 208);
            this.pnDonations.TabIndex = 11;
            // 
            // txtDonations
            // 
            this.txtDonations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtDonations.BorderColor = System.Drawing.Color.Transparent;
            this.txtDonations.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtDonations.BorderRadius = 0;
            this.txtDonations.BorderSize = 0;
            this.txtDonations.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonations.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDonations.Location = new System.Drawing.Point(1, 1);
            this.txtDonations.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonations.MaxLength = 32767;
            this.txtDonations.Multiline = false;
            this.txtDonations.Name = "txtDonations";
            this.txtDonations.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtDonations.PasswordChar = false;
            this.txtDonations.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonations.PlaceholderText = "";
            this.txtDonations.ReadOnly = true;
            this.txtDonations.Size = new System.Drawing.Size(160, 44);
            this.txtDonations.TabIndex = 7;
            this.txtDonations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDonations.Texts = "Donations";
            this.txtDonations.UnderlineStyle = false;
            // 
            // txtPrizes
            // 
            this.txtPrizes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtPrizes.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrizes.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPrizes.BorderRadius = 0;
            this.txtPrizes.BorderSize = 0;
            this.txtPrizes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrizes.Location = new System.Drawing.Point(1, 1);
            this.txtPrizes.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrizes.MaxLength = 32767;
            this.txtPrizes.Multiline = false;
            this.txtPrizes.Name = "txtPrizes";
            this.txtPrizes.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtPrizes.PasswordChar = false;
            this.txtPrizes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrizes.PlaceholderText = "";
            this.txtPrizes.ReadOnly = true;
            this.txtPrizes.Size = new System.Drawing.Size(160, 44);
            this.txtPrizes.TabIndex = 5;
            this.txtPrizes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrizes.Texts = "Prizes";
            this.txtPrizes.UnderlineStyle = false;
            // 
            // txtDonors
            // 
            this.txtDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtDonors.BorderColor = System.Drawing.Color.Transparent;
            this.txtDonors.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtDonors.BorderRadius = 0;
            this.txtDonors.BorderSize = 0;
            this.txtDonors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonors.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDonors.Location = new System.Drawing.Point(1, 1);
            this.txtDonors.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonors.MaxLength = 32767;
            this.txtDonors.Multiline = false;
            this.txtDonors.Name = "txtDonors";
            this.txtDonors.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtDonors.PasswordChar = false;
            this.txtDonors.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonors.PlaceholderText = "";
            this.txtDonors.ReadOnly = true;
            this.txtDonors.Size = new System.Drawing.Size(160, 44);
            this.txtDonors.TabIndex = 3;
            this.txtDonors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDonors.Texts = "Donors";
            this.txtDonors.UnderlineStyle = false;
            // 
            // txtSponsors
            // 
            this.txtSponsors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtSponsors.BorderColor = System.Drawing.Color.Transparent;
            this.txtSponsors.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSponsors.BorderRadius = 0;
            this.txtSponsors.BorderSize = 0;
            this.txtSponsors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSponsors.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSponsors.Location = new System.Drawing.Point(1, 2);
            this.txtSponsors.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponsors.MaxLength = 32767;
            this.txtSponsors.Multiline = false;
            this.txtSponsors.Name = "txtSponsors";
            this.txtSponsors.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtSponsors.PasswordChar = false;
            this.txtSponsors.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSponsors.PlaceholderText = "";
            this.txtSponsors.ReadOnly = true;
            this.txtSponsors.Size = new System.Drawing.Size(160, 44);
            this.txtSponsors.TabIndex = 1;
            this.txtSponsors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSponsors.Texts = "Sponsors";
            this.txtSponsors.UnderlineStyle = false;
            // 
            // panelDashData
            // 
            this.panelDashData.Controls.Add(this.dataGVDash);
            this.panelDashData.Location = new System.Drawing.Point(54, 287);
            this.panelDashData.Name = "panelDashData";
            this.panelDashData.Size = new System.Drawing.Size(773, 320);
            this.panelDashData.TabIndex = 29;
            // 
            // dataGVDash
            // 
            this.dataGVDash.AllowUserToAddRows = false;
            this.dataGVDash.AllowUserToDeleteRows = false;
            this.dataGVDash.AllowUserToResizeRows = false;
            this.dataGVDash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVDash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.dataGVDash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVDash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVDash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVDash.ColumnHeadersHeight = 34;
            this.dataGVDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGVDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDash.EnableHeadersVisualStyles = false;
            this.dataGVDash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.dataGVDash.Location = new System.Drawing.Point(0, 0);
            this.dataGVDash.Name = "dataGVDash";
            this.dataGVDash.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDash.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVDash.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGVDash.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVDash.RowTemplate.Height = 25;
            this.dataGVDash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDash.Size = new System.Drawing.Size(773, 320);
            this.dataGVDash.TabIndex = 12;
            this.dataGVDash.TabStop = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.panelDashData);
            this.Controls.Add(this.pnDonations);
            this.Controls.Add(this.pnPrizes);
            this.Controls.Add(this.pnDonors);
            this.Controls.Add(this.pnSponsors);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnSponsors.ResumeLayout(false);
            this.pnDonors.ResumeLayout(false);
            this.pnPrizes.ResumeLayout(false);
            this.pnDonations.ResumeLayout(false);
            this.panelDashData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSponsors;
        private CusTextBox txtSponsors;
        private CusTextBox txtDonors;
        private FontAwesome.Sharp.IconButton btnDonors;
        private CusTextBox txtPrizes;
        private FontAwesome.Sharp.IconButton btnPrizes;
        private CusTextBox txtDonations;
        private FontAwesome.Sharp.IconButton btnDonations;
        private System.Windows.Forms.Panel pnSponsors;
        private System.Windows.Forms.Panel pnDonors;
        private System.Windows.Forms.Panel pnPrizes;
        private System.Windows.Forms.Panel pnDonations;
        private System.Windows.Forms.Panel panelDashData;
        private System.Windows.Forms.DataGridView dataGVDash;
    }
}