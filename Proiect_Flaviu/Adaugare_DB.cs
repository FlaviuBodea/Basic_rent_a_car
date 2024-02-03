using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date


namespace Proiect_Flaviu
{
    class Adaugare_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=rent_a_car";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static void inregistrez_domeniu_in_BD(string denumireDomeniu)
        {
            MySqlCommand cmdAdaugFilm = new MySqlCommand();
            cmdAdaugFilm.Connection = conn;
            cmdAdaugFilm.CommandText = "INSERT INTO gama(denumire) VALUES(@denumire_domeniu);";
            try
            {
                conn.Open(); // Deschidem conexiunea cu Baza de Date
                cmdAdaugFilm.Parameters.AddWithValue("@denumire_domeniu", denumireDomeniu);
                cmdAdaugFilm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close(); // Inchidem conexiunea cu Baza de Date
            }
        }
        public static void inregistrez_film_in_BD(string denumireFilm, string
        imagineFilm, int idDomeniu, int anFilm, int totalFilme)
        {
            MySqlCommand cmdAdaugFilm = new MySqlCommand();
            cmdAdaugFilm.Connection = conn;
            cmdAdaugFilm.CommandText = "INSERT INTO masini(denumire, anul, imagine, nrtotal, nrdisponibile, idgama) VALUES(@denumire_film, @anul, @imagine, @nrtotal, @nrtotal, @idgama); ";
            try
            {
                conn.Open(); // Deschidem conexiunea cu Baza de Date
                cmdAdaugFilm.Parameters.AddWithValue("@denumire_film", denumireFilm);
                cmdAdaugFilm.Parameters.AddWithValue("@anul", anFilm);
                cmdAdaugFilm.Parameters.AddWithValue("@imagine", imagineFilm);
                cmdAdaugFilm.Parameters.AddWithValue("@nrtotal", totalFilme);
                cmdAdaugFilm.Parameters.AddWithValue("@idgama", idDomeniu);
                cmdAdaugFilm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close(); // Inchidem conexiunea cu Baza de Date
            }
        }


    }
}
