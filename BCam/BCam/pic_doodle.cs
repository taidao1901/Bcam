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
    public partial class pic_doodle : UserControl
    {

        public Image<Bgr, byte> ImgInput { get; set; }
        public pic_doodle()
        {
            InitializeComponent();
            bm = new Bitmap(frm_image.Instance.Pic_main.Image, pic_pic.Width, pic_pic.Height);
            g = Graphics.FromImage(bm);
            pic_pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic_pic.Image = bm;
        }
        private static pic_doodle _instance;
        public static pic_doodle Instance
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
        Point px, py;
        Pen crpPen=new Pen(Color.Black, 1);
        bool paint = false;
        int cX, cY;
        Bitmap bm;
        Graphics g;

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

        private void btn_pencolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorchooser = new ColorDialog();
            colorchooser.FullOpen = true;
            if (colorchooser.ShowDialog() == DialogResult.OK)
            {
                crpPen.Color = colorchooser.Color;
                btn_pencolor.BackColor = colorchooser.Color;
            }
        }

        private void pic_doodle_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }
        private void pic_pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            crpPen.Width = (float)numUD_width.Value;

            cX = e.X;
            cY = e.Y;
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

        private void pnl_width_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Select pen width !", pnl_width);
        }

        private void btn_pencolor_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Select pen color !", btn_pencolor);
        }

        private void pic_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                px = e.Location;
                g.DrawLine(crpPen, px, py);
                py = px;
            }
            pic_pic.Refresh();
        }

        private void pic_pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }
    }
}
