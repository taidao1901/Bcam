using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCam.Properties;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;

namespace doan
{
    public partial class frm_filter : UserControl
    {
            Bitmap bm;
            Graphics g;

        public Image<Bgr, byte> input { get; set; }
        public frm_filter()
        {
            InitializeComponent();
            bm = new Bitmap(frm_image.Instance.Pic_main.Image);
            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }

        private void frm_Filter_Load(object sender, EventArgs e)
        {
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void selectbtn(Button btn)
        {
            foreach(Button bt in pnl_edit.Controls)
            {
                bt.BackColor = Color.MediumSlateBlue;
            }
            btn.BackColor = Color.DarkOrchid;
        }
        private void btn_canny_Click(object sender, EventArgs e)
        {
            var imgCanny = input.SmoothGaussian(5).Canny(100, 50);
            var imgBgr = imgCanny.Convert<Bgr, byte>();
            input.SetValue(new Bgr(1, 1, 1));
            input._Mul(imgBgr);
            pic_pic.Image = input.AsBitmap();
            selectbtn(btn_canny);
        }

        private void btn_old_Click(object sender, EventArgs e)
        {
            var img = new Bitmap(frm_image.Instance.Pic_main.Image).ToImage<Gray, byte>();
            Mat output = new Mat();
            CvInvoke.CLAHE(img, 50, new Size(8, 8), output);
            pic_pic.Image = output.ToBitmap();
            selectbtn(btn_old);
        }

        private void btn_binarize_Click(object sender, EventArgs e)
        {
            frm_binarize frm = new frm_binarize();
            var img = new Bitmap(pic_pic.Image).ToImage<Bgr, byte>();
            frm.ImgInput = img.Clone();
            frm_image.Instance.Pnl_main.Controls.Clear();
            frm_image.Instance.Pnl_main.Controls.Add(frm);
            selectbtn(btn_binarize);
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

        private void btn_save_MouseHover(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("checkhover");
            btn_save.Image = (Image)O;
            toolTip1.Show("Click to save this change!", btn_save);
        }

        private void btn_save_ClientSizeChanged(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("check");
            btn_save.Image = (Image)O;
        }
    }
}
