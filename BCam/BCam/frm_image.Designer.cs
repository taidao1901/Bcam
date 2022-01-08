
namespace doan
{
    partial class frm_image
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
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gradientPanel1 = new BCam.GradientPanel();
            this.pnl_zoom = new System.Windows.Forms.Panel();
            this.lab_zoom = new System.Windows.Forms.Label();
            this.tbar_zoom = new System.Windows.Forms.TrackBar();
            this.btn_huy = new doan.RoundButton();
            this.btn_cmr = new doan.RoundButton();
            this.pnl_edit = new BCam.GradientPanel();
            this.btn_img = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_doodle = new System.Windows.Forms.Button();
            this.btn_BrCo = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.pnl_zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_zoom)).BeginInit();
            this.pnl_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.AutoScroll = true;
            this.pnl_main.BackColor = System.Drawing.Color.Silver;
            this.pnl_main.Controls.Add(this.pic_image);
            this.pnl_main.Location = new System.Drawing.Point(0, 24);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(843, 512);
            this.pnl_main.TabIndex = 25;
            // 
            // pic_image
            // 
            this.pic_image.BackColor = System.Drawing.Color.Silver;
            this.pic_image.Image = global::BCam.Properties.Resources.tao_dang;
            this.pic_image.Location = new System.Drawing.Point(0, 3);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(843, 512);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_image.TabIndex = 1;
            this.pic_image.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.appToolStripMenuItem.Text = "App";
            this.appToolStripMenuItem.Click += new System.EventHandler(this.appToolStripMenuItem_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.gradientPanel1.Controls.Add(this.pnl_zoom);
            this.gradientPanel1.Controls.Add(this.btn_huy);
            this.gradientPanel1.Controls.Add(this.btn_cmr);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 536);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(979, 100);
            this.gradientPanel1.TabIndex = 29;
            // 
            // pnl_zoom
            // 
            this.pnl_zoom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_zoom.Controls.Add(this.lab_zoom);
            this.pnl_zoom.Controls.Add(this.tbar_zoom);
            this.pnl_zoom.Location = new System.Drawing.Point(349, 19);
            this.pnl_zoom.Name = "pnl_zoom";
            this.pnl_zoom.Size = new System.Drawing.Size(303, 77);
            this.pnl_zoom.TabIndex = 35;
            // 
            // lab_zoom
            // 
            this.lab_zoom.AutoSize = true;
            this.lab_zoom.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_zoom.ForeColor = System.Drawing.Color.White;
            this.lab_zoom.Location = new System.Drawing.Point(135, 49);
            this.lab_zoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zoom.Name = "lab_zoom";
            this.lab_zoom.Size = new System.Drawing.Size(30, 25);
            this.lab_zoom.TabIndex = 32;
            this.lab_zoom.Text = "1x";
            // 
            // tbar_zoom
            // 
            this.tbar_zoom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbar_zoom.Location = new System.Drawing.Point(2, 2);
            this.tbar_zoom.Margin = new System.Windows.Forms.Padding(2);
            this.tbar_zoom.Minimum = 1;
            this.tbar_zoom.Name = "tbar_zoom";
            this.tbar_zoom.Size = new System.Drawing.Size(299, 45);
            this.tbar_zoom.TabIndex = 31;
            this.tbar_zoom.Value = 1;
            this.tbar_zoom.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_huy.FlatAppearance.BorderSize = 0;
            this.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huy.Image = global::BCam.Properties.Resources._return;
            this.btn_huy.Location = new System.Drawing.Point(783, 19);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(50, 50);
            this.btn_huy.TabIndex = 33;
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            this.btn_huy.MouseLeave += new System.EventHandler(this.btn_huy_MouseLeave);
            this.btn_huy.MouseHover += new System.EventHandler(this.btn_huy_MouseHover);
            // 
            // btn_cmr
            // 
            this.btn_cmr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cmr.FlatAppearance.BorderSize = 0;
            this.btn_cmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cmr.Image = global::BCam.Properties.Resources.backcmrhover50;
            this.btn_cmr.Location = new System.Drawing.Point(146, 19);
            this.btn_cmr.Name = "btn_cmr";
            this.btn_cmr.Size = new System.Drawing.Size(50, 50);
            this.btn_cmr.TabIndex = 34;
            this.btn_cmr.UseVisualStyleBackColor = false;
            this.btn_cmr.Click += new System.EventHandler(this.btn_cmr_Click);
            this.btn_cmr.MouseLeave += new System.EventHandler(this.btn_cmr_MouseLeave);
            this.btn_cmr.MouseHover += new System.EventHandler(this.btn_cmr_MouseHover);
            // 
            // pnl_edit
            // 
            this.pnl_edit.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.pnl_edit.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.pnl_edit.Controls.Add(this.btn_img);
            this.pnl_edit.Controls.Add(this.btn_rotate);
            this.pnl_edit.Controls.Add(this.btn_filter);
            this.pnl_edit.Controls.Add(this.btn_doodle);
            this.pnl_edit.Controls.Add(this.btn_BrCo);
            this.pnl_edit.Controls.Add(this.btn_erase);
            this.pnl_edit.Controls.Add(this.btn_drop);
            this.pnl_edit.Location = new System.Drawing.Point(843, 24);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(136, 512);
            this.pnl_edit.TabIndex = 30;
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Image = global::BCam.Properties.Resources.add;
            this.btn_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_img.Location = new System.Drawing.Point(1, 443);
            this.btn_img.Margin = new System.Windows.Forms.Padding(2);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(135, 59);
            this.btn_img.TabIndex = 13;
            this.btn_img.Text = "Add";
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            this.btn_img.MouseHover += new System.EventHandler(this.btn_img_MouseHover);
            // 
            // btn_rotate
            // 
            this.btn_rotate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_rotate.FlatAppearance.BorderSize = 0;
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotate.ForeColor = System.Drawing.Color.White;
            this.btn_rotate.Image = global::BCam.Properties.Resources.rotation2;
            this.btn_rotate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rotate.Location = new System.Drawing.Point(1, 367);
            this.btn_rotate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(135, 59);
            this.btn_rotate.TabIndex = 12;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = false;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            this.btn_rotate.MouseHover += new System.EventHandler(this.btn_rotate_MouseHover);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.Image = global::BCam.Properties.Resources.filter;
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.Location = new System.Drawing.Point(1, 223);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(137, 59);
            this.btn_filter.TabIndex = 10;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            this.btn_filter.MouseHover += new System.EventHandler(this.btn_filter_MouseHover);
            // 
            // btn_doodle
            // 
            this.btn_doodle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_doodle.FlatAppearance.BorderSize = 0;
            this.btn_doodle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doodle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doodle.ForeColor = System.Drawing.Color.White;
            this.btn_doodle.Image = global::BCam.Properties.Resources.pen;
            this.btn_doodle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doodle.Location = new System.Drawing.Point(1, 152);
            this.btn_doodle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doodle.Name = "btn_doodle";
            this.btn_doodle.Size = new System.Drawing.Size(135, 59);
            this.btn_doodle.TabIndex = 9;
            this.btn_doodle.Text = "Doodle";
            this.btn_doodle.UseVisualStyleBackColor = false;
            this.btn_doodle.Click += new System.EventHandler(this.btn_doodle_Click);
            this.btn_doodle.MouseHover += new System.EventHandler(this.btn_doodle_MouseHover);
            // 
            // btn_BrCo
            // 
            this.btn_BrCo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_BrCo.FlatAppearance.BorderSize = 0;
            this.btn_BrCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrCo.ForeColor = System.Drawing.Color.White;
            this.btn_BrCo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BrCo.Location = new System.Drawing.Point(1, 293);
            this.btn_BrCo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BrCo.Name = "btn_BrCo";
            this.btn_BrCo.Size = new System.Drawing.Size(135, 59);
            this.btn_BrCo.TabIndex = 11;
            this.btn_BrCo.Text = "Brightness Contrast";
            this.btn_BrCo.UseVisualStyleBackColor = false;
            this.btn_BrCo.Click += new System.EventHandler(this.btn_BrCo_Click);
            this.btn_BrCo.MouseHover += new System.EventHandler(this.btn_BrCo_MouseHover);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_erase.FlatAppearance.BorderSize = 0;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_erase.ForeColor = System.Drawing.Color.White;
            this.btn_erase.Image = global::BCam.Properties.Resources.eraser;
            this.btn_erase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_erase.Location = new System.Drawing.Point(1, 82);
            this.btn_erase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(137, 59);
            this.btn_erase.TabIndex = 8;
            this.btn_erase.Text = "Eraser";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            this.btn_erase.MouseHover += new System.EventHandler(this.btn_erase_MouseHover);
            // 
            // btn_drop
            // 
            this.btn_drop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_drop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_drop.FlatAppearance.BorderSize = 0;
            this.btn_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drop.ForeColor = System.Drawing.Color.White;
            this.btn_drop.Image = global::BCam.Properties.Resources.crop1;
            this.btn_drop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_drop.Location = new System.Drawing.Point(-1, 11);
            this.btn_drop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(137, 59);
            this.btn_drop.TabIndex = 7;
            this.btn_drop.Text = "Crop";
            this.btn_drop.UseVisualStyleBackColor = false;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            this.btn_drop.MouseHover += new System.EventHandler(this.btn_drop_MouseHover);
            // 
            // frm_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnl_edit);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_image";
            this.Size = new System.Drawing.Size(979, 635);
            this.Load += new System.EventHandler(this.frm_image_Load);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.pnl_zoom.ResumeLayout(false);
            this.pnl_zoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_zoom)).EndInit();
            this.pnl_edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_image;
        private BCam.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel pnl_zoom;
        private System.Windows.Forms.Label lab_zoom;
        private System.Windows.Forms.TrackBar tbar_zoom;
        private RoundButton btn_huy;
        private RoundButton btn_cmr;
        private BCam.GradientPanel pnl_edit;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_doodle;
        private System.Windows.Forms.Button btn_BrCo;
        private System.Windows.Forms.Button btn_erase;
        public System.Windows.Forms.Button btn_drop;
    }
}
