
namespace Proiect_Flaviu
{
    partial class Confirmare
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
            this.labelConfirmare = new System.Windows.Forms.Label();
            this.DA = new System.Windows.Forms.Button();
            this.NU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirmare
            // 
            this.labelConfirmare.AutoSize = true;
            this.labelConfirmare.Location = new System.Drawing.Point(85, 43);
            this.labelConfirmare.Name = "labelConfirmare";
            this.labelConfirmare.Size = new System.Drawing.Size(173, 13);
            this.labelConfirmare.TabIndex = 0;
            this.labelConfirmare.Text = "Sunteti sigur ca doriti sa confirmati?";
            // 
            // DA
            // 
            this.DA.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.DA.Location = new System.Drawing.Point(196, 83);
            this.DA.Name = "DA";
            this.DA.Size = new System.Drawing.Size(75, 23);
            this.DA.TabIndex = 1;
            this.DA.Text = "DA";
            this.DA.UseVisualStyleBackColor = true;
            // 
            // NU
            // 
            this.NU.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NU.Location = new System.Drawing.Point(60, 83);
            this.NU.Name = "NU";
            this.NU.Size = new System.Drawing.Size(75, 23);
            this.NU.TabIndex = 2;
            this.NU.Text = "NU";
            this.NU.UseVisualStyleBackColor = true;
            // 
            // Confirmare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 193);
            this.Controls.Add(this.NU);
            this.Controls.Add(this.DA);
            this.Controls.Add(this.labelConfirmare);
            this.Name = "Confirmare";
            this.Text = "Confirmare";
            this.Load += new System.EventHandler(this.Confirmare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfirmare;
        private System.Windows.Forms.Button DA;
        private System.Windows.Forms.Button NU;
    }
}