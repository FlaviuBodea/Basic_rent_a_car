using System;
using System.Windows.Forms;
using System.Drawing;


namespace Proiect_Flaviu
{
    public partial class Confirmare : Form
    {
        public bool Confirmed { get; private set; }

        public Confirmare(string mesaj)
        {
            InitializeComponent();
            labelConfirmare.Text = mesaj;
            Confirmed = false; // Initialize to false

            SetButtonStyle(NU);
            SetButtonStyle(DA);

            this.Font = new Font("Arial", 10, FontStyle.Regular);
            labelConfirmare.Font = new Font("Arial", 12, FontStyle.Regular);
            NU.Font = new Font("Arial", 12, FontStyle.Regular);
            DA.Font = new Font("Arial", 12, FontStyle.Regular);
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

        private void buttonDa_Click(object sender, EventArgs e)
        {
            Confirmed = true; // Set to true when the "Da" button is clicked
            Close();
        }

        private void buttonNu_Click(object sender, EventArgs e)
        {
            Confirmed = false; // Set to false when the "Nu" button is clicked
            Close();
        }

        private void Confirmare_Load(object sender, EventArgs e)
        {
            // You can perform additional setup here if needed
        }
    }
}
