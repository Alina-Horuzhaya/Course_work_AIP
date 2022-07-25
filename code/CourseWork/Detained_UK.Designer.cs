namespace CourseWork
{
    partial class Detained_UK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.involvement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details_of_the_case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Export_Excele = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(947, 729);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(118, 39);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Назад";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.full_name,
            this.date_of_birth,
            this.citizenship,
            this.involvement,
            this.details_of_the_case});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 711);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // full_name
            // 
            this.full_name.Frozen = true;
            this.full_name.HeaderText = "ФИО";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 150;
            // 
            // date_of_birth
            // 
            this.date_of_birth.Frozen = true;
            this.date_of_birth.HeaderText = "Дата рождения";
            this.date_of_birth.MinimumWidth = 6;
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.ReadOnly = true;
            this.date_of_birth.Width = 92;
            // 
            // citizenship
            // 
            this.citizenship.Frozen = true;
            this.citizenship.HeaderText = "Гражданство ";
            this.citizenship.MinimumWidth = 6;
            this.citizenship.Name = "citizenship";
            this.citizenship.ReadOnly = true;
            this.citizenship.Width = 105;
            // 
            // involvement
            // 
            this.involvement.Frozen = true;
            this.involvement.HeaderText = "Привлечение ранее";
            this.involvement.MinimumWidth = 6;
            this.involvement.Name = "involvement";
            this.involvement.ReadOnly = true;
            this.involvement.Width = 105;
            // 
            // details_of_the_case
            // 
            this.details_of_the_case.Frozen = true;
            this.details_of_the_case.HeaderText = "Детали дела";
            this.details_of_the_case.MinimumWidth = 6;
            this.details_of_the_case.Name = "details_of_the_case";
            this.details_of_the_case.ReadOnly = true;
            this.details_of_the_case.Width = 225;
            // 
            // button_Export_Excele
            // 
            this.button_Export_Excele.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Export_Excele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Export_Excele.ForeColor = System.Drawing.SystemColors.Info;
            this.button_Export_Excele.Location = new System.Drawing.Point(12, 730);
            this.button_Export_Excele.Name = "button_Export_Excele";
            this.button_Export_Excele.Size = new System.Drawing.Size(118, 39);
            this.button_Export_Excele.TabIndex = 2;
            this.button_Export_Excele.Text = "Отчёт";
            this.button_Export_Excele.UseVisualStyleBackColor = false;
            this.button_Export_Excele.Click += new System.EventHandler(this.button_Export_Excele_Click);
            // 
            // Detained_UK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 776);
            this.Controls.Add(this.button_Export_Excele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Cancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1095, 823);
            this.MinimumSize = new System.Drawing.Size(1095, 823);
            this.Name = "Detained_UK";
            this.Text = "Задержанные на основе УК РФ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenship;
        private System.Windows.Forms.DataGridViewTextBoxColumn involvement;
        private System.Windows.Forms.DataGridViewTextBoxColumn details_of_the_case;
        private System.Windows.Forms.Button button_Export_Excele;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}