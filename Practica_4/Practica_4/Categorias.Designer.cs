namespace Practica_4
{
    partial class Categorias
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
            dgCategorias = new DataGridView();
            groupBox4 = new GroupBox();
            btnCargar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnActualizar = new Button();
            txtIDActualizar = new TextBox();
            label6 = new Label();
            txtNombreActualizado = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtID = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(109, 547);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.RowHeadersWidth = 51;
            dgCategorias.Size = new Size(1198, 191);
            dgCategorias.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCargar);
            groupBox4.Location = new Point(470, 440);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 77);
            groupBox4.TabIndex = 6;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtNombreCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 306);
            groupBox1.TabIndex = 8;
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
            // txtCategoria
            // 
            txtCategoria.Location = new Point(320, 86);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 8;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(15, 76);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(125, 27);
            txtNombreCategoria.TabIndex = 7;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 53);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "ID Categortia";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(txtIDActualizar);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtNombreActualizado);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(887, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(510, 323);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(194, 187);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 36);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtIDActualizar
            // 
            txtIDActualizar.Location = new Point(78, 135);
            txtIDActualizar.Name = "txtIDActualizar";
            txtIDActualizar.Size = new Size(125, 27);
            txtIDActualizar.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 112);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "ID Categoria";
            // 
            // txtNombreActualizado
            // 
            txtNombreActualizado.Location = new Point(331, 135);
            txtNombreActualizado.Name = "txtNombreActualizado";
            txtNombreActualizado.Size = new Size(125, 27);
            txtNombreActualizado.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 112);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 11;
            label8.Text = "Nombre Completo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(531, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 168);
            groupBox2.TabIndex = 9;
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
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "ID Categoria";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 750);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgCategorias);
            Controls.Add(groupBox4);
            Name = "Categorias";
            Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgCategorias;
        private GroupBox groupBox4;
        private Button btnCargar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtCategoria;
        private TextBox txtNombreCategoria;
        private Label label1;
        private Label label2;
        private GroupBox groupBox3;
        private Button btnActualizar;
        private TextBox txtIDActualizar;
        private Label label6;
        private TextBox txtNombreActualizado;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtID;
        private Label label5;
    }
}