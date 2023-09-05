namespace S3_Ejercicio03_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtedad.Text);
            int adiv = int.Parse(txtaciert.Text);
            float mont = 0f;
            if (edad < 18)
            {
                if (adiv < 3)
                {
                    mont = 50.00f;
                }
                else
                {
                    mont = 80.00f;
                }
            }
            else
            {
                if (adiv < 3)
                {
                    mont = 30.00f;
                }
                else
                {
                    mont = 50.00f;
                }
            }
            mont += 5 * edad + 2 * adiv;
            lblresult.Text= "el premio es: " + mont;
        }
    }
}