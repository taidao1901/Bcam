
namespace doan
{
    partial class frm_camera
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pic_frame = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new BCam.GradientPanel();
            this.btn_takepic = new doan.RoundButton();
            this.cbb_camera = new System.Windows.Forms.ComboBox();
            this.grbox_filters = new System.Windows.Forms.GroupBox();
            this.tbar_thresholded = new System.Windows.Forms.TrackBar();
            this.btn_thresholded = new BCam.RoundEdgeButton();
            this.btn_grayscaled = new BCam.RoundEdgeButton();
            this.btn_blur = new BCam.RoundEdgeButton();
            this.tbar_blur = new System.Windows.Forms.TrackBar();
            this.btn_original = new BCam.RoundEdgeButton();
            this.pic_selectcam = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_frame)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbox_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_thresholded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectcam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pic_frame);
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(979, 523);
            this.pnl_main.TabIndex = 17;
            // 
            // pic_frame
            // 
            this.pic_frame.Location = new System.Drawing.Point(0, 0);
            this.pic_frame.Name = "pic_frame";
            this.pic_frame.Size = new System.Drawing.Size(979, 523);
            this.pic_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_frame.TabIndex = 0;
            this.pic_frame.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.panel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_takepic);
            this.panel1.Controls.Add(this.cbb_camera);
            this.panel1.Controls.Add(this.grbox_filters);
            this.panel1.Controls.Add(this.pic_selectcam);
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 112);
            this.panel1.TabIndex = 21;
            // 
            // btn_takepic
            // 
            this.btn_takepic.FlatAppearance.BorderSize = 0;
            this.btn_takepic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_takepic.Image = global::BCam.Properties.Resources.diaphragm;
            this.btn_takepic.Location = new System.Drawing.Point(442, 13);
            this.btn_takepic.Name = "btn_takepic";
            this.btn_takepic.Size = new System.Drawing.Size(90, 90);
            this.btn_takepic.TabIndex = 19;
            this.btn_takepic.UseVisualStyleBackColor = true;
            this.btn_takepic.Click += new System.EventHandler(this.btn_takepic_Click);
            this.btn_takepic.MouseLeave += new System.EventHandler(this.btn_takepic_MouseLeave);
            this.btn_takepic.MouseHover += new System.EventHandler(this.btn_takepic_MouseHover);
            // 
            // cbb_camera
            // 
            this.cbb_camera.FormattingEnabled = true;
            this.cbb_camera.Location = new System.Drawing.Point(54, 22);
            this.cbb_camera.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_camera.Name = "cbb_camera";
            this.cbb_camera.Size = new System.Drawing.Size(131, 21);
            this.cbb_camera.TabIndex = 11;
            // 
            // grbox_filters
            // 
            this.grbox_filters.BackColor = System.Drawing.Color.Transparent;
            this.grbox_filters.Controls.Add(this.tbar_thresholded);
            this.grbox_filters.Controls.Add(this.btn_thresholded);
            this.grbox_filters.Controls.Add(this.btn_grayscaled);
            this.grbox_filters.Controls.Add(this.btn_blur);
            this.grbox_filters.Controls.Add(this.tbar_blur);
            this.grbox_filters.Controls.Add(this.btn_original);
            this.grbox_filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_filters.ForeColor = System.Drawing.Color.White;
            this.grbox_filters.Location = new System.Drawing.Point(603, 3);
            this.grbox_filters.Name = "grbox_filters";
            this.grbox_filters.Size = new System.Drawing.Size(373, 109);
            this.grbox_filters.TabIndex = 18;
            this.grbox_filters.TabStop = false;
            this.grbox_filters.Text = "Filters";
            // 
            // tbar_thresholded
            // 
            this.tbar_thresholded.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbar_thresholded.Location = new System.Drawing.Point(233, 62);
            this.tbar_thresholded.Margin = new System.Windows.Forms.Padding(2);
            this.tbar_thresholded.Maximum = 255;
            this.tbar_thresholded.Name = "tbar_thresholded";
            this.tbar_thresholded.Size = new System.Drawing.Size(131, 45);
            this.tbar_thresholded.TabIndex = 23;
            this.tbar_thresholded.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_thresholded.Value = 127;
            this.tbar_thresholded.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_thresholded
            // 
            this.btn_thresholded.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_thresholded.FlatAppearance.BorderSize = 0;
            this.btn_thresholded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thresholded.Image = global::BCam.Properties.Resources.black_and_white;
            this.btn_thresholded.Location = new System.Drawing.Point(259, 11);
            this.btn_thresholded.Name = "btn_thresholded";
            this.btn_thresholded.Size = new System.Drawing.Size(82, 50);
            this.btn_thresholded.TabIndex = 22;
            this.btn_thresholded.UseVisualStyleBackColor = false;
            this.btn_thresholded.Click += new System.EventHandler(this.btn_thresholded_Click);
            this.btn_thresholded.MouseHover += new System.EventHandler(this.btn_thresholded_MouseHover);
            // 
            // btn_grayscaled
            // 
            this.btn_grayscaled.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_grayscaled.FlatAppearance.BorderSize = 0;
            this.btn_grayscaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grayscaled.Image = global::BCam.Properties.Resources.grayscale;
            this.btn_grayscaled.Location = new System.Drawing.Point(6, 59);
            this.btn_grayscaled.Name = "btn_grayscaled";
            this.btn_grayscaled.Size = new System.Drawing.Size(82, 50);
            this.btn_grayscaled.TabIndex = 0;
            this.btn_grayscaled.UseVisualStyleBackColor = false;
            this.btn_grayscaled.Click += new System.EventHandler(this.btn_grayscaled_Click);
            this.btn_grayscaled.MouseHover += new System.EventHandler(this.btn_grayscaled_MouseHover);
            // 
            // btn_blur
            // 
            this.btn_blur.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_blur.FlatAppearance.BorderSize = 0;
            this.btn_blur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blur.Image = global::BCam.Properties.Resources.blue;
            this.btn_blur.Location = new System.Drawing.Point(117, 11);
            this.btn_blur.Name = "btn_blur";
            this.btn_blur.Size = new System.Drawing.Size(82, 50);
            this.btn_blur.TabIndex = 0;
            this.btn_blur.UseVisualStyleBackColor = false;
            this.btn_blur.Click += new System.EventHandler(this.btn_blur_Click);
            this.btn_blur.MouseHover += new System.EventHandler(this.btn_blur_MouseHover);
            // 
            // tbar_blur
            // 
            this.tbar_blur.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbar_blur.Location = new System.Drawing.Point(95, 62);
            this.tbar_blur.Margin = new System.Windows.Forms.Padding(2);
            this.tbar_blur.Maximum = 100;
            this.tbar_blur.Name = "tbar_blur";
            this.tbar_blur.Size = new System.Drawing.Size(131, 45);
            this.tbar_blur.TabIndex = 21;
            this.tbar_blur.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_blur.Value = 1;
            this.tbar_blur.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // btn_original
            // 
            this.btn_original.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_original.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_original.FlatAppearance.BorderSize = 0;
            this.btn_original.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_original.ForeColor = System.Drawing.Color.Black;
            this.btn_original.Image = global::BCam.Properties.Resources.rgb1;
            this.btn_original.Location = new System.Drawing.Point(6, 12);
            this.btn_original.Name = "btn_original";
            this.btn_original.Size = new System.Drawing.Size(82, 50);
            this.btn_original.TabIndex = 0;
            this.btn_original.UseVisualStyleBackColor = false;
            this.btn_original.Click += new System.EventHandler(this.btn_original_Click);
            this.btn_original.MouseHover += new System.EventHandler(this.btn_original_MouseHover);
            // 
            // pic_selectcam
            // 
            this.pic_selectcam.BackColor = System.Drawing.Color.Transparent;
            this.pic_selectcam.BackgroundImage = global::BCam.Properties.Resources.focus;
            this.pic_selectcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_selectcam.Location = new System.Drawing.Point(4, 11);
            this.pic_selectcam.Name = "pic_selectcam";
            this.pic_selectcam.Size = new System.Drawing.Size(45, 45);
            this.pic_selectcam.TabIndex = 17;
            this.pic_selectcam.TabStop = false;
            this.pic_selectcam.MouseHover += new System.EventHandler(this.pic_selectcam_MouseHover);
            // 
            // frm_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_camera";
            this.Size = new System.Drawing.Size(979, 635);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_frame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbox_filters.ResumeLayout(false);
            this.grbox_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_thresholded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.PictureBox pic_selectcam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton btn_takepic;
        private System.Windows.Forms.TrackBar tbar_blur;
        private System.Windows.Forms.GroupBox grbox_filters;
        private System.Windows.Forms.ComboBox cbb_camera;
        private BCam.RoundEdgeButton btn_original;
        private BCam.RoundEdgeButton btn_grayscaled;
        private BCam.RoundEdgeButton btn_blur;
        private BCam.GradientPanel panel1;
        private System.Windows.Forms.PictureBox pic_frame;
        private System.Windows.Forms.TrackBar tbar_thresholded;
        private BCam.RoundEdgeButton btn_thresholded;
    }
}
