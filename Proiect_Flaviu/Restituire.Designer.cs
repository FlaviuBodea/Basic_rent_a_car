
namespace Proiect_Flaviu
{
    partial class Restituire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restituire));
            this.restituireClient = new System.Windows.Forms.Label();
            this.restituireRest = new System.Windows.Forms.Label();
            this.comboBoxClienti = new System.Windows.Forms.ComboBox();
            this.checkedListBoxMasini = new System.Windows.Forms.CheckedListBox();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.buttonInregistreaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restituireClient
            // 
            this.restituireClient.AutoSize = true;
            this.restituireClient.Location = new System.Drawing.Point(34, 44);
            this.restituireClient.Name = "restituireClient";
            this.restituireClient.Size = new System.Drawing.Size(33, 13);
            this.restituireClient.TabIndex = 0;
            this.restituireClient.Text = "Client";
            // 
            // restituireRest
            // 
            this.restituireRest.AutoSize = true;
            this.restituireRest.Location = new System.Drawing.Point(34, 87);
            this.restituireRest.Name = "restituireRest";
            this.restituireRest.Size = new System.Drawing.Size(51, 13);
            this.restituireRest.TabIndex = 1;
            this.restituireRest.Text = "Restituire";
            // 
            // comboBoxClienti
            // 
            this.comboBoxClienti.FormattingEnabled = true;
            this.comboBoxClienti.Location = new System.Drawing.Point(117, 44);
            this.comboBoxClienti.Name = "comboBoxClienti";
            this.comboBoxClienti.Size = new System.Drawing.Size(316, 21);
            this.comboBoxClienti.TabIndex = 2;
            this.comboBoxClienti.SelectedIndexChanged += new System.EventHandler(this.comboBoxClienti_SelectedIndexChanged);
            // 
            // checkedListBoxMasini
            // 
            this.checkedListBoxMasini.CheckOnClick = true;
            this.checkedListBoxMasini.FormattingEnabled = true;
            this.checkedListBoxMasini.HorizontalScrollbar = true;
            this.checkedListBoxMasini.Location = new System.Drawing.Point(117, 87);
            this.checkedListBoxMasini.Name = "checkedListBoxMasini";
            this.checkedListBoxMasini.Size = new System.Drawing.Size(316, 214);
            this.checkedListBoxMasini.TabIndex = 3;
            this.checkedListBoxMasini.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMasini_SelectedIndexChanged);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(358, 343);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(75, 23);
            this.buttonRenunta.TabIndex = 4;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // buttonInregistreaza
            // 
            this.buttonInregistreaza.Location = new System.Drawing.Point(439, 343);
            this.buttonInregistreaza.Name = "buttonInregistreaza";
            this.buttonInregistreaza.Size = new System.Drawing.Size(75, 23);
            this.buttonInregistreaza.TabIndex = 5;
            this.buttonInregistreaza.Text = "Confirma";
            this.buttonInregistreaza.UseVisualStyleBackColor = true;
            this.buttonInregistreaza.Click += new System.EventHandler(this.buttonInregistreaza_Click);
            // 
            // Restituire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 395);
            this.Controls.Add(this.buttonInregistreaza);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.checkedListBoxMasini);
            this.Controls.Add(this.comboBoxClienti);
            this.Controls.Add(this.restituireRest);
            this.Controls.Add(this.restituireClient);
            this.Name = "Restituire";
            this.Text = "Restituire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restituireClient;
        private System.Windows.Forms.Label restituireRest;
        private System.Windows.Forms.ComboBox comboBoxClienti;
        private System.Windows.Forms.CheckedListBox checkedListBoxMasini;
        private System.Windows.Forms.Button buttonRenunta;
        private System.Windows.Forms.Button buttonInregistreaza;
    }
}