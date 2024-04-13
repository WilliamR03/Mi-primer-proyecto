using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnagregarclientes_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void btnagregarpedidos_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
        }

        private void btnagregarvendedor_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
        }

        private void btnagregarproveedor_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }
    }
}
