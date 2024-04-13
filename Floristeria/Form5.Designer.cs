namespace Floristeria
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcedula = new TextBox();
            txttelefono = new TextBox();
            btnagregar = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            btnguardar = new Button();
            dataGridViewDatos = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnCedula = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 204);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(91, 87);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 4;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(91, 123);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 5;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(91, 162);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(100, 23);
            txtcedula.TabIndex = 6;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(91, 201);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(100, 23);
            txttelefono.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Lime;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(12, 239);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(115, 23);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Lime;
            btnactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(151, 281);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(115, 23);
            btnactualizar.TabIndex = 9;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(12, 281);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(115, 23);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Lime;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(151, 239);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(115, 23);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnApellido, ColumnCedula, ColumnTelefono });
            dataGridViewDatos.Location = new Point(272, 82);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(444, 222);
            dataGridViewDatos.TabIndex = 12;
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
            // ColumnCedula
            // 
            ColumnCedula.HeaderText = "Cedula";
            ColumnCedula.Name = "ColumnCedula";
            // 
            // ColumnTelefono
            // 
            ColumnTelefono.HeaderText = "Telefono";
            ColumnTelefono.Name = "ColumnTelefono";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9mt;
            pictureBox1.Location = new Point(739, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9mt;
            pictureBox2.Location = new Point(2, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9mt;
            pictureBox3.Location = new Point(739, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9mt;
            pictureBox4.Location = new Point(2, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(83, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax___copia1;
            pictureBox5.Location = new Point(306, 341);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax1;
            pictureBox6.Location = new Point(412, 341);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax___copia1;
            pictureBox7.Location = new Point(306, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4daax1;
            pictureBox8.Location = new Point(412, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(822, 392);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewDatos);
            Controls.Add(btnguardar);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btnagregar);
            Controls.Add(txttelefono);
            Controls.Add(txtcedula);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Agregar Vendedor";
            Load += Form5_Load;
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
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcedula;
        private TextBox txttelefono;
        private Button btnagregar;
        private Button btnactualizar;
        private Button btneliminar;
        private Button btnguardar;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnCedula;
        private DataGridViewTextBoxColumn ColumnTelefono;
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