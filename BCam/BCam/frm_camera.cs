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
using System.Media;
using System.Drawing.Drawing2D;

namespace doan
{
    public partial class frm_camera : UserControl
    {
        public frm_camera()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        public int a = 127;
        public int b;
        //int index = 0;
        int btnori = 1;
        int btngray = 0;
        int btnbw = 0;
        int btnblur = 0;
        Bitmap bm;
        //Graphics g;
        private static frm_camera _instance;
        public static frm_camera Instance
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
        public Panel Pnl_main
        {
            get { return pnl_main; }
            set { pnl_main = value; }
        }
        public PictureBox Pic_main
        {
            get { return pic_frame; }
            set { pic_frame = value; }
        }

        public Bitmap Bm
        {
            get { return bm; }
            set { bm = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbb_camera.Items.Add(filterInfo.Name);
            cbb_camera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            if (btnori==1)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                ////Nhận diện khuôn mặt
                //if (index % 2 != 0)
                //{
                //    Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
                //    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 3);
                //    foreach (Rectangle rectangle in rectangles)
                //    {
                //        using (Graphics graphics = Graphics.FromImage(bitmap))
                //        {
                //            using (Pen pen = new Pen(Color.Red, 2))
                //            {
                //                graphics.DrawRectangle(pen, rectangle);
                //            }
                //        }
                //    }
                //}    
                pic_frame.Image = bitmap;
            }
            if (btngray==1)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                var grayscaledBitmap = Grayscale.CommonAlgorithms.BT709.Apply(bitmap);
                pic_frame.Image = grayscaledBitmap;
            }
            if (btnbw==1)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                var grayscaledBitmap = Grayscale.CommonAlgorithms.BT709.Apply(bitmap);
                var thresholdedBitmap = new Threshold(a).Apply(grayscaledBitmap);
                pic_frame.Image = thresholdedBitmap;
            }
            if (btnblur==1)
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                StackBlur.StackBlur.Process(bitmap, b);
                pic_frame.Image = bitmap;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            a = tbar_thresholded.Value;
        }
        

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            b = tbar_blur.Value;
        }


        private void btn_takepic_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            SoundPlayer audio = new SoundPlayer(BCam.Properties.Resources.camera_shutter_click_01);
            audio.Play();

            frm_image image = new frm_image();

            Form1.Instance.Pnl_main.Controls.Clear();
            Form1.Instance.Pnl_main.Controls.Add(image);
            grbox_filters.Visible = false;


        }

        private void btn_takepic_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click button to take a picture", btn_takepic);
            object O = Resources.ResourceManager.GetObject("diaphragmhover");
            btn_takepic.Image = (Image)O;
        }

        private void pic_selectcam_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Changing input camera", pic_selectcam);
        }

        private void btn_takepic_MouseLeave(object sender, EventArgs e)
        {
            object O = Resources.ResourceManager.GetObject("diaphragm");
            btn_takepic.Image = (Image)O;
        }
        private void selectbtn(Button btn)
        {

            foreach(Control cl in grbox_filters.Controls)
            {
                cl.BackColor = Color.DeepSkyBlue;

            }
            if (btn == btn_thresholded)
            {
                btn_thresholded.BackColor = Color.DodgerBlue;
                tbar_thresholded.BackColor = Color.DodgerBlue;
            }
            else if (btn == btn_blur)
            {
                tbar_blur.BackColor = Color.DodgerBlue;
                btn_blur.BackColor= Color.DodgerBlue;
            }
            else
            {
                btn.BackColor = Color.DodgerBlue;
            }
            
        }

        private void btn_original_Click(object sender, EventArgs e)
        {
            btnori = 1; btngray = 0;btnblur = 0;btnbw = 0;
            selectbtn(btn_original);
        }

        private void btn_thresholded_Click(object sender, EventArgs e)
        {
            btnori = 0; btngray = 0; btnblur = 0; btnbw = 1;
            selectbtn(btn_thresholded);
        }

        private void btn_grayscaled_Click(object sender, EventArgs e)
        {
            btnori = 0; btngray = 1; btnblur = 0; btnbw = 0;
            selectbtn(btn_grayscaled);
        }

        private void btn_blur_Click(object sender, EventArgs e)
        {
            btnori = 0; btngray = 0; btnblur = 1; btnbw = 0;
            selectbtn(btn_blur);
        }

        private void btn_original_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Original filter",btn_original);

        }

        private void btn_grayscaled_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Grayscale filter", btn_grayscaled);
        }

        private void btn_blur_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Blur filter", btn_blur);
        }

        private void btn_thresholded_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Thresholded filter", btn_thresholded);
        }
    }
}
