using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Cuda;
using BCam.Properties;

namespace doan
{
    public partial class frm_image : UserControl
    {
        public frm_image()
        {
            InitializeComponent();
        }

        //static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        public int a = 127;
        public int b;
        Bitmap bm;
        public Dictionary<string, Image<Bgr, byte>> imgList;
        public int stt = 0;
        PictureBox img_tmp;
        //Graphics g;
        private static frm_image _instance;
        public static frm_image Instance
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

        private void frm_image_Load(object sender, EventArgs e)
        {
            _instance = this;
            pic_image.Image = frm_camera.Instance.Pic_main.Image;
        }
        public Panel Pnl_main
        {
            get { return pnl_main; }
            set { pnl_main = value; }
        }
        public PictureBox Pic_main
        {
            get { return pic_image; }
            set { pic_image = value; }
        }

        public Panel Pnl_zoom
        {
            get { return pnl_zoom; }
            set { pnl_zoom = value; }
        }
        private void hightlight(Button btn)
        {
            foreach (Button bt in pnl_edit.Controls)
            {
                bt.BackColor = Color.MediumSlateBlue;
                bt.ImageAlign = ContentAlignment.MiddleLeft;
                bt.TextAlign = ContentAlignment.MiddleCenter;
            }
            btn.BackColor = Color.DarkOrchid;
            btn.ImageAlign = ContentAlignment.MiddleRight;
            btn.TextAlign = ContentAlignment.MiddleLeft;



        }
        private void btn_drop_Click(object sender, EventArgs e)
        {
            pic_drop Pic = new pic_drop();
            Pic.Pic_pic.Image = Pic_main.Image;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(Pic);
            pnl_zoom.Visible = false;
            hightlight(btn_drop);
        }


        private void btn_doodle_Click(object sender, EventArgs e)
        {
            pic_doodle Pic = new pic_doodle();
            var img = new Bitmap(pic_image.Image).ToImage<Bgr, byte>();
            Pic.ImgInput = img.Clone();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(Pic);
            pnl_zoom.Visible = false;
            hightlight(btn_doodle);
        }


        private void btn_BrCo_Click(object sender, EventArgs e)
        {
            frm_BrCo frm = new frm_BrCo();
            var img = new Bitmap(pic_image.Image).ToImage<Bgr, byte>();
            frm.input = img.Clone();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(frm);
            pnl_zoom.Visible = false;
            hightlight(btn_BrCo);
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            frm_filter frm = new frm_filter();
            var img = new Bitmap(pic_image.Image).ToImage<Bgr, byte>();
            frm.input = img.Clone();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(frm);
            pnl_zoom.Visible = false;
            hightlight(btn_filter);
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            try
            {
                if (pic_image.Image == null)
                {
                    MessageBox.Show("Please select a template");
                    return;
                }

                var img = new Bitmap(pic_image.Image).ToImage<Bgr, byte>();
                img = img.Rotate(90, new Bgr(0, 0, 0), false);
                pic_image.Image = img.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            hightlight(btn_rotate);
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            frm_erase frm = new frm_erase();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(frm);
            pnl_zoom.Visible = false;
            hightlight(btn_erase);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_image.Image == null) return;
            var sfd = new SaveFileDialog();
            bm = new Bitmap(pic_image.Image, pic_image.Width, pic_image.Height);
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic_image.Width, pic_image.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(dialog.FileName);
                    pic_image.Image = img.AsBitmap();
                    //frm_image image = new frm_image();
                    //image.Pic_main.Image = img.AsBitmap();
                    //Form1.Instance.Pnl_main.Controls.Clear();
                    //Form1.Instance.Pnl_main.Controls.Add(image);
                    img_tmp = new PictureBox();
                    img_tmp.Load(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            frm_addimg frm = new frm_addimg();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(frm);
            pnl_zoom.Visible = false;
            hightlight(btn_img);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (tbar_zoom.Value != 1)
            {
                pic_image.Image = null;
                pnl_main.AutoScroll = true;
                pic_image.SizeMode = PictureBoxSizeMode.AutoSize;
                if (pic_image.Image == null)
                    pic_image.Image = frm_camera.Instance.Pic_main.Image;
                Bitmap bm = new Bitmap(frm_camera.Instance.Pic_main.Image, Convert.ToInt32(frm_camera.Instance.Pic_main.Width * tbar_zoom.Value), Convert.ToInt32(frm_camera.Instance.Pic_main.Height * tbar_zoom.Value));
                pic_image.Image = bm;
                string x = tbar_zoom.Value.ToString() + "x";
                lab_zoom.Text = x;
            }
            else
            {
                if (pic_image.Image == null)
                    pic_image.Image = frm_camera.Instance.Pic_main.Image;
                pic_image.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureBox1.Image = frm_camera.Instance.Pic_main.Image;
                lab_zoom.Text = "1x";
            }    
        }

        private void btn_cmr_Click(object sender, EventArgs e)
        {
            frm_camera camera = new frm_camera();
            Form1.Instance.Pnl_main.Controls.Clear();
            Form1.Instance.Pnl_main.Controls.Add(camera);
        }

        private void btn_cmr_MouseHover(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("backcmr50");
            btn_cmr.Image = (Image)O;
            toolTip1.Show("Click to back the camera!", btn_cmr);

        }

        private void btn_cmr_MouseLeave(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("backcmrhover50");
            btn_cmr.Image = (Image)O;
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            frm_image image = new frm_image();
            image.pic_image.Image = this.pic_image.Image;
            Form1.Instance.Pnl_main.Controls.Clear();
            Form1.Instance.Pnl_main.Controls.Add(image);
        }

        private void btn_huy_MouseHover(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("returnhover");
            btn_huy.Image = (Image)O;
            btn_huy.BackColor = Color.White;
            toolTip1.Show("Click to cancer!", btn_huy);
        }

        private void btn_huy_MouseLeave(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("return");
            btn_huy.Image = (Image)O;
            btn_huy.BackColor = Color.DodgerBlue;
        }

        private void btn_drop_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Crop tool", btn_drop);
        }

        private void btn_erase_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Eraser tool", btn_erase);
        }

        private void btn_doodle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Doodle tool", btn_doodle);
        }

        private void btn_filter_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Filer tool", btn_filter);
        }

        private void btn_BrCo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Brightness and Constract tool", btn_BrCo);
        }

        private void btn_rotate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Rotate tool", btn_rotate);
        }

        private void btn_img_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add image, text, icon to the image", btn_img);
        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bcam Application - Nhom 19");
        }
    }
    
}
