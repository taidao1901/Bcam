
namespace doan
{
    partial class frm_BrCo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_pic = new System.Windows.Forms.PictureBox();
            this.lab_Co = new System.Windows.Forms.Label();
            this.track_Co = new System.Windows.Forms.TrackBar();
            this.lab_Br = new System.Windows.Forms.Label();
            this.track_Br = new System.Windows.Forms.TrackBar();
            this.grBox_Br = new System.Windows.Forms.GroupBox();
            this.roundpic = new doan.RoundButton();
            this.grBox_Co = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new doan.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Co)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Br)).BeginInit();
            this.grBox_Br.SuspendLayout();
            this.grBox_Co.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pic_pic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 440);
            this.panel2.TabIndex = 7;
            // 
            // pic_pic
            // 
            this.pic_pic.BackColor = System.Drawing.Color.White;
            this.pic_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_pic.Location = new System.Drawing.Point(0, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(746, 440);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pic.TabIndex = 0;
            this.pic_pic.TabStop = false;
            // 
            // lab_Co
            // 
            this.lab_Co.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_Co.AutoSize = true;
            this.lab_Co.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lab_Co.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Co.ForeColor = System.Drawing.Color.White;
            this.lab_Co.Location = new System.Drawing.Point(334, 51);
            this.lab_Co.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Co.Name = "lab_Co";
            this.lab_Co.Size = new System.Drawing.Size(26, 19);
            this.lab_Co.TabIndex = 4;
            this.lab_Co.Text = "Co";
            // 
            // track_Co
            // 
            this.track_Co.AutoSize = false;
            this.track_Co.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.track_Co.Location = new System.Drawing.Point(71, 19);
            this.track_Co.Margin = new System.Windows.Forms.Padding(2);
            this.track_Co.Maximum = 500;
            this.track_Co.Name = "track_Co";
            this.track_Co.Size = new System.Drawing.Size(540, 32);
            this.track_Co.TabIndex = 3;
            this.track_Co.Value = 100;
            this.track_Co.Scroll += new System.EventHandler(this.track_Co_Scroll);
            // 
            // lab_Br
            // 
            this.lab_Br.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lab_Br.AutoSize = true;
            this.lab_Br.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lab_Br.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Br.ForeColor = System.Drawing.Color.White;
            this.lab_Br.Location = new System.Drawing.Point(43, 187);
            this.lab_Br.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Br.Name = "lab_Br";
            this.lab_Br.Size = new System.Drawing.Size(22, 19);
            this.lab_Br.TabIndex = 6;
            this.lab_Br.Text = "Br";
            // 
            // track_Br
            // 
            this.track_Br.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.track_Br.AutoSize = false;
            this.track_Br.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.track_Br.Location = new System.Drawing.Point(4, 19);
            this.track_Br.Margin = new System.Windows.Forms.Padding(2);
            this.track_Br.Maximum = 100;
            this.track_Br.Name = "track_Br";
            this.track_Br.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_Br.Size = new System.Drawing.Size(35, 385);
            this.track_Br.TabIndex = 5;
            this.track_Br.Scroll += new System.EventHandler(this.track_Br_Scroll);
            // 
            // grBox_Br
            // 
            this.grBox_Br.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.grBox_Br.Controls.Add(this.roundpic);
            this.grBox_Br.Controls.Add(this.lab_Br);
            this.grBox_Br.Controls.Add(this.track_Br);
            this.grBox_Br.Dock = System.Windows.Forms.DockStyle.Right;
            this.grBox_Br.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_Br.ForeColor = System.Drawing.Color.White;
            this.grBox_Br.Location = new System.Drawing.Point(746, 0);
            this.grBox_Br.Margin = new System.Windows.Forms.Padding(2);
            this.grBox_Br.Name = "grBox_Br";
            this.grBox_Br.Padding = new System.Windows.Forms.Padding(2);
            this.grBox_Br.Size = new System.Drawing.Size(97, 440);
            this.grBox_Br.TabIndex = 6;
            this.grBox_Br.TabStop = false;
            this.grBox_Br.Text = "Brightness";
            this.grBox_Br.MouseHover += new System.EventHandler(this.grBox_Br_MouseHover);
            // 
            // roundpic
            // 
            this.roundpic.BackColor = System.Drawing.Color.White;
            this.roundpic.FlatAppearance.BorderSize = 0;
            this.roundpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundpic.Image = global::BCam.Properties.Resources.monitor_levels;
            this.roundpic.Location = new System.Drawing.Point(6, 410);
            this.roundpic.Name = "roundpic";
            this.roundpic.Size = new System.Drawing.Size(24, 24);
            this.roundpic.TabIndex = 7;
            this.roundpic.UseMnemonic = false;
            this.roundpic.UseVisualStyleBackColor = false;
            // 
            // grBox_Co
            // 
            this.grBox_Co.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.grBox_Co.Controls.Add(this.pictureBox1);
            this.grBox_Co.Controls.Add(this.btn_save);
            this.grBox_Co.Controls.Add(this.lab_Co);
            this.grBox_Co.Controls.Add(this.track_Co);
            this.grBox_Co.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grBox_Co.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_Co.ForeColor = System.Drawing.Color.White;
            this.grBox_Co.Location = new System.Drawing.Point(0, 440);
            this.grBox_Co.Margin = new System.Windows.Forms.Padding(2);
            this.grBox_Co.Name = "grBox_Co";
            this.grBox_Co.Padding = new System.Windows.Forms.Padding(2);
            this.grBox_Co.Size = new System.Drawing.Size(843, 72);
            this.grBox_Co.TabIndex = 5;
            this.grBox_Co.TabStop = false;
            this.grBox_Co.Text = "Contrast";
            this.grBox_Co.MouseHover += new System.EventHandler(this.grBox_Co_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::BCam.Properties.Resources.contrast__2_;
            this.pictureBox1.Location = new System.Drawing.Point(33, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::BCam.Properties.Resources.check;
            this.btn_save.Location = new System.Drawing.Point(788, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 14;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save.MouseHover += new System.EventHandler(this.btn_save_MouseHover);
            // 
            // frm_BrCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grBox_Br);
            this.Controls.Add(this.grBox_Co);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_BrCo";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.BrCo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Co)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Br)).EndInit();
            this.grBox_Br.ResumeLayout(false);
            this.grBox_Br.PerformLayout();
            this.grBox_Co.ResumeLayout(false);
            this.grBox_Co.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_pic;
        private System.Windows.Forms.Label lab_Br;
        private System.Windows.Forms.TrackBar track_Br;
        private System.Windows.Forms.Label lab_Co;
        private System.Windows.Forms.TrackBar track_Co;
        private System.Windows.Forms.GroupBox grBox_Br;
        private System.Windows.Forms.GroupBox grBox_Co;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton btn_save;
        private RoundButton roundpic;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
