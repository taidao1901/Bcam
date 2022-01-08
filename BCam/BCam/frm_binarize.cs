using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using BCam.Properties;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;

namespace doan
{
    public partial class frm_binarize : UserControl
    {
        Bitmap bm;
        Graphics g;
        int a = 127;

        public Image<Bgr, byte> ImgInput { get; set; }
        Image<Gray, byte> output;
        public delegate void DelegateHaris(int x);

        public frm_binarize()
        {
            InitializeComponent();
            bm = new Bitmap(frm_image.Instance.Pic_main.Image, pic_pic.Width, pic_pic.Height);
            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }
        private void frm_binarize_Load(object sender, EventArgs e)
        {
            Binarize();
        }

        private void track_Bi_Scroll(object sender, EventArgs e)
        {
            try
            {
                a = track_Bi.Value;
                Binarize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Binarize()
        {
            try
            {
                if (ImgInput == null)
                {
                    return;
                }

                var img = ImgInput.Convert<Gray, byte>().Clone();
                output = img.ThresholdBinary(new Gray(a), new Gray(255));
                pic_pic.Image = output.AsBitmap();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
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
                frm_image.Instance.Pic_main.Image = output.AsBitmap();
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
    }
}
