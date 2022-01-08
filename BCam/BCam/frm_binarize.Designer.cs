
namespace doan
{
    partial class frm_binarize
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
            this.pic_pic = new System.Windows.Forms.PictureBox();
            this.track_Bi = new System.Windows.Forms.TrackBar();
            this.btn_save = new doan.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gradientPanel1 = new BCam.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Bi)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_pic
            // 
            this.pic_pic.BackColor = System.Drawing.Color.White;
            this.pic_pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_pic.Location = new System.Drawing.Point(0, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(843, 460);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pic.TabIndex = 7;
            this.pic_pic.TabStop = false;
            // 
            // track_Bi
            // 
            this.track_Bi.AutoSize = false;
            this.track_Bi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.track_Bi.Location = new System.Drawing.Point(156, 1);
            this.track_Bi.Margin = new System.Windows.Forms.Padding(2);
            this.track_Bi.Maximum = 255;
            this.track_Bi.Name = "track_Bi";
            this.track_Bi.Size = new System.Drawing.Size(542, 52);
            this.track_Bi.TabIndex = 9;
            this.track_Bi.Value = 127;
            this.track_Bi.Scroll += new System.EventHandler(this.track_Bi_Scroll);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::BCam.Properties.Resources.check;
            this.btn_save.Location = new System.Drawing.Point(792, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 13;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save.MouseHover += new System.EventHandler(this.btn_save_MouseHover);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.track_Bi);
            this.gradientPanel1.Controls.Add(this.btn_save);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 460);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(843, 52);
            this.gradientPanel1.TabIndex = 14;
            // 
            // frm_binarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.pic_pic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_binarize";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.frm_binarize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Bi)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_pic;
        private System.Windows.Forms.TrackBar track_Bi;
        private RoundButton btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private BCam.GradientPanel gradientPanel1;
    }
}
