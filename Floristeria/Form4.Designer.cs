namespace Floristeria
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnguardar = new Button();
            btnagregar = new Button();
            txtcliente = new TextBox();
            txtproducto = new TextBox();
            txtcantidad = new TextBox();
            txtfecha = new TextBox();
            dataGridViewDatos = new DataGridView();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnProducto = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            btneliminar = new Button();
            btnactualizar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 3;
            label4.Text = "Fecha";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Lime;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(132, 247);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(106, 23);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Lime;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(12, 247);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(106, 23);
            btnagregar.TabIndex = 5;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(92, 67);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(100, 23);
            txtcliente.TabIndex = 6;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(92, 107);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(100, 23);
            txtproducto.TabIndex = 7;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(92, 151);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 8;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(92, 189);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(100, 23);
            txtfecha.TabIndex = 9;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnCliente, ColumnProducto, ColumnCantidad, ColumnFecha });
            dataGridViewDatos.Location = new Point(260, 62);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(438, 247);
            dataGridViewDatos.TabIndex = 10;
            dataGridViewDatos.CellClick += dataGridViewDatos_CellClick;
            // 
            // ColumnCliente
            // 
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            // 
            // ColumnProducto
            // 
            ColumnProducto.HeaderText = "Producto";
            ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(12, 286);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(106, 23);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Lime;
            btnactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(132, 286);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(106, 23);
            btnactualizar.TabIndex = 12;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.af606cbf7f5250a76c9f05ed123b2bf4_planta_de_flores_planas_delicadas_simples1;
            pictureBox2.Location = new Point(1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.af606cbf7f5250a76c9f05ed123b2bf4_planta_de_flores_planas_delicadas_simples1;
            pictureBox1.Location = new Point(1, 320);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(731, 320);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(731, -3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(328, 320);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(401, 320);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 59);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(401, -3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(67, 59);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(328, -3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(67, 59);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 380);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(dataGridViewDatos);
            Controls.Add(txtfecha);
            Controls.Add(txtcantidad);
            Controls.Add(txtproducto);
            Controls.Add(txtcliente);
            Controls.Add(btnagregar);
            Controls.Add(btnguardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Agregar Pedidos";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnguardar;
        private Button btnagregar;
        private TextBox txtcliente;
        private TextBox txtproducto;
        private TextBox txtcantidad;
        private TextBox txtfecha;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnFecha;
        private Button btneliminar;
        private Button btnactualizar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}