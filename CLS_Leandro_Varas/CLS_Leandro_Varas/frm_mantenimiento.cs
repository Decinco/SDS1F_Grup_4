﻿using System;
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
    public partial class frm_mantenimiento : Form
    {
        public frm_mantenimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro1.Circuits' Puede moverla o quitarla según sea necesario.
            this.CirucitsTableAdapter.Fill(this.f1_CLS_Leandro1.Circuits);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro1.Circuits' Puede moverla o quitarla según sea necesario.
            this.CirucitsTableAdapter.Fill(this.f1_CLS_Leandro1.Circuits);

        }

        private void circuitLabel_Click(object sender, EventArgs e)
        {

        }

        private void circuitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DbCircuits.EndEdit();
            this.CirucitsTableAdapter.Update(f1_CLS_Leandro1);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void select_image_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagen;
            
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    img_pistas.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no se encuentra en la base de datos");
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //string imagen;

            //imagen = DbCircuits.DataSource.ToString();
            //img_pistas.Image = Image.FromFile(imagen);
        }

        private void img_pistas_Click(object sender, EventArgs e)
        {

        }
    }
}
