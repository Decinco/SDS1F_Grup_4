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
        private void idCircuitTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                circuitComboBox.SelectedValue = idCircuitTextBox.Text;
                gPBindingSource1.EndEdit();
            }
            catch
            {
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            bool com_cell;

            com_cell = DatosGP_circuit.Rows[e.RowIndex].Cells[4].Value.ToString() != "";
            if (e.ColumnIndex == 5 && com_cell)
            {
                F1_CLS_Leandro.CircuitsRow fila;

                string id = DatosGP_circuit.Rows[e.RowIndex].Cells[4].Value.ToString();

                fila = f1_CLS_Leandro.Circuits.FindByidCircuit(int.Parse(id));

                DatosGP_circuit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fila.Circuit;

                gPBindingSource1.EndEdit();  
            }
        }

        private void circuitComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (circuitComboBox.SelectedValue != null)
                {
                    idCircuitTextBox.Text = circuitComboBox.SelectedValue.ToString();
                    gPBindingSource1.EndEdit();
                }
                
            }
            catch
            {
            }
        }
    }
}
