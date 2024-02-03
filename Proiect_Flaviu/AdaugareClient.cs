using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Flaviu
{
    public partial class AdaugareClient : Form
    {
        public AdaugareClient()
        {
            InitializeComponent();
            this.Font = new Font("Arial", 10, FontStyle.Regular);
            nume.Font = new Font("Arial", 12, FontStyle.Regular);
            cnp.Font = new Font("Arial", 12, FontStyle.Regular);
            adresa.Font = new Font("Arial", 12, FontStyle.Regular);
            textNume.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox1.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox2.Font = new Font("Arial", 12, FontStyle.Regular);

            SetButtonStyle(adaugaClient);
        }

        private void SetButtonStyle(Button button)
        {
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Efecte la trecerea cu mouse peste buton
            if (sender is Button)
            {
                Button button = (Button)sender;
                button.Font = new Font("Arial", 12, FontStyle.Bold);
                button.ForeColor = Color.DodgerBlue;
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Anulează efectele atunci când mouse-ul părăsește butonul
            if (sender is Button)
            {
                Button button = (Button)sender;
                button.Font = new Font("Arial", 12, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.Cursor = Cursors.Default;
            }
        }

        private void adresa_Click(object sender, EventArgs e)
        {

        }

        private void adaugaClient_Click(object sender, EventArgs e)
        {

            string nume = textNume.Text;
            string cnp = textBox1.Text;
            string adresa = textBox2.Text;

            if (!string.IsNullOrEmpty(nume) && !string.IsNullOrEmpty(cnp) && !string.IsNullOrEmpty(adresa))
            {
                Interogari_DB.adauga_Client(nume, cnp, adresa);

                // Afișează un mesaj de succes
                MessageBox.Show("Client adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Setează rezultatul formularului la OK pentru a indica că operația a fost realizată cu succes
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Completați toate câmpurile!");
            }
        }
    }
}
