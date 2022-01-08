
namespace doan
{
    partial class frm_erase
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_pic = new System.Windows.Forms.PictureBox();
            this.btn_blur = new System.Windows.Forms.Button();
            this.btn_noise = new System.Windows.Forms.Button();
            this.tbar_noise = new System.Windows.Forms.TrackBar();
            this.btn_eraseW = new System.Windows.Forms.Button();
            this.tbar_white = new System.Windows.Forms.TrackBar();
            this.pnl_edit = new BCam.GradientPanel();
            this.btn_save = new doan.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_white)).BeginInit();
            this.pnl_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_pic
            // 
            this.pic_pic.BackColor = System.Drawing.Color.White;
            this.pic_pic.Location = new System.Drawing.Point(-1, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(843, 460);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pic.TabIndex = 9;
            this.pic_pic.TabStop = false;
            this.pic_pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_pic_Paint);
            this.pic_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseDown);
            this.pic_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseMove);
            this.pic_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseUp);
            // 
            // btn_blur
            // 
            this.btn_blur.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_blur.FlatAppearance.BorderSize = 0;
            this.btn_blur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blur.ForeColor = System.Drawing.Color.White;
            this.btn_blur.Image = global::BCam.Properties.Resources.blue;
            this.btn_blur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_blur.Location = new System.Drawing.Point(-2, 0);
            this.btn_blur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_blur.Name = "btn_blur";
            this.btn_blur.Size = new System.Drawing.Size(125, 52);
            this.btn_blur.TabIndex = 16;
            this.btn_blur.Text = "      Blur";
            this.btn_blur.UseVisualStyleBackColor = false;
            this.btn_blur.Click += new System.EventHandler(this.btn_blur_Click);
            this.btn_blur.MouseHover += new System.EventHandler(this.btn_blur_MouseHover);
            // 
            // btn_noise
            // 
            this.btn_noise.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_noise.FlatAppearance.BorderSize = 0;
            this.btn_noise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noise.ForeColor = System.Drawing.Color.White;
            this.btn_noise.Image = global::BCam.Properties.Resources.magic_wand;
            this.btn_noise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noise.Location = new System.Drawing.Point(127, 0);
            this.btn_noise.Margin = new System.Windows.Forms.Padding(2);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(125, 52);
            this.btn_noise.TabIndex = 17;
            this.btn_noise.Text = "         Noise";
            this.btn_noise.UseVisualStyleBackColor = false;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            this.btn_noise.MouseHover += new System.EventHandler(this.btn_noise_MouseHover);
            // 
            // tbar_noise
            // 
            this.tbar_noise.AutoSize = false;
            this.tbar_noise.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbar_noise.Location = new System.Drawing.Point(254, 0);
            this.tbar_noise.Margin = new System.Windows.Forms.Padding(2);
            this.tbar_noise.Maximum = 7;
            this.tbar_noise.Minimum = 1;
            this.tbar_noise.Name = "tbar_noise";
            this.tbar_noise.Size = new System.Drawing.Size(148, 52);
            this.tbar_noise.TabIndex = 19;
            this.tbar_noise.Value = 4;
            // 
            // btn_eraseW
            // 
            this.btn_eraseW.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_eraseW.FlatAppearance.BorderSize = 0;
            this.btn_eraseW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraseW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eraseW.ForeColor = System.Drawing.Color.White;
            this.btn_eraseW.Image = global::BCam.Properties.Resources.eraserW1;
            this.btn_eraseW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraseW.Location = new System.Drawing.Point(408, 0);
            this.btn_eraseW.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eraseW.Name = "btn_eraseW";
            this.btn_eraseW.Size = new System.Drawing.Size(125, 52);
            this.btn_eraseW.TabIndex = 18;
            this.btn_eraseW.Text = "      White";
            this.btn_eraseW.UseVisualStyleBackColor = false;
            this.btn_eraseW.Click += new System.EventHandler(this.btn_eraseW_Click);
            this.btn_eraseW.MouseHover += new System.EventHandler(this.btn_eraseW_MouseHover);
            // 
            // tbar_white
            // 
            this.tbar_white.AutoSize = false;
            this.tbar_white.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbar_white.Location = new System.Drawing.Point(534, 0);
            this.tbar_white.Margin = new System.Windows.Forms.Padding(2);
            this.tbar_white.Minimum = 1;
            this.tbar_white.Name = "tbar_white";
            this.tbar_white.Size = new System.Drawing.Size(148, 52);
            this.tbar_white.TabIndex = 20;
            this.tbar_white.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbar_white.Value = 5;
            // 
            // pnl_edit
            // 
            this.pnl_edit.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.pnl_edit.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.pnl_edit.Controls.Add(this.btn_save);
            this.pnl_edit.Controls.Add(this.btn_noise);
            this.pnl_edit.Controls.Add(this.tbar_noise);
            this.pnl_edit.Controls.Add(this.btn_eraseW);
            this.pnl_edit.Controls.Add(this.tbar_white);
            this.pnl_edit.Controls.Add(this.btn_blur);
            this.pnl_edit.Location = new System.Drawing.Point(0, 460);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(843, 52);
            this.pnl_edit.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::BCam.Properties.Resources.check;
            this.btn_save.Location = new System.Drawing.Point(790, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 21;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save.MouseHover += new System.EventHandler(this.btn_save_MouseHover);
            // 
            // frm_erase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnl_edit);
            this.Controls.Add(this.pic_pic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_erase";
            this.Size = new System.Drawing.Size(843, 512);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_white)).EndInit();
            this.pnl_edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pic;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btn_blur;
        private System.Windows.Forms.Button btn_noise;
        private System.Windows.Forms.TrackBar tbar_noise;
        private System.Windows.Forms.Button btn_eraseW;
        private System.Windows.Forms.TrackBar tbar_white;
        private BCam.GradientPanel pnl_edit;
        private RoundButton btn_save;
    }
}
