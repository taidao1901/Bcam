using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class pic_drop : UserControl
    {
        public pic_drop()
        {
            InitializeComponent();
        }
        private static pic_drop _instance;
        public static pic_drop Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public PictureBox Pic_pic
        {
            get { return pic_pic; }
            set { pic_pic = value; }
        }
        int rectW, rectH;
        public Pen crpPen;
        Rectangle rect;
        Point startPoint;

        private void pic_pic_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pic_pic.Refresh();
                rectW = Math.Max(startPoint.X, e.X) - Math.Min(startPoint.X, e.X);
                rectH = Math.Max(startPoint.Y, e.Y) - Math.Min(startPoint.Y, e.Y);
                Size size = new Size(rectW, rectH);
                Point startLocation = new Point(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y));
                Graphics g = pic_pic.CreateGraphics();
                rect = new Rectangle(startLocation, size);
                g.DrawRectangle(crpPen, rect);
                g.Dispose();
            }
        }

        private void pic_pic_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to save this change?", "Notice", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                Cursor = Cursors.Default;
                Bitmap bmp2 = new Bitmap(pic_pic.Width, pic_pic.Height);
                pic_pic.DrawToBitmap(bmp2, pic_pic.ClientRectangle);

                Bitmap crpImg = new Bitmap(rectW, rectH);

                for (int i = 0; i < rectW; i++)
                {
                    for (int y = 0; y < rectH; y++)
                    {
                        Color pxlclr = bmp2.GetPixel(Math.Min(startPoint.X, e.X) + i, Math.Min(startPoint.Y, e.Y) + y);
                        crpImg.SetPixel(i, y, pxlclr);
                    }
                }
                frm_image.Instance.Pic_main = new PictureBox();
                frm_image.Instance.Pic_main.SizeMode = PictureBoxSizeMode.CenterImage;
                frm_image.Instance.Pic_main.Size = pic_pic.Size;
                frm_image.Instance.Pic_main.Image = (Image)crpImg;
                frm_image.Instance.Pnl_main.Controls.Clear();
                frm_image.Instance.Pnl_main.Controls.Add(frm_image.Instance.Pic_main);
                frm_image.Instance.Pnl_zoom.Visible = true;
            }
        }

        private void pic_Load(object sender, EventArgs e)
        {
            crpPen = new Pen(Color.White);
            Cursor = Cursors.Cross;
            pic_pic.MouseDown += new MouseEventHandler(pic_pic_MouseDown);

            pic_pic.MouseMove += new MouseEventHandler(pic_pic_MouseMove);

            pic_pic.MouseUp += new MouseEventHandler(pic_pic_MouseUp);
            Controls.Add(pic_pic);
        }

        private void pic_pic_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            startPoint = e.Location;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            }
        }
    }
}
