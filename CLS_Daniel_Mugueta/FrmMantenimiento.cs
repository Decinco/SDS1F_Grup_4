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
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void circuitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1DataSet_CLSMugueta1.Escuderies' Puede moverla o quitarla según sea necesario.
            this.escuderiesTableAdapter.Fill(this.f1DataSet_CLSMugueta1.Escuderies);

        }

        private void descEscuderiaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void escuderiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BsEscuderia.EndEdit();
            this.escuderiesTableAdapter.Update(f1DataSet_CLSMugueta1.Escuderies);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagen;
            openFileDialog1.ShowDialog();
            imagen = openFileDialog1.FileName;
            Image.FromFile(imagen);
        }
    }
}
