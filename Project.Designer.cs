namespace PR2._2
{
    partial class Project
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
            this.result1 = new System.Windows.Forms.Label();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.btnMath1 = new System.Windows.Forms.Button();
            this.condition1 = new System.Windows.Forms.Label();
            this.condition2 = new System.Windows.Forms.Label();
            this.btnMath2 = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.Button();
            this.decision1 = new System.Windows.Forms.GroupBox();
            this.decision2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.decision2.SuspendLayout();
            this.SuspendLayout();
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.BackColor = System.Drawing.Color.MediumPurple;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result1.ForeColor = System.Drawing.Color.Transparent;
            this.result1.Location = new System.Drawing.Point(9, 87);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(80, 16);
            this.result1.TabIndex = 0;
            this.result1.Text = "Результат:";
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult1.Location = new System.Drawing.Point(95, 87);
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.ReadOnly = true;
            this.textBoxResult1.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult1.TabIndex = 1;
            // 
            // btnMath1
            // 
            this.btnMath1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMath1.Location = new System.Drawing.Point(12, 124);
            this.btnMath1.Name = "btnMath1";
            this.btnMath1.Size = new System.Drawing.Size(165, 39);
            this.btnMath1.TabIndex = 2;
            this.btnMath1.Text = "Рассчитать";
            this.btnMath1.UseVisualStyleBackColor = true;
            this.btnMath1.Click += new System.EventHandler(this.btnMath1_Click);
            // 
            // condition1
            // 
            this.condition1.AutoSize = true;
            this.condition1.BackColor = System.Drawing.Color.MediumPurple;
            this.condition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition1.ForeColor = System.Drawing.Color.Transparent;
            this.condition1.Location = new System.Drawing.Point(9, 44);
            this.condition1.Name = "condition1";
            this.condition1.Size = new System.Drawing.Size(202, 32);
            this.condition1.TabIndex = 3;
            this.condition1.Text = "Если вы хотите перемножить \r\n   числа в готовом словаре ";
            // 
            // condition2
            // 
            this.condition2.AutoSize = true;
            this.condition2.BackColor = System.Drawing.Color.SlateBlue;
            this.condition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition2.ForeColor = System.Drawing.Color.Transparent;
            this.condition2.Location = new System.Drawing.Point(218, 44);
            this.condition2.Name = "condition2";
            this.condition2.Size = new System.Drawing.Size(406, 32);
            this.condition2.TabIndex = 4;
            this.condition2.Text = "Если вы хотите перемножить числа в словаре заполненным \r\n               вами (вво" +
    "д осуществляется через пробел)";
            // 
            // btnMath2
            // 
            this.btnMath2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMath2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMath2.Location = new System.Drawing.Point(229, 96);
            this.btnMath2.Name = "btnMath2";
            this.btnMath2.Size = new System.Drawing.Size(165, 39);
            this.btnMath2.TabIndex = 5;
            this.btnMath2.Text = "Рассчитать";
            this.btnMath2.UseVisualStyleBackColor = true;
            this.btnMath2.Click += new System.EventHandler(this.btnMath2_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(310, 86);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 6;
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResult2.Location = new System.Drawing.Point(294, 58);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ReadOnly = true;
            this.textBoxResult2.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult2.TabIndex = 7;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.BackColor = System.Drawing.Color.SlateBlue;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.ForeColor = System.Drawing.Color.Transparent;
            this.input.Location = new System.Drawing.Point(219, 87);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(85, 16);
            this.input.TabIndex = 8;
            this.input.Text = "Ввод чисел:";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.BackColor = System.Drawing.Color.SlateBlue;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2.ForeColor = System.Drawing.Color.Transparent;
            this.result2.Location = new System.Drawing.Point(208, 59);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(80, 16);
            this.result2.TabIndex = 9;
            this.result2.Text = "Результат:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem,
            this.clear,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.вычислитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation1,
            this.calculation2});
            this.вычислитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // calculation1
            // 
            this.calculation1.BackColor = System.Drawing.Color.SlateBlue;
            this.calculation1.ForeColor = System.Drawing.Color.White;
            this.calculation1.Name = "calculation1";
            this.calculation1.Size = new System.Drawing.Size(297, 22);
            this.calculation1.Text = "Рассчитать числа в готовом словаре";
            this.calculation1.Click += new System.EventHandler(this.calculation1_Click);
            // 
            // calculation2
            // 
            this.calculation2.BackColor = System.Drawing.Color.SlateBlue;
            this.calculation2.ForeColor = System.Drawing.Color.White;
            this.calculation2.Name = "calculation2";
            this.calculation2.Size = new System.Drawing.Size(297, 22);
            this.calculation2.Text = "Рассчитать в своем словаре";
            this.calculation2.Click += new System.EventHandler(this.calculation2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.SlateBlue;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(138, 22);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.info_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(12, 174);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(598, 50);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // decision1
            // 
            this.decision1.BackColor = System.Drawing.Color.MediumPurple;
            this.decision1.ForeColor = System.Drawing.Color.White;
            this.decision1.Location = new System.Drawing.Point(-1, 28);
            this.decision1.Name = "decision1";
            this.decision1.Size = new System.Drawing.Size(218, 204);
            this.decision1.TabIndex = 12;
            this.decision1.TabStop = false;
            this.decision1.Text = "Решение 1:";
            // 
            // decision2
            // 
            this.decision2.BackColor = System.Drawing.Color.SlateBlue;
            this.decision2.Controls.Add(this.textBoxResult2);
            this.decision2.Controls.Add(this.result2);
            this.decision2.Controls.Add(this.btnMath2);
            this.decision2.ForeColor = System.Drawing.Color.White;
            this.decision2.Location = new System.Drawing.Point(216, 28);
            this.decision2.Name = "decision2";
            this.decision2.Size = new System.Drawing.Size(408, 204);
            this.decision2.TabIndex = 13;
            this.decision2.TabStop = false;
            this.decision2.Text = "Решение 2:";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(622, 229);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.input);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.condition2);
            this.Controls.Add(this.condition1);
            this.Controls.Add(this.btnMath1);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.decision1);
            this.Controls.Add(this.decision2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(638, 268);
            this.MinimumSize = new System.Drawing.Size(638, 268);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.decision2.ResumeLayout(false);
            this.decision2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Button btnMath1;
        private System.Windows.Forms.Label condition1;
        private System.Windows.Forms.Label condition2;
        private System.Windows.Forms.Button btnMath2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculation1;
        private System.Windows.Forms.ToolStripMenuItem calculation2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox decision1;
        private System.Windows.Forms.GroupBox decision2;
        private System.Windows.Forms.TextBox textBoxResult1;
    }
}

