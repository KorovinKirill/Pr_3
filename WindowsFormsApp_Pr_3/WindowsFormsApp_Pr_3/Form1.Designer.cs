namespace WindowsFormsApp_Pr_3
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.str2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.str1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаРасчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Razdelenie = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammMenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(455, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(400, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(143, 33);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(248, 69);
            this.result.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Новый список:";
            // 
            // str2
            // 
            this.str2.Location = new System.Drawing.Point(103, 76);
            this.str2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.str2.Multiline = true;
            this.str2.Name = "str2";
            this.str2.Size = new System.Drawing.Size(228, 27);
            this.str2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.str1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.str2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(400, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // str1
            // 
            this.str1.Location = new System.Drawing.Point(103, 37);
            this.str1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.str1.Multiline = true;
            this.str1.Name = "str1";
            this.str1.Size = new System.Drawing.Size(228, 27);
            this.str1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Список 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Список 1:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(455, 324);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 38);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuTools,
            this.ReferenceMenuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuTools
            // 
            this.FileMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.Razdelenie,
            this.DeleteMenuTools,
            this.ExitMenuTools});
            this.FileMenuTools.Name = "FileMenuTools";
            this.FileMenuTools.Size = new System.Drawing.Size(59, 24);
            this.FileMenuTools.Text = "Файл";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаРасчётыToolStripMenuItem});
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            // 
            // программаРасчётыToolStripMenuItem
            // 
            this.программаРасчётыToolStripMenuItem.Name = "программаРасчётыToolStripMenuItem";
            this.программаРасчётыToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.программаРасчётыToolStripMenuItem.Text = "Программа \"Расчёты\"";
            this.программаРасчётыToolStripMenuItem.Click += new System.EventHandler(this.программаРасчётыToolStripMenuItem_Click);
            // 
            // Razdelenie
            // 
            this.Razdelenie.Name = "Razdelenie";
            this.Razdelenie.Size = new System.Drawing.Size(164, 6);
            // 
            // DeleteMenuTools
            // 
            this.DeleteMenuTools.Name = "DeleteMenuTools";
            this.DeleteMenuTools.Size = new System.Drawing.Size(167, 26);
            this.DeleteMenuTools.Text = "Очистить";
            this.DeleteMenuTools.Click += new System.EventHandler(this.DeleteMenuTools_Click);
            // 
            // ExitMenuTools
            // 
            this.ExitMenuTools.Name = "ExitMenuTools";
            this.ExitMenuTools.Size = new System.Drawing.Size(167, 26);
            this.ExitMenuTools.Text = "Выход";
            this.ExitMenuTools.Click += new System.EventHandler(this.ExitMenuTools_Click);
            // 
            // ReferenceMenuTools
            // 
            this.ReferenceMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenuTools});
            this.ReferenceMenuTools.Name = "ReferenceMenuTools";
            this.ReferenceMenuTools.Size = new System.Drawing.Size(81, 24);
            this.ReferenceMenuTools.Text = "Справка";
            // 
            // AboutProgrammMenuTools
            // 
            this.AboutProgrammMenuTools.Name = "AboutProgrammMenuTools";
            this.AboutProgrammMenuTools.Size = new System.Drawing.Size(187, 26);
            this.AboutProgrammMenuTools.Text = "О программе";
            this.AboutProgrammMenuTools.Click += new System.EventHandler(this.AboutProgrammMenuTools_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 425);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_calc);
            this.tabPage1.Controls.Add(this.btn_close);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(896, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчёты";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(35, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(820, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте! \r\nЭта программа позволяет соединять два списка по принципу: \r\nиз пе" +
    "рвого списка берется четный элемент, а после него,\r\nиз второго списка берется не" +
    " четный элемент.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(301, 324);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(133, 38);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Рассчитать";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 460);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Шаблон функции";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox str2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuTools;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаРасчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Razdelenie;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuTools;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuTools;
        private System.Windows.Forms.ToolStripMenuItem ReferenceMenuTools;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammMenuTools;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox str1;
        private System.Windows.Forms.Label label1;
    }
}

