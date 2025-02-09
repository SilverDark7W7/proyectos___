﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generador_contraseña
{
    [DefaultEvent ("_TextChanged")]
    public partial class control_txt : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue; //color de borde
        private int borderSize = 2; //borde
        private bool underLineStyle = false;
        public control_txt()
        {
            InitializeComponent();
        }

        //eventos
        public event EventHandler _TextChanged;


        [Category ("New Textbox")]
        public Color BorderColor
        {
            get
            {

                return borderColor;

            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }

        }

        [Category("New Textbox")]
        public int BorderSize
        {
            get
            {

                return borderSize;

            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("New Textbox")]
        public bool UnderLineStyle
        {
            get
            {
                return underLineStyle;
            }
            set
            {
                underLineStyle = value;
                this.Invalidate();
            }

        }

        [Category("New Textbox")]
        public bool PasswordChart
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }

            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("New Textbox")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("New Textbox")]
        public override Color BackColor
        {

            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }

        }

        [Category("New Textbox")]
        public override Color ForeColor
        {

            get 
            { return base.ForeColor; 
            
            }

            set 
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;

             }

        }

        [Category("New Textbox")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("New Textbox")]
        public string Texts
        {
            get
            {
               return textBox1.Text;

            }
            set
            {
                textBox1.Text = value;

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //dibujar borde
            //crear objeto boligrafo

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                //dibujar borde subrayado
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underLineStyle)
                {
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {

                    //dibujar borde normal (rectangular)
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

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
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
    }
}
