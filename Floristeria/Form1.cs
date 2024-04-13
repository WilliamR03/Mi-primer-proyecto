namespace Floristeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            


            string usuario = txtusuario.Text;
            string clave = txtcontraseña.Text;

            if ( usuario == "admin" && clave == "12345678")
            {
                MessageBox.Show("Has iniciado correctamente");
                Form formulario = new Form2();
                formulario.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o clave incorrecta");
            }
        }
    }
}
