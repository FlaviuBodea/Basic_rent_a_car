
namespace Proiect_Flaviu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaGamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareMasiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutaMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restituireMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adaugareClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masiniToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaGamaToolStripMenuItem,
            this.adaugaMasinaToolStripMenuItem});
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.masiniToolStripMenuItem.Text = "Masini";
            // 
            // adaugaGamaToolStripMenuItem
            // 
            this.adaugaGamaToolStripMenuItem.Name = "adaugaGamaToolStripMenuItem";
            this.adaugaGamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaGamaToolStripMenuItem.Text = "Adauga gama";
            this.adaugaGamaToolStripMenuItem.Click += new System.EventHandler(this.adaugaGamaToolStripMenuItem_Click);
            // 
            // adaugaMasinaToolStripMenuItem
            // 
            this.adaugaMasinaToolStripMenuItem.Name = "adaugaMasinaToolStripMenuItem";
            this.adaugaMasinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaMasinaToolStripMenuItem.Text = "Adauga masina";
            this.adaugaMasinaToolStripMenuItem.Click += new System.EventHandler(this.adaugaMasinaToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareMasiniToolStripMenuItem,
            this.imprumutaMasinaToolStripMenuItem,
            this.restituireMasinaToolStripMenuItem,
            this.adaugareClientToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // afisareMasiniToolStripMenuItem
            // 
            this.afisareMasiniToolStripMenuItem.Name = "afisareMasiniToolStripMenuItem";
            this.afisareMasiniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afisareMasiniToolStripMenuItem.Text = "Afisare masini";
            this.afisareMasiniToolStripMenuItem.Click += new System.EventHandler(this.afisareMasiniToolStripMenuItem_Click);
            // 
            // imprumutaMasinaToolStripMenuItem
            // 
            this.imprumutaMasinaToolStripMenuItem.Name = "imprumutaMasinaToolStripMenuItem";
            this.imprumutaMasinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprumutaMasinaToolStripMenuItem.Text = "Imprumuta masina";
            this.imprumutaMasinaToolStripMenuItem.Click += new System.EventHandler(this.imprumutaMasinaToolStripMenuItem_Click);
            // 
            // restituireMasinaToolStripMenuItem
            // 
            this.restituireMasinaToolStripMenuItem.Name = "restituireMasinaToolStripMenuItem";
            this.restituireMasinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restituireMasinaToolStripMenuItem.Text = "Restituire masina";
            this.restituireMasinaToolStripMenuItem.Click += new System.EventHandler(this.restituireMasinaToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(47, 65);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(47, 94);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(37, 13);
            this.Parola.TabIndex = 2;
            this.Parola.Text = "Parola";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(106, 65);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(190, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(106, 94);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(190, 20);
            this.textBoxParola.TabIndex = 4;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acces aplicatie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adaugareClientToolStripMenuItem
            // 
            this.adaugareClientToolStripMenuItem.Name = "adaugareClientToolStripMenuItem";
            this.adaugareClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugareClientToolStripMenuItem.Text = "Adaugare client";
            this.adaugareClientToolStripMenuItem.Click += new System.EventHandler(this.adaugareClientToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(439, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.User);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inchirieri masini";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaGamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareMasiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumutaMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restituireMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem adaugareClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
    }
}