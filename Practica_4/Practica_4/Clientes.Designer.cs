namespace Practica_4
{
    partial class Clientes
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            textTelefono = new TextBox();
            textCorreoelec = new TextBox();
            textDireccion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtID = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnActualizar = new Button();
            txtIDActualizar = new TextBox();
            textTelefonoActualizado = new TextBox();
            label6 = new Label();
            textCorreoElectronicoActualizado = new TextBox();
            txtNombreActualizado = new TextBox();
            textDireccionActualizado = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCargar = new Button();
            groupBox4 = new GroupBox();
            dgClientes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textCorreoelec);
            groupBox1.Controls.Add(textDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(178, 246);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 36);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(320, 86);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(125, 27);
            textTelefono.TabIndex = 8;
            // 
            // textCorreoelec
            // 
            textCorreoelec.Location = new Point(6, 195);
            textCorreoelec.Name = "textCorreoelec";
            textCorreoelec.Size = new Size(218, 27);
            textCorreoelec.TabIndex = 9;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(310, 182);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(125, 27);
            textDireccion.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 155);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Dirrecion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 155);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 5;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Telefono";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(515, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 168);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(64, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 36);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(64, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 23);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "ID Cliente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(txtIDActualizar);
            groupBox3.Controls.Add(textTelefonoActualizado);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textCorreoElectronicoActualizado);
            groupBox3.Controls.Add(txtNombreActualizado);
            groupBox3.Controls.Add(textDireccionActualizado);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(871, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(510, 323);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(194, 282);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 36);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtIDActualizar
            // 
            txtIDActualizar.Location = new Point(6, 46);
            txtIDActualizar.Name = "txtIDActualizar";
            txtIDActualizar.Size = new Size(125, 27);
            txtIDActualizar.TabIndex = 9;
            // 
            // textTelefonoActualizado
            // 
            textTelefonoActualizado.Location = new Point(336, 122);
            textTelefonoActualizado.Name = "textTelefonoActualizado";
            textTelefonoActualizado.Size = new Size(125, 27);
            textTelefonoActualizado.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "ID Cliente";
            // 
            // textCorreoElectronicoActualizado
            // 
            textCorreoElectronicoActualizado.Location = new Point(22, 231);
            textCorreoElectronicoActualizado.Name = "textCorreoElectronicoActualizado";
            textCorreoElectronicoActualizado.Size = new Size(218, 27);
            textCorreoElectronicoActualizado.TabIndex = 18;
            // 
            // txtNombreActualizado
            // 
            txtNombreActualizado.Location = new Point(31, 112);
            txtNombreActualizado.Name = "txtNombreActualizado";
            txtNombreActualizado.Size = new Size(125, 27);
            txtNombreActualizado.TabIndex = 16;
            // 
            // textDireccionActualizado
            // 
            textDireccionActualizado.Location = new Point(326, 218);
            textDireccionActualizado.Name = "textDireccionActualizado";
            textDireccionActualizado.Size = new Size(125, 27);
            textDireccionActualizado.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 89);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 12;
            label10.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 191);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 13;
            label9.Text = "Correo Electronico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 191);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "Dirrecion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 89);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 11;
            label8.Text = "Nombre Completo";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(18, 26);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(379, 29);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click_1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCargar);
            groupBox4.Location = new Point(416, 354);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 77);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Agregar";
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(55, 461);
            dgClientes.Name = "dgClientes";
            dgClientes.RowHeadersWidth = 51;
            dgClientes.Size = new Size(1198, 191);
            dgClientes.TabIndex = 5;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 684);
            Controls.Add(dgClientes);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Clientes";
            Text = "Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textDireccion;
        private TextBox txtNombre;
        private Button btnAgregar;
        private TextBox textTelefono;
        private TextBox textCorreoelec;
        private TextBox txtID;
        private Label label5;
        private Button btnEliminar;
        private TextBox txtIDActualizar;
        private Label label6;
        private Button btnActualizar;
        private TextBox textTelefonoActualizado;
        private TextBox textCorreoElectronicoActualizado;
        private TextBox txtNombreActualizado;
        private TextBox textDireccionActualizado;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label8;
        private Button btnCargar;
        private GroupBox groupBox4;
        private DataGridView dgClientes;
    }
}