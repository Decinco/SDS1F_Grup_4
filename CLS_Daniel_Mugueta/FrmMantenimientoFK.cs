using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLS_Daniel_Mugueta
{
    public partial class FrmMantenimientoFK : Form
    {
        public FrmMantenimientoFK()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoFK_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1DataSet_CLSMugueta.Pilots' Puede moverla o quitarla según sea necesario.
            this.pilotsTableAdapter.Fill(this.f1DataSet_CLSMugueta.Pilots);

        }
    }
}
