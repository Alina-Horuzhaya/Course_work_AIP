namespace CourseWork
{
    partial class AddUK
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_of_brith_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zenship_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Yes = new System.Windows.Forms.CheckBox();
            this.checkBox_No = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.details_case_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите полную информацию о задержанном";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО:";
            // 
            // fio_box
            // 
            this.fio_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_box.Location = new System.Drawing.Point(44, 69);
            this.fio_box.Name = "fio_box";
            this.fio_box.Size = new System.Drawing.Size(287, 27);
            this.fio_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата рождения:";
            // 
            // date_of_brith_box
            // 
            this.date_of_brith_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_of_brith_box.Location = new System.Drawing.Point(43, 136);
            this.date_of_brith_box.Name = "date_of_brith_box";
            this.date_of_brith_box.Size = new System.Drawing.Size(287, 27);
            this.date_of_brith_box.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Гражданство:";
            // 
            // zenship_box
            // 
            this.zenship_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zenship_box.Location = new System.Drawing.Point(45, 202);
            this.zenship_box.Name = "zenship_box";
            this.zenship_box.Size = new System.Drawing.Size(287, 27);
            this.zenship_box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Привлечение ранее:";
            // 
            // checkBox_Yes
            // 
            this.checkBox_Yes.AutoSize = true;
            this.checkBox_Yes.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Yes.Location = new System.Drawing.Point(45, 270);
            this.checkBox_Yes.Name = "checkBox_Yes";
            this.checkBox_Yes.Size = new System.Drawing.Size(53, 27);
            this.checkBox_Yes.TabIndex = 10;
            this.checkBox_Yes.Text = "Да";
            this.checkBox_Yes.UseVisualStyleBackColor = true;
            this.checkBox_Yes.CheckedChanged += new System.EventHandler(this.CheckBox_Yes_CheckedChanged);
            // 
            // checkBox_No
            // 
            this.checkBox_No.AutoSize = true;
            this.checkBox_No.Checked = true;
            this.checkBox_No.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_No.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_No.Location = new System.Drawing.Point(148, 270);
            this.checkBox_No.Name = "checkBox_No";
            this.checkBox_No.Size = new System.Drawing.Size(61, 27);
            this.checkBox_No.TabIndex = 11;
            this.checkBox_No.Text = "Нет";
            this.checkBox_No.UseVisualStyleBackColor = true;
            this.checkBox_No.CheckedChanged += new System.EventHandler(this.CheckBox_No_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Детали дела:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(218, 474);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(114, 39);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Add.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(370, 474);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(114, 39);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // details_case_box
            // 
            this.details_case_box.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_case_box.Location = new System.Drawing.Point(43, 337);
            this.details_case_box.MaximumSize = new System.Drawing.Size(394, 116);
            this.details_case_box.MinimumSize = new System.Drawing.Size(394, 116);
            this.details_case_box.Name = "details_case_box";
            this.details_case_box.Size = new System.Drawing.Size(394, 116);
            this.details_case_box.TabIndex = 16;
            this.details_case_box.Text = "";
            // 
            // AddUK
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(496, 525);
            this.Controls.Add(this.details_case_box);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_No);
            this.Controls.Add(this.checkBox_Yes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zenship_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_of_brith_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fio_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 572);
            this.MinimumSize = new System.Drawing.Size(514, 572);
            this.Name = "AddUK";
            this.Text = "Добавление задержанного УК";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date_of_brith_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zenship_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Yes;
        private System.Windows.Forms.CheckBox checkBox_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.RichTextBox details_case_box;
    }
}
