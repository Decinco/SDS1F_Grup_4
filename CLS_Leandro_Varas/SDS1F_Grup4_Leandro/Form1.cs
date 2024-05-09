using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLS_Leandro_Varas;

namespace SDS1F_Grup4_Leandro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dghToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista frm_lista = new frm_lista();
            frm_lista.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mantenimiento frm_mantenimiento = new frm_mantenimiento();
            frm_mantenimiento.Show();
        }

        private void oracleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oracle oracle = new oracle();
            oracle.Show();
        }
    }
}
