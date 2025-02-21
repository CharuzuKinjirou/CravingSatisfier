
namespace Craving_Satisfier
{
    partial class Hot_Coffee
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
            this.HotCoffeePnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HotCoffeePnl
            // 
            this.HotCoffeePnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.hot_cof;
            this.HotCoffeePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HotCoffeePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotCoffeePnl.Location = new System.Drawing.Point(0, 0);
            this.HotCoffeePnl.Name = "HotCoffeePnl";
            this.HotCoffeePnl.Size = new System.Drawing.Size(440, 586);
            this.HotCoffeePnl.TabIndex = 0;
            // 
            // Hot_Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HotCoffeePnl);
            this.Name = "Hot_Coffee";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotCoffeePnl;
    }
}
