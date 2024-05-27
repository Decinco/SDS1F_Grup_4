using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLS_Juan_Paredes
{
    public partial class frmMantenimiento_FK : Form
    {
        public frmMantenimiento_FK()
        {
            InitializeComponent();
        }

        private void frmOracle_FK_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_Paredes1.DetallsIncidencies' Puede moverla o quitarla según sea necesario.
            this.detallsIncidenciesTableAdapter.Fill(this.f1_Paredes1.DetallsIncidencies);
            // TODO: esta línea de código carga datos en la tabla 'f1_Paredes1.Incidencies' Puede moverla o quitarla según sea necesario.
            this.incidenciesTableAdapter.Fill(this.f1_Paredes1.Incidencies);

        }
    }
}
