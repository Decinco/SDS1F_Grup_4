﻿using System;
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
    public partial class frm_Mantenimiento : Form
    {
        public frm_Mantenimiento()
        {
            InitializeComponent();
        }

        private void frm_Mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1_Paredes1.TipusIncidencia' Puede moverla o quitarla según sea necesario.
            this.tipusIncidenciaTableAdapter.Fill(this.f1_Paredes1.TipusIncidencia);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
