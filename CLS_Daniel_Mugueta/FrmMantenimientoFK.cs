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
            // TODO: esta línea de código carga datos en la tabla 'f1DataSet_CLSMugueta1.Escuderies' Puede moverla o quitarla según sea necesario.
            this.escuderiesTableAdapter.Fill(this.f1DataSet_CLSMugueta1.Escuderies);
            // TODO: esta línea de código carga datos en la tabla 'f1DataSet_CLSMugueta1.Pilots' Puede moverla o quitarla según sea necesario.
            this.pilotsTableAdapter.Fill(this.f1DataSet_CLSMugueta1.Pilots);
        }

        private void cmbEscuderia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbEscuderia.SelectedValue != null)
            {
                txtEscuderia.Text = cmbEscuderia.SelectedValue.ToString();
                BSPilots.EndEdit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BSPilots.EndEdit();
            this.pilotsTableAdapter.Update(f1DataSet_CLSMugueta1.Pilots);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                F1DataSet_CLSMugueta.EscuderiesRow fila;
                string id = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                fila = f1DataSet_CLSMugueta1.Escuderies.FindByidEscuderia(int.Parse(id));

                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fila.DescEscuderia;

                BSPilots.EndEdit();

            }
        }

        private void txtEscuderia_TextChanged(object sender, EventArgs e)
        {
            if (txtEscuderia.Text != "")
            {
                cmbEscuderia.SelectedValue = txtEscuderia.Text;
                BSPilots.EndEdit();
            }
        }
    }
}
