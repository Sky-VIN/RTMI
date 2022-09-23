namespace RTMI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closePic = new System.Windows.Forms.PictureBox();
            this.enableChk = new System.Windows.Forms.CheckBox();
            this.info = new System.Windows.Forms.Label();
            this.examplePic = new System.Windows.Forms.PictureBox();
            this.waterMark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePic)).BeginInit();
            this.SuspendLayout();
            // 
            // closePic
            // 
            this.closePic.BackColor = System.Drawing.Color.Transparent;
            this.closePic.BackgroundImage = global::RTMI.Properties.Resources.close;
            this.closePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closePic.Location = new System.Drawing.Point(254, 6);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(18, 18);
            this.closePic.TabIndex = 24;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            this.closePic.MouseLeave += new System.EventHandler(this.closePic_MouseLeave);
            this.closePic.MouseHover += new System.EventHandler(this.closePic_MouseHover);
            // 
            // enableChk
            // 
            this.enableChk.AutoSize = true;
            this.enableChk.BackColor = System.Drawing.Color.Transparent;
            this.enableChk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableChk.Location = new System.Drawing.Point(12, 12);
            this.enableChk.Name = "enableChk";
            this.enableChk.Size = new System.Drawing.Size(155, 18);
            this.enableChk.TabIndex = 23;
            this.enableChk.Text = "Enable Refresh types";
            this.enableChk.UseVisualStyleBackColor = false;
            this.enableChk.CheckedChanged += new System.EventHandler(this.enableChk_CheckedChanged);
            this.enableChk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Info;
            this.info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(12, 33);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(256, 50);
            this.info.TabIndex = 22;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // examplePic
            // 
            this.examplePic.BackColor = System.Drawing.Color.Transparent;
            this.examplePic.BackgroundImage = global::RTMI.Properties.Resources.example_off;
            this.examplePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.examplePic.Enabled = false;
            this.examplePic.Location = new System.Drawing.Point(12, 86);
            this.examplePic.Name = "examplePic";
            this.examplePic.Size = new System.Drawing.Size(256, 151);
            this.examplePic.TabIndex = 21;
            this.examplePic.TabStop = false;
            // 
            // waterMark
            // 
            this.waterMark.AutoSize = true;
            this.waterMark.BackColor = System.Drawing.Color.Transparent;
            this.waterMark.Enabled = false;
            this.waterMark.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterMark.Location = new System.Drawing.Point(165, 240);
            this.waterMark.Name = "waterMark";
            this.waterMark.Size = new System.Drawing.Size(105, 13);
            this.waterMark.TabIndex = 25;
            this.waterMark.Text = "Daniel Swan © 2022";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::RTMI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.waterMark);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.enableChk);
            this.Controls.Add(this.info);
            this.Controls.Add(this.examplePic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN: Refresh Types Menu Item";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.CheckBox enableChk;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox examplePic;
        private System.Windows.Forms.Label waterMark;







    }
}

