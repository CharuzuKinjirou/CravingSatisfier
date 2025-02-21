
namespace Craving_Satisfier
{
    partial class Cold_Coffee
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
            this.ColdCoffee = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ColdCoffee
            // 
            this.ColdCoffee.BackgroundImage = global::Craving_Satisfier.Properties.Resources.cold_cof;
            this.ColdCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColdCoffee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColdCoffee.Location = new System.Drawing.Point(0, 0);
            this.ColdCoffee.Name = "ColdCoffee";
            this.ColdCoffee.Size = new System.Drawing.Size(440, 586);
            this.ColdCoffee.TabIndex = 0;
            // 
            // Cold_Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColdCoffee);
            this.Name = "Cold_Coffee";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ColdCoffee;
    }
}
