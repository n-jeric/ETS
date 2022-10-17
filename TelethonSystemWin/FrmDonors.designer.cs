namespace TelethonSystemWin
{
    partial class FrmDonors
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
            this.btnViewDonations = new FontAwesome.Sharp.IconButton();
            this.btnViewDonors = new FontAwesome.Sharp.IconButton();
            this.panelSData = new System.Windows.Forms.Panel();
            this.dataGVDonors = new System.Windows.Forms.DataGridView();
            this.btnSaveDonation = new FontAwesome.Sharp.IconButton();
            this.btnSaveDonor = new FontAwesome.Sharp.IconButton();
            this.lblDonation = new System.Windows.Forms.Label();
            this.lblDonor = new System.Windows.Forms.Label();
            this.btnShowPrizes = new FontAwesome.Sharp.IconButton();
            this.btnClearDonor = new System.Windows.Forms.Button();
            this.btnClearDonation = new System.Windows.Forms.Button();
            this.gbCreditCard = new TelethonSystemWin.CusControls.CusGroupBox();
            this.txtExpiration = new TelethonSystemWin.CusTextBox();
            this.txtCreditCard = new TelethonSystemWin.CusTextBox();
            this.gbCardType = new TelethonSystemWin.CusControls.CusGroupBox();
            this.rbAmex = new TelethonSystemWin.CusControls.CusRadioButton();
            this.rbMC = new TelethonSystemWin.CusControls.CusRadioButton();
            this.rbVisa = new TelethonSystemWin.CusControls.CusRadioButton();
            this.comBoxPrize = new TelethonSystemWin.CusControls.CusComboBox();
            this.txtNumber = new TelethonSystemWin.CusTextBox();
            this.txtPhone = new TelethonSystemWin.CusTextBox();
            this.txtAmount = new TelethonSystemWin.CusTextBox();
            this.txtAddress = new TelethonSystemWin.CusTextBox();
            this.txtDonationID = new TelethonSystemWin.CusTextBox();
            this.txtDonorID = new TelethonSystemWin.CusTextBox();
            this.txtDonorLName = new TelethonSystemWin.CusTextBox();
            this.txtDonorFName = new TelethonSystemWin.CusTextBox();
            this.btnDeleteDonor = new FontAwesome.Sharp.IconButton();
            this.panelSData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonors)).BeginInit();
            this.gbCreditCard.SuspendLayout();
            this.gbCardType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewDonations
            // 
            this.btnViewDonations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnViewDonations.FlatAppearance.BorderSize = 0;
            this.btnViewDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDonations.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDonations.ForeColor = System.Drawing.Color.DarkGray;
            this.btnViewDonations.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btnViewDonations.IconColor = System.Drawing.Color.DarkGray;
            this.btnViewDonations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDonations.IconSize = 20;
            this.btnViewDonations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDonations.Location = new System.Drawing.Point(182, 340);
            this.btnViewDonations.Name = "btnViewDonations";
            this.btnViewDonations.Size = new System.Drawing.Size(150, 30);
            this.btnViewDonations.TabIndex = 31;
            this.btnViewDonations.Text = "View Donations";
            this.btnViewDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDonations.UseVisualStyleBackColor = true;
            this.btnViewDonations.Click += new System.EventHandler(this.btnViewDonations_Click);
            // 
            // btnViewDonors
            // 
            this.btnViewDonors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnViewDonors.FlatAppearance.BorderSize = 0;
            this.btnViewDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDonors.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDonors.ForeColor = System.Drawing.Color.DarkGray;
            this.btnViewDonors.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btnViewDonors.IconColor = System.Drawing.Color.DarkGray;
            this.btnViewDonors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDonors.IconSize = 20;
            this.btnViewDonors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDonors.Location = new System.Drawing.Point(33, 340);
            this.btnViewDonors.Name = "btnViewDonors";
            this.btnViewDonors.Size = new System.Drawing.Size(142, 30);
            this.btnViewDonors.TabIndex = 30;
            this.btnViewDonors.Text = "View Donors";
            this.btnViewDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDonors.UseVisualStyleBackColor = true;
            this.btnViewDonors.Click += new System.EventHandler(this.btnViewDonors_Click);
            // 
            // panelSData
            // 
            this.panelSData.Controls.Add(this.dataGVDonors);
            this.panelSData.Location = new System.Drawing.Point(33, 376);
            this.panelSData.Name = "panelSData";
            this.panelSData.Size = new System.Drawing.Size(814, 231);
            this.panelSData.TabIndex = 28;
            // 
            // dataGVDonors
            // 
            this.dataGVDonors.AllowUserToAddRows = false;
            this.dataGVDonors.AllowUserToDeleteRows = false;
            this.dataGVDonors.AllowUserToResizeRows = false;
            this.dataGVDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVDonors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.dataGVDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVDonors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVDonors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVDonors.ColumnHeadersHeight = 34;
            this.dataGVDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGVDonors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDonors.EnableHeadersVisualStyles = false;
            this.dataGVDonors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.dataGVDonors.Location = new System.Drawing.Point(0, 0);
            this.dataGVDonors.Name = "dataGVDonors";
            this.dataGVDonors.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDonors.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVDonors.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGVDonors.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVDonors.RowTemplate.Height = 25;
            this.dataGVDonors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDonors.Size = new System.Drawing.Size(814, 231);
            this.dataGVDonors.TabIndex = 12;
            this.dataGVDonors.TabStop = false;
            // 
            // btnSaveDonation
            // 
            this.btnSaveDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSaveDonation.FlatAppearance.BorderSize = 0;
            this.btnSaveDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDonation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDonation.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSaveDonation.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSaveDonation.IconColor = System.Drawing.Color.DarkGray;
            this.btnSaveDonation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveDonation.IconSize = 20;
            this.btnSaveDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonation.Location = new System.Drawing.Point(661, 340);
            this.btnSaveDonation.Name = "btnSaveDonation";
            this.btnSaveDonation.Size = new System.Drawing.Size(143, 30);
            this.btnSaveDonation.TabIndex = 26;
            this.btnSaveDonation.Text = "Save Donation";
            this.btnSaveDonation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDonation.UseVisualStyleBackColor = true;
            this.btnSaveDonation.Click += new System.EventHandler(this.btnSaveDonation_Click);
            // 
            // btnSaveDonor
            // 
            this.btnSaveDonor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSaveDonor.FlatAppearance.BorderSize = 0;
            this.btnSaveDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDonor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDonor.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSaveDonor.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSaveDonor.IconColor = System.Drawing.Color.DarkGray;
            this.btnSaveDonor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveDonor.IconSize = 20;
            this.btnSaveDonor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonor.Location = new System.Drawing.Point(53, 279);
            this.btnSaveDonor.Name = "btnSaveDonor";
            this.btnSaveDonor.Size = new System.Drawing.Size(137, 30);
            this.btnSaveDonor.TabIndex = 15;
            this.btnSaveDonor.Text = "Save Donor";
            this.btnSaveDonor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDonor.UseVisualStyleBackColor = true;
            this.btnSaveDonor.Click += new System.EventHandler(this.btnSaveDonor_Click);
            // 
            // lblDonation
            // 
            this.lblDonation.AutoSize = true;
            this.lblDonation.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.lblDonation.Location = new System.Drawing.Point(418, 192);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDonation.Size = new System.Drawing.Size(200, 24);
            this.lblDonation.TabIndex = 27;
            this.lblDonation.Text = "Donation Information";
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.lblDonor.Location = new System.Drawing.Point(49, 72);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDonor.Size = new System.Drawing.Size(176, 24);
            this.lblDonor.TabIndex = 24;
            this.lblDonor.Text = "Donor Information";
            // 
            // btnShowPrizes
            // 
            this.btnShowPrizes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnShowPrizes.FlatAppearance.BorderSize = 0;
            this.btnShowPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPrizes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPrizes.ForeColor = System.Drawing.Color.DarkGray;
            this.btnShowPrizes.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.btnShowPrizes.IconColor = System.Drawing.Color.DarkGray;
            this.btnShowPrizes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPrizes.IconSize = 20;
            this.btnShowPrizes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPrizes.Location = new System.Drawing.Point(422, 271);
            this.btnShowPrizes.Name = "btnShowPrizes";
            this.btnShowPrizes.Size = new System.Drawing.Size(143, 30);
            this.btnShowPrizes.TabIndex = 23;
            this.btnShowPrizes.Text = "Show Prizes";
            this.btnShowPrizes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowPrizes.UseVisualStyleBackColor = true;
            this.btnShowPrizes.Click += new System.EventHandler(this.btnShowPrizes_Click);
            // 
            // btnClearDonor
            // 
            this.btnClearDonor.FlatAppearance.BorderSize = 0;
            this.btnClearDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDonor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDonor.ForeColor = System.Drawing.Color.Gray;
            this.btnClearDonor.Location = new System.Drawing.Point(198, 279);
            this.btnClearDonor.Name = "btnClearDonor";
            this.btnClearDonor.Size = new System.Drawing.Size(105, 23);
            this.btnClearDonor.TabIndex = 40;
            this.btnClearDonor.Text = "Clear Donor";
            this.btnClearDonor.UseVisualStyleBackColor = true;
            this.btnClearDonor.Click += new System.EventHandler(this.btnClearDonor_Click);
            // 
            // btnClearDonation
            // 
            this.btnClearDonation.FlatAppearance.BorderSize = 0;
            this.btnClearDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDonation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDonation.ForeColor = System.Drawing.Color.Gray;
            this.btnClearDonation.Location = new System.Drawing.Point(686, 267);
            this.btnClearDonation.Name = "btnClearDonation";
            this.btnClearDonation.Size = new System.Drawing.Size(118, 23);
            this.btnClearDonation.TabIndex = 41;
            this.btnClearDonation.Text = "Clear Donation";
            this.btnClearDonation.UseVisualStyleBackColor = true;
            this.btnClearDonation.Click += new System.EventHandler(this.btnClearDonation_Click);
            // 
            // gbCreditCard
            // 
            this.gbCreditCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.gbCreditCard.Controls.Add(this.txtExpiration);
            this.gbCreditCard.Controls.Add(this.txtCreditCard);
            this.gbCreditCard.Controls.Add(this.gbCardType);
            this.gbCreditCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreditCard.ForeColor = System.Drawing.Color.DarkGray;
            this.gbCreditCard.Location = new System.Drawing.Point(422, 26);
            this.gbCreditCard.Name = "gbCreditCard";
            this.gbCreditCard.Size = new System.Drawing.Size(382, 140);
            this.gbCreditCard.TabIndex = 8;
            this.gbCreditCard.TabStop = false;
            this.gbCreditCard.Text = "Credit Card Information";
            this.gbCreditCard.TextColor = System.Drawing.Color.DimGray;
            // 
            // txtExpiration
            // 
            this.txtExpiration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtExpiration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtExpiration.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtExpiration.BorderRadius = 15;
            this.txtExpiration.BorderSize = 1;
            this.txtExpiration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiration.ForeColor = System.Drawing.Color.DarkGray;
            this.txtExpiration.Location = new System.Drawing.Point(275, 88);
            this.txtExpiration.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiration.MaxLength = 7;
            this.txtExpiration.Multiline = false;
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Padding = new System.Windows.Forms.Padding(6, 7, 7, 7);
            this.txtExpiration.PasswordChar = false;
            this.txtExpiration.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtExpiration.PlaceholderText = "MM/YYYY";
            this.txtExpiration.ReadOnly = false;
            this.txtExpiration.Size = new System.Drawing.Size(92, 36);
            this.txtExpiration.TabIndex = 14;
            this.txtExpiration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExpiration.Texts = "";
            this.txtExpiration.UnderlineStyle = false;
            this.txtExpiration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpiration_KeyPress);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCreditCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtCreditCard.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtCreditCard.BorderRadius = 15;
            this.txtCreditCard.BorderSize = 1;
            this.txtCreditCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCard.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCreditCard.Location = new System.Drawing.Point(27, 88);
            this.txtCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCard.MaxLength = 16;
            this.txtCreditCard.Multiline = false;
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCreditCard.PasswordChar = false;
            this.txtCreditCard.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCreditCard.PlaceholderText = "Credit Card";
            this.txtCreditCard.ReadOnly = false;
            this.txtCreditCard.Size = new System.Drawing.Size(240, 36);
            this.txtCreditCard.TabIndex = 13;
            this.txtCreditCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCreditCard.Texts = "";
            this.txtCreditCard.UnderlineStyle = false;
            this.txtCreditCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCard_KeyPress);
            // 
            // gbCardType
            // 
            this.gbCardType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.gbCardType.Controls.Add(this.rbAmex);
            this.gbCardType.Controls.Add(this.rbMC);
            this.gbCardType.Controls.Add(this.rbVisa);
            this.gbCardType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCardType.Location = new System.Drawing.Point(27, 26);
            this.gbCardType.Name = "gbCardType";
            this.gbCardType.Size = new System.Drawing.Size(239, 55);
            this.gbCardType.TabIndex = 9;
            this.gbCardType.TabStop = false;
            this.gbCardType.Text = "Card Type";
            this.gbCardType.TextColor = System.Drawing.Color.DimGray;
            // 
            // rbAmex
            // 
            this.rbAmex.AutoSize = true;
            this.rbAmex.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.rbAmex.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmex.Location = new System.Drawing.Point(155, 23);
            this.rbAmex.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbAmex.Name = "rbAmex";
            this.rbAmex.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbAmex.Size = new System.Drawing.Size(80, 24);
            this.rbAmex.TabIndex = 12;
            this.rbAmex.TabStop = true;
            this.rbAmex.Tag = "A";
            this.rbAmex.Text = "AMEX";
            this.rbAmex.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbAmex.UseVisualStyleBackColor = true;
            // 
            // rbMC
            // 
            this.rbMC.AutoSize = true;
            this.rbMC.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.rbMC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMC.Location = new System.Drawing.Point(85, 23);
            this.rbMC.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbMC.Name = "rbMC";
            this.rbMC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbMC.Size = new System.Drawing.Size(64, 24);
            this.rbMC.TabIndex = 11;
            this.rbMC.TabStop = true;
            this.rbMC.Tag = "M";
            this.rbMC.Text = "MC";
            this.rbMC.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbMC.UseVisualStyleBackColor = true;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.rbVisa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVisa.Location = new System.Drawing.Point(8, 23);
            this.rbVisa.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbVisa.Size = new System.Drawing.Size(71, 24);
            this.rbVisa.TabIndex = 10;
            this.rbVisa.TabStop = true;
            this.rbVisa.Tag = "V";
            this.rbVisa.Text = "VISA";
            this.rbVisa.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // comBoxPrize
            // 
            this.comBoxPrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comBoxPrize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.comBoxPrize.BorderSize = 1;
            this.comBoxPrize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPrize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxPrize.ForeColor = System.Drawing.Color.DimGray;
            this.comBoxPrize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.comBoxPrize.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comBoxPrize.ListTextColor = System.Drawing.Color.DarkGray;
            this.comBoxPrize.Location = new System.Drawing.Point(422, 303);
            this.comBoxPrize.MinimumSize = new System.Drawing.Size(200, 30);
            this.comBoxPrize.Name = "comBoxPrize";
            this.comBoxPrize.Padding = new System.Windows.Forms.Padding(1);
            this.comBoxPrize.Size = new System.Drawing.Size(203, 30);
            this.comBoxPrize.TabIndex = 24;
            this.comBoxPrize.Tag = "Select Prize";
            this.comBoxPrize.Texts = "";
            this.comBoxPrize.OnSelectedIndexChanged += new System.EventHandler(this.comBoxPrize_OnSelectedIndexChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtNumber.BorderRadius = 15;
            this.txtNumber.BorderSize = 1;
            this.txtNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNumber.Location = new System.Drawing.Point(644, 297);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.MaxLength = 2;
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNumber.PlaceholderText = "Number";
            this.txtNumber.ReadOnly = false;
            this.txtNumber.Size = new System.Drawing.Size(160, 36);
            this.txtNumber.TabIndex = 25;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderlineStyle = false;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtPhone.BorderRadius = 15;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPhone.Location = new System.Drawing.Point(53, 236);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPhone.PlaceholderText = "Phone (555 555-5555)";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.Size = new System.Drawing.Size(250, 36);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlineStyle = false;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtAmount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtAmount.BorderRadius = 15;
            this.txtAmount.BorderSize = 1;
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.Location = new System.Drawing.Point(644, 227);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.MaxLength = 9;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAmount.PlaceholderText = "Donation Amount";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.Size = new System.Drawing.Size(160, 36);
            this.txtAmount.TabIndex = 22;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlineStyle = false;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAddress.Location = new System.Drawing.Point(53, 192);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MaxLength = 40;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(250, 36);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlineStyle = false;
            // 
            // txtDonationID
            // 
            this.txtDonationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDonationID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtDonationID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtDonationID.BorderRadius = 15;
            this.txtDonationID.BorderSize = 1;
            this.txtDonationID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonationID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDonationID.Location = new System.Drawing.Point(422, 227);
            this.txtDonationID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonationID.MaxLength = 4;
            this.txtDonationID.Multiline = false;
            this.txtDonationID.Name = "txtDonationID";
            this.txtDonationID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonationID.PasswordChar = false;
            this.txtDonationID.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDonationID.PlaceholderText = "Donation ID";
            this.txtDonationID.ReadOnly = false;
            this.txtDonationID.Size = new System.Drawing.Size(203, 36);
            this.txtDonationID.TabIndex = 21;
            this.txtDonationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonationID.Texts = "";
            this.txtDonationID.UnderlineStyle = false;
            // 
            // txtDonorID
            // 
            this.txtDonorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDonorID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtDonorID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtDonorID.BorderRadius = 15;
            this.txtDonorID.BorderSize = 2;
            this.txtDonorID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDonorID.Location = new System.Drawing.Point(53, 26);
            this.txtDonorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonorID.MaxLength = 4;
            this.txtDonorID.Multiline = false;
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonorID.PasswordChar = false;
            this.txtDonorID.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDonorID.PlaceholderText = "Donor ID";
            this.txtDonorID.ReadOnly = false;
            this.txtDonorID.Size = new System.Drawing.Size(250, 36);
            this.txtDonorID.TabIndex = 0;
            this.txtDonorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonorID.Texts = "";
            this.txtDonorID.UnderlineStyle = false;
            this.txtDonorID.Leave += new System.EventHandler(this.txtDonorID_Leave);
            // 
            // txtDonorLName
            // 
            this.txtDonorLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDonorLName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtDonorLName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtDonorLName.BorderRadius = 15;
            this.txtDonorLName.BorderSize = 1;
            this.txtDonorLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorLName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDonorLName.Location = new System.Drawing.Point(53, 148);
            this.txtDonorLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonorLName.MaxLength = 15;
            this.txtDonorLName.Multiline = false;
            this.txtDonorLName.Name = "txtDonorLName";
            this.txtDonorLName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonorLName.PasswordChar = false;
            this.txtDonorLName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDonorLName.PlaceholderText = "Last Name";
            this.txtDonorLName.ReadOnly = false;
            this.txtDonorLName.Size = new System.Drawing.Size(250, 36);
            this.txtDonorLName.TabIndex = 2;
            this.txtDonorLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonorLName.Texts = "";
            this.txtDonorLName.UnderlineStyle = false;
            this.txtDonorLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonorLName_KeyPress);
            // 
            // txtDonorFName
            // 
            this.txtDonorFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDonorFName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtDonorFName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.txtDonorFName.BorderRadius = 15;
            this.txtDonorFName.BorderSize = 1;
            this.txtDonorFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorFName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDonorFName.Location = new System.Drawing.Point(53, 104);
            this.txtDonorFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonorFName.MaxLength = 15;
            this.txtDonorFName.Multiline = false;
            this.txtDonorFName.Name = "txtDonorFName";
            this.txtDonorFName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonorFName.PasswordChar = false;
            this.txtDonorFName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDonorFName.PlaceholderText = "First Name";
            this.txtDonorFName.ReadOnly = false;
            this.txtDonorFName.Size = new System.Drawing.Size(250, 36);
            this.txtDonorFName.TabIndex = 1;
            this.txtDonorFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonorFName.Texts = "";
            this.txtDonorFName.UnderlineStyle = false;
            this.txtDonorFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonorFName_KeyPress);
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDeleteDonor.FlatAppearance.BorderSize = 0;
            this.btnDeleteDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDonor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDonor.ForeColor = System.Drawing.Color.Gray;
            this.btnDeleteDonor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteDonor.IconColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDonor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteDonor.IconSize = 20;
            this.btnDeleteDonor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDonor.Location = new System.Drawing.Point(33, 616);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(137, 30);
            this.btnDeleteDonor.TabIndex = 43;
            this.btnDeleteDonor.Text = "Delete Donor";
            this.btnDeleteDonor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            this.btnDeleteDonor.Click += new System.EventHandler(this.btnDeleteDonor_Click);
            // 
            // FrmDonors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnClearDonation);
            this.Controls.Add(this.btnClearDonor);
            this.Controls.Add(this.btnShowPrizes);
            this.Controls.Add(this.gbCreditCard);
            this.Controls.Add(this.comBoxPrize);
            this.Controls.Add(this.btnViewDonations);
            this.Controls.Add(this.btnViewDonors);
            this.Controls.Add(this.panelSData);
            this.Controls.Add(this.btnSaveDonation);
            this.Controls.Add(this.btnSaveDonor);
            this.Controls.Add(this.lblDonation);
            this.Controls.Add(this.lblDonor);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDonationID);
            this.Controls.Add(this.txtDonorID);
            this.Controls.Add(this.txtDonorLName);
            this.Controls.Add(this.txtDonorFName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDonors";
            this.Text = "FrmDonors";
            this.panelSData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDonors)).EndInit();
            this.gbCreditCard.ResumeLayout(false);
            this.gbCardType.ResumeLayout(false);
            this.gbCardType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnViewDonations;
        private FontAwesome.Sharp.IconButton btnViewDonors;
        private System.Windows.Forms.Panel panelSData;
        private System.Windows.Forms.DataGridView dataGVDonors;
        private FontAwesome.Sharp.IconButton btnSaveDonation;
        private FontAwesome.Sharp.IconButton btnSaveDonor;
        private System.Windows.Forms.Label lblDonation;
        private System.Windows.Forms.Label lblDonor;
        private CusTextBox txtNumber;
        private CusTextBox txtPhone;
        private CusTextBox txtAmount;
        private CusTextBox txtAddress;
        private CusTextBox txtDonationID;
        private CusTextBox txtDonorID;
        private CusTextBox txtDonorLName;
        private CusTextBox txtDonorFName;
        private CusControls.CusComboBox comBoxPrize;
        private CusControls.CusGroupBox gbCreditCard;
        private CusControls.CusGroupBox gbCardType;
        private CusControls.CusRadioButton rbAmex;
        private CusControls.CusRadioButton rbMC;
        private CusControls.CusRadioButton rbVisa;
        private CusTextBox txtCreditCard;
        private CusTextBox txtExpiration;
        private FontAwesome.Sharp.IconButton btnShowPrizes;
        private System.Windows.Forms.Button btnClearDonor;
        private System.Windows.Forms.Button btnClearDonation;
        private FontAwesome.Sharp.IconButton btnDeleteDonor;
    }
}