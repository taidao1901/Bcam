
namespace doan
{
    partial class pic_doodle
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
            this.numUD_width = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_width = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new doan.RoundButton();
            this.btn_pencolor = new System.Windows.Forms.Button();
            this.pic_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_width)).BeginInit();
            this.pnl_width.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // numUD_width
            // 
            this.numUD_width.Location = new System.Drawing.Point(68, 18);
            this.numUD_width.Margin = new System.Windows.Forms.Padding(2);
            this.numUD_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_width.Name = "numUD_width";
            this.numUD_width.ReadOnly = true;
            this.numUD_width.Size = new System.Drawing.Size(81, 20);
            this.numUD_width.TabIndex = 2;
            this.numUD_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUD_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnl_width
            // 
            this.pnl_width.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_width.Controls.Add(this.pictureBox1);
            this.pnl_width.Controls.Add(this.numUD_width);
            this.pnl_width.Location = new System.Drawing.Point(0, 460);
            this.pnl_width.Name = "pnl_width";
            this.pnl_width.Size = new System.Drawing.Size(161, 52);
            this.pnl_width.TabIndex = 14;
            this.pnl_width.MouseHover += new System.EventHandler(this.pnl_width_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BCam.Properties.Resources.circumflex_accent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::BCam.Properties.Resources.check;
            this.btn_save.Location = new System.Drawing.Point(790, 461);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 13;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save.MouseHover += new System.EventHandler(this.btn_save_MouseHover);
            // 
            // btn_pencolor
            // 
            this.btn_pencolor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pencolor.FlatAppearance.BorderSize = 0;
            this.btn_pencolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pencolor.Image = global::BCam.Properties.Resources.wheel;
            this.btn_pencolor.Location = new System.Drawing.Point(167, 460);
            this.btn_pencolor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pencolor.Name = "btn_pencolor";
            this.btn_pencolor.Size = new System.Drawing.Size(54, 54);
            this.btn_pencolor.TabIndex = 4;
            this.btn_pencolor.UseVisualStyleBackColor = false;
            this.btn_pencolor.Click += new System.EventHandler(this.btn_pencolor_Click);
            this.btn_pencolor.MouseHover += new System.EventHandler(this.btn_pencolor_MouseHover);
            // 
            // pic_pic
            // 
            this.pic_pic.Location = new System.Drawing.Point(0, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(843, 460);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pic.TabIndex = 1;
            this.pic_pic.TabStop = false;
            this.pic_pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseDown);
            this.pic_pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseMove);
            this.pic_pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_pic_MouseUp);
            // 
            // pic_doodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnl_width);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_pencolor);
            this.Controls.Add(this.pic_pic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pic_doodle";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.pic_doodle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_width)).EndInit();
            this.pnl_width.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pic;
        private System.Windows.Forms.NumericUpDown numUD_width;
        private System.Windows.Forms.Button btn_pencolor;
        private RoundButton btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnl_width;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
