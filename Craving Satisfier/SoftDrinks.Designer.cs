
namespace Craving_Satisfier
{
    partial class SoftDrinks
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
            this.SoftDrinksPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SoftDrinksPanel
            // 
            this.SoftDrinksPanel.BackgroundImage = global::Craving_Satisfier.Properties.Resources.soft_drinks1;
            this.SoftDrinksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoftDrinksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoftDrinksPanel.Location = new System.Drawing.Point(0, 0);
            this.SoftDrinksPanel.Name = "SoftDrinksPanel";
            this.SoftDrinksPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SoftDrinksPanel.Size = new System.Drawing.Size(440, 586);
            this.SoftDrinksPanel.TabIndex = 0;
            // 
            // SoftDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SoftDrinksPanel);
            this.Name = "SoftDrinks";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SoftDrinksPanel;
    }
}
