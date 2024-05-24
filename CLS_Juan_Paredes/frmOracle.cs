using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace CLS_Juan_Paredes
{
    public partial class frmOracle : Form
    {
        public frmOracle()
        {
            InitializeComponent();
        }

        private void frmOracle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'oracle_dataSet1.PILOTS' Puede moverla o quitarla según sea necesario.
            this.pILOTSTableAdapter.Fill(this.oracle_dataSet1.PILOTS);

        }

        private void nombres_pilots_Click(object sender, EventArgs e)
        {

        }

        private void nombres_pilots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String CadenaConnexio = "USER ID = F1; PASSWORD = 1234; DATA SOURCE = 10.0.15.22:1521 / XEPDB1; PERSIST SECURITY INFO = True";
            OracleConnection cnn = new OracleConnection(CadenaConnexio);
            OracleCommand command = new OracleCommand();
            command.Connection = cnn;
            command.CommandText = "INCIDENCIES_PILOTS.PR_MOSTRARPILOT";
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter id_pilot = new OracleParameter("id_pilot", OracleDbType.Int32, ParameterDirection.Input);
            OracleParameter cur_pilot = new OracleParameter("cur_pilot", OracleDbType.RefCursor, ParameterDirection.Output);

            id_pilot.Value = nombres_pilots.SelectedValue;

            command.Parameters.Add(id_pilot);
            command.Parameters.Add(cur_pilot);
            cnn.Open();
            OracleDataAdapter dta = new OracleDataAdapter(command);

            DataSet dts = new DataSet();
            dta.Fill(dts);

            cnn.Close();

            dataGridView1.DataSource = dts.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CadenaConnexio = "USER ID = F1; PASSWORD = 1234; DATA SOURCE = 10.0.15.22:1521 / XEPDB1; PERSIST SECURITY INFO = True";
            OracleConnection cnn = new OracleConnection(CadenaConnexio);
            OracleCommand command = new OracleCommand();
            command.Connection = cnn;
            command.CommandText = "INCIDENCIES_PILOTS.SUM_PUNTS";
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter punts_sancio = new OracleParameter("v_total_punts", OracleDbType.Int16, ParameterDirection.ReturnValue);
            OracleParameter id_pilot = new OracleParameter("id_pilot", OracleDbType.Int16, ParameterDirection.Input);

            id_pilot.Value = nombres_pilots.SelectedValue;

            command.Parameters.Add(punts_sancio);
            command.Parameters.Add(id_pilot);

            cnn.Open();
            command.ExecuteScalar();

            string texto = command.Parameters["v_total_punts"].Value.ToString();
            cnn.Close();

            textBox1.Text = texto;
        }
    }
}
