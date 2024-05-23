using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CLS_Daniel_Mugueta
{
    public partial class FrmBBDD : Form
    {

        private string connString;

        public string ConnString
        {
            get { return connString; }
            set { connString = value; }
        }



        public FrmBBDD()
        {
            InitializeComponent();

            // Inicializar conexión
            ConnString = @"TNS_ADMIN=C:\Users\danie\Oracle\network\admin;USER ID=F1;PASSWORD=1234;DATA SOURCE=10.0.15.22:1521/XEPDB1;PERSIST SECURITY INFO=True";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBBDD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'f1DataSetOracle_CLSMugueta.PILOTS' Puede moverla o quitarla según sea necesario.
            this.pILOTSTableAdapter.Fill(this.f1DataSetOracle_CLSMugueta.PILOTS);

            imgFerrari = Image.FromFile("..\)
        }

        private void GetValues()
        {
            // Crear Conexión
            OracleConnection dbSource = new OracleConnection(ConnString);

            // Crear comando del cursor
            OracleCommand recValores = new OracleCommand();
            recValores.Connection = dbSource;
            recValores.CommandText = "Resultats_Pilot.Cursor_Pilot";
            recValores.CommandType = CommandType.StoredProcedure;

            // Obtener idPiloto
            OracleParameter idPiloto = new OracleParameter("pilot", OracleDbType.Int32, ParameterDirection.Input);
            idPiloto.Value = cmbPilots.SelectedValue;

            // Añadir parámetros del cursor
            recValores.Parameters.Add(idPiloto);
            recValores.Parameters.Add(new OracleParameter("gp_pilots", OracleDbType.RefCursor, ParameterDirection.Output));


            // Ejecutar comandos y recuperar datos
            try
            {
                using (dbSource)
                {
                    // Datos tabla
                    OracleDataAdapter dta = new OracleDataAdapter(recValores);
                    DataSet pilotsClassificacio = new DataSet();
                    dta.Fill(pilotsClassificacio);
                    dataGridView1.DataSource = pilotsClassificacio.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al obtener las puntuaciones del piloto");
            }

        }

        private void GetPuntTotal()
        {

            string total;

            // Crear Conexión
            OracleConnection dbSource = new OracleConnection(ConnString);

            // Crear comando de la puntuación total
            OracleCommand puntTotal = new OracleCommand();
            puntTotal.Connection = dbSource;
            puntTotal.CommandText = "Resultats_Pilot.Suma_Punts";
            puntTotal.CommandType = CommandType.StoredProcedure;

            // Añadir parámetro de la puntuación total
            puntTotal.Parameters.Add(new OracleParameter("ReturnValue", OracleDbType.Int32, ParameterDirection.ReturnValue));

            // Obtener idPiloto
            OracleParameter idPiloto = new OracleParameter("pilot", OracleDbType.Int32, ParameterDirection.Input);
            idPiloto.Value = cmbPilots.SelectedValue;

            puntTotal.Parameters.Add(idPiloto);

            // Puntos totales
            try
            {
                dbSource.Open();
                puntTotal.ExecuteScalar();
                txtPT.Text = puntTotal.Parameters["ReturnValue"].Value.ToString();
                dbSource.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al obtener los puntos totales del piloto");
            }
            
        }

        private void cmbPilots_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPilots.SelectedValue != null)
            {
                GetValues();
                GetPuntTotal();
            }
        }
    }
}
