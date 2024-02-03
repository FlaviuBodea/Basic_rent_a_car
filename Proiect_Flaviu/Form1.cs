using System;
using System.Windows.Forms;
using System.Drawing;


namespace Proiect_Flaviu
{
    public partial class Form1 : Form
    {
        int login; // login = 0 cand nu este logat nimeni, =1 pt. admin =2 pt. angajat
        string userTastat, parolaTastata, user_role;

        private void ascundeMeniuTot()
        {
            // Ascundem din meniu optiunile Filme si Clienti .Visible = false;
            // (care va deveni vizibil dupa ce operatia log-in a avut succes)
            // Daca am vrea sa ascundem meniul in intregime:
            // menuStrip1.Hide(); menuStrip1.Show();
            masiniToolStripMenuItem.Visible = false;
            clientiToolStripMenuItem.Visible = false;
            modificareToolStripMenuItem.Visible = false;
            button1.Text = "Log in";
            login = 0;
            userTastat = parolaTastata = "";
        }

        public Form1()
        {
            InitializeComponent();

            ascundeMeniuTot();

            textBoxUser.BorderStyle = BorderStyle.Fixed3D;
            textBoxParola.BorderStyle = BorderStyle.Fixed3D;
            textBoxUser.BackColor = Color.LightGray;
            textBoxParola.BackColor = Color.LightGray;

            this.Font = new Font("Arial", 10, FontStyle.Regular);
            User.Font = new Font("Arial", 12, FontStyle.Regular);
            Parola.Font = new Font("Arial", 12, FontStyle.Regular);
            button1.Font = new Font("Arial", 12, FontStyle.Bold);

            // Setează culoarea de fundal și de text pentru meniu
            menuStrip1.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip1.ForeColor = Color.White;

            // Adaugă o umbra sub meniu pentru un aspect tridimensional
            menuStrip1.Paint += (sender, e) =>
            {
                var rect = new Rectangle(0, menuStrip1.Height - 1, menuStrip1.Width, 1);
                var color = Color.FromArgb(37, 37, 38);
                e.Graphics.FillRectangle(new SolidBrush(color), rect);
            };

            // Setează fontul și stilul meniului
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Adaugă un spațiu la începutul fiecărui element de meniu pentru un aspect mai curat
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Padding = new Padding(10, item.Padding.Top, item.Padding.Right, item.Padding.Bottom);
            }

            // Adaugă efecte de culoare la hover
            menuStrip1.MouseEnter += (sender, e) => menuStrip1.BackColor = Color.FromArgb(60, 60, 60);
            menuStrip1.MouseLeave += (sender, e) => menuStrip1.BackColor = Color.FromArgb(45, 45, 48);

            // Adaugă efecte de culoare la hover pentru fiecare element de meniu
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseEnter += (sender, e) =>
                {
                    item.BackColor = Color.FromArgb(60, 60, 60);
                    item.ForeColor = Color.White;
                };
                item.MouseLeave += (sender, e) =>
                {
                    item.BackColor = Color.FromArgb(45, 45, 48);
                    item.ForeColor = Color.White;
                };
            }


            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            // Efecte la trecerea cu mouse peste buton
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            button1.ForeColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            // Anulăm efectele atunci când mouse-ul părăsește butonul
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Cursor = Cursors.Default;
        }

        private void adaugaGamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugare adaug = new Adaugare("D");
            adaug.ShowDialog();
        }


        private void afisareMasiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afisare afis = new Afisare();
            afis.ShowDialog();
        }

        private void imprumutaMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprumut impr = new Imprumut();
            impr.ShowDialog();
        }

        private void restituireMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restituire restit = new Restituire();
            restit.ShowDialog();
        }

        private void adaugaMasinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Adaugare adaug = new Adaugare("F");
        adaug.ShowDialog();
        }

        private void adaugareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creează o instanță a formularului AdaugareClient
            AdaugareClient adaugaClientForm = new AdaugareClient();

            // Deschide formularul AdaugareClient
            DialogResult result = adaugaClientForm.ShowDialog();

        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificareDate modif = new ModificareDate();
            modif.ShowDialog();

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login == 0)
                {
                    // Preluam user si parola, stergem eventualele spatii
                    // de la inceputul si sfarsitul numelui utilizator
                    userTastat = textBoxUser.Text.Trim();
                    parolaTastata = textBoxParola.Text;
                    if (userTastat == "") throw new Exception("Completati campul User");
                    if (parolaTastata == "") throw new Exception("Completati campul Parola");

                    // Debug output
                    Console.WriteLine($"Attempting login for User: {userTastat}, Parola: {parolaTastata}");

                    // Cautam in baza de date rent_a_car combinatia user+parola care au fost tastate
                    // Daca gasim o inregistrare ce corespunde: aducem din baza de date
                    // denumirea rolului acelui user, altfel user_role ramane sirul vid =""
                    user_role = Interogari_DB.caut_User(userTastat, parolaTastata);

                    // Debug output
                    Console.WriteLine($"Returned role: {user_role}");

                    if (user_role == "admin")
                    { // Daca rolul este de administrator ="admin" are drepturi depline
                        login = 1;
                        masiniToolStripMenuItem.Visible = true;
                        clientiToolStripMenuItem.Visible = true;
                        modificareToolStripMenuItem.Visible = true;
                        button1.Text = "Log out";
                    }
                    else if (user_role == "angajat")
                    { //Daca rolul este ="angajat" nu are dreptul sa acceseze meniul Filme
                      // ca sa adauge un domeniu sau un film in BD
                        login = 2;
                        clientiToolStripMenuItem.Visible = true;
                        modificareToolStripMenuItem.Visible = true;
                        button1.Text = "Log out";
                    }
                    else
                    {
                        throw new Exception("User sau Parola incorecte");
                    }
                }
                else
                {
                    // A fost apasat butonul log-out. Resetam controalele, ascundem meniul
                    textBoxUser.Text = "";
                    textBoxParola.Text = "";
                    ascundeMeniuTot();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }
    }
}
