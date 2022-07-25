namespace CourseWork
{
    partial class DeleteStaff
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
            this.button_DeleteStaff = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.number_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер значка сотрудника, данные о котором необходимо удалить из базы";
            // 
            // button_DeleteStaff
            // 
            this.button_DeleteStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_DeleteStaff.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteStaff.Location = new System.Drawing.Point(479, 129);
            this.button_DeleteStaff.Name = "button_DeleteStaff";
            this.button_DeleteStaff.Size = new System.Drawing.Size(114, 39);
            this.button_DeleteStaff.TabIndex = 1;
            this.button_DeleteStaff.Text = "Удалить";
            this.button_DeleteStaff.UseVisualStyleBackColor = false;
            this.button_DeleteStaff.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(315, 129);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(114, 39);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_cencele_Click);
            // 
            // number_box
            // 
            this.number_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_box.Location = new System.Drawing.Point(28, 95);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(219, 27);
            this.number_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер:";
            // 
            // DeleteStaff
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(632, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_box);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_DeleteStaff);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 231);
            this.MinimumSize = new System.Drawing.Size(650, 231);
            this.Name = "DeleteStaff";
            this.Text = "Удаление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteStaff;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox number_box;
        private System.Windows.Forms.Label label2;
    }
}
