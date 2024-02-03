
namespace Proiect_Flaviu
{
    partial class Adaugare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaugare));
            this.Denumirea = new System.Windows.Forms.Label();
            this.Gama = new System.Windows.Forms.Label();
            this.Anul = new System.Windows.Forms.Label();
            this.NumarTotal = new System.Windows.Forms.Label();
            this.Imaginea = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxAnul = new System.Windows.Forms.TextBox();
            this.textBoxNrTotal = new System.Windows.Forms.TextBox();
            this.textBoxImagine = new System.Windows.Forms.TextBox();
            this.comboBoxGama = new System.Windows.Forms.ComboBox();
            this.buttonSelectImg = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Denumirea
            // 
            this.Denumirea.AutoSize = true;
            this.Denumirea.Location = new System.Drawing.Point(60, 60);
            this.Denumirea.Name = "Denumirea";
            this.Denumirea.Size = new System.Drawing.Size(58, 13);
            this.Denumirea.TabIndex = 0;
            this.Denumirea.Text = "Denumirea";
            // 
            // Gama
            // 
            this.Gama.AutoSize = true;
            this.Gama.Location = new System.Drawing.Point(60, 94);
            this.Gama.Name = "Gama";
            this.Gama.Size = new System.Drawing.Size(35, 13);
            this.Gama.TabIndex = 1;
            this.Gama.Text = "Gama";
            // 
            // Anul
            // 
            this.Anul.AutoSize = true;
            this.Anul.Location = new System.Drawing.Point(60, 132);
            this.Anul.Name = "Anul";
            this.Anul.Size = new System.Drawing.Size(28, 13);
            this.Anul.TabIndex = 2;
            this.Anul.Text = "Anul";
            // 
            // NumarTotal
            // 
            this.NumarTotal.AutoSize = true;
            this.NumarTotal.Location = new System.Drawing.Point(60, 164);
            this.NumarTotal.Name = "NumarTotal";
            this.NumarTotal.Size = new System.Drawing.Size(61, 13);
            this.NumarTotal.TabIndex = 3;
            this.NumarTotal.Text = "Numar total";
            // 
            // Imaginea
            // 
            this.Imaginea.AutoSize = true;
            this.Imaginea.Location = new System.Drawing.Point(60, 203);
            this.Imaginea.Name = "Imaginea";
            this.Imaginea.Size = new System.Drawing.Size(50, 13);
            this.Imaginea.TabIndex = 4;
            this.Imaginea.Text = "Imaginea";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(168, 60);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(221, 20);
            this.textBoxDenumire.TabIndex = 5;
            // 
            // textBoxAnul
            // 
            this.textBoxAnul.Location = new System.Drawing.Point(168, 132);
            this.textBoxAnul.Name = "textBoxAnul";
            this.textBoxAnul.Size = new System.Drawing.Size(221, 20);
            this.textBoxAnul.TabIndex = 6;
            // 
            // textBoxNrTotal
            // 
            this.textBoxNrTotal.Location = new System.Drawing.Point(168, 164);
            this.textBoxNrTotal.Name = "textBoxNrTotal";
            this.textBoxNrTotal.Size = new System.Drawing.Size(221, 20);
            this.textBoxNrTotal.TabIndex = 7;
            // 
            // textBoxImagine
            // 
            this.textBoxImagine.Location = new System.Drawing.Point(168, 203);
            this.textBoxImagine.Name = "textBoxImagine";
            this.textBoxImagine.Size = new System.Drawing.Size(221, 20);
            this.textBoxImagine.TabIndex = 8;
            // 
            // comboBoxGama
            // 
            this.comboBoxGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGama.FormattingEnabled = true;
            this.comboBoxGama.Location = new System.Drawing.Point(168, 94);
            this.comboBoxGama.Name = "comboBoxGama";
            this.comboBoxGama.Size = new System.Drawing.Size(221, 21);
            this.comboBoxGama.TabIndex = 9;
            // 
            // buttonSelectImg
            // 
            this.buttonSelectImg.Location = new System.Drawing.Point(236, 229);
            this.buttonSelectImg.Name = "buttonSelectImg";
            this.buttonSelectImg.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectImg.TabIndex = 10;
            this.buttonSelectImg.Text = "Incarca";
            this.buttonSelectImg.UseVisualStyleBackColor = true;
            this.buttonSelectImg.Click += new System.EventHandler(this.buttonSelectImg_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(236, 360);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(86, 32);
            this.buttonRenunta.TabIndex = 11;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(339, 360);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(86, 32);
            this.buttonAdauga.TabIndex = 12;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(477, 404);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonSelectImg);
            this.Controls.Add(this.comboBoxGama);
            this.Controls.Add(this.textBoxImagine);
            this.Controls.Add(this.textBoxNrTotal);
            this.Controls.Add(this.textBoxAnul);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.Imaginea);
            this.Controls.Add(this.NumarTotal);
            this.Controls.Add(this.Anul);
            this.Controls.Add(this.Gama);
            this.Controls.Add(this.Denumirea);
            this.Name = "Adaugare";
            this.Text = "Adaugare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Denumirea;
        private System.Windows.Forms.Label Gama;
        private System.Windows.Forms.Label Anul;
        private System.Windows.Forms.Label NumarTotal;
        private System.Windows.Forms.Label Imaginea;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxAnul;
        private System.Windows.Forms.TextBox textBoxNrTotal;
        private System.Windows.Forms.TextBox textBoxImagine;
        private System.Windows.Forms.ComboBox comboBoxGama;
        private System.Windows.Forms.Button buttonSelectImg;
        private System.Windows.Forms.Button buttonRenunta;
        private System.Windows.Forms.Button buttonAdauga;
    }
}