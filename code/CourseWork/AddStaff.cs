using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class AddStaff : Form
    {
        SQL_connector connector;
        public AddStaff()
        {
            InitializeComponent();
            connector = new SQL_connector();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие окна
        }

        private void Button_AddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(badge_number_box.Text))
            { 
                MessageBox.Show("Поле \"Номер значка\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(fio_box.Text))
            {
                MessageBox.Show("Поле \"ФИО\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return; 
            }

            if (string.IsNullOrWhiteSpace(title_box.Text))
            {
                MessageBox.Show("Поле \"Звание\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO staff(BadgeNumber, FullName, Title) VALUES(@BadgeNumber, @FullName, @Title)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@BadgeNumber", int.Parse(badge_number_box.Text));
                cmd.Parameters.AddWithValue("@FullName", fio_box.Text);
                cmd.Parameters.AddWithValue("@Title", title_box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления нового сотрудника", " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Сотрудник успешно добавлен", "Успешно");
            this.Close();
        }
    }
}
