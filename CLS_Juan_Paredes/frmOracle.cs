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
    public partial class frmOracle : Form
    {
        public frmOracle()
        {
            InitializeComponent();
        }

        private void frmOracle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'oracle_dataSet1.PILOTS' Puede moverla o quitarla según sea necesario.
            this.pILOTSTableAdapter.Fill(this.oracle_dataSet1.PILOTS);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
