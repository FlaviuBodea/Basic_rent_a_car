using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable
using System.Collections; // Pentru ArrayList

namespace Proiect_Flaviu
{
    class Imprumut_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=rent_a_car";
        static MySqlConnection conn = new MySqlConnection(connstr);
        public static void inregistrez_imprumut_in_BD(int idcl, ArrayList idmasina,
       DateTime datRestit)
        {
            conn.Open();
            DateTime azi = DateTime.Now;
            MySqlCommand adaugImpr = new MySqlCommand("INSERT INTO imprumuturi (idmasina, idclient, data_inchirierii, data_restituirii) VALUES(@idmasina, @idclient, CAST(@data_inchirierii as datetime), CAST(@data_restituirii as datetime))", conn);
            MySqlCommand scadFilme = new MySqlCommand("UPDATE masini SET nrdisponibile=nrdisponibile-1 WHERE idf = @idf", conn);
             // Instantiez si incep o tranzactie
             MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                // Atasez cele doua comenzi adaugImpr si scadFilme tranzactiei tx
                adaugImpr.Transaction = tx;
                scadFilme.Transaction = tx;
                foreach (int idfi in idmasina)
                {
                    // Adaug
                    adaugImpr.Parameters.AddWithValue("@idmasina", idfi);
                    adaugImpr.Parameters.AddWithValue("@idclient", idcl);
                    adaugImpr.Parameters.AddWithValue("@data_inchirierii", azi);
                    adaugImpr.Parameters.AddWithValue("@data_restituirii", datRestit);
                    adaugImpr.ExecuteNonQuery();
                    // Golim parametrii utilizati in comanda SQL pentru a-i putea reutiliza
                    adaugImpr.Parameters.Clear();
                    scadFilme.Parameters.AddWithValue("@idf", idfi);
                    scadFilme.ExecuteNonQuery();
                    // Golim parametrii utilizati in comanda SQL pentru a-i putea reutiliza
                    scadFilme.Parameters.Clear();
                }
                // Modificarile devin permanente
                tx.Commit();
            }
            catch (Exception)
            {
                // Daca a aparut o eroare in timpul executiei vreuneia dintre operatiile asupra bazei de date
            // se vor anula si operatiile care au fost facute inaintea erorii
 tx.Rollback();
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
        }
    }

}

