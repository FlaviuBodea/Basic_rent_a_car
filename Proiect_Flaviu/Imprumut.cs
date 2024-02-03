using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Pentru ArrayList


namespace Proiect_Flaviu
{
    public partial class Imprumut : Form
    {
        int idDomeniu;
        DataTable clientiDT;
        DataTable domeniiDT;
        DataRow domeniiDR;
        DataTable filmeDT;

        public Imprumut()
        {
            InitializeComponent();
            // In dateTimePickerDataRest se vor afisa doar
            // datele calendaristice ulterioare datei de astazi
            dateTimePickerDataRest.MinDate = DateTime.Now.AddDays(1);
            try
            {
                // Completez la pornire lista clientilor si lista cu domeniile filmelor
                Completez_ComboBoxClienti();
                Completez_ComboBoxDomenii();
                // Completez la pornire toate filmele, parametrul: - idDomeniu = 0
                Completez_checkedListBoxFilme(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetButtonStyle(buttonRenunta);
            SetButtonStyle(buttonInregistreaza);

            this.Font = new Font("Arial", 10, FontStyle.Regular);
            client.Font = new Font("Arial", 12, FontStyle.Regular);
            gama.Font = new Font("Arial", 12, FontStyle.Regular);
            masini.Font = new Font("Arial", 12, FontStyle.Regular);
            restituire.Font = new Font("Arial", 12, FontStyle.Regular);
            comboBoxClienti.Font = new Font("Arial", 12, FontStyle.Regular);
            comboBoxGama.Font = new Font("Arial", 12, FontStyle.Regular);
            checkedListBoxMasini.Font = new Font("Arial", 12, FontStyle.Regular);
            dateTimePickerDataRest.Font = new Font("Arial", 12, FontStyle.Regular);

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

        private void Completez_ComboBoxClienti()
        {
            comboBoxClienti.Items.Clear();
            // Apelam metoda care interogheaza tabela clienti si depune rezultatul in: DataTable clientiDT
             clientiDT = Interogari_DB.selectez_Clienti();
            // DataTable clientiDT este folosit ca sursa de date pentru comboBoxClienti
            comboBoxClienti.DataSource = clientiDT;
            // Valoarea din coloana "idc" se asociaza fiecarui item
            // din comboBoxClienti dar nu se afiseaza in comboBoxClienti
            comboBoxClienti.ValueMember = "idc";
            // Denumirea domeniului afisata in comboBoxClienti, preluata din DataTable
            comboBoxClienti.DisplayMember = "informatii";
        }

        private void Completez_ComboBoxDomenii()
        {
            comboBoxGama.Items.Clear();
            // Apelam metoda care interogheaza tabela domenii si depune rezultatul intr-un DataTable
            domeniiDT = Interogari_DB.selectez_Domenii();
            // Pentru optiunea "--Toate domeniile--" adaugam un rand cu idd=0
            // la inceputul: DataTable domeniiDT
            domeniiDR = domeniiDT.NewRow();
            domeniiDR["idd"] = "0";
            domeniiDR["denumire"] = "--Toate domeniile--";
            domeniiDT.Rows.InsertAt(domeniiDR, 0);
            // DataTable din care sunt preluate datele pentru comboBoxDomenii
            comboBoxGama.DataSource = domeniiDT;
            // Valoarea din coloana idd nu se afiseaza in comboBoxDomenii
            comboBoxGama.ValueMember = "idd";
            // Denumirea domeniului afisata in comboBoxDomenii, preluata din:
            // DataTable domeniiDT - coloana "denumire"
            comboBoxGama.DisplayMember = "denumire";
        }

        public void Completez_checkedListBoxFilme(int idDomeniu)
        {
            try
            {
                filmeDT = Interogari_DB.selectez_FilmeDisponibile(idDomeniu);
                // Am incarcat in DataTable filmeDT filmele din domeniul selectat
                // apoi setez acest filmeDT ca sursa de date pentru checkedListBoxFilme
                // din care se afiseaza coloana "date_film" fiecare rand cu id asociat "idf"
                checkedListBoxMasini.DataSource = filmeDT;
                checkedListBoxMasini.ValueMember = "idf";
                checkedListBoxMasini.DisplayMember = "date_film";
                if (checkedListBoxMasini.Items.Count == 0)// sau: (filmeDT.Rows.Count == 0)
                {
                    MessageBox.Show("Nu mai sunt masini disponibile din aceasta gama ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDomenii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // Cand selectam un alt domeniu din comboBoxDomenii trebuie sa
                // reincarcam lista filmelor cu filmele din domeniul selectat
                object selectedValue = comboBoxGama.SelectedValue;

                if (selectedValue != null && int.TryParse(selectedValue.ToString(), out idDomeniu))
                {
                    // Conversia a reușit
                    Completez_checkedListBoxFilme(idDomeniu);
                }
                else
                {
                    // Nu face nimic dacă nu este selectată o opțiune validă pentru gama
                }
                Completez_checkedListBoxFilme(idDomeniu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void buttonInregistreaza_Click(object sender, EventArgs e)
        {
            ArrayList idmasinaeArrayList = new ArrayList();
            int idmasina, idClient;

            try
            {
                idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
                // Parcurgem lista cu filmele bifate- .CheckedIndices
                // facem ca fiecare dintre cei bifati, pe rand, sa devina .SelectedIndex
                // preluam idFilm de la fiecare item devenit selected, pe rand, si il adaugam in lista "ArrayList idFilme"
            foreach (int i in checkedListBoxMasini.CheckedIndices)
                {
                    if (checkedListBoxMasini.GetItemChecked(i))
                    {
                        DataRowView drv = (DataRowView)checkedListBoxMasini.Items[i];
                        idmasina = Convert.ToInt32(drv["idf"]);
                    }
                    else
                    {
                        MessageBox.Show("Selectați o mașină validă.");
                        return;
                    }

                    idmasinaeArrayList.Add(idmasina);
                }
                if (idmasinaeArrayList.Count == 0) throw new Exception("Bifati cel putin o masina!");
                Confirmare c = new Confirmare ("Confirmati imprumutul?");
                DialogResult dr = c.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    Imprumut_DB.inregistrez_imprumut_in_BD(idClient, idmasinaeArrayList, dateTimePickerDataRest.Value.Date);
                    MessageBox.Show("Imprumutul a fost inregistrat in baza de date");
                    // Dupa inregistrarea imprumutului o parte din filme s-au epuizat, nu mai sunt disponibile pentru imprumut
                    // Reincarc in checkedListBoxFilme noua lista cu filmele ramase dupa imprumut
                    // Pentru asta "resetez" datele din dataTable filmeDT (.DataSource pentru checkedListFilme)
                    filmeDT.Clear();
                    checkedListBoxMasini.DataSource = null;
                    idDomeniu = Convert.ToInt32(comboBoxGama.SelectedValue.ToString());
                    Completez_checkedListBoxFilme(idDomeniu);
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Imprumutul nu a fost inregistrat");
                    // Nu facem nici o actiune
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goleste_checkedListBoxFilme()
        {
            checkedListBoxMasini.ClearSelected();
            // deselecteaza filmul selectat
            foreach (int i in checkedListBoxMasini.CheckedIndices)
                checkedListBoxMasini.SetItemChecked(i, false);
            // debifeaza filmele bifate
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            // Parcurgem lista filmelor si debifam tot ce a fost bifat
            goleste_checkedListBoxFilme();
        }
    }
}

