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

        private void frmMantenimiento_FK_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_Paredes1.TipusIncidencia' Puede moverla o quitarla según sea necesario.
            this.tipusIncidenciaTableAdapter.Fill(this.f1_Paredes1.TipusIncidencia);
            // TODO: esta línea de código carga datos en la tabla 'f1_Paredes1.Incidencies' Puede moverla o quitarla según sea necesario.
            this.incidenciesTableAdapter.Fill(this.f1_Paredes1.Incidencies);

        }

        private void id_Incidencias_TextChanged(object sender, EventArgs e)
        {
            if (id_Incidencias.Text != "")
            {
                cmb_descIncidencias.SelectedValue = id_Incidencias.Text;
                BSIncidencias.EndEdit();
            }
        }

        private void cmb_descIncidencias_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_descIncidencias.SelectedValue != null)
            {
                id_Incidencias.Text = cmb_descIncidencias.SelectedValue.ToString();
                BSIncidencias.EndEdit();
            }
        }

        private void GuardarYCerrar_Click(object sender, EventArgs e)
        {
            this.Validate();
            BSTiposIncidencias.EndEdit();
            incidenciesTableAdapter.Update(f1_Paredes1.Incidencies);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool dt_incidencias;

            dt_incidencias = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "";

            if (e.ColumnIndex == 1 && dt_incidencias)
            {
                F1_Paredes.TipusIncidenciaRow fila;

                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                fila = f1_Paredes1.TipusIncidencia.FindByidTipusIncidencia(int.Parse(id));

                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fila.DescTipusIncidencia;

                BSIncidencias.EndEdit();
            }
        }
    }
}
