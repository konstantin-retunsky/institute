namespace Babeshin
{
    partial class request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(request));
            this.showBook = new System.Windows.Forms.Button();
            this.showAutor = new System.Windows.Forms.Button();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bestReader = new System.Windows.Forms.Button();
            this.showDate = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_month = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showBook
            // 
            this.showBook.Location = new System.Drawing.Point(217, 82);
            this.showBook.Name = "showBook";
            this.showBook.Size = new System.Drawing.Size(162, 50);
            this.showBook.TabIndex = 2;
            this.showBook.Text = "Самая популярная книга";
            this.showBook.UseVisualStyleBackColor = true;
            this.showBook.Click += new System.EventHandler(this.showBook_Click);
            // 
            // showAutor
            // 
            this.showAutor.Location = new System.Drawing.Point(411, 12);
            this.showAutor.Name = "showAutor";
            this.showAutor.Size = new System.Drawing.Size(162, 50);
            this.showAutor.TabIndex = 3;
            this.showAutor.Text = "Самая не популярная книга";
            this.showAutor.UseVisualStyleBackColor = true;
            this.showAutor.Click += new System.EventHandler(this.showAutor_Click);
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(12, 167);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.ReadOnly = true;
            this.mainGrid.Size = new System.Drawing.Size(754, 67);
            this.mainGrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // bestReader
            // 
            this.bestReader.Location = new System.Drawing.Point(217, 12);
            this.bestReader.Name = "bestReader";
            this.bestReader.Size = new System.Drawing.Size(162, 50);
            this.bestReader.TabIndex = 9;
            this.bestReader.Text = "Любимый читатель";
            this.bestReader.UseVisualStyleBackColor = true;
            this.bestReader.Click += new System.EventHandler(this.bestReader_Click);
            // 
            // showDate
            // 
            this.showDate.Location = new System.Drawing.Point(11, 54);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(169, 50);
            this.showDate.TabIndex = 0;
            this.showDate.Text = "Самые популярные книги за данный период\r\n";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.Click += new System.EventHandler(this.showDate_Click);
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(98, 27);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(82, 21);
            this.dateBox.TabIndex = 1;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.dateBox_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(11, 27);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(81, 21);
            this.monthBox.TabIndex = 5;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "год";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthBox);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.showDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "поиск по дате";
            // 
            // search_month
            // 
            this.search_month.Location = new System.Drawing.Point(411, 82);
            this.search_month.Name = "search_month";
            this.search_month.Size = new System.Drawing.Size(162, 50);
            this.search_month.TabIndex = 11;
            this.search_month.Text = "Самый читаемый месяц";
            this.search_month.UseVisualStyleBackColor = true;
            this.search_month.Click += new System.EventHandler(this.search_month_Click);
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(584, 11);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(181, 120);
            this.statistics.TabIndex = 12;
            this.statistics.Text = "Посмотреть статистику по выдачам";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 361);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.search_month);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bestReader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.showAutor);
            this.Controls.Add(this.showBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(799, 400);
            this.MinimumSize = new System.Drawing.Size(799, 400);
            this.Name = "request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запросы";
            this.Load += new System.EventHandler(this.request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showBook;
        private System.Windows.Forms.Button showAutor;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bestReader;
        private System.Windows.Forms.Button showDate;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_month;
        private System.Windows.Forms.Button statistics;
    }
}