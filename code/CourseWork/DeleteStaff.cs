using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
        }

        private void Button_cencele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number_box.Text))
            {
                string message = "Поле \"Номер значка\" не заполнено";
                string title = "Предупреждение";
                MessageBox.Show(message, title);
                return;
            }
        }
    }
}
