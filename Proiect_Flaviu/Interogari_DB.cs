using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace Proiect_Flaviu
{
    class Interogari_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=rent_a_car";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static string caut_User(string u, string p)
        {
            MySqlCommand comUser = new MySqlCommand();
            comUser.Connection = conn;
            comUser.CommandText = "SELECT denumire_rol FROM utilizatori join roluri on idrol = idr where user = @paramUser and parola = @paramParola";
            comUser.Parameters.AddWithValue("@paramUser", u);
            comUser.Parameters.AddWithValue("@paramParola", p);
            string rol = "";

            try
            {
                // Debug output
                Console.WriteLine($"SQL Query: {comUser.CommandText}");
                Console.WriteLine($"Parameter User: {comUser.Parameters["@paramUser"].Value}");
                Console.WriteLine($"Parameter Parola: {comUser.Parameters["@paramParola"].Value}");

                conn.Open();
                MySqlDataReader readerUser = comUser.ExecuteReader();

                if (readerUser.Read())
                {
                    rol = readerUser["denumire_rol"].ToString();
                }

                comUser.Parameters.Clear();
            }
            catch (Exception ex)
            {
                // Debug output for SQL errors
                Console.WriteLine($"SQL Error: {ex.Message}");
                throw;
            }
            finally
            {
                conn.Close();
            }

            return rol;
        }

        public static DataTable selectez_Filme(int idCurentPrim, int idCurentUltim, int dir)
        {
            // -- Operatia de interogare --
            MySqlCommand comFilme = new MySqlCommand();
            comFilme.Connection = conn;
            MySqlDataAdapter filmeAdp = new MySqlDataAdapter(comFilme);
            DataTable filmeDT = new DataTable();
            if (dir == 1)
            {
                // Cautam urmatoarele 3 filme de dupa ultimul idf al filmului afisat deja
                // in ordinea crescatoare a idf (id film in tabela filme)
                comFilme.CommandText = "SELECT idf, f.denumire AS denFilm, d.denumire AS denDomeniu, imagine, nrdisponibile FROM masini f JOIN gama d ON idgama = idd WHERE idf > @paramID ORDER BY idf ASC LIMIT 3";
            comFilme.Parameters.AddWithValue("@paramID", idCurentUltim);
            }
            else
            {
                // Cautam cele 3 filme de inaintea primului idf afisat deja
                // le obtinem in ordine descrescatoare a idf si le includem intr-o alta comanda SELECT
            // care sa le sorteze in ordinea crescatoare a idf (id film in tabela filme)
            
                comFilme.CommandText = "SELECT * FROM ( SELECT idf, f.denumire AS denFilm, d.denumire AS denDomeniu, imagine, nrdisponibile FROM masini f JOIN gama d ON idgama = idd WHERE idf<@paramID ORDER BY idf DESC LIMIT 3) a ORDER BY idf ASC ";
            comFilme.Parameters.AddWithValue("@paramID", idCurentPrim);
            }
            try
            {
                conn.Open();
                filmeAdp.Fill(filmeDT);
            }
            catch (Exception)
            {
                // Aruncam exceptia in Afisare.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Curatam parametri comenzii comFilme pentru a-i putea
                // reutiliza la un apel urmator al metodei: caut_filme()
                comFilme.Parameters.Clear();
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return filmeDT;
        }

        public static DataTable selectez_Clienti()
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date DBvideoteca tabela clienti
            // toate inregistrarile (toti clientii) ordonati alfabetic dupa nume
            MySqlCommand comClienti = new MySqlCommand();
            comClienti.Connection = conn;
            comClienti.CommandText = "SELECT idc, CONCAT(numepre,' --(',adresa,', CNP: ', CAST(cnp as char(13)),')') AS informatii FROM clienti ORDER BY numepre";
            MySqlDataAdapter clientiAdapt = new MySqlDataAdapter(comClienti);
            DataTable clientiDT = new DataTable();
            try
            {
                conn.Open();
                clientiAdapt.Fill(clientiDT);
            }
            catch (Exception)
            {
                // Aruncam exceptia in Afisare.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return clientiDT;
        }
        public static DataTable selectez_Domenii()
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date DBvideoteca tabela domenii
            // toate inregistrarile (toate domeniile) ordonate alfabetic
            MySqlCommand comDomenii = new MySqlCommand();
            comDomenii.Connection = conn;
            comDomenii.CommandText = "SELECT * FROM gama ORDER BY denumire ASC ";
            MySqlDataAdapter domeniiAdapt = new MySqlDataAdapter(comDomenii);
            DataTable domeniiDT = new DataTable();
            try
            {
                conn.Open();
                domeniiAdapt.Fill(domeniiDT);
            }
            catch (Exception)
            {
                // Aruncam exceptia in Afisare.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return domeniiDT;
        }
        public static DataTable selectez_FilmeDisponibile(int idDomeniu)
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date DBvideoteca tabela filme join domenii
            // toate filmele disponibile -care pot fi imprumutate-
            // din domeniul cu idDomeniu transmis ca parametru ordonate alfabetic
            // dupa denumire film
            MySqlCommand comFilme = new MySqlCommand();
            comFilme.Connection = conn;
            if (idDomeniu == 0)
                comFilme.CommandText = "SELECT idf, CONCAT(f.denumire,' (Anul: ',cast(anul as char(4)),', Domeniul: ',d.denumire,')') as date_film FROM masini f JOIN gama d ON idgama = idd WHERE nrdisponibile > 0 ORDER BY f.denumire";
            else
            {
                comFilme.CommandText = "SELECT idf, CONCAT(f.denumire,' (Anul: ',cast(anul as char(4)),', Domeniul: ',d.denumire,')') as date_film FROM masini f JOIN gama d ON idgama = idd WHERE idgama = @paramID AND nrdisponibile > 0 ORDER BY f.denumire";
            comFilme.Parameters.AddWithValue("@paramID", idDomeniu);
            }
            MySqlDataAdapter filmeAdapt = new MySqlDataAdapter(comFilme);
            DataTable filmeDT = new DataTable();
            try
            {
                conn.Open();
                filmeAdapt.Fill(filmeDT);
                // Golim parametrii utilizati in comanda SQL pentru a-i putea reutiliza
                comFilme.Parameters.Clear();
            }
            catch (Exception)
            {
                // Aruncam exceptia in Afisare.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return filmeDT;
        }

        public static DataTable selectez_FilmeDeRestituit(int idClient)
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date DBvideoteca tabela filme join imprumut
            // toate filmele care au fost imprumutate de catre clientul
            // cu idClient transmis ca parametru ordonate alfabetic dupa denumire film
            MySqlCommand comFilmeDeRestituitUnClient = new MySqlCommand();
            comFilmeDeRestituitUnClient.Connection = conn; ;
            MySqlDataAdapter filmeAdp = new MySqlDataAdapter(comFilmeDeRestituitUnClient);
            DataTable filmeDT = new DataTable();
            comFilmeDeRestituitUnClient.CommandText = "Select idf,Concat(f.denumire,' ',cast(anul as char(4))) as date_film from masini f join imprumuturi i on idmasina = idf where idclient = @idclient order by f.denumire";
            // Comanda SQL pentru selectarea filmelor imprumutate de un client (in vederea restituirii)
            comFilmeDeRestituitUnClient.Parameters.AddWithValue("@idclient", idClient);
            try
            {
                conn.Open();// Deschid conexiunea cu serverul de BD
                filmeAdp.Fill(filmeDT);
                comFilmeDeRestituitUnClient.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return filmeDT;
        }

        public static void adauga_Client(string nume, string cnp, string adresa)
        {
            MySqlCommand comAdaugaClient = new MySqlCommand();
            comAdaugaClient.Connection = conn;
            comAdaugaClient.CommandText = "INSERT INTO clienti (numepre, cnp, adresa) VALUES (@nume, @cnp, @adresa)";
            comAdaugaClient.Parameters.AddWithValue("@nume", nume);
            comAdaugaClient.Parameters.AddWithValue("@cnp", cnp);
            comAdaugaClient.Parameters.AddWithValue("@adresa", adresa);

            try
            {
                conn.Open();
                comAdaugaClient.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Poți arunca o excepție sau trata altfel eroarea
                Console.WriteLine($"Eroare la adăugarea clientului: {ex.Message}");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
