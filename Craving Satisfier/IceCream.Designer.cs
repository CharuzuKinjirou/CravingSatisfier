
namespace Craving_Satisfier
{
    partial class IceCream
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
            this.IceCreamPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IceCreamPnl
            // 
            this.IceCreamPnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.Ice_creams;
            this.IceCreamPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IceCreamPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IceCreamPnl.Location = new System.Drawing.Point(0, 0);
            this.IceCreamPnl.Name = "IceCreamPnl";
            this.IceCreamPnl.Size = new System.Drawing.Size(440, 586);
            this.IceCreamPnl.TabIndex = 0;
            // 
            // IceCream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IceCreamPnl);
            this.Name = "IceCream";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel IceCreamPnl;
    }
}
