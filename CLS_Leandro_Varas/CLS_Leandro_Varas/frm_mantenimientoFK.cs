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
    public partial class frm_mantenimientoFK : Form
    {
        public frm_mantenimientoFK()
        {
            InitializeComponent();
        }

        private void gPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f1_CLS_Leandro);

        }

        private void frm_mantenimientoFK_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.Circuits' Puede moverla o quitarla según sea necesario.
            this.circuitsTableAdapter.Fill(this.f1_CLS_Leandro.Circuits);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.GP' Puede moverla o quitarla según sea necesario.
            this.gPTableAdapter.Fill(this.f1_CLS_Leandro.GP);

        }

        private void descGPLabel_Click(object sender, EventArgs e)
        {

        }

        private void descGPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
