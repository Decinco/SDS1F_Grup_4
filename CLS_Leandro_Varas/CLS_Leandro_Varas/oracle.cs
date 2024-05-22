using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLS_Leandro_Varas
{
    public partial class oracle : Form
    {
        public oracle()
        {
            InitializeComponent();
        }

        private void gPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f1_CLS_Leandro);

        }

        private void oracle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.ClassificacioGP' Puede moverla o quitarla según sea necesario.
            this.classificacioGPTableAdapter.Fill(this.f1_CLS_Leandro.ClassificacioGP);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.Pilots' Puede moverla o quitarla según sea necesario.
            this.pilotsTableAdapter.Fill(this.f1_CLS_Leandro.Pilots);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.GP' Puede moverla o quitarla según sea necesario.
            this.gPTableAdapter.Fill(this.f1_CLS_Leandro.GP);

        }

        private void descGPLabel_Click(object sender, EventArgs e)
        {

        }

        private void descGPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
