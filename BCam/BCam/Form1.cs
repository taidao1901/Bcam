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

namespace doan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //g = Graphics.FromImage(pictureBox1.Image);
        }
        private static Form1 _instance;
        public static Form1 Instance
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
        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            frm_camera camera = new frm_camera();
            pnl_main.Controls.Add(camera);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
