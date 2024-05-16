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

            updateImage();

        }


        private void escuderiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateImage();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BsEscuderia.EndEdit();
            this.escuderiesTableAdapter.Update(f1DataSet_CLSMugueta1.Escuderies);

            updateImage();
        }

        private void button1_Click(object sender, EventArgs e) // Importar imagen
        {
            string imagePath, imageFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                imagePath = openFileDialog1.FileName;
                imageFile = Path.GetFileName(imagePath);

                if (!File.Exists($"../Images/{imageFile}"))
                {
                    File.Copy(imagePath, $"../Images/{imageFile}");
                }

                txtLogoPath.Text = imageFile;
            }

            updateImage();
        }

        private void updateImage()
        {
            string image, path;

            image = txtLogoPath.Text;

            path = $"../Images/{image}";

            if (File.Exists(path))
            {
                logoBox.Image = Image.FromFile(path);
            }
            else
            {
                logoBox.Image = Image.FromFile("../Images/default.png");
            }
        }
    }
}
