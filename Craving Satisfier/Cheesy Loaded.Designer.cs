﻿
namespace Craving_Satisfier
{
    partial class Cheesy_Loaded
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
            this.CheesyPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CheesyPnl
            // 
            this.CheesyPnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.cheesy;
            this.CheesyPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheesyPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheesyPnl.Location = new System.Drawing.Point(0, 0);
            this.CheesyPnl.Name = "CheesyPnl";
            this.CheesyPnl.Size = new System.Drawing.Size(440, 586);
            this.CheesyPnl.TabIndex = 0;
            // 
            // Cheesy_Loaded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheesyPnl);
            this.Name = "Cheesy_Loaded";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CheesyPnl;
    }
}
