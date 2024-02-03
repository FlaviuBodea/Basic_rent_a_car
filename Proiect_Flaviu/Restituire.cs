using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Proiect_Flaviu
{
    public partial class Restituire : Form
    {
        __Restituire_DB restituireDB = new __Restituire_DB();
        CheckedListBox checkedListBoxFilme = new CheckedListBox();

        public Restituire()
        {
            InitializeComponent();
            restituireDB.Completez_ComboBoxClienti(comboBoxClienti);
            int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
            restituireDB.Completez_CheckList_FilmeImprumutateDeUnClient(checkedListBoxMasini, idClient);

            this.Font = new Font("Arial", 10, FontStyle.Regular);
            restituireClient.Font = new Font("Arial", 12, FontStyle.Regular);
            restituireRest.Font = new Font("Arial", 12, FontStyle.Regular);
            comboBoxClienti.Font = new Font("Arial", 12, FontStyle.Regular);
            checkedListBoxMasini.Font = new Font("Arial", 12, FontStyle.Regular);

            SetButtonStyle(buttonRenunta);
            SetButtonStyle(buttonInregistreaza);
        }

        private void SetButtonStyle(Button button)
        {
            button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
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
            if (sender is Button)
            {
                Button button = (Button)sender;
                button.Font = new Font("Arial", 12, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.Cursor = Cursors.Default;
            }
        }

        private void buttonInregistreaza_Click(object sender, EventArgs e)
        {
            ArrayList listaFilmeDeRestituit = new ArrayList(); // Declarație înainte de blocul if

            if (checkedListBoxMasini.CheckedIndices.Count > 0)
            {
                Confirmare c = new Confirmare("Confirmati restituirea?");
                DialogResult dr = c.ShowDialog();
                int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        foreach (int selectedIndex in checkedListBoxMasini.CheckedIndices)
                        {
                            object selectedItem = checkedListBoxMasini.Items[selectedIndex];

                            if (selectedItem is DataRowView drv)
                            {
                                try
                                {
                                    if (drv.Row.RowState != DataRowState.Deleted)
                                    {
                                        if (drv.Row.Table.Columns.Contains("idf"))
                                        {
                                            if (!drv.Row.IsNull("idf"))
                                            {
                                                object idfValue = drv.Row["idf"];

                                                if (idfValue is IConvertible)
                                                {
                                                    try
                                                    {
                                                        int idFilm = Convert.ToInt32(idfValue);
                                                        listaFilmeDeRestituit.Add(idFilm);
                                                    }
                                                    catch (FormatException)
                                                    {
                                                        MessageBox.Show("Valoarea coloanei 'idf' nu este un număr întreg valid.");
                                                        // Continuă cu următorul element în loc să arunci o excepție
                                                        continue;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Valoarea coloanei 'idf' nu este convertibilă în int.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Valoarea coloanei 'idf' este null.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Coloana 'idf' nu există.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Elementul selectat este marcat pentru ștergere.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"A apărut o excepție la iterația {selectedIndex}: {ex.Message}");
                                    if (ex.InnerException != null)
                                    {
                                        MessageBox.Show($"Detalii excepție internă: {ex.InnerException.Message}");
                                    }
                                }
                            }
                            else if (selectedItem is string)
                            {
                                string denumireMasina = (string)selectedItem;
                                int idFilm = restituireDB.GetIdMasinaByDenumire(denumireMasina);

                                if (idFilm != -1)
                                {
                                    listaFilmeDeRestituit.Add(idFilm);
                                }
                                else
                                {
                                    MessageBox.Show($"Nu s-a putut găsi identificatorul pentru mașina cu denumirea '{denumireMasina}'.");
                                }
                            }

                            Console.WriteLine($"Number of films to return: {listaFilmeDeRestituit.Count}");

                            restituireDB.Inregistrez_restituire_in_BD(listaFilmeDeRestituit, idClient);
                            Console.WriteLine("Restitution recorded successfully!");
                            MessageBox.Show("Restituirea a fost înregistrată cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A apărut o excepție: {ex.Message}");
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show($"Detalii excepție internă: {ex.InnerException.Message}");
                        }
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Restituirea NU a fost înregistrată");
                    goleste_checkedListBoxFilme();
                }
            }
            else
            {
                MessageBox.Show("NU ați selectat nici o masina!");
            }
        }


        private void goleste_checkedListBoxFilme()
        {
            checkedListBoxMasini.Items.Clear();
        }

        private void checkedListBoxMasini_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Codul pentru eveniment
        }

        private void comboBoxClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
                restituireDB.Completez_CheckList_FilmeImprumutateDeUnClient(checkedListBoxMasini, idClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            // Parcurgem lista filmelor și debifăm tot ce a fost bifat
            goleste_checkedListBoxFilme();
        }
    }
}
