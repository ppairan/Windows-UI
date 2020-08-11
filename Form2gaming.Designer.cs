namespace WindowsUI
{
    partial class Form2gaming
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
            this.StartProjectIgnis = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartProjectIgnis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartProjectIgnis
            // 
            this.StartProjectIgnis.Image = global::WindowsUI.Properties.Resources.AppIcon;
            this.StartProjectIgnis.Location = new System.Drawing.Point(262, 55);
            this.StartProjectIgnis.Name = "StartProjectIgnis";
            this.StartProjectIgnis.Size = new System.Drawing.Size(79, 70);
            this.StartProjectIgnis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartProjectIgnis.TabIndex = 1;
            this.StartProjectIgnis.TabStop = false;
            this.StartProjectIgnis.Click += new System.EventHandler(this.StartProjectIgnis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WindowsUI.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2gaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(964, 546);
            this.Controls.Add(this.StartProjectIgnis);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(964, 585);
            this.Name = "Form2gaming";
            this.Text = "Gaming";
            ((System.ComponentModel.ISupportInitialize)(this.StartProjectIgnis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox StartProjectIgnis;
    }
}