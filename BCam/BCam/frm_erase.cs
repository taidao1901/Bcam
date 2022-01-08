using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using BCam.Properties;

namespace doan
{
    public partial class frm_erase : UserControl
    {
        public frm_erase()
        {
            InitializeComponent();

            rect = Rectangle.Empty;

            bm = new Bitmap(frm_image.Instance.Pic_main.Image, pic_pic.Width, pic_pic.Height);

            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }
        bool NoiseDown = false;
        bool NoiseSelecting = false;
        bool Selecting = false;
        bool MouseDown = false;
        bool WSelecting = false;
        bool WDown = false;
        int index;

        Point px, py;
        Bitmap bm;
        Graphics g;
        Rectangle rect;

        List<List<Point>> NoiseP = null;
        List<Point> NoiseCurP = null;
        Point ROI;

        private void btn_noise_Click(object sender, EventArgs e)
        {
            NoiseSelecting = true;
            NoiseCurP = new List<Point>();
            NoiseP = new List<List<Point>>();
            index = 1;
            //trackBar1.Maximum = 7;
            //trackBar1.Minimum = 1;
            //trackBar1.Value = 4;
            selectbtn(btn_noise);
        }

        private void pic_pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (NoiseSelecting == true && e.Button == MouseButtons.Left)
            {
                NoiseDown = true;
                NoiseCurP.Add(e.Location);
            }

            if (Selecting)
            {
                MouseDown = true;
                ROI = e.Location;
            }

            if (WSelecting)
            {
                WDown = true;
                py = e.Location;
            }    
        }

        private void pic_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic_pic.Image == null)
            {
                return;
            }
            if (NoiseDown == true && NoiseSelecting == true)
            {
                if (NoiseCurP.Count > 0)
                {
                    Pen p = new Pen(Brushes.Red, tbar_noise.Value);
                    using (Graphics g = Graphics.FromImage(pic_pic.Image))
                    {
                        g.DrawLine(p, NoiseCurP.Last(), e.Location);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    }
                }
                NoiseCurP.Add(e.Location);
                pic_pic.Invalidate();
            }
            if (Selecting)
            {
                int width = Math.Max(ROI.X, e.X) - Math.Min(ROI.X, e.X);
                int height = Math.Max(ROI.Y, e.Y) - Math.Min(ROI.Y, e.Y);
                rect = new Rectangle(Math.Min(ROI.X, e.X), Math.Min(ROI.Y, e.Y), width, height);
                pic_pic.Invalidate();
            }
            if (WDown == true && WSelecting == true) 
            {
                using (Graphics g = Graphics.FromImage(pic_pic.Image))
                {
                    Pen erase = new Pen(Color.White, tbar_white.Value);
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                    pic_pic.Invalidate();
                }        
            }
        }

        private void pic_pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (NoiseDown == true && NoiseSelecting)
            {
                NoiseDown = false;
                NoiseP.Add(NoiseCurP.ToList());
                NoiseCurP.Clear();
            }

            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }

            if (index == 1)
            {
                try
                {
                    if (NoiseP.Count == 0) return;
                    var img = new Bitmap(pic_pic.Image).ToImage<Bgr, byte>();
                    var mask = new Image<Gray, byte>(img.Width, img.Height);
                    foreach (var polys in NoiseP)
                    {
                        mask.DrawPolyline(polys.ToArray(), false, new Gray(255), 5);
                    }
                    var output = img.CopyBlank();
                    CvInvoke.Inpaint(img, mask, output, 3, InpaintType.Telea);
                    pic_pic.Image = output.AsBitmap();
                    NoiseSelecting = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
            if (index == 2)
            {
                try
                {
                    var img = new Bitmap(pic_pic.Image).ToImage<Bgr, byte>();
                    img.ROI = rect;
                    var img2 = img.Copy();
                    var imgSmooth = img2.SmoothGaussian(25);
                    img.SetValue(new Bgr(1, 1, 1));
                    img._Mul(imgSmooth);
                    img.ROI = Rectangle.Empty;
                    pic_pic.Image = img.AsBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (index == 3)
            {
                WSelecting = false;
                WDown = false;
            }
        }

        private void pic_pic_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown && index == 2)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
        private void selectbtn(Button btn)
        {
            foreach (Control bt in pnl_edit.Controls)
            {

                    bt.BackColor = Color.MediumSlateBlue;
                
            }
            btn.BackColor = Color.DarkOrchid;
            if (btn == btn_noise)
            {
                tbar_noise.BackColor= Color.DarkOrchid;
            }
            if (btn== btn_eraseW)
            {
                tbar_white.BackColor = Color.DarkOrchid;
            }
        }
        private void btn_blur_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 2;
            selectbtn(btn_blur);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to save this change?", "Notice", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                frm_image.Instance.Pic_main = new PictureBox();
                frm_image.Instance.Pic_main.SizeMode = PictureBoxSizeMode.Zoom;
                frm_image.Instance.Pic_main.Size = pic_pic.Size;
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic_pic.Width, pic_pic.Height), bm.PixelFormat);
                frm_image.Instance.Pic_main.Dock = DockStyle.Fill;
                frm_image.Instance.Pic_main.Image = btm;
                frm_image.Instance.Pnl_main.Controls.Clear();
                frm_image.Instance.Pnl_main.Controls.Add(frm_image.Instance.Pic_main);
                frm_image.Instance.Pnl_zoom.Visible = true;
            }
        }


        private void btn_save_MouseHover(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("checkhover");
            btn_save.Image = (Image)O;
            toolTip1.Show("Click to save this change!", btn_save);
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("check");
            btn_save.Image = (Image)O;
        }

        private void btn_blur_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Blurring select area", btn_blur);
        }

        private void btn_noise_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Removing noise", btn_noise);
        }

        private void btn_eraseW_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Eraser", btn_eraseW);
        }

        private void btn_eraseW_Click(object sender, EventArgs e)
        {
            index = 3;
            WSelecting = true;
            selectbtn(btn_eraseW);
        }
    }
}
