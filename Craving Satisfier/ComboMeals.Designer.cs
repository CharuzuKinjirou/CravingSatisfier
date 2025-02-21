
namespace Craving_Satisfier
{
    partial class ComboMeals
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
            this.ComboMealPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ComboMealPnl
            // 
            this.ComboMealPnl.BackgroundImage = global::Craving_Satisfier.Properties.Resources.Combo_Meals;
            this.ComboMealPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComboMealPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboMealPnl.Location = new System.Drawing.Point(0, 0);
            this.ComboMealPnl.Name = "ComboMealPnl";
            this.ComboMealPnl.Size = new System.Drawing.Size(440, 586);
            this.ComboMealPnl.TabIndex = 0;
            // 
            // ComboMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboMealPnl);
            this.Name = "ComboMeals";
            this.Size = new System.Drawing.Size(440, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ComboMealPnl;
    }
}
