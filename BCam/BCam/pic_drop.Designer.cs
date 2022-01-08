
namespace doan
{
    partial class pic_drop
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
            this.pic_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_pic
            // 
            this.pic_pic.Location = new System.Drawing.Point(2, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(841, 512);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pic.TabIndex = 0;
            this.pic_pic.TabStop = false;
            // 
            // pic_drop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_pic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pic_drop";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.pic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pic;
    }
}
