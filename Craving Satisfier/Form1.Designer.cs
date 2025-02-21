
namespace Craving_Satisfier
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.LoadPnl = new System.Windows.Forms.Panel();
            this.LoaderProgress = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loader = new System.Windows.Forms.Panel();
            this.LoadingTime = new System.Windows.Forms.Timer(this.components);
            this.LoadPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadPnl
            // 
            this.LoadPnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.galax;
            this.LoadPnl.Controls.Add(this.LoaderProgress);
            this.LoadPnl.Controls.Add(this.pictureBox1);
            this.LoadPnl.Location = new System.Drawing.Point(13, 27);
            this.LoadPnl.Name = "LoadPnl";
            this.LoadPnl.Size = new System.Drawing.Size(440, 610);
            this.LoadPnl.TabIndex = 0;
            // 
            // LoaderProgress
            // 
            this.LoaderProgress.BackColor = System.Drawing.Color.Transparent;
            this.LoaderProgress.Location = new System.Drawing.Point(0, 595);
            this.LoaderProgress.Name = "LoaderProgress";
            this.LoaderProgress.Size = new System.Drawing.Size(441, 15);
            this.LoaderProgress.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Craving_Satisfier.Properties.Resources.new_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loader
            // 
            this.Loader.BackColor = System.Drawing.Color.Gold;
            this.Loader.Location = new System.Drawing.Point(12, 622);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(20, 15);
            this.Loader.TabIndex = 2;
            // 
            // LoadingTime
            // 
            this.LoadingTime.Enabled = true;
            this.LoadingTime.Interval = 15;
            this.LoadingTime.Tick += new System.EventHandler(this.LoadingTime_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Craving_Satisfier.Properties.Resources.cp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 680);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.LoadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.LoadPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadPnl;
        private System.Windows.Forms.Panel LoaderProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Loader;
        private System.Windows.Forms.Timer LoadingTime;
    }
}

