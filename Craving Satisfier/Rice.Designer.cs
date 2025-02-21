
namespace Craving_Satisfier
{
    partial class Rice
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
            this.RiceMenuPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RiceMenuPnl
            // 
            this.RiceMenuPnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.Rice;
            this.RiceMenuPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RiceMenuPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RiceMenuPnl.Location = new System.Drawing.Point(0, 0);
            this.RiceMenuPnl.Name = "RiceMenuPnl";
            this.RiceMenuPnl.Size = new System.Drawing.Size(440, 586);
            this.RiceMenuPnl.TabIndex = 0;
            // 
            // Rice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RiceMenuPnl);
            this.Name = "Rice";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RiceMenuPnl;
    }
}
