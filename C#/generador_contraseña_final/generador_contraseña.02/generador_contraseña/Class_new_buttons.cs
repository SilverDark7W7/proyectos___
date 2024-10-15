using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace generador_contraseña
{
    public class Class_new_buttons : Button
    {
        //declaracion de campos para la apariencia
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Boton_personalizado")]
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

        [Category("Boton_personalizado")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }

        }

        [Category("Boton_personalizado")]
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

        [Category("Boton_personalizado")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }

        }

        [Category("Boton_personalizado")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }

        }
        //uso del constructor para aparencia predeterminada del boton

        public Class_new_buttons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;

            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }

        //Metodo de orilla o margen del boton

        private GraphicsPath GetFigurePath (RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath ();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder= new RectangleF(1, 1, this.Width-0.8F, this.Height-1);

            if(borderRadius > 2) //si el borde del radio es mayor a 2 sera un boton circular
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //superficie del boton
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    //dibujar borde de la superficie del boton
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //borde del boton
                    if(borderSize >= 1)
                    {
                        //dibujar borde del boton
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                    } 
                                                                                     
            }

            else // si no sera un boton normal rectangular
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen (borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
                
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
               this.Invalidate();
            
        }
    }
}
        
