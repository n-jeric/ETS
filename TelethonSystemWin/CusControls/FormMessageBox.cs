﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelethonSystemWin.CusControls
{
public partial class FormMessageBox : Form
{
    //Fields
    private Color primaryColor = Color.FromArgb(37, 40, 57);
    private int borderSize = 2;

    //Properties
    public Color PrimaryColor
    {
        get { return primaryColor; }
        set
        {
            primaryColor = value;
            this.BackColor = primaryColor;//Form Border Color
            this.panelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
        }
    }

    //Constructors
    public FormMessageBox(string text)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = "";
        SetFormSize();
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
    }
    public FormMessageBox(string text, string caption)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        SetIcon(icon);
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, defaultButton);
        SetIcon(icon);
    }

    //-> Private Methods
    private void InitializeItems()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.Padding = new Padding(borderSize);//Set border size
        this.labelMessage.MaximumSize = new Size(550, 0);
        this.btnClose.DialogResult = DialogResult.Cancel;
        this.button1.DialogResult = DialogResult.OK;
        this.button1.Visible = false;
        this.button2.Visible = false;
        this.button3.Visible = false;
    }
    private void SetFormSize()
    {
        int widht = this.labelMessage.Width + this.pictureBoxIcon1.Width + this.panelBody.Padding.Left;
        int height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
        this.Size = new Size(widht, height);
    }
    private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
    {
        int xCenter = (this.panelButtons.Width - button1.Width) / 2;
        int yCenter = (this.panelButtons.Height - button1.Height) / 2;

        switch (buttons)
        {
            case MessageBoxButtons.OK:
                //OK Button
                button1.Visible = true;
                button1.Location = new Point(xCenter, yCenter);
                button1.Text = "Ok";
                button1.DialogResult = DialogResult.OK;//Set DialogResult

                //Set Default Button
                SetDefaultButton(defaultButton);
                break;
            case MessageBoxButtons.OKCancel:
                //OK Button
                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Ok";
                button1.DialogResult = DialogResult.OK;//Set DialogResult

                //Cancel Button
                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "Cancel";
                button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                //button2.BackColor = Color.DimGray;
                button2.FlatAppearance.BorderColor = Color.DimGray;

                //Set Default Button
                if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;

            case MessageBoxButtons.RetryCancel:
                //Retry Button
                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Retry";
                button1.DialogResult = DialogResult.Retry;//Set DialogResult

                //Cancel Button
                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "Cancel";
                button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                //button2.BackColor = Color.DimGray;
                button2.FlatAppearance.BorderColor = Color.DimGray;

                //Set Default Button
                if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;

            case MessageBoxButtons.YesNo:
                //Yes Button
                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Yes";
                button1.DialogResult = DialogResult.Yes;//Set DialogResult

                //No Button
                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "No";
                button2.DialogResult = DialogResult.No;//Set DialogResult
                //button2.BackColor = Color.IndianRed;
                button2.FlatAppearance.BorderColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                    SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;
            case MessageBoxButtons.YesNoCancel:
                //Yes Button
                button1.Visible = true;
                button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                button1.Text = "Yes";
                button1.DialogResult = DialogResult.Yes;//Set DialogResult

                //No Button
                button2.Visible = true;
                button2.Location = new Point(xCenter, yCenter);
                button2.Text = "No";
                button2.DialogResult = DialogResult.No;//Set DialogResult
                //button2.BackColor = Color.IndianRed;
                button2.FlatAppearance.BorderColor = Color.IndianRed;

                    //Cancel Button
                    button3.Visible = true;
                button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                button3.Text = "Cancel";
                button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                //button3.BackColor = Color.DimGray;
                button3.FlatAppearance.BorderColor = Color.DimGray;

                //Set Default Button
                SetDefaultButton(defaultButton);
                break;

            case MessageBoxButtons.AbortRetryIgnore:
                //Abort Button
                button1.Visible = true;
                button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                button1.Text = "Abort";
                button1.DialogResult = DialogResult.Abort;//Set DialogResult
                //button1.BackColor = Color.Goldenrod;
                button1.FlatAppearance.BorderColor = Color.Goldenrod;
                //button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 79, 114);


                    //Retry Button
                    button2.Visible = true;
                button2.Location = new Point(xCenter, yCenter);
                button2.Text = "Retry";
                button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                //Ignore Button
                button3.Visible = true;
                button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                button3.Text = "Ignore";
                button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                //button3.BackColor = Color.IndianRed;
                button3.FlatAppearance.BorderColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                break;
        }
    }
    private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
    {
        switch (defaultButton)
        {
            case MessageBoxDefaultButton.Button1://Focus button 1
                button1.Select();
                button1.ForeColor = Color.LightGray;
                button1.Font = new Font(button1.Font, FontStyle.Underline);
                break;
            case MessageBoxDefaultButton.Button2://Focus button 2
                button2.Select();
                button2.ForeColor = Color.LightGray;
                button2.Font = new Font(button2.Font, FontStyle.Underline);
                break;
            case MessageBoxDefaultButton.Button3://Focus button 3
                button3.Select();
                button3.ForeColor = Color.LightGray;
                button3.Font = new Font(button3.Font, FontStyle.Underline);
                break;
        }
    }
    private void SetIcon(MessageBoxIcon icon)
    {
        switch (icon)
        {
            case MessageBoxIcon.Error: //Error
                //this.pictureBoxIcon1.Image = Properties.Resources.error;
                this.pictureBoxIcon.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
                this.pictureBoxIcon.IconColor = System.Drawing.Color.PaleVioletRed;
                PrimaryColor = Color.PaleVioletRed;
                //this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 31, 85);
                break;
            case MessageBoxIcon.Information: //Information
                //this.pictureBoxIcon1.Image = Properties.Resources.information;
                this.pictureBoxIcon.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
                this.pictureBoxIcon.IconColor = System.Drawing.Color.FromArgb(98, 146, 158);
                PrimaryColor = Color.FromArgb(98, 146, 158);
                break;
            case MessageBoxIcon.Question://Question
                //this.pictureBoxIcon1.Image = Properties.Resources.question;
                this.pictureBoxIcon.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
                this.pictureBoxIcon.IconColor = System.Drawing.Color.FromArgb(139, 95, 191);
                PrimaryColor = Color.FromArgb(139, 95, 191);
                break;
            case MessageBoxIcon.Exclamation://Exclamation
                //this.pictureBoxIcon1.Image = Properties.Resources.exclamation;
                this.pictureBoxIcon.IconChar = FontAwesome.Sharp.IconChar.TriangleExclamation;
                this.pictureBoxIcon.IconColor = System.Drawing.Color.FromArgb(229, 79, 109);
                PrimaryColor = Color.FromArgb(229, 79, 109);
                break;
            case MessageBoxIcon.None: //None
                this.pictureBoxIcon1.Image = Properties.Resources.chat;
                this.pictureBoxIcon.IconChar = FontAwesome.Sharp.IconChar.Rocketchat;
                PrimaryColor = Color.FromArgb(69, 31, 85);
                break;
        }
    }

    //-> Events Methods
    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #region -> Drag Form
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
    #endregion
}
}
