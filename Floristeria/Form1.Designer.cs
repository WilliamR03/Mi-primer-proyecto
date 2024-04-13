namespace Floristeria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            btningresar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 85);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(207, 27);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(207, 83);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(100, 23);
            txtcontraseña.TabIndex = 3;
            txtcontraseña.TextChanged += textBox2_TextChanged;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Lime;
            btningresar.Location = new Point(126, 141);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(181, 23);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4d9c0;
            pictureBox1.Location = new Point(362, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hermoso_contorno_logo_con_rosa_flor_para_boutique_o_salon_de_belleza_o_flores_empresa_rosa_vector_logo_ilustracion_el_logotipo_simple_minimo_facil_t_2f4dc85;
            pictureBox2.Location = new Point(2, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(460, 221);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btningresar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private Button btningresar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
