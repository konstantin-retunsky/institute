namespace coursework {
	partial class FormStatistic {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
			this.buttonTopClient = new System.Windows.Forms.Button();
			this.buttonTopYear = new System.Windows.Forms.Button();
			this.bttonTopService = new System.Windows.Forms.Button();
			this.comboBoxTable = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxCells = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewStatistic
			// 
			this.dataGridViewStatistic.AllowUserToAddRows = false;
			this.dataGridViewStatistic.AllowUserToDeleteRows = false;
			this.dataGridViewStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStatistic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStatistic.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewStatistic.Name = "dataGridViewStatistic";
			this.dataGridViewStatistic.ReadOnly = true;
			this.dataGridViewStatistic.RowHeadersWidth = 43;
			this.dataGridViewStatistic.Size = new System.Drawing.Size(591, 426);
			this.dataGridViewStatistic.TabIndex = 0;
			// 
			// buttonTopClient
			// 
			this.buttonTopClient.Location = new System.Drawing.Point(46, 31);
			this.buttonTopClient.Name = "buttonTopClient";
			this.buttonTopClient.Size = new System.Drawing.Size(114, 51);
			this.buttonTopClient.TabIndex = 1;
			this.buttonTopClient.Text = "Показать лучшего клиента";
			this.buttonTopClient.UseVisualStyleBackColor = true;
			this.buttonTopClient.Click += new System.EventHandler(this.ButtonTopClient_Click);
			// 
			// buttonTopYear
			// 
			this.buttonTopYear.Location = new System.Drawing.Point(46, 88);
			this.buttonTopYear.Name = "buttonTopYear";
			this.buttonTopYear.Size = new System.Drawing.Size(114, 51);
			this.buttonTopYear.TabIndex = 1;
			this.buttonTopYear.Text = "Показать лучший год";
			this.buttonTopYear.UseVisualStyleBackColor = true;
			this.buttonTopYear.Click += new System.EventHandler(this.ButtonTopYear_Click);
			// 
			// bttonTopService
			// 
			this.bttonTopService.Location = new System.Drawing.Point(46, 145);
			this.bttonTopService.Name = "bttonTopService";
			this.bttonTopService.Size = new System.Drawing.Size(114, 51);
			this.bttonTopService.TabIndex = 1;
			this.bttonTopService.Text = "Показать лучшую услугу";
			this.bttonTopService.UseVisualStyleBackColor = true;
			this.bttonTopService.Click += new System.EventHandler(this.BttonTopService_Click);
			// 
			// comboBoxTable
			// 
			this.comboBoxTable.FormattingEnabled = true;
			this.comboBoxTable.Location = new System.Drawing.Point(27, 34);
			this.comboBoxTable.Name = "comboBoxTable";
			this.comboBoxTable.Size = new System.Drawing.Size(156, 21);
			this.comboBoxTable.TabIndex = 2;
			this.comboBoxTable.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxTable_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выберите таблицу ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxCells);
			this.groupBox1.Controls.Add(this.textBoxSearch);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBoxTable);
			this.groupBox1.Location = new System.Drawing.Point(626, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 158);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// comboBoxCells
			// 
			this.comboBoxCells.FormattingEnabled = true;
			this.comboBoxCells.Location = new System.Drawing.Point(27, 76);
			this.comboBoxCells.Name = "comboBoxCells";
			this.comboBoxCells.Size = new System.Drawing.Size(156, 21);
			this.comboBoxCells.TabIndex = 6;
			this.comboBoxCells.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCells_SelectedIndexChanged);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(27, 118);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(156, 20);
			this.textBoxSearch.TabIndex = 5;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Текст для поиска";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Выбирите колону для поиска";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonTopClient);
			this.groupBox2.Controls.Add(this.buttonTopYear);
			this.groupBox2.Controls.Add(this.bttonTopService);
			this.groupBox2.Location = new System.Drawing.Point(626, 215);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 223);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Статистика";
			// 
			// FormStatistic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 457);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridViewStatistic);
			this.Name = "FormStatistic";
			this.Text = "Статистические данные";
			this.Load += new System.EventHandler(this.StatisticForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewStatistic;
		private System.Windows.Forms.Button buttonTopClient;
		private System.Windows.Forms.Button buttonTopYear;
		private System.Windows.Forms.Button bttonTopService;
		private System.Windows.Forms.ComboBox comboBoxTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBoxCells;
	}
}