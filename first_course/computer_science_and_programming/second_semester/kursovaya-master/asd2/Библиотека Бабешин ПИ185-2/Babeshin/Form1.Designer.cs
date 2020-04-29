namespace Babeshin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readers = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.itog = new System.Windows.Forms.Button();
            this.subitog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parametr = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksFile = new System.Windows.Forms.ToolStripMenuItem();
            this.readersFile = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.informAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.requests = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readers
            // 
            this.readers.BackColor = System.Drawing.Color.DarkKhaki;
            this.readers.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.readers.FlatAppearance.BorderSize = 2;
            this.readers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.readers.Location = new System.Drawing.Point(36, 36);
            this.readers.Name = "readers";
            this.readers.Size = new System.Drawing.Size(140, 51);
            this.readers.TabIndex = 0;
            this.readers.Text = "Читатели";
            this.readers.UseVisualStyleBackColor = false;
            this.readers.Click += new System.EventHandler(this.readers_Click);
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.DarkKhaki;
            this.books.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.books.FlatAppearance.BorderSize = 2;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.ForeColor = System.Drawing.SystemColors.ControlText;
            this.books.Location = new System.Drawing.Point(36, 116);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(140, 51);
            this.books.TabIndex = 1;
            this.books.Text = "Книги";
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.DarkKhaki;
            this.Output.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.Output.FlatAppearance.BorderSize = 2;
            this.Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Output.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output.Location = new System.Drawing.Point(36, 208);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(140, 51);
            this.Output.TabIndex = 2;
            this.Output.Text = "Выдачи";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // itog
            // 
            this.itog.BackColor = System.Drawing.Color.NavajoWhite;
            this.itog.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.itog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itog.Location = new System.Drawing.Point(41, 25);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(140, 51);
            this.itog.TabIndex = 3;
            this.itog.Text = "Итоги";
            this.itog.UseVisualStyleBackColor = false;
            this.itog.Click += new System.EventHandler(this.itog_Click);
            // 
            // subitog
            // 
            this.subitog.BackColor = System.Drawing.Color.NavajoWhite;
            this.subitog.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.subitog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subitog.Location = new System.Drawing.Point(41, 101);
            this.subitog.Name = "subitog";
            this.subitog.Size = new System.Drawing.Size(140, 51);
            this.subitog.TabIndex = 4;
            this.subitog.Text = "Итоги с подчинённой ";
            this.subitog.UseVisualStyleBackColor = false;
            this.subitog.Click += new System.EventHandler(this.subitog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.requests);
            this.groupBox1.Controls.Add(this.subitog);
            this.groupBox1.Controls.Add(this.itog);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(55, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ИТОГИ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.Output);
            this.groupBox2.Controls.Add(this.books);
            this.groupBox2.Controls.Add(this.readers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОСНОВНЫЕ ТАБЛИЦЫ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.BurlyWood;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametr,
            this.выходToolStripMenuItem,
            this.exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // parametr
            // 
            this.parametr.BackColor = System.Drawing.Color.DarkKhaki;
            this.parametr.Name = "parametr";
            this.parametr.Size = new System.Drawing.Size(185, 22);
            this.parametr.Text = "Параметры";
            this.parametr.Click += new System.EventHandler(this.parametr_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksFile,
            this.readersFile,
            this.outputFile});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.выходToolStripMenuItem.Text = "Файлы с таблицами";
            // 
            // booksFile
            // 
            this.booksFile.BackColor = System.Drawing.Color.DarkKhaki;
            this.booksFile.Name = "booksFile";
            this.booksFile.Size = new System.Drawing.Size(125, 22);
            this.booksFile.Text = "Книги";
            this.booksFile.Click += new System.EventHandler(this.booksFile_Click);
            // 
            // readersFile
            // 
            this.readersFile.BackColor = System.Drawing.Color.DarkKhaki;
            this.readersFile.Name = "readersFile";
            this.readersFile.Size = new System.Drawing.Size(125, 22);
            this.readersFile.Text = "Читатели";
            this.readersFile.Click += new System.EventHandler(this.readersFile_Click);
            // 
            // outputFile
            // 
            this.outputFile.BackColor = System.Drawing.Color.DarkKhaki;
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(125, 22);
            this.outputFile.Text = "Выдачи";
            this.outputFile.Click += new System.EventHandler(this.outputFile_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkKhaki;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(185, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.informAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.DarkKhaki;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(256, 22);
            this.About.Text = "Просмотреть Справку";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // informAbout
            // 
            this.informAbout.BackColor = System.Drawing.Color.DarkKhaki;
            this.informAbout.Name = "informAbout";
            this.informAbout.Size = new System.Drawing.Size(256, 22);
            this.informAbout.Text = "Информация о данном продукте";
            this.informAbout.Click += new System.EventHandler(this.informAbout_Click);
            // 
            // requests
            // 
            this.requests.BackColor = System.Drawing.Color.NavajoWhite;
            this.requests.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.requests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requests.Location = new System.Drawing.Point(41, 182);
            this.requests.Name = "requests";
            this.requests.Size = new System.Drawing.Size(140, 51);
            this.requests.TabIndex = 5;
            this.requests.Text = "ЗАПРОСЫ";
            this.requests.UseVisualStyleBackColor = false;
            this.requests.Click += new System.EventHandler(this.requests_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(324, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 700);
            this.MinimumSize = new System.Drawing.Size(340, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая 18-19 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readers;
        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button itog;
        private System.Windows.Forms.Button subitog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametr;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksFile;
        private System.Windows.Forms.ToolStripMenuItem readersFile;
        private System.Windows.Forms.ToolStripMenuItem outputFile;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem informAbout;
        private System.Windows.Forms.Button requests;
    }
}

