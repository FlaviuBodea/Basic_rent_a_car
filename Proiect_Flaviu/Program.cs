using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect_Flaviu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Apelul metodei pentru crearea bazei de date
            Creare_DB();

            // Apelul metodei pentru crearea tabelelor cu relații
            Creare_Tabele_Relatii();
        }

        private static void Creare_DB()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;");

            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS Rent_a_car;", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Baza de date Rent_a_car a fost creata sau deja exista.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private static void Creare_Tabele_Relatii()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Database=Rent_a_car;");
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();

                // Verificăm dacă tabela 'gama' există
                cmd.Connection = conn;
                cmd.CommandText = "SHOW TABLES LIKE 'gama'";
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'gama' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE gama (idd int auto_increment, denumire varchar(30) NOT NULL, PRIMARY KEY(idd))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul gama a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul gama deja există");
                }

                // Verificăm dacă tabela 'masini' există
                cmd.CommandText = "SHOW TABLES LIKE 'masini'";
                result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'masini' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE masini (idf int auto_increment, denumire varchar(50) NOT NULL, anul int, imagine varchar(30), nrtotal int, nrdisponibile int, idgama int, PRIMARY KEY(idf), FOREIGN KEY(idgama) REFERENCES gama(idd))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul masini a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul masini deja există");
                }

                // Verificăm dacă tabela 'clienti' există
                cmd.CommandText = "SHOW TABLES LIKE 'clienti'";
                result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'clienti' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE clienti (idc int auto_increment, numepre varchar(50) NOT NULL, CNP int, adresa varchar(30), PRIMARY KEY(idc))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul clienti a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul clienti deja există");
                }

                // imprumuturi, cu câmpurile: idi(numeric, cheie primară, AutoIncrement), idfilm(numeric,cheie străină pentru idf din tabela filme), idclient(numeric, cheie străină pentru idc din tabela clienti), data_inchirierii(date), data_restituirii(date).

                cmd.CommandText = "SHOW TABLES LIKE 'imprumuturi'";
                result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'imprumuturi' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE imprumuturi (idi int auto_increment, idmasina int, idclient int, data_inchirierii date, data_restituire date, PRIMARY KEY(idi), FOREIGN KEY(idmasina) REFERENCES masini(idf), FOREIGN KEY(idclient) REFERENCES clienti(idc))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul imprumuturi a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul imprumuturi deja există");
                }


                // Verificăm dacă tabela 'roluri' există
                cmd.CommandText = "SHOW TABLES LIKE 'roluri'";
                result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'roluri' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE roluri (idr int auto_increment, denumire_rol varchar(50) NOT NULL, PRIMARY KEY(idr))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul roluri a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul roluri deja există");
                }

                // utilizatori, cu câmpurile: idu(numeric, cheie primară, AutoIncrement) , nume_prenume(varchar50), user(varchar30) , parola(varchar50), idrol(numeric, cheie străină pentru idr din tabela roluri).

                // Verificăm dacă tabela 'utilizatori' există
                cmd.CommandText = "SHOW TABLES LIKE 'utilizatori'";
                result = cmd.ExecuteScalar();

                if (result == null)
                {
                    // Tabela 'utilizatori' nu există, deci o creăm
                    cmd.CommandText = "CREATE TABLE utilizatori (idu int auto_increment, nume_prenume varchar(50) NOT NULL, user varchar(50) NOT NULL, parola varchar(50) NOT NULL, idrol int, PRIMARY KEY(idu), FOREIGN KEY(idrol) REFERENCES roluri(idr))";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tabelul utilizatori a fost creat");
                }
                else
                {
                    Console.WriteLine("Tabelul roluri deja există");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Eroare la crearea tabelelor: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
