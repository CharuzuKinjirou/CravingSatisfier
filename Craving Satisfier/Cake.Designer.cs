
namespace Craving_Satisfier
{
    partial class Cake
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
            this.CakePnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CakePnl
            // 
            this.CakePnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.cakes;
            this.CakePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CakePnl.Location = new System.Drawing.Point(0, 0);
            this.CakePnl.Name = "CakePnl";
            this.CakePnl.Size = new System.Drawing.Size(440, 586);
            this.CakePnl.TabIndex = 0;
            // 
            // Cake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CakePnl);
            this.Name = "Cake";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CakePnl;
    }
}
