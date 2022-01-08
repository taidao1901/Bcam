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
using Emgu.CV.Structure;

namespace doan
{
    public partial class frm_BrCo : UserControl
    {
        public frm_BrCo()
        {
            InitializeComponent();
            bm = new Bitmap(frm_image.Instance.Pic_main.Image, pic_pic.Width, pic_pic.Height);

            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }

        public Image<Bgr, byte> input { get; set; }
        Image<Bgr, byte> output;
        Bitmap bm;
        Graphics g;

        private void BrCo_Load(object sender, EventArgs e)
        {
            try
            {
                if (input == null)
                {
                    throw new Exception("Vui lòng chụp ảnh !!!");
                }
                if (input != null)
                {
                    pic_pic.Image = input.AsBitmap();
                }

                lab_Br.Text = track_Br.Value.ToString();
                //lab_min_br.Text = track_Br.Minimum.ToString();
                //lab_max_br.Text = track_Br.Maximum.ToString();


                //lab_min_co.Text = track_Co.Minimum.ToString();
                //lab_max_co.Text = (track_Co.Maximum/100).ToString();
                lab_Co.Text = track_Co.Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void track_Co_Scroll(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    lab_Co.Text = ((float)track_Co.Value / 100).ToString();
                    lab_Br.Text = ((float)track_Br.Value).ToString();
                    output = input.Mul(double.Parse(lab_Co.Text)) + track_Br.Value;
                    pic_pic.Image = output.AsBitmap();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void track_Br_Scroll(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    lab_Co.Text = ((float)track_Co.Value / 100).ToString();
                    lab_Br.Text = ((float)track_Br.Value).ToString();
                    output = input.Mul(double.Parse(lab_Co.Text)) + track_Br.Value;
                    pic_pic.Image = output.AsBitmap();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to save this change?", "Notice", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                try
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
                catch (Exception)
                {
                    MessageBox.Show("Chưa có sự thay đổi");
                }
            }
        }

        private void grBox_Co_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Slide to change contrast", grBox_Co);
        }

        private void grBox_Br_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Slide to change brightness", grBox_Br);
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
