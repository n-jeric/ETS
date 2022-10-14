/**
 * Custom TextBox WinForm Control
 * Adapted from tutorial by RJ Code Advance EN: Custom TextBox - Border, Focus Color, Underlined Style - WinForm C#
 * https://www.youtube.com/watch?v=CkpUQYzYCC8
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace TelethonSystemWin
{
    [DefaultEvent("_TextChanged")]
    public partial class CusTextBox : UserControl
    {

        #region Fields

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor=Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        #endregion

        public CusTextBox()
        {
            InitializeComponent();
        }

        //events
        public event EventHandler _TextChanged;


        #region Properties
        [Category("Custom Code")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Custom Code")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Custom Code")]
        public bool UnderlineStyle { get => underlineStyle; set { underlineStyle = value; this.Invalidate(); } }
        [Category("Custom Code")]
        public bool PasswordChar 
        { 
            get => textBox1.UseSystemPasswordChar; 
            set 
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("Custom Code")]
        public int MaxLength
        {
            get => textBox1.MaxLength;
            set
            {
                textBox1.MaxLength = value;
            }
        }
        [Category("Custom Code")]
        public bool ReadOnly
        {
             get => textBox1.ReadOnly; set { textBox1.ReadOnly = value; this.Invalidate(); } 
        }


        [Category("Custom Code")]
        public bool Multiline { get => textBox1.Multiline; set => textBox1.Multiline = value; }
        [Category("Custom Code")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("Custom Code")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; } }
        [Category("Custom Code")]
        public override Font Font 
        { 
            get => base.Font; 
            set 
            { 
                base.Font = value; 
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            } 
        }
        [Category("Custom Code")]
        public string Texts 
        { 
            get 
            {
                if (isPlaceholder) return "";
                else return textBox1.Text; 
            } 
            set 
            {
                if (textBox1.Text == "*")
                {
                    RemovePlaceholder();
                    textBox1.Text = value;
                }
                else
                {

                textBox1.Text = value;
                SetPlaceholder();
                }
            }
        }
        [Category("Custom Code")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        [Category("Custom Code")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//redraw control invoking onpaint event 
                }
            }
        }
        [Category("Custom Code")]
        public Color PlaceholderColor 
        { 
            get => placeholderColor; 
            set
            { 
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }
        [Category("Custom Code")]
        public string PlaceholderText 
        { 
            get => placeholderText; 
            set
            { 
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        [Category("Custom Code")]
        public HorizontalAlignment TextAlign
        {
            get { return textBox1.TextAlign; }
            set { textBox1.TextAlign = value; }
        }



        #endregion

        public void Clear()
        {
            textBox1.Clear();
        }
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false; ;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }
        #region Override Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlineStyle) //Line Style
                    {
                        //Draw border smoothing
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        g.SmoothingMode = SmoothingMode.None;
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        g.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //draw border of square/normal text box
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused) { penBorder.Color = borderFocusColor; }

                    if (underlineStyle) //underline style
                    {
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //full border style
                    {
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }
            }
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize*2);
                textBox1.Region = new Region(pathTxt);
            }
        }
        
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion
        
        //private methods
        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #region Events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

       
        #endregion

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
