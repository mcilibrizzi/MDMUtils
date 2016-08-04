using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AccountOBJ;


namespace MDMUtils
{
    

    class DBUtils
    {
        private string DBNAME = "mdmdb";
        private string DBSERVER = "localhost";
        private string USERID = "root";
        private string PASSWORD = "wesley";
        private uint PORT = 3306; 

        private MySqlConnection dbConnection;

        public DBUtils()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = this.DBSERVER;
            builder.Port = this.PORT;
            builder.UserID = this.USERID;
            builder.Password = this.PASSWORD;
            builder.Database = this.DBNAME;

            dbConnection = new MySqlConnection(builder.ToString());
        }


        public void closeConnection()
        {
            this.dbConnection.Close();
        }

        public List<Account> searchAccount(string JDA)
        {
            string query = "select clienti.nome AS Cliente , tipologia.tipoaccount AS Tipologia , account.accountAD AS AccountAD from tipologia, account, clienti where clienti.idcliente = account.idcliente AND tipologia.idtype = account.idtipologia AND account.JDA = '60120'";

            dbConnection.Open();
            MySqlCommand cmdGetUser = new MySqlCommand(query, dbConnection);

            MySqlDataReader getUserReader = cmdGetUser.ExecuteReader();

            while (getUserReader.Read())
            {
                Console.WriteLine(getUserReader[0] + " " + getUserReader[1] + " " + getUserReader [2]);
            }

            getUserReader.Close();

            return null;
        }
    }
}
