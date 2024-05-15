using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLS_Daniel_Mugueta;
using CLS_Leandro_Varas;
using CLS_Juan_Paredes;

namespace SDS1F_Grup_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circuitosYCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.frm_lista form = new frm_lista();
            form.Show();
        }

        private void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Juan_Paredes.frmLlista form = new frmLlista();
            form.Show();
        }

        private void perfilPilotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmLista form = new FrmLista();
            form.Show();
        }
    }
}
