namespace Floristeria
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btningresar = new Button();
            btnguardar = new Button();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txttelefono = new TextBox();
            txtproductos = new TextBox();
            dataGridViewDatos = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            ColumnProductos = new DataGridViewTextBoxColumn();
            btneliminar = new Button();
            btnactualizar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Productos";
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Lime;
            btningresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(12, 260);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(121, 23);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Lime;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(165, 260);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(121, 23);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(103, 78);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(103, 126);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 7;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(103, 169);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(100, 23);
            txttelefono.TabIndex = 8;
            // 
            // txtproductos
            // 
            txtproductos.Location = new Point(103, 214);
            txtproductos.Name = "txtproductos";
            txtproductos.Size = new Size(100, 23);
            txtproductos.TabIndex = 9;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnApellido, ColumnTelefono, ColumnProductos });
            dataGridViewDatos.Location = new Point(301, 78);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(437, 249);
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
            // ColumnProductos
            // 
            ColumnProductos.HeaderText = "Productos";
            ColumnProductos.Name = "ColumnProductos";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(12, 304);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(121, 23);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Lime;
            btnactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(165, 304);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(121, 23);
            btnactualizar.TabIndex = 12;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax___copia2;
            pictureBox1.Location = new Point(1, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax___copia2;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(734, 363);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(734, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(86, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(319, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(411, 363);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(411, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(86, 62);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(319, 363);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(86, 62);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(822, 426);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(dataGridViewDatos);
            Controls.Add(txtproductos);
            Controls.Add(txttelefono);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(btnguardar);
            Controls.Add(btningresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btningresar;
        private Button btnguardar;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txttelefono;
        private TextBox txtproductos;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private DataGridViewTextBoxColumn ColumnProductos;
        private Button btneliminar;
        private Button btnactualizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}