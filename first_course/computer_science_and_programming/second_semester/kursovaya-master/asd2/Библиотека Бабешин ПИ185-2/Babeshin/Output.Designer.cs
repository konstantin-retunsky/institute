namespace Babeshin
{
    partial class Output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.outDGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.bookNameCB = new System.Windows.Forms.ComboBox();
            this.fioCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rowNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backRow = new System.Windows.Forms.Button();
            this.nextRow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTBX = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outDGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outDGV1
            // 
            this.outDGV1.AllowUserToAddRows = false;
            this.outDGV1.AllowUserToDeleteRows = false;
            this.outDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.outDGV1.Location = new System.Drawing.Point(30, 35);
            this.outDGV1.Name = "outDGV1";
            this.outDGV1.ReadOnly = true;
            this.outDGV1.Size = new System.Drawing.Size(697, 397);
            this.outDGV1.TabIndex = 0;
            this.outDGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outDGV1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 93.27411F;
            this.Column2.HeaderText = "Название книги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 93.27411F;
            this.Column3.HeaderText = "ФИО";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 93.27411F;
            this.Column4.HeaderText = "Дата выдачи";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 93.27411F;
            this.Column5.HeaderText = "Дата возврата";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(749, 466);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(126, 47);
            this.del.TabIndex = 6;
            this.del.Text = "Удалить запись";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(766, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 47);
            this.save.TabIndex = 8;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(476, 482);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 483);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 3;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(617, 466);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(126, 47);
            this.edit.TabIndex = 5;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(47, 509);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 47);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bookNameCB
            // 
            this.bookNameCB.FormattingEnabled = true;
            this.bookNameCB.Location = new System.Drawing.Point(50, 482);
            this.bookNameCB.Name = "bookNameCB";
            this.bookNameCB.Size = new System.Drawing.Size(113, 21);
            this.bookNameCB.TabIndex = 1;
            this.bookNameCB.TextChanged += new System.EventHandler(this.bookNameCB_TextChanged);
            // 
            // fioCB
            // 
            this.fioCB.FormattingEnabled = true;
            this.fioCB.Location = new System.Drawing.Point(169, 482);
            this.fioCB.Name = "fioCB";
            this.fioCB.Size = new System.Drawing.Size(131, 21);
            this.fioCB.TabIndex = 2;
            this.fioCB.TextChanged += new System.EventHandler(this.fioCB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФИО читателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата выдачи (дд/мм/гггг)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата возвтрата (дд/мм/гггг)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "№ строки";
            // 
            // rowNumber
            // 
            this.rowNumber.AutoSize = true;
            this.rowNumber.Location = new System.Drawing.Point(535, 526);
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.Size = new System.Drawing.Size(0, 13);
            this.rowNumber.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backRow);
            this.groupBox1.Controls.Add(this.nextRow);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.searchTBX);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Location = new System.Drawing.Point(749, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 155);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПОИСК";
            // 
            // backRow
            // 
            this.backRow.Enabled = false;
            this.backRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backRow.Location = new System.Drawing.Point(59, 110);
            this.backRow.Name = "backRow";
            this.backRow.Size = new System.Drawing.Size(33, 29);
            this.backRow.TabIndex = 18;
            this.backRow.Text = "<";
            this.backRow.UseVisualStyleBackColor = true;
            this.backRow.Click += new System.EventHandler(this.backRow_Click);
            // 
            // nextRow
            // 
            this.nextRow.Enabled = false;
            this.nextRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextRow.Location = new System.Drawing.Point(109, 110);
            this.nextRow.Name = "nextRow";
            this.nextRow.Size = new System.Drawing.Size(33, 29);
            this.nextRow.TabIndex = 17;
            this.nextRow.Text = ">";
            this.nextRow.UseVisualStyleBackColor = true;
            this.nextRow.Click += new System.EventHandler(this.nextRow_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Введите дату выдачи";
            // 
            // searchTBX
            // 
            this.searchTBX.Location = new System.Drawing.Point(23, 47);
            this.searchTBX.Name = "searchTBX";
            this.searchTBX.Size = new System.Drawing.Size(159, 20);
            this.searchTBX.TabIndex = 15;
            this.searchTBX.TextChanged += new System.EventHandler(this.searchTBX_TextChanged);
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(23, 73);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(159, 31);
            this.search.TabIndex = 14;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rowNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fioCB);
            this.Controls.Add(this.bookNameCB);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.del);
            this.Controls.Add(this.outDGV1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 640);
            this.MinimumSize = new System.Drawing.Size(999, 640);
            this.Name = "Output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдачи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Output_FormClosing);
            this.Load += new System.EventHandler(this.Output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outDGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outDGV1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox bookNameCB;
        private System.Windows.Forms.ComboBox fioCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rowNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTBX;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button backRow;
        private System.Windows.Forms.Button nextRow;
    }
}