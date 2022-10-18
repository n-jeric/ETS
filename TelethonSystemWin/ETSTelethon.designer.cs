namespace TelethonSystemWin
{
    partial class ETSTelethon
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFiles = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnDonors = new FontAwesome.Sharp.IconButton();
            this.btnSponsors = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cgWrite = new TelethonSystemWin.CusControls.CusGroupBox();
            this.btnSaveAll = new FontAwesome.Sharp.IconButton();
            this.btnSaveDonation = new FontAwesome.Sharp.IconButton();
            this.btnSavePrize = new FontAwesome.Sharp.IconButton();
            this.btnSaveDonor = new FontAwesome.Sharp.IconButton();
            this.btnSaveSponsor = new FontAwesome.Sharp.IconButton();
            this.gbRead = new TelethonSystemWin.CusControls.CusGroupBox();
            this.btnLoadAll = new FontAwesome.Sharp.IconButton();
            this.btnLoadDonation = new FontAwesome.Sharp.IconButton();
            this.btnLoadPrize = new FontAwesome.Sharp.IconButton();
            this.btnLoadDonor = new FontAwesome.Sharp.IconButton();
            this.btnLoadSponsor = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cgWrite.SuspendLayout();
            this.gbRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnFiles);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnDonors);
            this.panelMenu.Controls.Add(this.btnSponsors);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 740);
            this.panelMenu.TabIndex = 0;
            // 
            // btnFiles
            // 
            this.btnFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiles.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFiles.FlatAppearance.BorderSize = 0;
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFiles.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnFiles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiles.IconSize = 32;
            this.btnFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.Location = new System.Drawing.Point(0, 375);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFiles.Size = new System.Drawing.Size(220, 60);
            this.btnFiles.TabIndex = 5;
            this.btnFiles.Tag = "Files";
            this.btnFiles.Text = "Files";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiles.UseVisualStyleBackColor = false;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.DarkGray;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 680);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDonors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDonors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonors.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDonors.FlatAppearance.BorderSize = 0;
            this.btnDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDonors.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnDonors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDonors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonors.IconSize = 32;
            this.btnDonors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonors.Location = new System.Drawing.Point(0, 315);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDonors.Size = new System.Drawing.Size(220, 60);
            this.btnDonors.TabIndex = 3;
            this.btnDonors.Tag = "Donors";
            this.btnDonors.Text = "Donors";
            this.btnDonors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonors.UseVisualStyleBackColor = false;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnSponsors
            // 
            this.btnSponsors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSponsors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSponsors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSponsors.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSponsors.FlatAppearance.BorderSize = 0;
            this.btnSponsors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSponsors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSponsors.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnSponsors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSponsors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSponsors.IconSize = 32;
            this.btnSponsors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSponsors.Location = new System.Drawing.Point(0, 255);
            this.btnSponsors.Name = "btnSponsors";
            this.btnSponsors.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSponsors.Size = new System.Drawing.Size(220, 60);
            this.btnSponsors.TabIndex = 2;
            this.btnSponsors.Tag = "Sponsors";
            this.btnSponsors.Text = "Sponsors";
            this.btnSponsors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSponsors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSponsors.UseVisualStyleBackColor = false;
            this.btnSponsors.Click += new System.EventHandler(this.btnSponsors_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 195);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 195);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::TelethonSystemWin.Properties.Resources.Telethon_logo;
            this.btnHome.Location = new System.Drawing.Point(21, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 131);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(880, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(836, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(54, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Tag = "Home";
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(880, 4);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelDesktop.Controls.Add(this.cgWrite);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.gbRead);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(880, 661);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelethonSystemWin.Properties.Resources.Telethon_logo;
            this.pictureBox1.Location = new System.Drawing.Point(325, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cgWrite
            // 
            this.cgWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.cgWrite.Controls.Add(this.btnSaveAll);
            this.cgWrite.Controls.Add(this.btnSaveDonation);
            this.cgWrite.Controls.Add(this.btnSavePrize);
            this.cgWrite.Controls.Add(this.btnSaveDonor);
            this.cgWrite.Controls.Add(this.btnSaveSponsor);
            this.cgWrite.Location = new System.Drawing.Point(589, 88);
            this.cgWrite.Name = "cgWrite";
            this.cgWrite.Size = new System.Drawing.Size(227, 432);
            this.cgWrite.TabIndex = 4;
            this.cgWrite.TabStop = false;
            this.cgWrite.Text = "Save To TextFile";
            this.cgWrite.TextColor = System.Drawing.Color.DimGray;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAll.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnSaveAll.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAll.Location = new System.Drawing.Point(22, 343);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveAll.Size = new System.Drawing.Size(180, 50);
            this.btnSaveAll.TabIndex = 5;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveDonation
            // 
            this.btnSaveDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnSaveDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDonation.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnSaveDonation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveDonation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonation.Location = new System.Drawing.Point(23, 269);
            this.btnSaveDonation.Name = "btnSaveDonation";
            this.btnSaveDonation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveDonation.Size = new System.Drawing.Size(180, 50);
            this.btnSaveDonation.TabIndex = 3;
            this.btnSaveDonation.Text = "Donations";
            this.btnSaveDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDonation.UseVisualStyleBackColor = true;
            this.btnSaveDonation.Click += new System.EventHandler(this.btnSaveDonation_Click);
            // 
            // btnSavePrize
            // 
            this.btnSavePrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnSavePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrize.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.btnSavePrize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSavePrize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSavePrize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePrize.Location = new System.Drawing.Point(23, 195);
            this.btnSavePrize.Name = "btnSavePrize";
            this.btnSavePrize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSavePrize.Size = new System.Drawing.Size(180, 50);
            this.btnSavePrize.TabIndex = 2;
            this.btnSavePrize.Text = "Prizes";
            this.btnSavePrize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePrize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePrize.UseVisualStyleBackColor = true;
            this.btnSavePrize.Click += new System.EventHandler(this.btnSavePrize_Click);
            // 
            // btnSaveDonor
            // 
            this.btnSaveDonor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnSaveDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDonor.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnSaveDonor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveDonor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveDonor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonor.Location = new System.Drawing.Point(23, 121);
            this.btnSaveDonor.Name = "btnSaveDonor";
            this.btnSaveDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveDonor.Size = new System.Drawing.Size(180, 50);
            this.btnSaveDonor.TabIndex = 1;
            this.btnSaveDonor.Text = "Donors";
            this.btnSaveDonor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDonor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDonor.UseVisualStyleBackColor = true;
            this.btnSaveDonor.Click += new System.EventHandler(this.btnSaveDonor_Click);
            // 
            // btnSaveSponsor
            // 
            this.btnSaveSponsor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnSaveSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSponsor.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnSaveSponsor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveSponsor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveSponsor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSponsor.Location = new System.Drawing.Point(22, 47);
            this.btnSaveSponsor.Name = "btnSaveSponsor";
            this.btnSaveSponsor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveSponsor.Size = new System.Drawing.Size(180, 50);
            this.btnSaveSponsor.TabIndex = 0;
            this.btnSaveSponsor.Text = "Sponsors";
            this.btnSaveSponsor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSponsor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSponsor.UseVisualStyleBackColor = true;
            this.btnSaveSponsor.Click += new System.EventHandler(this.btnSaveSponsor_Click);
            // 
            // gbRead
            // 
            this.gbRead.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.gbRead.Controls.Add(this.btnLoadAll);
            this.gbRead.Controls.Add(this.btnLoadDonation);
            this.gbRead.Controls.Add(this.btnLoadPrize);
            this.gbRead.Controls.Add(this.btnLoadDonor);
            this.gbRead.Controls.Add(this.btnLoadSponsor);
            this.gbRead.Location = new System.Drawing.Point(58, 88);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(227, 432);
            this.gbRead.TabIndex = 0;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Load From TextFile";
            this.gbRead.TextColor = System.Drawing.Color.DimGray;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAll.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnLoadAll.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadAll.Location = new System.Drawing.Point(23, 343);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadAll.Size = new System.Drawing.Size(180, 50);
            this.btnLoadAll.TabIndex = 4;
            this.btnLoadAll.Text = "Import All";
            this.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnLoadDonation
            // 
            this.btnLoadDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnLoadDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDonation.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnLoadDonation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadDonation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDonation.Location = new System.Drawing.Point(23, 269);
            this.btnLoadDonation.Name = "btnLoadDonation";
            this.btnLoadDonation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadDonation.Size = new System.Drawing.Size(180, 50);
            this.btnLoadDonation.TabIndex = 3;
            this.btnLoadDonation.Text = "Donations";
            this.btnLoadDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDonation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadDonation.UseVisualStyleBackColor = true;
            this.btnLoadDonation.Click += new System.EventHandler(this.btnLoadDonation_Click);
            // 
            // btnLoadPrize
            // 
            this.btnLoadPrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnLoadPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPrize.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.btnLoadPrize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadPrize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadPrize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPrize.Location = new System.Drawing.Point(23, 195);
            this.btnLoadPrize.Name = "btnLoadPrize";
            this.btnLoadPrize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadPrize.Size = new System.Drawing.Size(180, 50);
            this.btnLoadPrize.TabIndex = 2;
            this.btnLoadPrize.Text = "Prizes";
            this.btnLoadPrize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPrize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPrize.UseVisualStyleBackColor = true;
            this.btnLoadPrize.Click += new System.EventHandler(this.btnLoadPrize_Click);
            // 
            // btnLoadDonor
            // 
            this.btnLoadDonor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnLoadDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDonor.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnLoadDonor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadDonor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadDonor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDonor.Location = new System.Drawing.Point(23, 121);
            this.btnLoadDonor.Name = "btnLoadDonor";
            this.btnLoadDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadDonor.Size = new System.Drawing.Size(180, 50);
            this.btnLoadDonor.TabIndex = 1;
            this.btnLoadDonor.Text = "Donors";
            this.btnLoadDonor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDonor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadDonor.UseVisualStyleBackColor = true;
            this.btnLoadDonor.Click += new System.EventHandler(this.btnLoadDonor_Click);
            // 
            // btnLoadSponsor
            // 
            this.btnLoadSponsor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.btnLoadSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSponsor.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnLoadSponsor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadSponsor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadSponsor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSponsor.Location = new System.Drawing.Point(22, 47);
            this.btnLoadSponsor.Name = "btnLoadSponsor";
            this.btnLoadSponsor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadSponsor.Size = new System.Drawing.Size(180, 50);
            this.btnLoadSponsor.TabIndex = 0;
            this.btnLoadSponsor.Text = "Sponsors";
            this.btnLoadSponsor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSponsor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadSponsor.UseVisualStyleBackColor = true;
            this.btnLoadSponsor.Click += new System.EventHandler(this.btnLoadSponsor_Click);
            // 
            // ETSTelethon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ETSTelethon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETSTelethon";
            this.Load += new System.EventHandler(this.ETSTelethon_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cgWrite.ResumeLayout(false);
            this.gbRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDonors;
        private FontAwesome.Sharp.IconButton btnSponsors;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconButton btnExit;
        private CusControls.CusGroupBox gbRead;
        private FontAwesome.Sharp.IconButton btnLoadSponsor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLoadDonation;
        private FontAwesome.Sharp.IconButton btnLoadPrize;
        private FontAwesome.Sharp.IconButton btnLoadDonor;
        private CusControls.CusGroupBox cgWrite;
        private FontAwesome.Sharp.IconButton btnSaveDonation;
        private FontAwesome.Sharp.IconButton btnSavePrize;
        private FontAwesome.Sharp.IconButton btnSaveDonor;
        private FontAwesome.Sharp.IconButton btnSaveSponsor;
        private FontAwesome.Sharp.IconButton btnSaveAll;
        private FontAwesome.Sharp.IconButton btnLoadAll;
        private FontAwesome.Sharp.IconButton btnFiles;
    }
}

