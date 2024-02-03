
namespace Proiect_Flaviu
{
    partial class Imprumut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprumut));
            this.client = new System.Windows.Forms.Label();
            this.gama = new System.Windows.Forms.Label();
            this.masini = new System.Windows.Forms.Label();
            this.restituire = new System.Windows.Forms.Label();
            this.comboBoxClienti = new System.Windows.Forms.ComboBox();
            this.comboBoxGama = new System.Windows.Forms.ComboBox();
            this.checkedListBoxMasini = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerDataRest = new System.Windows.Forms.DateTimePicker();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.buttonInregistreaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.BackColor = System.Drawing.Color.Transparent;
            this.client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client.Location = new System.Drawing.Point(23, 29);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(41, 13);
            this.client.TabIndex = 0;
            this.client.Text = "Clientul";
            // 
            // gama
            // 
            this.gama.AutoSize = true;
            this.gama.BackColor = System.Drawing.Color.Transparent;
            this.gama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gama.Location = new System.Drawing.Point(23, 66);
            this.gama.Name = "gama";
            this.gama.Size = new System.Drawing.Size(35, 13);
            this.gama.TabIndex = 1;
            this.gama.Text = "Gama";
            // 
            // masini
            // 
            this.masini.AutoSize = true;
            this.masini.BackColor = System.Drawing.Color.Transparent;
            this.masini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masini.Location = new System.Drawing.Point(23, 107);
            this.masini.Name = "masini";
            this.masini.Size = new System.Drawing.Size(97, 13);
            this.masini.TabIndex = 2;
            this.masini.Text = "Masinile disponibile";
            // 
            // restituire
            // 
            this.restituire.AutoSize = true;
            this.restituire.BackColor = System.Drawing.Color.Transparent;
            this.restituire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restituire.Location = new System.Drawing.Point(26, 351);
            this.restituire.Name = "restituire";
            this.restituire.Size = new System.Drawing.Size(72, 13);
            this.restituire.TabIndex = 3;
            this.restituire.Text = "Data restituire";
            // 
            // comboBoxClienti
            // 
            this.comboBoxClienti.FormattingEnabled = true;
            this.comboBoxClienti.Location = new System.Drawing.Point(158, 29);
            this.comboBoxClienti.Name = "comboBoxClienti";
            this.comboBoxClienti.Size = new System.Drawing.Size(300, 21);
            this.comboBoxClienti.TabIndex = 4;
            // 
            // comboBoxGama
            // 
            this.comboBoxGama.FormattingEnabled = true;
            this.comboBoxGama.Location = new System.Drawing.Point(158, 66);
            this.comboBoxGama.Name = "comboBoxGama";
            this.comboBoxGama.Size = new System.Drawing.Size(178, 21);
            this.comboBoxGama.TabIndex = 5;
            this.comboBoxGama.SelectedIndexChanged += new System.EventHandler(this.comboBoxDomenii_SelectionChangeCommitted);
            // 
            // checkedListBoxMasini
            // 
            this.checkedListBoxMasini.CheckOnClick = true;
            this.checkedListBoxMasini.FormattingEnabled = true;
            this.checkedListBoxMasini.HorizontalScrollbar = true;
            this.checkedListBoxMasini.Location = new System.Drawing.Point(158, 107);
            this.checkedListBoxMasini.Name = "checkedListBoxMasini";
            this.checkedListBoxMasini.Size = new System.Drawing.Size(300, 229);
            this.checkedListBoxMasini.TabIndex = 6;
            // 
            // dateTimePickerDataRest
            // 
            this.dateTimePickerDataRest.Location = new System.Drawing.Point(158, 351);
            this.dateTimePickerDataRest.Name = "dateTimePickerDataRest";
            this.dateTimePickerDataRest.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerDataRest.TabIndex = 7;
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(517, 415);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(104, 23);
            this.buttonRenunta.TabIndex = 8;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // buttonInregistreaza
            // 
            this.buttonInregistreaza.Location = new System.Drawing.Point(653, 415);
            this.buttonInregistreaza.Name = "buttonInregistreaza";
            this.buttonInregistreaza.Size = new System.Drawing.Size(104, 23);
            this.buttonInregistreaza.TabIndex = 9;
            this.buttonInregistreaza.Text = "Inregistreaza";
            this.buttonInregistreaza.UseVisualStyleBackColor = true;
            this.buttonInregistreaza.Click += new System.EventHandler(this.buttonInregistreaza_Click);
            // 
            // Imprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInregistreaza);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.dateTimePickerDataRest);
            this.Controls.Add(this.checkedListBoxMasini);
            this.Controls.Add(this.comboBoxGama);
            this.Controls.Add(this.comboBoxClienti);
            this.Controls.Add(this.restituire);
            this.Controls.Add(this.masini);
            this.Controls.Add(this.gama);
            this.Controls.Add(this.client);
            this.Name = "Imprumut";
            this.Text = "Imprumut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label client;
        private System.Windows.Forms.Label gama;
        private System.Windows.Forms.Label masini;
        private System.Windows.Forms.Label restituire;
        private System.Windows.Forms.ComboBox comboBoxClienti;
        private System.Windows.Forms.ComboBox comboBoxGama;
        private System.Windows.Forms.CheckedListBox checkedListBoxMasini;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRest;
        private System.Windows.Forms.Button buttonRenunta;
        private System.Windows.Forms.Button buttonInregistreaza;
    }
}