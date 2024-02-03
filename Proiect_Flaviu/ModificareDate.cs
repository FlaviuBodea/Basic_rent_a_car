using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Proiect_Flaviu
{
    public partial class ModificareDate : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;User Id=root;Database=rent_a_car");
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        MySqlCommandBuilder cb; // Adăugați această linie
        DataTable filmeleDT = new DataTable();

        public ModificareDate()
        {
            InitializeComponent();

            dataGridViewFilme.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewFilme.BackColor = Color.LightGray;
           
            this.Font = new Font("Arial", 10, FontStyle.Regular);
            label1.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridViewFilme.Font = new Font("Arial", 12, FontStyle.Regular);
            buttonAfisare.Font = new Font("Arial", 12, FontStyle.Bold);
            buttonModificare.Font = new Font("Arial", 12, FontStyle.Bold);
            buttonIesire.Font = new Font("Arial", 12, FontStyle.Bold);

            SetButtonStyle(buttonAfisare);
            SetButtonStyle(buttonModificare);
            SetButtonStyle(buttonIesire);
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

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adapt = new MySqlDataAdapter("SELECT * FROM masini", conn);
                filmeleDT.Clear();
                adapt.Fill(filmeleDT);
                dataGridViewFilme.DataSource = filmeleDT;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cb = new MySqlCommandBuilder(adapt);
                adapt.Update(filmeleDT);
                MessageBox.Show("Am modificat tabela masini");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
