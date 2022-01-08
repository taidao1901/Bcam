
namespace doan
{
    partial class frm_filter
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
            this.btn_binarize = new System.Windows.Forms.Button();
            this.btn_old = new System.Windows.Forms.Button();
            this.btn_canny = new System.Windows.Forms.Button();
            this.pic_pic = new System.Windows.Forms.PictureBox();
            this.btn_save = new doan.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_edit = new BCam.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).BeginInit();
            this.pnl_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_binarize
            // 
            this.btn_binarize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_binarize.FlatAppearance.BorderSize = 0;
            this.btn_binarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_binarize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_binarize.ForeColor = System.Drawing.Color.White;
            this.btn_binarize.Location = new System.Drawing.Point(499, 0);
            this.btn_binarize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_binarize.Name = "btn_binarize";
            this.btn_binarize.Size = new System.Drawing.Size(125, 52);
            this.btn_binarize.TabIndex = 16;
            this.btn_binarize.Text = "Binarize";
            this.btn_binarize.UseVisualStyleBackColor = false;
            this.btn_binarize.Click += new System.EventHandler(this.btn_binarize_Click);
            // 
            // btn_old
            // 
            this.btn_old.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_old.FlatAppearance.BorderSize = 0;
            this.btn_old.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_old.ForeColor = System.Drawing.Color.White;
            this.btn_old.Location = new System.Drawing.Point(370, 0);
            this.btn_old.Margin = new System.Windows.Forms.Padding(2);
            this.btn_old.Name = "btn_old";
            this.btn_old.Size = new System.Drawing.Size(125, 52);
            this.btn_old.TabIndex = 15;
            this.btn_old.Text = "Old";
            this.btn_old.UseVisualStyleBackColor = false;
            this.btn_old.Click += new System.EventHandler(this.btn_old_Click);
            // 
            // btn_canny
            // 
            this.btn_canny.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_canny.FlatAppearance.BorderSize = 0;
            this.btn_canny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canny.ForeColor = System.Drawing.Color.White;
            this.btn_canny.Location = new System.Drawing.Point(241, 0);
            this.btn_canny.Margin = new System.Windows.Forms.Padding(2);
            this.btn_canny.Name = "btn_canny";
            this.btn_canny.Size = new System.Drawing.Size(125, 52);
            this.btn_canny.TabIndex = 14;
            this.btn_canny.Text = "Canny";
            this.btn_canny.UseVisualStyleBackColor = false;
            this.btn_canny.Click += new System.EventHandler(this.btn_canny_Click);
            // 
            // pic_pic
            // 
            this.pic_pic.BackColor = System.Drawing.Color.White;
            this.pic_pic.Location = new System.Drawing.Point(0, 0);
            this.pic_pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic_pic.Name = "pic_pic";
            this.pic_pic.Size = new System.Drawing.Size(843, 460);
            this.pic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_pic.TabIndex = 17;
            this.pic_pic.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::BCam.Properties.Resources.check;
            this.btn_save.Location = new System.Drawing.Point(793, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 18;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.ClientSizeChanged += new System.EventHandler(this.btn_save_ClientSizeChanged);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseHover += new System.EventHandler(this.btn_save_MouseHover);
            // 
            // pnl_edit
            // 
            this.pnl_edit.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.pnl_edit.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.pnl_edit.Controls.Add(this.btn_canny);
            this.pnl_edit.Controls.Add(this.btn_binarize);
            this.pnl_edit.Controls.Add(this.btn_old);
            this.pnl_edit.Controls.Add(this.btn_save);
            this.pnl_edit.Location = new System.Drawing.Point(0, 460);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(843, 52);
            this.pnl_edit.TabIndex = 19;
            // 
            // frm_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_edit);
            this.Controls.Add(this.pic_pic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_filter";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.frm_Filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pic)).EndInit();
            this.pnl_edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_binarize;
        private System.Windows.Forms.Button btn_old;
        private System.Windows.Forms.Button btn_canny;
        private System.Windows.Forms.PictureBox pic_pic;
        private RoundButton btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private BCam.GradientPanel pnl_edit;
    }
}
