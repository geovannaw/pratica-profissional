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

namespace Sistema_Vendas.GControls
{
    [DefaultEvent("_TextChanged")]
    public partial class GMaskedTextBox : UserControl
    {
        //Default Event
        public event EventHandler _TextChanged;

        public GMaskedTextBox()
        {
            InitializeComponent();
            maskedTextBox1.ReadOnly = false;
        }

        //Fields
        private Color borderColor = Color.DarkGray;
        private Color borderFocusColor = Color.FromArgb(63, 23, 159);
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 5;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private CharacterCasing characterCasing = CharacterCasing.Upper;

        private Color disabledBackColor = Color.White;
        private Color disabledForeColor = Color.White;
        private Color disabledBorderColor = Color.Gainsboro;

        private HorizontalAlignment textAlign = HorizontalAlignment.Left;
        private string mask = "";

        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                maskedTextBox1.Text = placeholderText;
                maskedTextBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    maskedTextBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    maskedTextBox1.UseSystemPasswordChar = true;
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
        private void SetMaskedTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(maskedTextBox1.ClientRectangle, borderRadius - borderSize);
                maskedTextBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(maskedTextBox1.ClientRectangle, borderSize * 2);
                maskedTextBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (maskedTextBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                maskedTextBox1.Multiline = true;
                maskedTextBox1.MinimumSize = new Size(0, txtHeight);
                maskedTextBox1.Multiline = false;

                this.Height = maskedTextBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region -> Properties
        [Category("G Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("G Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("G Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("G Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("G Code Advance")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    maskedTextBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("G Code Advance")]
        public bool Multiline
        {
            get { return maskedTextBox1.Multiline; }
            set { maskedTextBox1.Multiline = value; }
        }

        [Category("G Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                maskedTextBox1.BackColor = value;
            }
        }

        [Category("G Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                maskedTextBox1.ForeColor = value;
            }
        }

        [Category("G Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                maskedTextBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("G Code Advance")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return maskedTextBox1.Text;
            }
            set
            {
                maskedTextBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("G Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("G Code Advance")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    maskedTextBox1.ForeColor = value;
            }
        }

        [Category("G Code Advance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                maskedTextBox1.Text = "";
                SetPlaceholder();
            }
        }

        [Category("G Code Advance")]
        public Color DisabledBackColor
        {
            get { return disabledBackColor; }
            set
            {
                disabledBackColor = value;
                if (!maskedTextBox1.Enabled)
                {
                    maskedTextBox1.BackColor = value;
                }
            }
        }

        [Category("G Code Advance")]
        public Color DisabledForeColor
        {
            get { return disabledForeColor; }
            set
            {
                disabledForeColor = value;
                if (!maskedTextBox1.Enabled)
                {
                    maskedTextBox1.ForeColor = value;
                }
            }
        }

        [Category("G Code Advance")]
        public bool Enabled
        {
            get { return maskedTextBox1.Enabled; }
            set
            {
                maskedTextBox1.Enabled = value;
                if (!value)
                {
                    maskedTextBox1.BackColor = disabledBackColor;
                    maskedTextBox1.ForeColor = disabledForeColor;
                }
                else
                {
                    maskedTextBox1.BackColor = this.BackColor;
                    maskedTextBox1.ForeColor = this.ForeColor;
                }
            }
        }

        [Category("G Code Advance")]
        public HorizontalAlignment TextAlign
        {
            get { return textAlign; }
            set
            {
                textAlign = value;
                maskedTextBox1.TextAlign = value;
            }
        }

        [Category("G Code Advance")]
        public string Mask
        {
            get { return mask; }
            set
            {
                mask = value;
                maskedTextBox1.Mask = value;
            }
        }

        [Category("G Code Advance")]
        public int MaxLength
        {
            get { return maskedTextBox1.MaxLength; }
            set { maskedTextBox1.MaxLength = value; }
        }

        [Category("G Code Advance")]
        public Color DisabledBorderColor
        {
            get { return disabledBorderColor; }
            set
            {
                disabledBorderColor = value;
                this.Invalidate();
            }
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1) //Rounded MaskedTextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(maskedTextBox1.Enabled ? borderColor : disabledBorderColor, borderSize)) 
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth); //Set the rounded region of UserControl
                    if (borderRadius > 15) SetMaskedTextBoxRoundedRegion(); //Set the rounded region of MaskedTextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal MaskedTextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(maskedTextBox1.Enabled ? borderColor : disabledBorderColor, borderSize)) 
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        #endregion


        public void Clear()
        {
            maskedTextBox1.Text = "";
            SetPlaceholder();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
    }
}
