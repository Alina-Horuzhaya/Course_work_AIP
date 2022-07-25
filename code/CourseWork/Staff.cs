using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CourseWork
{
    public partial class Staff : Form
    {
        SQL_connector connector;
        public Staff()
        {
            InitializeComponent();
            connector = new SQL_connector();
            connector.Get_Connection_First_Time();
            LoadData();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();
                string query = "SELECT * FROM staff ORDER BY id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = conn;
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (rdr.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = rdr[0].ToString();  //прочитываем 0 столбец
                    data[data.Count - 1][1] = rdr[1].ToString(); //прочитываем 1 столбец
                    data[data.Count - 1][2] = rdr[2].ToString();  //прочитываем 2 столбец
                    data[data.Count - 1][3] = rdr[3].ToString();  //прочитываем 3 столбец
                }
                rdr.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода данных", "Ошибка");
            }
            
        }
               
    }
}
