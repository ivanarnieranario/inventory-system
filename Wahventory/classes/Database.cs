using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Wahventory.classes;
using Wahventory.Properties;

namespace Wahventory.classes
{
    class Database
    {
        private static string sql;
        private static string[] values;

        public static MySqlConnection getConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(getConnectionString());
                connection.Open();
                connection.Close();
                return connection;
            }
            catch (Exception exception)
            {

                System.Windows.Forms.MessageBox.Show(null, exception.Message, "Connection Failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        private static string getConnectionString()
        {
            return string.Format("Server={0}; Port={1}; Username={2}; Password={3}; Database={4};", Properties.Settings.Default.server, Properties.Settings.Default.port, Properties.Settings.Default.username, Properties.Settings.Default.password, Properties.Settings.Default.database);
        }

        public static void set(string sql, string[] values)
        {
            Database.values = values;
            set(sql);
        }

        public static void set(string sql)
        {
            Database.sql = sql;
        }

        //Compress the parameters
        private static string[] getParametersFromQuery()
        {
            int length = values.Length;
            string sqlTemp = Database.sql;
            string[] parameters = new string[length];

            try
            {
                for (int x = 0; x < length; x++)
                {
                    int startIndex = sqlTemp.IndexOf('@');
                    int endIndex = getEndIndex(sqlTemp, startIndex);
                    parameters[x] = sqlTemp.Substring(startIndex, endIndex - startIndex);
                    sqlTemp = sqlTemp.Substring(endIndex, sqlTemp.Length - endIndex);
                }

            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(null, exception.Message, "Query Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return parameters;
        }

        private static int getEndIndex(string sql, int startIndex)
        {
            string endChar = " ,);";
            int endIndex = -1;
            for (int x = 0; x < endChar.Length; x++)
            {
                endIndex = sql.IndexOf(endChar[x], startIndex);
                if (endIndex != -1)
                    return endIndex;
            }
            return -1;
        }

        //dynamically set the parameters in the command
        private static MySqlCommand setCommands(MySqlCommand command)
        {
            if (!sql.Contains("@"))
                return new MySqlCommand();

            string[] parameters = getParametersFromQuery();
            int counter = -1;
            foreach (string value in values)
            {
                command.Parameters.AddWithValue(parameters[++counter], value);
            }
            return command;
        }

        //NonQuery
        public static Boolean executeNonQuery()
        {
            using (MySqlConnection connection = getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    setCommands(command);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message);
                    return false;
                }
            }
        }

        //table or resultset
        public static System.Data.DataTable executeResultSet()
        {
            using (MySqlConnection connection = getConnection())
            {
                try
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    connection.Open();
                    if(frmHome.LIMIT_RECORD != 0)
                        sql = sql.Insert(sql.Length - 1, " LIMIT " + frmHome.LIMIT_RECORD.ToString());
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    setCommands(command);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);
                    return table;
                }
                catch (MySqlException exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message);
                    return null;
                }
            }
        }

        //getInteger
        public static int executeInteger()
        {
            using (MySqlConnection connection = getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    setCommands(command);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
                catch (MySqlException exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message);
                    return -1;
                }
            }
        }

        //getString
        public static string executeString()
        {
            using (MySqlConnection connection = getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    setCommands(command);
                    return Convert.ToString(command.ExecuteScalar());
                }
                catch (MySqlException exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message);
                    return null;
                }
            }
        }


    }
}
