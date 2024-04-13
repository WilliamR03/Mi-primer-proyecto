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
    public partial class Form4 : Form
    {
        int poc;
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=WILLIAM\\MSSQLSERVER2;Initial Catalog=Floreria;Integrated Security=True;");

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert into Pedidos values(@Cliente, @Producto, @Cantidad, @Fecha)", conexion);
            conexion.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridViewDatos.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@Cliente", Convert.ToString(row.Cells["ColumnCliente"].Value));
                    agregar.Parameters.AddWithValue("@Producto", Convert.ToString(row.Cells["ColumnProducto"].Value));
                    agregar.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["ColumnCantidad"].Value));
                    agregar.Parameters.AddWithValue("@Fecha", Convert.ToString(row.Cells["ColumnFecha"].Value));

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

            dataGridViewDatos.Rows[n].Cells[0].Value = txtcliente.Text;
            dataGridViewDatos.Rows[n].Cells[1].Value = txtproducto.Text;
            dataGridViewDatos.Rows[n].Cells[2].Value = txtcantidad.Text;
            dataGridViewDatos.Rows[n].Cells[3].Value = txtfecha.Text;

            txtcliente.Clear();
            txtproducto.Clear();
            txtcantidad.Clear();
            txtfecha.Clear();
        }

        private void dataGridViewDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridViewDatos.CurrentRow.Index;

            txtcliente.Text = dataGridViewDatos[0, poc].Value.ToString();
            txtproducto.Text = dataGridViewDatos[1, poc].Value.ToString();
            txtcantidad.Text = dataGridViewDatos[2, poc].Value.ToString();
            txtfecha.Text = dataGridViewDatos[3, poc].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos[0, poc].Value = txtcliente.Text;
            dataGridViewDatos[1, poc].Value = txtproducto.Text;
            dataGridViewDatos[2, poc].Value = txtcantidad.Text;
            dataGridViewDatos[3, poc].Value = txtfecha.Text;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dataGridViewDatos.Rows.RemoveAt(poc);
        }
    }
}
