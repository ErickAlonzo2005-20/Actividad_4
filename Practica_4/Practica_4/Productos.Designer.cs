namespace Practica_4
{
    partial class Productos
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
            dgProductos = new DataGridView();
            groupBox4 = new GroupBox();
            btnCargar = new Button();
            groupBox3 = new GroupBox();
            txtCategoriaIDActualizado = new TextBox();
            label7 = new Label();
            txtDescripcionActualizada = new TextBox();
            txtPrecioActualizado = new TextBox();
            txtStockActualizado = new TextBox();
            txtNombreProductoActualizado = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            btnActualizar = new Button();
            txtIDProductoActualizar = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtIDProducto = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtCategoriaID = new TextBox();
            btnAgregar = new Button();
            label11 = new Label();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(48, 463);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersWidth = 51;
            dgProductos.Size = new Size(1198, 191);
            dgProductos.TabIndex = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCargar);
            groupBox4.Location = new Point(409, 356);
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
            btnCargar.Click += btnCargar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCategoriaIDActualizado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDescripcionActualizada);
            groupBox3.Controls.Add(txtPrecioActualizado);
            groupBox3.Controls.Add(txtStockActualizado);
            groupBox3.Controls.Add(txtNombreProductoActualizado);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(txtIDProductoActualizar);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(864, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(510, 323);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // txtCategoriaIDActualizado
            // 
            txtCategoriaIDActualizado.Location = new Point(211, 165);
            txtCategoriaIDActualizado.Name = "txtCategoriaIDActualizado";
            txtCategoriaIDActualizado.Size = new Size(125, 27);
            txtCategoriaIDActualizado.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 138);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 24;
            label7.Text = "Categoria ID";
            // 
            // txtDescripcionActualizada
            // 
            txtDescripcionActualizada.Location = new Point(357, 99);
            txtDescripcionActualizada.Name = "txtDescripcionActualizada";
            txtDescripcionActualizada.Size = new Size(125, 27);
            txtDescripcionActualizada.TabIndex = 21;
            // 
            // txtPrecioActualizado
            // 
            txtPrecioActualizado.Location = new Point(29, 230);
            txtPrecioActualizado.Name = "txtPrecioActualizado";
            txtPrecioActualizado.Size = new Size(218, 27);
            txtPrecioActualizado.TabIndex = 22;
            // 
            // txtStockActualizado
            // 
            txtStockActualizado.Location = new Point(347, 195);
            txtStockActualizado.Name = "txtStockActualizado";
            txtStockActualizado.Size = new Size(125, 27);
            txtStockActualizado.TabIndex = 23;
            // 
            // txtNombreProductoActualizado
            // 
            txtNombreProductoActualizado.Location = new Point(38, 111);
            txtNombreProductoActualizado.Name = "txtNombreProductoActualizado";
            txtNombreProductoActualizado.Size = new Size(125, 27);
            txtNombreProductoActualizado.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(367, 168);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 19;
            label8.Text = "Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 88);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 16;
            label9.Text = "Nombre Producto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 190);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 18;
            label10.Text = "Precio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(380, 66);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 17;
            label12.Text = "Descripcion";
            label12.Click += label12_Click;
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
            // txtIDProductoActualizar
            // 
            txtIDProductoActualizar.Location = new Point(6, 46);
            txtIDProductoActualizar.Name = "txtIDProductoActualizar";
            txtIDProductoActualizar.Size = new Size(125, 27);
            txtIDProductoActualizar.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 5;
            label6.Text = "ID Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtIDProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(508, 55);
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
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(64, 55);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 23);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "ID Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoriaID);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 306);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // txtCategoriaID
            // 
            txtCategoriaID.Location = new Point(188, 130);
            txtCategoriaID.Name = "txtCategoriaID";
            txtCategoriaID.Size = new Size(125, 27);
            txtCategoriaID.TabIndex = 12;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(218, 103);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 11;
            label11.Text = "Categoria ID";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(334, 64);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(6, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(218, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(324, 160);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 10;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(15, 76);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 133);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 155);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 31);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 771);
            Controls.Add(dgProductos);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
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

        private DataGridView dgProductos;
        private GroupBox groupBox4;
        private Button btnCargar;
        private GroupBox groupBox3;
        private Button btnActualizar;
        private TextBox txtIDProductoActualizar;
        private Label label6;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtIDProducto;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtCategoriaID;
        private Button btnAgregar;
        private Label label11;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtNombreProducto;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtCategoriaIDActualizado;
        private Label label7;
        private TextBox txtDescripcionActualizada;
        private TextBox txtPrecioActualizado;
        private TextBox txtStockActualizado;
        private TextBox txtNombreProductoActualizado;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
    }
}