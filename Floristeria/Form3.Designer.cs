namespace Floristeria
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnombre = new TextBox();
            txttelefono = new TextBox();
            txtapellido = new TextBox();
            btnagregar = new Button();
            btnguardar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            dataGridViewDatos = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 163);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(110, 78);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(139, 23);
            txtnombre.TabIndex = 3;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(110, 160);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(139, 23);
            txttelefono.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(110, 119);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(139, 23);
            txtapellido.TabIndex = 3;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Lime;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(12, 204);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(120, 23);
            btnagregar.TabIndex = 6;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Lime;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(153, 204);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(117, 23);
            btnguardar.TabIndex = 7;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(12, 244);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(120, 23);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Lime;
            btnactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(153, 244);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(117, 23);
            btnactualizar.TabIndex = 9;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnApellido, ColumnTelefono });
            dataGridViewDatos.Location = new Point(276, 68);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(345, 214);
            dataGridViewDatos.TabIndex = 10;
            dataGridViewDatos.CellClick += dataGridViewDatos_CellClick;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            ColumnApellido.HeaderText = "Apellido";
            ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnTelefono
            // 
            ColumnTelefono.HeaderText = "Telefono";
            ColumnTelefono.Name = "ColumnTelefono";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9c0___copia;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9c0___copia;
            pictureBox2.Location = new Point(0, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(642, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(642, 286);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(73, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(714, 349);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewDatos);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnguardar);
            Controls.Add(btnagregar);
            Controls.Add(txttelefono);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Agregar Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txttelefono;
        private TextBox txtapellido;
        private Button btnagregar;
        private Button btnguardar;
        private Button btneliminar;
        private Button btnactualizar;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}