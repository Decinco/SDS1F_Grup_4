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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void informePerfilPilotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmLista form = new FrmLista();
            form.Show();
        }

        private void escuderíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmMantenimiento form = new FrmMantenimiento();
            form.Show();
        }

        private void pilotosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmMantenimientoFK form = new FrmMantenimientoFK();
            form.Show();
        }

        private void análisisClasificaciónPorPilotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmBBDD form = new FrmBBDD();
            form.Show();
        }
    }
}
