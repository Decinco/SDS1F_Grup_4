using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CLS_Leandro_Varas
{
    public partial class frm_mantenimiento : Form
    {
        public frm_mantenimiento()
        {
            InitializeComponent();
        }

        private void frm_mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro1.Circuits' Puede moverla o quitarla según sea necesario.
            this.CirucitsTableAdapter.Fill(this.f1_CLS_Leandro1.Circuits);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DbCircuits.EndEdit();
            this.CirucitsTableAdapter.Update(f1_CLS_Leandro1);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabla_inf_circuits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string imagen, ruta;

            imagen = esquemaCircuitTextBox.Text;
            ruta = "../../imatges/imatges/" + imagen;

            if (imagen == "")
            {
                img_pistas.Image = null;
            }
            else
            {
                img_pistas.Image = Image.FromFile(ruta);
            }
        }
        private void DbCircuits_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            string imagen, ruta;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    img_pistas.Image = Image.FromFile(imagen);

                    ruta = Path.GetFileName(imagen);
                    esquemaCircuitTextBox.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no se encuentra en la base de datos");
            }
        }
    }
}
