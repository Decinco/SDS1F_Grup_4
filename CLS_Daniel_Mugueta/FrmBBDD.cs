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
        private OracleConnection dbSource;

        public OracleConnection DBSource
        {
            get { return dbSource; }
            set { dbSource = value; }
        }


        public FrmBBDD()
        {
            InitializeComponent();

            // Inicializar conexión
            string conexion = @"TNS_ADMIN=C:\Users\danie\Oracle\network\admin;USER ID=F1;PASSWORD=1234;DATA SOURCE=10.0.15.22:1521/XEPDB1;PERSIST SECURITY INFO=True";
            DBSource = new OracleConnection(conexion);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBBDD_Load(object sender, EventArgs e)
        {

        }

        private void GetValues()
        {
            // Crear comando
            OracleCommand recValores = new OracleCommand();
            recValores.Connection = DBSource;
            recValores.CommandText = "Resultats_Pilot.Cursor_Pilot";
            recValores.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros
            OracleParameter idPiloto = new OracleParameter();
            idPiloto.Direction = ParameterDirection.Input;
            idPiloto.Value = cmbPilots.SelectedValue;
            recValores.Parameters.Add(idPiloto);

            // Añadir Return
            OracleParameter cursor = new OracleParameter("cursor_classificacio", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
            recValores.Parameters.Add(cursor);

            // Ejecutar comando y recuperar datos
            using (DBSource)
            {
                OracleDataAdapter dta = new OracleDataAdapter(recValores);
                DataSet pilotsClassificacio = new DataSet();
                dta.Fill(pilotsClassificacio);
                dataGridView1.DataSource = pilotsClassificacio.Tables;
            }            

        }

        private void cmbPilots_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPilots.SelectedValue != null)
            {
                GetValues();
            }
        }
    }
}
