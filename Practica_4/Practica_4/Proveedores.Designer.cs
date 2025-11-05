namespace Practica_4
{
    partial class Proveedores
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
            dgProveedores = new DataGridView();
            groupBox4 = new GroupBox();
            btnCargar = new Button();
            groupBox3 = new GroupBox();
            txtProveedorActualizado = new TextBox();
            textCorreoElectronicoActualizado = new TextBox();
            textTelefonoActualizado = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnActualizar = new Button();
            txtProveedorIDActualizado = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtID = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            textNombreProveedor = new TextBox();
            textCorreoElectronico = new TextBox();
            textTelefono = new TextBox();
            textNombreProveedo = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProveedores).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgProveedores
            // 
            dgProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProveedores.Location = new Point(41, 462);
            dgProveedores.Name = "dgProveedores";
            dgProveedores.RowHeadersWidth = 51;
            dgProveedores.Size = new Size(1198, 191);
            dgProveedores.TabIndex = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCargar);
            groupBox4.Location = new Point(402, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 77);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Agregar";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(txtProveedorActualizado);
            groupBox3.Controls.Add(textCorreoElectronicoActualizado);
            groupBox3.Controls.Add(textTelefonoActualizado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(txtProveedorIDActualizado);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(857, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(510, 323);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // txtProveedorActualizado
            // 
            txtProveedorActualizado.Location = new Point(326, 126);
            txtProveedorActualizado.Name = "txtProveedorActualizado";
            txtProveedorActualizado.Size = new Size(125, 27);
            txtProveedorActualizado.TabIndex = 21;
            // 
            // textCorreoElectronicoActualizado
            // 
            textCorreoElectronicoActualizado.Location = new Point(12, 235);
            textCorreoElectronicoActualizado.Name = "textCorreoElectronicoActualizado";
            textCorreoElectronicoActualizado.Size = new Size(218, 27);
            textCorreoElectronicoActualizado.TabIndex = 22;
            // 
            // textTelefonoActualizado
            // 
            textTelefonoActualizado.Location = new Point(316, 222);
            textTelefonoActualizado.Name = "textTelefonoActualizado";
            textTelefonoActualizado.Size = new Size(125, 27);
            textTelefonoActualizado.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 195);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 19;
            label7.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 195);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 18;
            label9.Text = "Correo Electronico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(349, 93);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 17;
            label10.Text = "Nombre Proveedor";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(194, 282);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 36);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // txtProveedorIDActualizado
            // 
            txtProveedorIDActualizado.Location = new Point(12, 96);
            txtProveedorIDActualizado.Name = "txtProveedorIDActualizado";
            txtProveedorIDActualizado.Size = new Size(125, 27);
            txtProveedorIDActualizado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 73);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 5;
            label6.Text = "ID Proveedores";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(501, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 168);
            groupBox2.TabIndex = 7;
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
            btnEliminar.Click += btnEliminar_Click_1;
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
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "ID Provedor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(textNombreProveedor);
            groupBox1.Controls.Add(textCorreoElectronico);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textNombreProveedo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(-1, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 306);
            groupBox1.TabIndex = 6;
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
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // textNombreProveedor
            // 
            textNombreProveedor.Location = new Point(320, 86);
            textNombreProveedor.Name = "textNombreProveedor";
            textNombreProveedor.Size = new Size(125, 27);
            textNombreProveedor.TabIndex = 8;
            // 
            // textCorreoElectronico
            // 
            textCorreoElectronico.Location = new Point(6, 195);
            textCorreoElectronico.Name = "textCorreoElectronico";
            textCorreoElectronico.Size = new Size(218, 27);
            textCorreoElectronico.TabIndex = 9;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(310, 182);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(125, 27);
            textTelefono.TabIndex = 10;
            // 
            // textNombreProveedo
            // 
            textNombreProveedo.Location = new Point(15, 76);
            textNombreProveedo.Name = "textNombreProveedo";
            textNombreProveedo.Size = new Size(125, 27);
            textNombreProveedo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 155);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "ID Proveedores";
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
            label2.Size = new Size(136, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre Proveedor";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 763);
            Controls.Add(dgProveedores);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgProveedores).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProveedores;
        private GroupBox groupBox4;
        private Button btnCargar;
        private GroupBox groupBox3;
        private Button btnActualizar;
        private TextBox txtProveedorIDActualizado;
        private Label label6;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtID;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox textNombreProveedor;
        private TextBox textCorreoElectronico;
        private TextBox textTelefono;
        private TextBox textNombreProveedo;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtProveedorActualizado;
        private TextBox textCorreoElectronicoActualizado;
        private TextBox textTelefonoActualizado;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}