
namespace Proiect_Flaviu
{
    partial class ModificareDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareDate));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFilme = new System.Windows.Forms.DataGridView();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonModificare = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista masinilor din flota";
            // 
            // dataGridViewFilme
            // 
            this.dataGridViewFilme.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilme.Location = new System.Drawing.Point(16, 53);
            this.dataGridViewFilme.Name = "dataGridViewFilme";
            this.dataGridViewFilme.Size = new System.Drawing.Size(756, 324);
            this.dataGridViewFilme.TabIndex = 1;
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(16, 409);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(88, 23);
            this.buttonAfisare.TabIndex = 2;
            this.buttonAfisare.Text = "Afisare";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // buttonModificare
            // 
            this.buttonModificare.Location = new System.Drawing.Point(159, 409);
            this.buttonModificare.Name = "buttonModificare";
            this.buttonModificare.Size = new System.Drawing.Size(88, 23);
            this.buttonModificare.TabIndex = 3;
            this.buttonModificare.Text = "Modificare";
            this.buttonModificare.UseVisualStyleBackColor = true;
            this.buttonModificare.Click += new System.EventHandler(this.buttonModificare_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(292, 409);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(86, 23);
            this.buttonIesire.TabIndex = 4;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // ModificareDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonModificare);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.dataGridViewFilme);
            this.Controls.Add(this.label1);
            this.Name = "ModificareDate";
            this.Text = "ModificareDate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFilme;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonModificare;
        private System.Windows.Forms.Button buttonIesire;
    }
}