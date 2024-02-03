using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Adaugă această linie
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Flaviu
{
    public partial class Afisare : Form
    {

        int idCurentPrim = 0;
        int idCurentUltim = 0;
        int randuriFilmeDT; // Numarul de filme adus, poate avea valoarea 0, 1, 2 sau 3
        DataTable filmeDT; // "Recipientul" pentru filmele aduse din baza de date
        DataRow filmeDR; // va pastra, pe rand, cate o inregistrare -film- din DataTable 

        public Afisare()
        {
            InitializeComponent();
            labelTitlu.Text += DateTime.Now.ToShortDateString();
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, 1);

            SetButtonStyle(Inapoi);
            SetButtonStyle(Inainte);

            this.Font = new Font("Arial", 10, FontStyle.Regular);
            labelTitlu.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox1.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox2.Font = new Font("Arial", 12, FontStyle.Regular);
            textBox3.Font = new Font("Arial", 12, FontStyle.Regular);    
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

        private void reseteazaFilme()
        {
            pictureBox1.Image = null;
            textBox1.Text = "";
            pictureBox2.Image = null;
            textBox2.Text = "";
            pictureBox3.Image = null;
            textBox3.Text = "";
        }

        public void completeazaFilme(ref int idCurentPrim, ref int idCurentUltim, int dir)
        {
            try
            {
                filmeDT = Interogari_DB.selectez_Filme(idCurentPrim, idCurentUltim, dir);
                randuriFilmeDT = filmeDT.Rows.Count;
                if (randuriFilmeDT > 0)
                {
                    reseteazaFilme();
                    for (int i = 0; i < randuriFilmeDT; i++)
                    {
                        filmeDR = filmeDT.Rows[i];
                        idCurentPrim = Convert.ToInt32(filmeDR["idf"]);
                        idCurentUltim = Convert.ToInt32(filmeDR["idf"]);

                        string caleImagine = Path.Combine("C:\\Users\\Bodea Flaviu\\Desktop\\UTCN\\An 2\\Programare avansata\\Proiect\\Proiect_Flaviu\\Poze", filmeDR["imagine"].ToString());

                        Console.WriteLine($"Cale imagine {i + 1}: {caleImagine}");

                        switch (i)
                        {
                            case 0:
                                textBox1.Text = filmeDR["denFilm"] + Environment.NewLine + "Gama: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                                pictureBox1.Image = Image.FromFile(caleImagine);
                                pictureBox1.Visible = true;
                                break;
                            case 1:
                                textBox2.Text = filmeDR["denFilm"] + Environment.NewLine + "Gama: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                                pictureBox2.Image = Image.FromFile(caleImagine);
                                pictureBox2.Visible = true;
                                break;
                            case 2:
                                textBox3.Text = filmeDR["denFilm"] + Environment.NewLine + "Gama: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                                pictureBox3.Image = Image.FromFile(caleImagine);
                                pictureBox3.Visible = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Eroare la afișarea imaginilor:\n{ex.Message}\nStackTrace: {ex.StackTrace}";
                Console.WriteLine(errorMessage);

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Detalii excepție internă: {ex.InnerException.Message}");
                }
            }
        }


        private void Inapoi_Click(object sender, EventArgs e)
        {
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, 1);
        }

        private void Inainte_Click(object sender, EventArgs e)
        {
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, -1);
        }
    }
}
