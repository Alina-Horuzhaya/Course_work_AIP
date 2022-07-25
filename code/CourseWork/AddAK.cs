using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace CourseWork
{
    public partial class AddAK : Form
    {
        SQL_connector connector;
        public AddAK()
        {
            InitializeComponent();
            connector = new SQL_connector();
        }

        private void CheckBox_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Yes.Checked) checkBox_No.Checked = false;      //единственный выбор переключателя
        }

        private void CheckBox_No_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_No.Checked) checkBox_Yes.Checked = false;      //единственный выбор переключателя
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие окна 
        }

        private bool Check_Current_CheckBox()
        {
            bool result = false;
            if (checkBox_Yes.Checked)   //проверка на заполненность чекбокса
            {
                result = true;
            }
            return result;
        }

        private string Get_Correct_Date_Birth()
        {
            string result = "";
            if (Regex.IsMatch(date_of_brith_box.Text, @"[0-9]{4}\-[0-9]{2}\-[0-9]{2}", RegexOptions.IgnoreCase))    //условие для ввода даты
            {
                result = date_of_brith_box.Text;
            }
            return result;
            
        }

        private void Button_Add_Click(object sender, EventArgs e)   //проверка на заполненность всех полей
        {
            if (string.IsNullOrWhiteSpace(fio_box.Text))
            {
                MessageBox.Show("Поле \"ФИО\" не заполнено", "Предупреждение");     //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(date_of_brith_box.Text))
            {
                MessageBox.Show("Поле\"Дата рождения\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (Get_Correct_Date_Birth() == "")
            {   
                MessageBox.Show("Некорректно введена дата ( корректно:ГГГГ-ММ-ДД) ", "Предупреждение"); //предупреждение о некорректно введенем формате даты
                return;
            }

            if (string.IsNullOrWhiteSpace(zenship_box.Text))
            {
                MessageBox.Show("Поле\"Гражданство\" не заполнено", "Предупреждение");  //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(details_case_box.Text))
            {
                MessageBox.Show("Поле\"Детали дела\" не заполнено", "Предупреждение");  //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations(); //открываем соединение
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(); //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Detained_AK_RF(FullName, DateOfBirth, Citizenship, InvolvementOfEarlier, Details) VALUES (@FullName, @DateOfBirth, @Citizenship, @InvolvementOfEarlier, @Details)";
                cmd.Parameters.AddWithValue("@FullName", fio_box.Text); //передаем параметр ФИО
                cmd.Parameters.AddWithValue("@DateOfBirth", date_of_brith_box.Text);    //передаем параметр дата рождения
                cmd.Parameters.AddWithValue("@Citizenship", zenship_box.Text);  //передаем параметр гражданство
                if (Check_Current_CheckBox()) 
                {
                    cmd.Parameters.AddWithValue("@InvolvementOfEarlier", 1);    //вывод 1 при нажатии на "ДА"
                }  
                else {
                    cmd.Parameters.AddWithValue("@InvolvementOfEarlier",0); //вывод 0 при нажатии на "НЕТ"
                }
                cmd.Parameters.AddWithValue("@Details", details_case_box.Text);
                cmd.ExecuteNonQuery();

                conn.Close(); //передаем данные и закрываем соединение
                MessageBox.Show("Задержанный добавлен", "Успешно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления нового задержанного", " Ошибка "); //сообщение о результате 
            }
            
          
        }
    }
}
