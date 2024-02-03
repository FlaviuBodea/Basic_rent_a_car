using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Pentru lucrul cu fisiere si directoare


namespace Proiect_Flaviu
{
    public partial class Adaugare : Form
    {
        public Adaugare(string tipAdaugare)
        {
            InitializeComponent();
            if (tipAdaugare == "D")
                elimin_Obiecte();
            else
            {
                completez_ComboBoxDomeniul();
                buttonAdauga.Text = "Adauga masina";
                buttonAdauga.AutoSize = true;

                SetButtonStyle(buttonRenunta);
                SetButtonStyle(buttonAdauga);

                textBoxDenumire.BorderStyle = BorderStyle.Fixed3D;
                textBoxAnul.BorderStyle = BorderStyle.Fixed3D;
                textBoxDenumire.BackColor = Color.LightGray;
                textBoxAnul.BackColor = Color.LightGray;
                textBoxNrTotal.BackColor = Color.LightGray;
                textBoxNrTotal.BorderStyle = BorderStyle.Fixed3D;
                textBoxImagine.BackColor = Color.LightGray;
                textBoxImagine.BorderStyle = BorderStyle.Fixed3D;

                this.Font = new Font("Arial", 10, FontStyle.Regular);
                Denumirea.Font = new Font("Arial", 12, FontStyle.Regular);
                Gama.Font = new Font("Arial", 12, FontStyle.Regular);
                Anul.Font = new Font("Arial", 12, FontStyle.Regular);
                NumarTotal.Font = new Font("Arial", 12, FontStyle.Regular);
                Imaginea.Font = new Font("Arial", 12, FontStyle.Regular);
                buttonRenunta.Font = new Font("Arial", 12, FontStyle.Bold);
                buttonAdauga.Font = new Font("Arial", 12, FontStyle.Bold);
                buttonSelectImg.Font = new Font("Arial", 12, FontStyle.Bold);
            }

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

        // Fereastra de dialog pentru alegere fisier
        OpenFileDialog fleDlg = new OpenFileDialog();
        DataTable domeniiDT;
        String denumire, imagineFilm, anFilm, totalFilme;
        Int16 idDomeniu;
        // Folderul implicit - directorul curent relativ la fis. .exe
        // String selFldr = Application.StartupPath; 

        private void completez_ComboBoxDomeniul()
        {
            comboBoxGama.Items.Clear();
            // Apelam metoda care interogheaza tabela domenii si depune rezultatul intr-un DataTable
            domeniiDT = Interogari_DB.selectez_Domenii();
            // DataTable din care sunt preluate datele pentru comboBoxDomenii
            comboBoxGama.DataSource = domeniiDT;
            // Valoarea din coloana idd nu se afiseaza in comboBoxDomenii
            comboBoxGama.ValueMember = "idd";
            // Denumirea domeniului afisata in comboBoxDomenii, preluata din:
            // DataTable domeniiDT - coloana "denumire"
            comboBoxGama.DisplayMember = "denumire";
        }

        private void elimin_Obiecte()
        {
            Denumirea.Hide();
            Gama.Hide();
            Anul.Hide();
            NumarTotal.Hide();
            comboBoxGama.Hide();
            textBoxAnul.Hide();
            textBoxImagine.Hide();
            textBoxNrTotal.Hide();
            buttonRenunta.Hide();
            buttonSelectImg.Hide();
            buttonAdauga.Location = new System.Drawing.Point(114, 90);
            buttonAdauga.Text = "Adauga gama";
            buttonAdauga.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 200);
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (buttonAdauga.Text == "Adauga gama")
            {
                denumire = textBoxDenumire.Text;
                try
                {
                    // Daca nu au fost completate toate datele "aruncam" o exceptie
                    if (denumire == "") throw new Exception("Completati denumirea gamei");
                    // Daca nu a iesit din cauza exceptiei scriem cate o informatie pe un rand
                    Adaugare_DB.inregistrez_domeniu_in_BD(denumire);
                    MessageBox.Show("Am adaugat");
                    // Golim continutul obiectelor din interfata
                    textBoxDenumire.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                denumire = textBoxDenumire.Text;
                idDomeniu = Convert.ToInt16(comboBoxGama.SelectedValue.ToString());
                anFilm = textBoxAnul.Text;
                imagineFilm = textBoxImagine.Text;
                totalFilme = textBoxNrTotal.Text;
                try
                {
                    // Daca nu au fost completate toate datele "aruncam" o exceptie
                    if (denumire == "" || imagineFilm == "" || anFilm == "" || totalFilme == "")
                        throw new Exception("Completati toate informatiile");
                    // Daca nu a iesit din cauza exceptiei scriem cate o informatie pe un rand
                    Adaugare_DB.inregistrez_film_in_BD(denumire, imagineFilm,
                   Convert.ToInt16(idDomeniu), Convert.ToInt16(anFilm), Convert.ToInt16(totalFilme));
                    MessageBox.Show("Am adaugat");
                    // Golim continutul obiectelor din interfata
                    textBoxDenumire.Text = "";
                    textBoxNrTotal.Text = "";
                    textBoxAnul.Text = "";
                    textBoxImagine.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            textBoxDenumire.Text = "";
            textBoxNrTotal.Text = "";
            textBoxAnul.Text = "";
            textBoxImagine.Text = "";

        }

        private void adaugaDomeniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Actiunea click pe optiunea "Adauga domeniu" va transmite
            // valoarea unui parametru "D" -domeniu- in clasa Adaugare
            Adaugare adaug = new Adaugare("D");
            adaug.ShowDialog();
        }

        private void adaugaFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugare adaug = new Adaugare("F");
            adaug.ShowDialog();
        }


        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            // Selectam fisierul imagine - afisul filmului - din folderul \Poze
            fleDlg.Filter = "Image Files|*.jpg"; // Ce tip de fisiere sa fie aratate in fereastra
            fleDlg.Title = "Selecteaza fisierul imagine"; // Textul din titlul ferestrei
                                                          // Deschidem o fereastra de dialog (folderul cu imaginile, \Poze) pentru selectarea imaginii
            fleDlg.InitialDirectory = Directory.GetCurrentDirectory() + @"\Poze";
            if (fleDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) //A fost apasat butonul OK
            {
                // Calea completa a fisierului:
                string caleFisier = fleDlg.FileName;
                // Separam bucatile din path complet - ce se afla intre \\
                string[] numeFisier = @caleFisier.Split('\\');
                // Luam doar ultima parte (bucata) - numele fisierului - este la sfarsitul path-ului
                textBoxImagine.Text = numeFisier[numeFisier.Length - 1];
            }
        }

    }
}
