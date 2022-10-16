namespace TelethonSystemWin
{
    partial class FrmSponsors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSponsor = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.btnSaveSpon = new FontAwesome.Sharp.IconButton();
            this.btnSavePrize = new FontAwesome.Sharp.IconButton();
            this.dataGVSponsors = new System.Windows.Forms.DataGridView();
            this.panelSData = new System.Windows.Forms.Panel();
            this.btnViewSponsor = new FontAwesome.Sharp.IconButton();
            this.btnViewPrize = new FontAwesome.Sharp.IconButton();
            this.btnClearSponsor = new System.Windows.Forms.Button();
            this.btnClearPrize = new System.Windows.Forms.Button();
            this.txtDonationLimit = new TelethonSystemWin.CusTextBox();
            this.txtQty = new TelethonSystemWin.CusTextBox();
            this.txtPrizeValue = new TelethonSystemWin.CusTextBox();
            this.txtPrizeDesc = new TelethonSystemWin.CusTextBox();
            this.txtPrizeID = new TelethonSystemWin.CusTextBox();
            this.txtSponID = new TelethonSystemWin.CusTextBox();
            this.txtSponLName = new TelethonSystemWin.CusTextBox();
            this.txtSponFName = new TelethonSystemWin.CusTextBox();
            this.btnDeleteSponsor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSponsors)).BeginInit();
            this.panelSData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSponsor
            // 
            this.lblSponsor.AutoSize = true;
            this.lblSponsor.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.lblSponsor.Location = new System.Drawing.Point(49, 72);
            this.lblSponsor.Name = "lblSponsor";
            this.lblSponsor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSponsor.Size = new System.Drawing.Size(188, 24);
            this.lblSponsor.TabIndex = 8;
            this.lblSponsor.Text = "Sponsor Information";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.lblPrize.Location = new System.Drawing.Point(446, 72);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPrize.Size = new System.Drawing.Size(163, 24);
            this.lblPrize.TabIndex = 9;
            this.lblPrize.Text = "Prize Information";
            // 
            // btnSaveSpon
            // 
            this.btnSaveSpon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSaveSpon.FlatAppearance.BorderSize = 0;
            this.btnSaveSpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSpon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSpon.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSaveSpon.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSaveSpon.IconColor = System.Drawing.Color.DarkGray;
            this.btnSaveSpon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveSpon.IconSize = 20;
            this.btnSaveSpon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSpon.Location = new System.Drawing.Point(53, 191);
            this.btnSaveSpon.Name = "btnSaveSpon";
            this.btnSaveSpon.Size = new System.Drawing.Size(137, 30);
            this.btnSaveSpon.TabIndex = 3;
            this.btnSaveSpon.Text = "Save Sponsor";
            this.btnSaveSpon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSpon.UseVisualStyleBackColor = true;
            this.btnSaveSpon.Click += new System.EventHandler(this.btnSaveSpon_Click);
            // 
            // btnSavePrize
            // 
            this.btnSavePrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnSavePrize.FlatAppearance.BorderSize = 0;
            this.btnSavePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSavePrize.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnSavePrize.IconColor = System.Drawing.Color.DarkGray;
            this.btnSavePrize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSavePrize.IconSize = 20;
            this.btnSavePrize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePrize.Location = new System.Drawing.Point(450, 323);
            this.btnSavePrize.Name = "btnSavePrize";
            this.btnSavePrize.Size = new System.Drawing.Size(137, 30);
            this.btnSavePrize.TabIndex = 9;
            this.btnSavePrize.Text = "Save Prize";
            this.btnSavePrize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePrize.UseVisualStyleBackColor = true;
            this.btnSavePrize.Click += new System.EventHandler(this.btnSavePrize_Click);
            // 
            // dataGVSponsors
            // 
            this.dataGVSponsors.AllowUserToAddRows = false;
            this.dataGVSponsors.AllowUserToDeleteRows = false;
            this.dataGVSponsors.AllowUserToResizeRows = false;
            this.dataGVSponsors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVSponsors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.dataGVSponsors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVSponsors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVSponsors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGVSponsors.ColumnHeadersHeight = 34;
            this.dataGVSponsors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGVSponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVSponsors.EnableHeadersVisualStyles = false;
            this.dataGVSponsors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.dataGVSponsors.Location = new System.Drawing.Point(0, 0);
            this.dataGVSponsors.Name = "dataGVSponsors";
            this.dataGVSponsors.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVSponsors.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGVSponsors.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGVSponsors.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGVSponsors.RowTemplate.Height = 25;
            this.dataGVSponsors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVSponsors.Size = new System.Drawing.Size(814, 231);
            this.dataGVSponsors.TabIndex = 12;
            this.dataGVSponsors.TabStop = false;
            // 
            // panelSData
            // 
            this.panelSData.Controls.Add(this.dataGVSponsors);
            this.panelSData.Location = new System.Drawing.Point(33, 376);
            this.panelSData.Name = "panelSData";
            this.panelSData.Size = new System.Drawing.Size(814, 231);
            this.panelSData.TabIndex = 13;
            // 
            // btnViewSponsor
            // 
            this.btnViewSponsor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnViewSponsor.FlatAppearance.BorderSize = 0;
            this.btnViewSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSponsor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSponsor.ForeColor = System.Drawing.Color.DarkGray;
            this.btnViewSponsor.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btnViewSponsor.IconColor = System.Drawing.Color.DarkGray;
            this.btnViewSponsor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewSponsor.IconSize = 20;
            this.btnViewSponsor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSponsor.Location = new System.Drawing.Point(33, 340);
            this.btnViewSponsor.Name = "btnViewSponsor";
            this.btnViewSponsor.Size = new System.Drawing.Size(142, 30);
            this.btnViewSponsor.TabIndex = 14;
            this.btnViewSponsor.Text = "View Sponsors";
            this.btnViewSponsor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSponsor.UseVisualStyleBackColor = true;
            this.btnViewSponsor.Click += new System.EventHandler(this.btnViewSponsor_Click);
            // 
            // btnViewPrize
            // 
            this.btnViewPrize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnViewPrize.FlatAppearance.BorderSize = 0;
            this.btnViewPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPrize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPrize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnViewPrize.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btnViewPrize.IconColor = System.Drawing.Color.DarkGray;
            this.btnViewPrize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewPrize.IconSize = 20;
            this.btnViewPrize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPrize.Location = new System.Drawing.Point(198, 340);
            this.btnViewPrize.Name = "btnViewPrize";
            this.btnViewPrize.Size = new System.Drawing.Size(137, 30);
            this.btnViewPrize.TabIndex = 15;
            this.btnViewPrize.Text = "View Prizes";
            this.btnViewPrize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewPrize.UseVisualStyleBackColor = true;
            this.btnViewPrize.Click += new System.EventHandler(this.btnViewPrize_Click);
            // 
            // btnClearSponsor
            // 
            this.btnClearSponsor.FlatAppearance.BorderSize = 0;
            this.btnClearSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSponsor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSponsor.ForeColor = System.Drawing.Color.Gray;
            this.btnClearSponsor.Location = new System.Drawing.Point(198, 191);
            this.btnClearSponsor.Name = "btnClearSponsor";
            this.btnClearSponsor.Size = new System.Drawing.Size(105, 23);
            this.btnClearSponsor.TabIndex = 18;
            this.btnClearSponsor.Text = "Clear Sponsor";
            this.btnClearSponsor.UseVisualStyleBackColor = true;
            this.btnClearSponsor.Click += new System.EventHandler(this.btnClearSponsor_Click);
            // 
            // btnClearPrize
            // 
            this.btnClearPrize.FlatAppearance.BorderSize = 0;
            this.btnClearPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPrize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPrize.ForeColor = System.Drawing.Color.Gray;
            this.btnClearPrize.Location = new System.Drawing.Point(610, 323);
            this.btnClearPrize.Name = "btnClearPrize";
            this.btnClearPrize.Size = new System.Drawing.Size(105, 23);
            this.btnClearPrize.TabIndex = 19;
            this.btnClearPrize.Text = "Clear Prize";
            this.btnClearPrize.UseVisualStyleBackColor = true;
            this.btnClearPrize.Click += new System.EventHandler(this.btnClearPrize_Click);
            // 
            // txtDonationLimit
            // 
            this.txtDonationLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDonationLimit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtDonationLimit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtDonationLimit.BorderRadius = 15;
            this.txtDonationLimit.BorderSize = 1;
            this.txtDonationLimit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonationLimit.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDonationLimit.Location = new System.Drawing.Point(450, 280);
            this.txtDonationLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonationLimit.MaxLength = 32767;
            this.txtDonationLimit.Multiline = false;
            this.txtDonationLimit.Name = "txtDonationLimit";
            this.txtDonationLimit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonationLimit.PasswordChar = false;
            this.txtDonationLimit.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDonationLimit.PlaceholderText = "Donation Limit";
            this.txtDonationLimit.ReadOnly = false;
            this.txtDonationLimit.Size = new System.Drawing.Size(250, 36);
            this.txtDonationLimit.TabIndex = 8;
            this.txtDonationLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonationLimit.Texts = "";
            this.txtDonationLimit.UnderlineStyle = false;
            this.txtDonationLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonationLimit_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtQty.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtQty.BorderRadius = 15;
            this.txtQty.BorderSize = 1;
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.DarkGray;
            this.txtQty.Location = new System.Drawing.Point(450, 236);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.MaxLength = 3;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQty.PasswordChar = false;
            this.txtQty.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtQty.PlaceholderText = "Quantity";
            this.txtQty.ReadOnly = false;
            this.txtQty.Size = new System.Drawing.Size(250, 36);
            this.txtQty.TabIndex = 7;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.Texts = "";
            this.txtQty.UnderlineStyle = false;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtPrizeValue
            // 
            this.txtPrizeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPrizeValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtPrizeValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtPrizeValue.BorderRadius = 15;
            this.txtPrizeValue.BorderSize = 1;
            this.txtPrizeValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeValue.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrizeValue.Location = new System.Drawing.Point(450, 192);
            this.txtPrizeValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrizeValue.MaxLength = 6;
            this.txtPrizeValue.Multiline = false;
            this.txtPrizeValue.Name = "txtPrizeValue";
            this.txtPrizeValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrizeValue.PasswordChar = false;
            this.txtPrizeValue.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrizeValue.PlaceholderText = "Value per Prize";
            this.txtPrizeValue.ReadOnly = false;
            this.txtPrizeValue.Size = new System.Drawing.Size(250, 36);
            this.txtPrizeValue.TabIndex = 6;
            this.txtPrizeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrizeValue.Texts = "";
            this.txtPrizeValue.UnderlineStyle = false;
            this.txtPrizeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrizeValue_KeyPress);
            this.txtPrizeValue.Leave += new System.EventHandler(this.txtPrizeValue_Leave);
            // 
            // txtPrizeDesc
            // 
            this.txtPrizeDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPrizeDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtPrizeDesc.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtPrizeDesc.BorderRadius = 15;
            this.txtPrizeDesc.BorderSize = 1;
            this.txtPrizeDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeDesc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrizeDesc.Location = new System.Drawing.Point(450, 148);
            this.txtPrizeDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrizeDesc.MaxLength = 15;
            this.txtPrizeDesc.Multiline = false;
            this.txtPrizeDesc.Name = "txtPrizeDesc";
            this.txtPrizeDesc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrizeDesc.PasswordChar = false;
            this.txtPrizeDesc.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrizeDesc.PlaceholderText = "Description";
            this.txtPrizeDesc.ReadOnly = false;
            this.txtPrizeDesc.Size = new System.Drawing.Size(250, 36);
            this.txtPrizeDesc.TabIndex = 5;
            this.txtPrizeDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrizeDesc.Texts = "";
            this.txtPrizeDesc.UnderlineStyle = false;
            // 
            // txtPrizeID
            // 
            this.txtPrizeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPrizeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtPrizeID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtPrizeID.BorderRadius = 15;
            this.txtPrizeID.BorderSize = 1;
            this.txtPrizeID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrizeID.Location = new System.Drawing.Point(450, 104);
            this.txtPrizeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrizeID.MaxLength = 4;
            this.txtPrizeID.Multiline = false;
            this.txtPrizeID.Name = "txtPrizeID";
            this.txtPrizeID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrizeID.PasswordChar = false;
            this.txtPrizeID.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrizeID.PlaceholderText = "Prize ID";
            this.txtPrizeID.ReadOnly = false;
            this.txtPrizeID.Size = new System.Drawing.Size(250, 36);
            this.txtPrizeID.TabIndex = 4;
            this.txtPrizeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrizeID.Texts = "";
            this.txtPrizeID.UnderlineStyle = false;
            // 
            // txtSponID
            // 
            this.txtSponID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSponID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtSponID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtSponID.BorderRadius = 15;
            this.txtSponID.BorderSize = 2;
            this.txtSponID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSponID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSponID.Location = new System.Drawing.Point(53, 26);
            this.txtSponID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponID.MaxLength = 4;
            this.txtSponID.Multiline = false;
            this.txtSponID.Name = "txtSponID";
            this.txtSponID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSponID.PasswordChar = false;
            this.txtSponID.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSponID.PlaceholderText = "Sponsor ID";
            this.txtSponID.ReadOnly = false;
            this.txtSponID.Size = new System.Drawing.Size(250, 36);
            this.txtSponID.TabIndex = 0;
            this.txtSponID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSponID.Texts = "";
            this.txtSponID.UnderlineStyle = false;
            this.txtSponID.Leave += new System.EventHandler(this.txtSponID_Leave);
            // 
            // txtSponLName
            // 
            this.txtSponLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSponLName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtSponLName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtSponLName.BorderRadius = 15;
            this.txtSponLName.BorderSize = 1;
            this.txtSponLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSponLName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSponLName.Location = new System.Drawing.Point(53, 148);
            this.txtSponLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponLName.MaxLength = 15;
            this.txtSponLName.Multiline = false;
            this.txtSponLName.Name = "txtSponLName";
            this.txtSponLName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSponLName.PasswordChar = false;
            this.txtSponLName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSponLName.PlaceholderText = "Last Name";
            this.txtSponLName.ReadOnly = false;
            this.txtSponLName.Size = new System.Drawing.Size(250, 36);
            this.txtSponLName.TabIndex = 2;
            this.txtSponLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSponLName.Texts = "";
            this.txtSponLName.UnderlineStyle = false;
            this.txtSponLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSponLName_KeyPress);
            // 
            // txtSponFName
            // 
            this.txtSponFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSponFName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtSponFName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.txtSponFName.BorderRadius = 15;
            this.txtSponFName.BorderSize = 1;
            this.txtSponFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSponFName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSponFName.Location = new System.Drawing.Point(53, 104);
            this.txtSponFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponFName.MaxLength = 15;
            this.txtSponFName.Multiline = false;
            this.txtSponFName.Name = "txtSponFName";
            this.txtSponFName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSponFName.PasswordChar = false;
            this.txtSponFName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSponFName.PlaceholderText = "First Name";
            this.txtSponFName.ReadOnly = false;
            this.txtSponFName.Size = new System.Drawing.Size(250, 36);
            this.txtSponFName.TabIndex = 1;
            this.txtSponFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSponFName.Texts = "";
            this.txtSponFName.UnderlineStyle = false;
            this.txtSponFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSponFName_KeyPress);
            // 
            // btnDeleteSponsor
            // 
            this.btnDeleteSponsor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.btnDeleteSponsor.FlatAppearance.BorderSize = 0;
            this.btnDeleteSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSponsor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSponsor.ForeColor = System.Drawing.Color.Gray;
            this.btnDeleteSponsor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteSponsor.IconColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSponsor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteSponsor.IconSize = 20;
            this.btnDeleteSponsor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSponsor.Location = new System.Drawing.Point(33, 619);
            this.btnDeleteSponsor.Name = "btnDeleteSponsor";
            this.btnDeleteSponsor.Size = new System.Drawing.Size(157, 30);
            this.btnDeleteSponsor.TabIndex = 44;
            this.btnDeleteSponsor.Text = "Delete Sponsor";
            this.btnDeleteSponsor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSponsor.UseVisualStyleBackColor = true;
            this.btnDeleteSponsor.Click += new System.EventHandler(this.btnDeleteSponsor_Click);
            // 
            // FrmSponsors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.btnDeleteSponsor);
            this.Controls.Add(this.btnClearPrize);
            this.Controls.Add(this.btnClearSponsor);
            this.Controls.Add(this.btnViewPrize);
            this.Controls.Add(this.btnViewSponsor);
            this.Controls.Add(this.panelSData);
            this.Controls.Add(this.btnSavePrize);
            this.Controls.Add(this.btnSaveSpon);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblSponsor);
            this.Controls.Add(this.txtDonationLimit);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrizeValue);
            this.Controls.Add(this.txtPrizeDesc);
            this.Controls.Add(this.txtPrizeID);
            this.Controls.Add(this.txtSponID);
            this.Controls.Add(this.txtSponLName);
            this.Controls.Add(this.txtSponFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSponsors";
            this.Text = "FrmSponsors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSponsors)).EndInit();
            this.panelSData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CusTextBox txtSponFName;
        private CusTextBox txtSponLName;
        private CusTextBox txtSponID;
        private CusTextBox txtPrizeID;
        private CusTextBox txtPrizeDesc;
        private CusTextBox txtPrizeValue;
        private CusTextBox txtQty;
        private CusTextBox txtDonationLimit;
        private System.Windows.Forms.Label lblSponsor;
        private System.Windows.Forms.Label lblPrize;
        private FontAwesome.Sharp.IconButton btnSaveSpon;
        private FontAwesome.Sharp.IconButton btnSavePrize;
        private System.Windows.Forms.DataGridView dataGVSponsors;
        private System.Windows.Forms.Panel panelSData;
        private FontAwesome.Sharp.IconButton btnViewSponsor;
        private FontAwesome.Sharp.IconButton btnViewPrize;
        private System.Windows.Forms.Button btnClearSponsor;
        private System.Windows.Forms.Button btnClearPrize;
        private FontAwesome.Sharp.IconButton btnDeleteSponsor;
    }
}