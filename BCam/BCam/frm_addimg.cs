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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using BCam.Properties;

namespace doan
{
    public partial class frm_addimg : UserControl
    {
        public frm_addimg()
        {
            InitializeComponent();
            rect = Rectangle.Empty;
            bm = new Bitmap(frm_image.Instance.Pic_main.Image, pic_pic.Width, pic_pic.Height);
            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }
        FontDialog fdl;
        ColorDialog cdl;
        Rectangle rect;
        Point point;
        bool Selecting = false, MouseDown = false;
        bool imgselect = false;
        Bitmap bm;
        Bitmap img2;
        Image<Bgr, byte> img3;
        Graphics g;
        int index;

        private void pic_pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                MouseDown = true;
                point = e.Location;
            }
        }

        private void pic_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic_pic.Image == null)
            {
                return;
            }
            if (Selecting)
            {
                int width = Math.Max(point.X, e.X) - Math.Min(point.X, e.X);
                int height = Math.Max(point.Y, e.Y) - Math.Min(point.Y, e.Y);
                rect = new Rectangle(Math.Min(point.X, e.X), Math.Min(point.Y, e.Y), width, height);
                Refresh();  
            }
        }

        private void pic_pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
                Cursor = Cursors.Default;
            }
            if (index == 1)
            {
                try
                {
                    //OpenFileDialog dialog = new OpenFileDialog();
                    //if (dialog.ShowDialog() == DialogResult.OK)
                    //{
                    //    var img1 = new Bitmap(pic_pic.Image).ToImage<Bgr, byte>();
                    //    var img2 = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>().Resize(0.75, Inter.Cubic);
                    //    var mask = img2.Convert<Gray, byte>().SmoothGaussian(3).ThresholdBinaryInv(new Gray(245), new Gray(255)).Erode(1);
                    //    rect.Width = img2.Width;
                    //    rect.Height = img2.Height;
                    //    img1.ROI = rect;
                    //    img1.SetValue(new Bgr(0, 0, 0), mask);
                    //    img2.SetValue(new Bgr(0, 0, 0), mask.Not());
                    //    img1._Or(img2);
                    //    img1.ROI = Rectangle.Empty;
                    //    pic_pic.Image = img1.ToBitmap();
                    //}
                    var img1 = new Bitmap(pic_pic.Image).ToImage<Bgr, byte>();
                    //var img2 = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>().Resize(0.75, Inter.Cubic);
                    var mask = img3.Convert<Gray, byte>().SmoothGaussian(3).ThresholdBinaryInv(new Gray(245), new Gray(255)).Erode(1);
                    rect.Width = img3.Width;
                    rect.Height = img3.Height;
                    img1.ROI = rect;
                    img1.SetValue(new Bgr(0, 0, 0), mask);
                    img3.SetValue(new Bgr(0, 0, 0), mask.Not());
                    img1._Or(img3);
                    img1.ROI = Rectangle.Empty;
                    pic_pic.Image = img1.ToBitmap();
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
                    if (rect == null) return;
                    Pen p = new Pen(cdl.Color, 2);
                    using (Graphics g = Graphics.FromImage(pic_pic.Image))
                    {
                        Font f = new Font("Segoe UI", 12, FontStyle.Regular);
                        g.DrawString(richTxt_txt.Text, fdl.Font, p.Brush, rect);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (index == 3)
            {
                try
                {
                    if (rect == null) return;
                    Icon icon1 = new Icon(SystemIcons.Exclamation, 40, 40);
                    Bitmap bmp = icon1.ToBitmap();
                    using (Graphics g = Graphics.FromImage(pic_pic.Image))
                    {
                        g.DrawImage(bmp, new Point(30, 30));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
            if (index == 4)
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        img2 = new Image<Bgr, byte>(dialog.FileName).Resize(0.75, Inter.Cubic).ToBitmap();
                        rect.Width = img2.Width;
                        rect.Height = img2.Height;
                        using (Graphics g = Graphics.FromImage(pic_pic.Image))
                        {
                            g.DrawImage(img2, point);
                            imgselect = true;
                            pic_pic.Invalidate();
                        }
                        imgselect = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            index = 4;
            Selecting = true;
            Cursor = Cursors.Cross;
            selectbtn(btn_img);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to save this change?", "Notice", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                frm_image.Instance.Pic_main = new PictureBox();
                frm_image.Instance.Pic_main.SizeMode = PictureBoxSizeMode.Zoom;
                frm_image.Instance.Pic_main.Dock = DockStyle.Fill;
                Size s = new Size(829, 461);
                frm_image.Instance.Pic_main.Size = s;
                frm_image.Instance.Pic_main.Image = pic_pic.Image;
                frm_image.Instance.Pnl_main.Controls.Clear();
                frm_image.Instance.Pnl_main.Controls.Add(frm_image.Instance.Pic_main);
                frm_image.Instance.Pnl_zoom.Visible = true;
            }
        }
        private void selectbtn(Button btn)
        {
            foreach (Button bt in pnl_edit.Controls)
            {
                bt.BackColor = Color.MediumSlateBlue;
            }
            btn.BackColor = Color.DarkOrchid;
        }
        private void btn_txt_Click(object sender, EventArgs e)
        {
            grBox_txt.Visible = true;
            cdl = new ColorDialog();
            fdl = new FontDialog();
            selectbtn(btn_txt);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            index = 2;
            Selecting = true;
            grBox_txt.Visible = false;
            Cursor = Cursors.Cross;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            grBox_txt.Visible = false;
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            if (fdl.ShowDialog() == DialogResult.OK)
            {
                richTxt_txt.Font = fdl.Font;
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cdl.ShowDialog() == DialogResult.OK)
            {
                richTxt_txt.ForeColor = cdl.Color;
            }
        }


        private void btn_icon_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            pnl_icon.Visible = true;
            selectbtn(btn_icon);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox2.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox3.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox6.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox5.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox4.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox9.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox8.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox7.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox12.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox11.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Selecting = true;
            index = 1;
            Cursor = Cursors.Cross;
            img3 = new Bitmap(pictureBox10.Image).ToImage<Bgr, byte>().Resize(0.5, Inter.Cubic);
            pnl_icon.Visible = false;
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

        private void pic_pic_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown && index == 1)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
            if (MouseDown && index == 2)
            {
                Pen p = new Pen(cdl.Color, 2);
                e.Graphics.DrawString(richTxt_txt.Text, fdl.Font, p.Brush, rect);
                pic_pic.Invalidate();
            }
            if (MouseDown && index == 4 && imgselect)
            {
                e.Graphics.DrawImage(img2, point);
                pic_pic.Invalidate();
                imgselect = false;
            }
            if (MouseDown && index == 3)
            {
                Icon icon1 = new Icon(SystemIcons.Error, 40, 40);

                // Call ToBitmap to convert it.
                Bitmap bmp = icon1.ToBitmap();

                // Draw the bitmap.
                e.Graphics.DrawImage(bmp, new Point(30, 30));
            }    
        }
    }
}
