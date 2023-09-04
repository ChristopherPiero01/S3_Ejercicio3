namespace S3_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adivinanzas = int.Parse(this.txtAdivinanza.Text);
            int edad = int.Parse(this.txtEdad.Text);

            switch (adivinanzas)
            {
                case < 3:
                    switch (edad)
                    {
                        case <= 0:
                            txtPremio.Text = string.Empty;
                            break;
                        case < 18:
                            int premio = 50 + 5 * edad + 2 * adivinanzas;
                            txtPremio.Text = premio.ToString()+ " soles";
                            break;
                        case >= 18:
                            premio = 30 + 5 * edad + 2 * adivinanzas;
                            txtPremio.Text = premio.ToString() + " soles";
                            break;
                    }
                    break;

                case <= 5:
                    switch (edad)
                    {
                        case <= 0:
                            txtPremio.Text = string.Empty;
                            break;
                        case < 18:
                            int premio = 80 + 5 * edad + 2 * adivinanzas;
                            txtPremio.Text = premio.ToString() + " soles";
                            break;
                        case >= 18:
                            premio = 50 + 5 * edad + 2 * adivinanzas;
                            txtPremio.Text = premio.ToString();
                            break;
                    }
                    break;
            }
        }
    }
}