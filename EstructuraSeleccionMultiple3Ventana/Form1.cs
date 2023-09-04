namespace EstructuraSeleccionMultiple3Ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtedad.Text);
            int aciertos = int.Parse(txtaciertos.Text);

            int ganancia = 0;
            if (edad >= 18)
            {
                if (edad < 3)
                {

                    ganancia = 30;
                }
                else
                {
                    ganancia = 50;

                }



            }
            else
            {
                if (edad < 3)
                {
                    ganancia = 50;

                }
                else
                {
                    ganancia = 80;
                }
            }
            float extra = (edad * 5) + (aciertos * 2);

            float total = ganancia + extra;

            lblresultado.Text = "El extra es : " + extra +

             "\nEl monto total del ganador es: " + total;
        }
    }
}