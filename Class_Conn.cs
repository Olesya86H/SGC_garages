using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SGC_garages
{
    class Class_Conn
    {
        const string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;";
        public NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
        public void Open()
        {
            npgSqlConnection.Open();            
        }

        public void Close()
        {
            npgSqlConnection.Close();
        }

        public void ExecProc(string comm)
        {
            this.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(comm);
            npgSqlCommand.ExecuteNonQuery();
            this.Close();
        }
        public string ExecSQLStr(string comm)
        {
            string ls_result;
            ls_result = "";
            this.Open();            
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(comm, npgSqlConnection);
            ls_result = Convert.ToString(npgSqlCommand.ExecuteScalar());
            this.Close();
            return ls_result;
        }
        public int ExecSQLInt(string comm)
        {
            int li_result;
            li_result = 0;
            this.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(comm, npgSqlConnection);
            li_result = Convert.ToInt32(npgSqlCommand.ExecuteScalar());                         
            this.Close();
            return li_result;
        }
        public Array ExecSQLArray(string comm)
        {
            Array ll_result;
            ll_result = null;
            this.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(comm, npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                ll_result = null;
            }
            this.Close();
            return ll_result;
        }

        public string neither_quoke(string str) //функция определяет, нужна ли кавычка при формировании и передаче запроса в СУБД
        {
            string str_result;
            if (str != "null")
                str_result = "'" + str + "'";
            else
                str_result = "null";
            return str_result;
        }

    }
}
