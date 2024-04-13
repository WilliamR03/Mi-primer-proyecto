using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Floristeria
{
    public partial class Form3 : Form
    {
        int poc;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=WILLIAM\\MSSQLSERVER2;Initial Catalog=Floreria;Integrated Security=True;");

        

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert into Clientes values(@Nombre, @Apellido, @Telefono)", conexion);
            conexion.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridViewDatos.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["ColumnNombre"].Value));
                    agregar.Parameters.AddWithValue("@Apellido", Convert.ToString(row.Cells["ColumnApellido"].Value));
                    agregar.Parameters.AddWithValue("@Telefono", Convert.ToString(row.Cells["ColumnTelefono"].Value));

                    agregar.ExecuteNonQuery();
                }

                MessageBox.Show("Datos agregados");
            }

            catch (Exception)
            {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = dataGridViewDatos.Rows.Add();

            dataGridViewDatos.Rows[n].Cells[0].Value = txtnombre.Text;
            dataGridViewDatos.Rows[n].Cells[1].Value = txtapellido.Text;
            dataGridViewDatos.Rows[n].Cells[2].Value = txttelefono.Text;

            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
        }

        private void dataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridViewDatos.CurrentRow.Index;

            txtnombre.Text = dataGridViewDatos[0, poc].Value.ToString();
            txtapellido.Text = dataGridViewDatos[1, poc].Value.ToString();
            txttelefono.Text = dataGridViewDatos[2, poc].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos[0, poc].Value = txtnombre.Text;
            dataGridViewDatos[1, poc].Value = txtapellido.Text;
            dataGridViewDatos[2, poc].Value = txttelefono.Text;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos.Rows.RemoveAt(poc);
        }
    }

}

