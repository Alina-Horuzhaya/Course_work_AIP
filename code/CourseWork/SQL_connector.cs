using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace CourseWork
{
    class SQL_connector
    {
        static string host = "127.0.0.1";
        static int port = 3306;
        static string database = "police_station";
        static string username = "admin";
        static string password = "password";

        String connString = "Server=" + host + ";" + ";port=" + port + ";User Id=" + username + ";password=" + password;
        String connString_with_DB = "Server=" + host + ";" + ";database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
        public SQL_connector()
        {
        }

        public void Get_Connection_First_Time()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `police_station`;";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn = new MySqlConnection(connString_with_DB);
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `staff`(id INTEGER PRIMARY KEY AUTO_INCREMENT, BadgeNumber INT, FullName TEXT, Title TEXT); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Detained_AK_RF`(id INTEGER PRIMARY KEY AUTO_INCREMENT, FullName TEXT, DateOfBirth DATE, Citizenship TEXT, InvolvementOfEarlier BOOLEAN, Details TEXT); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Detained_UK_RF`(id INTEGER PRIMARY KEY AUTO_INCREMENT, FullName TEXT, DateOfBirth DATE, Citizenship TEXT, InvolvementOfEarlier BOOLEAN, Details TEXT); ";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public MySqlConnection Get_Connection_For_Operations()
        {
            return new MySqlConnection(connString_with_DB);
        }
    }
}
