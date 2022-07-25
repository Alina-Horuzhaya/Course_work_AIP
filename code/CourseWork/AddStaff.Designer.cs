namespace CourseWork
{
    partial class AddStaff
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
            this.badge_number_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fio_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.title_box = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_AddStaff = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // badge_number_box
            // 
            this.badge_number_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.badge_number_box.Location = new System.Drawing.Point(26, 93);
            this.badge_number_box.Name = "badge_number_box";
            this.badge_number_box.Size = new System.Drawing.Size(231, 27);
            this.badge_number_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите данные о новом сотруднике";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер значка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ФИО:";
            // 
            // fio_box
            // 
            this.fio_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_box.Location = new System.Drawing.Point(26, 176);
            this.fio_box.Name = "fio_box";
            this.fio_box.Size = new System.Drawing.Size(231, 27);
            this.fio_box.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Звание:";
            // 
            // title_box
            // 
            this.title_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_box.Location = new System.Drawing.Point(26, 253);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(231, 27);
            this.title_box.TabIndex = 8;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(239, 352);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 37);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_AddStaff
            // 
            this.button_AddStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_AddStaff.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddStaff.Location = new System.Drawing.Point(384, 352);
            this.button_AddStaff.Name = "button_AddStaff";
            this.button_AddStaff.Size = new System.Drawing.Size(100, 37);
            this.button_AddStaff.TabIndex = 10;
            this.button_AddStaff.Text = "Добавить";
            this.button_AddStaff.UseVisualStyleBackColor = false;
            this.button_AddStaff.Click += new System.EventHandler(this.Button_AddStaff_Click);
            // 
            // AddStaff
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(496, 400);
            this.Controls.Add(this.button_AddStaff);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fio_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.badge_number_box);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(514, 447);
            this.Name = "AddStaff";
            this.Text = "Добавление нового сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox badge_number_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fio_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_AddStaff;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
