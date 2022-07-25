using System;

namespace CourseWork
{
    partial class Form1
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
            this.button_staff = new System.Windows.Forms.Button();
            this.button_AK = new System.Windows.Forms.Button();
            this.button_UK = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add_UK = new System.Windows.Forms.Button();
            this.button_add_AK = new System.Windows.Forms.Button();
            this.button_delete_staff = new System.Windows.Forms.Button();
            this.button_add_staff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_staff
            // 
            this.button_staff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_staff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_staff.Location = new System.Drawing.Point(28, 40);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(353, 60);
            this.button_staff.TabIndex = 0;
            this.button_staff.Text = "Сотрудники";
            this.button_staff.UseVisualStyleBackColor = false;
            this.button_staff.Click += new System.EventHandler(this.Button_staff_Click);
            // 
            // button_AK
            // 
            this.button_AK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AK.Location = new System.Drawing.Point(28, 166);
            this.button_AK.Name = "button_AK";
            this.button_AK.Size = new System.Drawing.Size(353, 61);
            this.button_AK.TabIndex = 1;
            this.button_AK.Text = "Задержанные на основе АК РФ";
            this.button_AK.UseVisualStyleBackColor = false;
            this.button_AK.Click += new System.EventHandler(this.Button_AK_Click);
            // 
            // button_UK
            // 
            this.button_UK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_UK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UK.Location = new System.Drawing.Point(28, 279);
            this.button_UK.Name = "button_UK";
            this.button_UK.Size = new System.Drawing.Size(353, 57);
            this.button_UK.TabIndex = 2;
            this.button_UK.Text = "Задержанные на основе УК РФ";
            this.button_UK.UseVisualStyleBackColor = false;
            this.button_UK.Click += new System.EventHandler(this.Button_UK_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(135, 423);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(142, 41);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_add_UK);
            this.groupBox1.Controls.Add(this.button_add_AK);
            this.groupBox1.Controls.Add(this.button_delete_staff);
            this.groupBox1.Controls.Add(this.button_add_staff);
            this.groupBox1.Controls.Add(this.button_exit);
            this.groupBox1.Controls.Add(this.button_UK);
            this.groupBox1.Controls.Add(this.button_AK);
            this.groupBox1.Controls.Add(this.button_staff);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(100, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 479);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button_add_UK
            // 
            this.button_add_UK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_add_UK.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_UK.Location = new System.Drawing.Point(144, 342);
            this.button_add_UK.Name = "button_add_UK";
            this.button_add_UK.Size = new System.Drawing.Size(119, 39);
            this.button_add_UK.TabIndex = 7;
            this.button_add_UK.Text = "Добавить";
            this.button_add_UK.UseVisualStyleBackColor = false;
            this.button_add_UK.Click += new System.EventHandler(this.Button_add_UK_Click);
            // 
            // button_add_AK
            // 
            this.button_add_AK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_add_AK.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_AK.Location = new System.Drawing.Point(144, 233);
            this.button_add_AK.Name = "button_add_AK";
            this.button_add_AK.Size = new System.Drawing.Size(119, 39);
            this.button_add_AK.TabIndex = 6;
            this.button_add_AK.Text = "Добавить";
            this.button_add_AK.UseVisualStyleBackColor = false;
            this.button_add_AK.Click += new System.EventHandler(this.Button_add_AK_Click);
            // 
            // button_delete_staff
            // 
            this.button_delete_staff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_delete_staff.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_staff.Location = new System.Drawing.Point(262, 106);
            this.button_delete_staff.Name = "button_delete_staff";
            this.button_delete_staff.Size = new System.Drawing.Size(119, 39);
            this.button_delete_staff.TabIndex = 5;
            this.button_delete_staff.Text = "Удалить";
            this.button_delete_staff.UseVisualStyleBackColor = false;
            this.button_delete_staff.Click += new System.EventHandler(this.Button_delete_staff_Click);
            // 
            // button_add_staff
            // 
            this.button_add_staff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_add_staff.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_staff.Location = new System.Drawing.Point(28, 106);
            this.button_add_staff.Name = "button_add_staff";
            this.button_add_staff.Size = new System.Drawing.Size(119, 39);
            this.button_add_staff.TabIndex = 4;
            this.button_add_staff.Text = "Добавить";
            this.button_add_staff.UseVisualStyleBackColor = false;
            this.button_add_staff.Click += new System.EventHandler(this.Button_add_staff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(632, 603);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_staff;
        private System.Windows.Forms.Button button_AK;
        private System.Windows.Forms.Button button_UK;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add_UK;
        private System.Windows.Forms.Button button_add_AK;
        private System.Windows.Forms.Button button_delete_staff;
        private System.Windows.Forms.Button button_add_staff;
    }
}

