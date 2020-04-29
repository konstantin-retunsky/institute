namespace coursework
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelGroupBox_5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.labelGroupBox_4 = new System.Windows.Forms.Label();
            this.labelGroupBox_2 = new System.Windows.Forms.Label();
            this.labelGroupBox_3 = new System.Windows.Forms.Label();
            this.labelGroupBox_1 = new System.Windows.Forms.Label();
            this.textBox_5 = new System.Windows.Forms.TextBox();
            this.textInput_4 = new System.Windows.Forms.TextBox();
            this.textInput_3 = new System.Windows.Forms.TextBox();
            this.textInput_2 = new System.Windows.Forms.TextBox();
            this.textInput_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxBtn = new System.Windows.Forms.GroupBox();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxBtn.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 5);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(549, 329);
            this.dgv.TabIndex = 0;
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(577, 43);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(154, 21);
            this.comboBoxChoose.TabIndex = 1;
            this.comboBoxChoose.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxChoose_SelectionChangeCommitted);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.groupBoxEdit.Controls.Add(this.labelGroupBox_5);
            this.groupBoxEdit.Controls.Add(this.btnCalc);
            this.groupBoxEdit.Controls.Add(this.labelGroupBox_4);
            this.groupBoxEdit.Controls.Add(this.labelGroupBox_2);
            this.groupBoxEdit.Controls.Add(this.labelGroupBox_3);
            this.groupBoxEdit.Controls.Add(this.labelGroupBox_1);
            this.groupBoxEdit.Controls.Add(this.textBox_5);
            this.groupBoxEdit.Controls.Add(this.textInput_4);
            this.groupBoxEdit.Controls.Add(this.textInput_3);
            this.groupBoxEdit.Controls.Add(this.textInput_2);
            this.groupBoxEdit.Controls.Add(this.textInput_1);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 362);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(549, 108);
            this.groupBoxEdit.TabIndex = 2;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Visible = false;
            // 
            // labelGroupBox_5
            // 
            this.labelGroupBox_5.AutoSize = true;
            this.labelGroupBox_5.Location = new System.Drawing.Point(440, 27);
            this.labelGroupBox_5.Name = "labelGroupBox_5";
            this.labelGroupBox_5.Size = new System.Drawing.Size(35, 13);
            this.labelGroupBox_5.TabIndex = 4;
            this.labelGroupBox_5.Text = "label2";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(221, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 27);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Добавить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // labelGroupBox_4
            // 
            this.labelGroupBox_4.AutoSize = true;
            this.labelGroupBox_4.Location = new System.Drawing.Point(324, 27);
            this.labelGroupBox_4.Name = "labelGroupBox_4";
            this.labelGroupBox_4.Size = new System.Drawing.Size(35, 13);
            this.labelGroupBox_4.TabIndex = 4;
            this.labelGroupBox_4.Text = "label2";
            // 
            // labelGroupBox_2
            // 
            this.labelGroupBox_2.AutoSize = true;
            this.labelGroupBox_2.Location = new System.Drawing.Point(112, 27);
            this.labelGroupBox_2.Name = "labelGroupBox_2";
            this.labelGroupBox_2.Size = new System.Drawing.Size(35, 13);
            this.labelGroupBox_2.TabIndex = 4;
            this.labelGroupBox_2.Text = "label2";
            // 
            // labelGroupBox_3
            // 
            this.labelGroupBox_3.AutoSize = true;
            this.labelGroupBox_3.Location = new System.Drawing.Point(218, 27);
            this.labelGroupBox_3.Name = "labelGroupBox_3";
            this.labelGroupBox_3.Size = new System.Drawing.Size(35, 13);
            this.labelGroupBox_3.TabIndex = 4;
            this.labelGroupBox_3.Text = "label2";
            // 
            // labelGroupBox_1
            // 
            this.labelGroupBox_1.AutoSize = true;
            this.labelGroupBox_1.Location = new System.Drawing.Point(6, 27);
            this.labelGroupBox_1.Name = "labelGroupBox_1";
            this.labelGroupBox_1.Size = new System.Drawing.Size(35, 13);
            this.labelGroupBox_1.TabIndex = 4;
            this.labelGroupBox_1.Text = "label2";
            // 
            // textBox_5
            // 
            this.textBox_5.Location = new System.Drawing.Point(443, 46);
            this.textBox_5.Name = "textBox_5";
            this.textBox_5.Size = new System.Drawing.Size(100, 20);
            this.textBox_5.TabIndex = 3;
            // 
            // textInput_4
            // 
            this.textInput_4.Location = new System.Drawing.Point(327, 46);
            this.textInput_4.Name = "textInput_4";
            this.textInput_4.Size = new System.Drawing.Size(100, 20);
            this.textInput_4.TabIndex = 3;
            // 
            // textInput_3
            // 
            this.textInput_3.Location = new System.Drawing.Point(221, 46);
            this.textInput_3.Name = "textInput_3";
            this.textInput_3.Size = new System.Drawing.Size(100, 20);
            this.textInput_3.TabIndex = 3;
            // 
            // textInput_2
            // 
            this.textInput_2.Location = new System.Drawing.Point(115, 46);
            this.textInput_2.Name = "textInput_2";
            this.textInput_2.Size = new System.Drawing.Size(100, 20);
            this.textInput_2.TabIndex = 3;
            // 
            // textInput_1
            // 
            this.textInput_1.Location = new System.Drawing.Point(9, 46);
            this.textInput_1.Name = "textInput_1";
            this.textInput_1.Size = new System.Drawing.Size(100, 20);
            this.textInput_1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор таблцы:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(115, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 27);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 27);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактирование";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(115, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Выборка";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBoxBtn
            // 
            this.groupBoxBtn.Controls.Add(this.btnSearch);
            this.groupBoxBtn.Controls.Add(this.btnAdd);
            this.groupBoxBtn.Controls.Add(this.btnEdit);
            this.groupBoxBtn.Controls.Add(this.btnRemove);
            this.groupBoxBtn.Location = new System.Drawing.Point(570, 70);
            this.groupBoxBtn.Name = "groupBoxBtn";
            this.groupBoxBtn.Size = new System.Drawing.Size(219, 95);
            this.groupBoxBtn.TabIndex = 5;
            this.groupBoxBtn.TabStop = false;
            this.groupBoxBtn.Text = "Выбирите действие над таблицей";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.менюToolStripMenuItem.Text = "меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(570, 171);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(213, 216);
            this.treeView.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.comboBoxChoose);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fMain";
            this.Text = "оказания транспортных услуг ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxBtn.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label labelGroupBox_5;
        private System.Windows.Forms.Label labelGroupBox_4;
        private System.Windows.Forms.Label labelGroupBox_2;
        private System.Windows.Forms.Label labelGroupBox_3;
        private System.Windows.Forms.Label labelGroupBox_1;
        private System.Windows.Forms.TextBox textBox_5;
        private System.Windows.Forms.TextBox textInput_4;
        private System.Windows.Forms.TextBox textInput_3;
        private System.Windows.Forms.TextBox textInput_2;
        private System.Windows.Forms.TextBox textInput_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxBtn;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button1;
    }
}

