
namespace Proiect_Flaviu
{
    partial class AdaugareClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareClient));
            this.nume = new System.Windows.Forms.Label();
            this.cnp = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.adaugaClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(45, 67);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(89, 13);
            this.nume.TabIndex = 0;
            this.nume.Text = "Nume si prenume";
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Location = new System.Drawing.Point(45, 101);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(29, 13);
            this.cnp.TabIndex = 1;
            this.cnp.Text = "CNP";
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(160, 67);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(185, 20);
            this.textNume.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Location = new System.Drawing.Point(45, 137);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(40, 13);
            this.adresa.TabIndex = 4;
            this.adresa.Text = "Adresa";
            this.adresa.Click += new System.EventHandler(this.adresa_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 5;
            // 
            // adaugaClient
            // 
            this.adaugaClient.Location = new System.Drawing.Point(212, 176);
            this.adaugaClient.Name = "adaugaClient";
            this.adaugaClient.Size = new System.Drawing.Size(75, 23);
            this.adaugaClient.TabIndex = 6;
            this.adaugaClient.Text = "Adauga";
            this.adaugaClient.UseVisualStyleBackColor = true;
            this.adaugaClient.Click += new System.EventHandler(this.adaugaClient_Click);
            // 
            // AdaugareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(428, 225);
            this.Controls.Add(this.adaugaClient);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.nume);
            this.Name = "AdaugareClient";
            this.Text = "AdaugareClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label adresa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button adaugaClient;
    }
}