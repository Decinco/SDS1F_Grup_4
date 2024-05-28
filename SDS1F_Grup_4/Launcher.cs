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

            form.MdiParent = this;
            form.Show();
        }

        private void escuderíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmMantenimiento form = new FrmMantenimiento();
            form.MdiParent = this;
            form.Show();
        }

        private void pilotosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmMantenimientoFK form = new FrmMantenimientoFK();
            form.MdiParent = this;
            form.Show();
        }

        private void análisisClasificaciónPorPilotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Daniel_Mugueta.FrmBBDD form = new FrmBBDD();
            form.MdiParent = this;
            form.Show();
        }

        private void informeClasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Juan_Paredes.frmLlista1 form = new frmLlista1();
            form.MdiParent = this;
            form.Show();
        }

        private void tiposIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Juan_Paredes.frm_Mantenimiento form = new frm_Mantenimiento();
            form.MdiParent = this;
            form.Show();
        }

        private void incidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Juan_Paredes.frmMantenimiento_FK form = new frmMantenimiento_FK();
            form.MdiParent = this;
            form.Show();
        }

        private void incidenciasDeUnPilotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Juan_Paredes.frmOracle form = new frmOracle();
            form.MdiParent = this;
            form.Show();
        }

        private void informeCircuitosYGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.frm_lista form = new frm_lista();
            form.MdiParent = this;
            form.Show();
        }

        private void circuitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.frm_mantenimiento form = new frm_mantenimiento();
            form.MdiParent = this;
            form.Show();
        }

        private void gPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.frm_mantenimientoFK form = new frm_mantenimientoFK();
            form.MdiParent = this;
            form.Show();
        }

        private void resultadosGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLS_Leandro_Varas.oracle form = new oracle();
            form.MdiParent = this;
            form.Show();
        }
    }
}
