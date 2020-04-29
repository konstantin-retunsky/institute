namespace Babeshin
{
    partial class itog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itog));
            this.itogDGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.allLines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allEmptyBook = new System.Windows.Forms.Label();
            this.showEmptyBooks = new System.Windows.Forms.Button();
            this.returnTab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreteDoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.show2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itogDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // itogDGV1
            // 
            this.itogDGV1.AllowUserToAddRows = false;
            this.itogDGV1.AllowUserToDeleteRows = false;
            this.itogDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itogDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itogDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.itogDGV1.Location = new System.Drawing.Point(15, 42);
            this.itogDGV1.Name = "itogDGV1";
            this.itogDGV1.ReadOnly = true;
            this.itogDGV1.Size = new System.Drawing.Size(869, 387);
            this.itogDGV1.TabIndex = 0;
            this.itogDGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itogDGV1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ФИО";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Адрес проживания";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата выдачи";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дата возврата";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество записей - ";
            // 
            // allLines
            // 
            this.allLines.AutoSize = true;
            this.allLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allLines.Location = new System.Drawing.Point(175, 453);
            this.allLines.Name = "allLines";
            this.allLines.Size = new System.Drawing.Size(0, 16);
            this.allLines.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число не сданных книг - ";
            // 
            // allEmptyBook
            // 
            this.allEmptyBook.AutoSize = true;
            this.allEmptyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allEmptyBook.Location = new System.Drawing.Point(207, 488);
            this.allEmptyBook.Name = "allEmptyBook";
            this.allEmptyBook.Size = new System.Drawing.Size(29, 16);
            this.allEmptyBook.TabIndex = 4;
            this.allEmptyBook.Text = "111";
            // 
            // showEmptyBooks
            // 
            this.showEmptyBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showEmptyBooks.Location = new System.Drawing.Point(254, 488);
            this.showEmptyBooks.Name = "showEmptyBooks";
            this.showEmptyBooks.Size = new System.Drawing.Size(103, 23);
            this.showEmptyBooks.TabIndex = 1;
            this.showEmptyBooks.Text = "Показать";
            this.showEmptyBooks.UseVisualStyleBackColor = true;
            this.showEmptyBooks.Click += new System.EventHandler(this.showEmptyBooks_Click);
            // 
            // returnTab
            // 
            this.returnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnTab.Location = new System.Drawing.Point(715, 435);
            this.returnTab.Name = "returnTab";
            this.returnTab.Size = new System.Drawing.Size(166, 34);
            this.returnTab.TabIndex = 3;
            this.returnTab.Text = "Восстановить таблицу";
            this.returnTab.UseVisualStyleBackColor = true;
            this.returnTab.Click += new System.EventHandler(this.returnTab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(343, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Телефон";
            // 
            // CreteDoc
            // 
            this.CreteDoc.Location = new System.Drawing.Point(784, 540);
            this.CreteDoc.Name = "CreteDoc";
            this.CreteDoc.Size = new System.Drawing.Size(109, 49);
            this.CreteDoc.TabIndex = 9;
            this.CreteDoc.Text = "Создать квитанции";
            this.CreteDoc.UseVisualStyleBackColor = true;
            this.CreteDoc.Visible = false;
            this.CreteDoc.Click += new System.EventHandler(this.CreteDoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Число Просроченных книг - ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(207, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "111";
            // 
            // show2
            // 
            this.show2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show2.Location = new System.Drawing.Point(254, 527);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(103, 23);
            this.show2.TabIndex = 12;
            this.show2.Text = "Показать";
            this.show2.UseVisualStyleBackColor = true;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // itog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 601);
            this.Controls.Add(this.show2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreteDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.returnTab);
            this.Controls.Add(this.showEmptyBooks);
            this.Controls.Add(this.allEmptyBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itogDGV1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(909, 640);
            this.Name = "itog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИТОГИ";
            this.Load += new System.EventHandler(this.itog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itogDGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itogDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allEmptyBook;
        private System.Windows.Forms.Button showEmptyBooks;
        private System.Windows.Forms.Button returnTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreteDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button show2;
    }
}