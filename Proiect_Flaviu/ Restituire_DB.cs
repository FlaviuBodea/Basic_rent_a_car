using System;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;


namespace Proiect_Flaviu
{
    class __Restituire_DB
    {
        static string connstr = "Server=localhost;User Id=root;Database=rent_a_car";
        static MySqlConnection conn = new MySqlConnection(connstr);

        DataTable clientiDT = new DataTable();
        DataTable filmeDT = new DataTable();

        public void Inregistrez_restituire_in_BD(ArrayList filmeDeRestituit, int id_client)
        {
            MySqlCommand stergImprumut = new MySqlCommand("DELETE FROM imprumuturi WHERE idmasina = @idmasina AND idclient = @idclient", conn);
            MySqlCommand adaugFilme = new MySqlCommand("UPDATE masini SET nrdisponibile = nrdisponibile + 1 WHERE idf = @idf", conn);

            // Deschidem conexiunea cu serverul de BD
            conn.Open();

            // Instantiem si incepem executia unei tranzactii pe conexiunea cu baza de date deschisa
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                // Atasam cele doua comenzi stergImprumut si adaugFilme tranzactiei tx
                stergImprumut.Transaction = tx;
                adaugFilme.Transaction = tx;

                // Parcurgem in ArrayList filmeDeRestituit toate id-urile filmelor
                // care au fost preluate pentru restituire din checkedListBoxFilme
                foreach (int id_film in filmeDeRestituit)
                {
                    stergImprumut.Parameters.AddWithValue("@idmasina", id_film);
                    stergImprumut.Parameters.AddWithValue("@idclient", id_client);
                    stergImprumut.ExecuteNonQuery();
                    stergImprumut.Parameters.Clear();

                    adaugFilme.Parameters.AddWithValue("@idf", id_film);
                    adaugFilme.ExecuteNonQuery();
                    adaugFilme.Parameters.Clear();
                }

                // Modificarile devin permanente
                tx.Commit();
                // Modificari in baza de date finalizate cu succes
            }
            catch (Exception)
            {
                // Daca a aparut o eroare in timpul executiei vreuneia dintre operatiile asupra bazei de date
                // se vor anula toate operatiile, si cele care au fost parcurse inaintea erorii
                tx.Rollback();
                throw;
                // Modificari in baza de date neefectuate din cauza unei erori
            }
            finally
            {
                conn.Close();
            }
        }

        public void Completez_ComboBoxClienti(ComboBox comboBoxClienti)
        {
            comboBoxClienti.Items.Clear();
            clientiDT = Interogari_DB.selectez_Clienti();
            comboBoxClienti.DataSource = clientiDT;
            comboBoxClienti.ValueMember = "idc";
            comboBoxClienti.DisplayMember = "informatii";
        }

        public void Completez_CheckList_FilmeImprumutateDeUnClient(CheckedListBox checkedListBoxFilme, int idClient)
        {

            filmeDT = Interogari_DB.selectez_FilmeDeRestituit(idClient);

            checkedListBoxFilme.Items.Clear(); // Golește lista înainte de a adăuga noi elemente

            foreach (DataRow row in filmeDT.Rows)
            {
                // Asigură-te că row["date_film"] nu este null înainte de adăugare
                if (row["date_film"] != DBNull.Value)
                {
                    checkedListBoxFilme.Items.Add(row["date_film"].ToString());
                }
            }
        }

        public int GetIdMasinaByDenumire(string denumireMasina)
        {
            int idMasina = -1;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    conn.Open();

                    // Separă denumirea și anul din formatul "Denumire An" (de exemplu, "Audi A6 2020")
                    string[] parts = denumireMasina.Split(' ');

                    if (parts.Length >= 2)
                    {
                        string marca = string.Join(" ", parts.Take(parts.Length - 1)); // Concatenează toate părțile, cu excepția ultimei
                        string an = parts[parts.Length - 1]; // Ultima parte este anul

                        Console.WriteLine($"Marca: {marca}, An: {an}");

                        // Caută identificatorul mașinii
                        string query = "SELECT idf FROM masini WHERE denumire = @denumire AND anul = @anul LIMIT 1";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@denumire", marca);
                            cmd.Parameters.AddWithValue("@anul", an);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idMasina = reader.GetInt32("idf");
                                    Console.WriteLine($"ID Mașină: {idMasina}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A apărut o excepție în GetIdMasinaByDenumire: {ex.Message}");
            }

            return idMasina;
        }
    }
    }
