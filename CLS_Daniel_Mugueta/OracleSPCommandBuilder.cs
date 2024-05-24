using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace CLS_Daniel_Mugueta
{
    class OracleSPCommandBuilder
    {
        private OracleConnection connection;

        public OracleConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }


        private OracleCommand resultingCommand;

        public OracleCommand ResultingCommand
        {
            get { return resultingCommand; }
            set { resultingCommand = value; }
        }

        private string returnValue;

        public string ReturnValue
        {
            get { return returnValue; }
            set { returnValue = value; }
        }

        public OracleSPCommandBuilder(string command, string connectionString, OracleDbType retvaltype, bool execute = false)
        {
            bool isFunction = true;

            Connection = new OracleConnection(connectionString);
            CreateCommand(command);
            FindParameters(command, retvaltype);
            if (execute)
            {
                ExecuteCommand(isFunction);
            }
        }

        public OracleSPCommandBuilder(string command, string connectionString, bool execute = false)
        {
            bool isFunction = false;

            Connection = new OracleConnection(connectionString);
            CreateCommand(command);
            FindParameters(command);
            if (execute)
            {
                ExecuteCommand(isFunction);
            }
        }

        private void CreateCommand(string command)
        {
            ResultingCommand = new OracleCommand();
            ResultingCommand.CommandType = CommandType.StoredProcedure;
            ResultingCommand.CommandText = FindCommand(command);
            ResultingCommand.Connection = Connection;
        }

        private string FindCommand(string command)
        {
            string commandName;

            Regex rgx = new Regex(@"(.+)[(].*");
            Match commandstring = rgx.Match(command);
            commandName = rgx.Replace(commandstring.Value, "$+");

            return commandName;

        }

        private void FindParameters(string command, OracleDbType retvaltype)
        {
            OracleParameter newParameter;
            string parameterstring;
            string[] parameterList;
            string[] parameterSettings;

            Regex rgx = new Regex(@".+[(](.*)[)]");
            Match mParameterString = rgx.Match(command);
            parameterstring = rgx.Replace(mParameterString.Value, "$+");

            parameterList = parameterstring.Split(',');

            newParameter = new OracleParameter();
            newParameter.OracleDbType = retvaltype;
            newParameter.Direction = ParameterDirection.ReturnValue;

            ResultingCommand.Parameters.Add(newParameter);

            for (int i = 0; i < parameterList.Length; i++)
            {
                parameterSettings = parameterList[i].Split('.');

                newParameter = new OracleParameter();
                newParameter.OracleDbType = (OracleDbType)Enum.Parse(typeof(OracleDbType), parameterSettings[2]);
                newParameter.Direction = GetParamDirection(parameterSettings[1]);

                if (newParameter.Direction != ParameterDirection.Output)
                {
                    newParameter.Value = parameterSettings[0];
                }

                ResultingCommand.Parameters.Add(newParameter);
            }
        }

        private void FindParameters(string command)
        {
            OracleParameter newParameter;
            string parameterstring;
            string[] parameterList;
            string[] parameterSettings;

            Regex rgx = new Regex(@".+[(](.*)[)]");
            Match mParameterString = rgx.Match(command);
            parameterstring = rgx.Replace(mParameterString.Value, "$+");

            parameterList = parameterstring.Split(',');

            for (int i = 0; i < parameterList.Length; i++)
            {
                parameterSettings = parameterList[i].Split('.');

                newParameter = new OracleParameter();
                newParameter.OracleDbType = (OracleDbType)Enum.Parse(typeof(OracleDbType), parameterSettings[2]);
                newParameter.Direction = GetParamDirection(parameterSettings[1]);

                if (newParameter.Direction != ParameterDirection.Output)
                {
                    newParameter.Value = parameterSettings[0];
                }

                ResultingCommand.Parameters.Add(newParameter);
            }
        }

        private ParameterDirection GetParamDirection(string directioncode)
        {
            ParameterDirection direction;

            if (directioncode == "in")
            {
                direction = ParameterDirection.Input;
            }
            else if (directioncode == "out")
            {
                direction = ParameterDirection.Output;
            }
            else
            {
                direction = ParameterDirection.InputOutput;
            }

            return direction;
        }

        public void ExecuteCommand(bool isFunction)
        {
            Connection.Open();
            ResultingCommand.ExecuteScalar();
            Connection.Close();

            if (isFunction)
            {
                ReturnValue = ResultingCommand.Parameters[0].Value.ToString();
            }
        }

    }
}
