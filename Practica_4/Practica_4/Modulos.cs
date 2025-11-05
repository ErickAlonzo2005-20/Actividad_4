using Practica_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.MdiParent = this;
            frm.Show();

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    
}
