﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CLS_Leandro_Varas
{
    public partial class oracle : Form
    {
        private string connectionString = @"TNS_ADMIN=C:\Users\leova\Oracle\network\admin;USER ID=F1;PASSWORD=1234;DATA SOURCE=10.0.15.22:1521/XEPDB1;PERSIST SECURITY INFO=True";

        public oracle()
        {
            InitializeComponent();
        }

        private void gPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f1_CLS_Leandro);

        }

        private void oracle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'oracledb.GP' Puede moverla o quitarla según sea necesario.
            this.gPTableAdapter1.Fill(this.oracledb.GP);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.Pilots' Puede moverla o quitarla según sea necesario.
            this.pilotsTableAdapter.Fill(this.f1_CLS_Leandro.Pilots);
            // TODO: esta línea de código carga datos en la tabla 'f1_CLS_Leandro.GP' Puede moverla o quitarla según sea necesario.
            this.gPTableAdapter.Fill(this.f1_CLS_Leandro.GP);
        }

        private void descGPLabel_Click(object sender, EventArgs e)
        {

        }
        private void Resultados_Click(object sender, EventArgs e)
        {
            int pgSeleccionada;
            if (int.TryParse(iDGPTextBox.Text, out pgSeleccionada))
            {
                SetPgSeleccionada(pgSeleccionada);
                MostrarResultados();
                MostrarGanador();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido para pg_seleccionada.");
            }
        }
        private void SetPgSeleccionada(int pgSeleccionada)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("Cursor_gPremi.set_pg_seleccionada", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("p_value", OracleDbType.Int32).Value = pgSeleccionada;
                    command.ExecuteNonQuery();
                }
            }
        }
        private void MostrarResultados()
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("Cursor_gPremi.abrir_cursor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    var refCursor = new OracleParameter("p_cursor", OracleDbType.RefCursor);
                    refCursor.Direction = ParameterDirection.Output;
                    command.Parameters.Add(refCursor);

                    using (var adapter = new OracleDataAdapter(command))
                    {
                        DataSet dataTable = new DataSet();
                        adapter.Fill(dataTable);
                        puestos_gp.DataSource = dataTable.Tables[0];
                    }
                }
            }
        }
        private void MostrarGanador()
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("Cursor_gPremi.mostrar_ganador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetro de salida para el nombre del ganador
                    OracleParameter outParameter = new OracleParameter();
                    outParameter.ParameterName = "v_name";
                    outParameter.OracleDbType = OracleDbType.Varchar2;
                    outParameter.Direction = ParameterDirection.Output;
                    outParameter.Size = 255; // Tamaño máximo del nombre del piloto
                    command.Parameters.Add(outParameter);

                    command.ExecuteNonQuery();

                    // Obtener el nombre del ganador del parámetro de salida
                    string nombreGanador = outParameter.Value.ToString();

                    // Mostrar el nombre del ganador en la TextBox
                    Ganador.Text = nombreGanador;
                }
            }
        }
    }
}
