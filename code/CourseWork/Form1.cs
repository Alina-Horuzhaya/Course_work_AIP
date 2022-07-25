using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        SQL_connector connector;

        public Form1()
        {
            InitializeComponent();
            connector = new SQL_connector();
            connector.Get_Connection_First_Time();
        }
        

        private void Button_staff_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Staff frm6 = new Staff();
            dr = frm6.ShowDialog();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void Button_AK_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            Detained_AK frm7 = new Detained_AK();
            dr = frm7.ShowDialog();
        }

        private void Button_UK_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Detained_UK frm8 = new Detained_UK();
            dr = frm8.ShowDialog();

        }

        private void Button_add_staff_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddStaff frm2 = new AddStaff();
            dr = frm2.ShowDialog();
            
        }

        private void Button_delete_staff_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            DeleteStaff frm5 = new DeleteStaff();
            dr = frm5.ShowDialog();
        }

        private void Button_add_AK_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddAK frm4 = new AddAK();
            dr = frm4.ShowDialog();
        }

        private void Button_add_UK_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            AddUK frm3 = new AddUK();
            dr = frm3.ShowDialog();
        }
    }
}
