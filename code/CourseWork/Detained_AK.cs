using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;


namespace CourseWork
{
    public partial class Detained_AK : Form
    {
        SQL_connector connector;
        List<string[]> data;

        public Detained_AK()
        {
            InitializeComponent();
            connector = new SQL_connector();
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
                string query = "SELECT * FROM detained_ak_rf ORDER BY id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = conn;
                MySqlDataReader rdr = cmd.ExecuteReader();

                data = new List<string[]>();

                while (rdr.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = rdr[0].ToString(); //ID
                    data[data.Count - 1][1] = rdr[1].ToString(); //FullName
                    data[data.Count - 1][2] = changeDataOfBirth(rdr[2].ToString()); //DateOfBirth
                    data[data.Count - 1][3] = rdr[3].ToString(); //Citizenship
                    data[data.Count - 1][4] = rdr[4].ToString(); //Involment
                    data[data.Count - 1][5] = rdr[5].ToString(); //Details
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

        private string changeDataOfBirth(string value)
        {
            return value.Split(' ')[0];
        }

        private void button_Export_Excele_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Задержанные_АК";
            app.Columns.ColumnWidth = 20;

            for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Отчёт по АК";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
