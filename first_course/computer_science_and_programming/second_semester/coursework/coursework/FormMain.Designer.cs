namespace coursework {
	 partial class FormMain {
		  /// <summary>
		  /// Обязательная переменная конструктора.
		  /// </summary>
		  private System.ComponentModel.IContainer components = null;

		  /// <summary>
		  /// Освободить все используемые ресурсы.
		  /// </summary>
		  /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		  protected override void Dispose (bool disposing) {
				if (disposing && ( components != null )) {
					 components.Dispose();
				}
				base.Dispose(disposing);
		  }

		  #region Код, автоматически созданный конструктором форм Windows

		  /// <summary>
		  /// Требуемый метод для поддержки конструктора — не изменяйте 
		  /// содержимое этого метода с помощью редактора кода.
		  /// </summary>
		  private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.comboBoxTable = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonStatisticalData = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxButtons = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBoxButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidth = 45;
			this.dataGridView.Size = new System.Drawing.Size(582, 426);
			this.dataGridView.TabIndex = 0;
			// 
			// comboBoxTable
			// 
			this.comboBoxTable.FormattingEnabled = true;
			this.comboBoxTable.Location = new System.Drawing.Point(6, 29);
			this.comboBoxTable.Name = "comboBoxTable";
			this.comboBoxTable.Size = new System.Drawing.Size(113, 21);
			this.comboBoxTable.TabIndex = 1;
			this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTable_SelectedIndexChanged);
			this.comboBoxTable.Click += new System.EventHandler(this.comboBoxTable_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(6, 134);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(112, 33);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(6, 95);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(112, 33);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Location = new System.Drawing.Point(6, 173);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(112, 33);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(6, 56);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(112, 33);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(6, 395);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(112, 33);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Выход";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// buttonStatisticalData
			// 
			this.buttonStatisticalData.Location = new System.Drawing.Point(6, 212);
			this.buttonStatisticalData.Name = "buttonStatisticalData";
			this.buttonStatisticalData.Size = new System.Drawing.Size(112, 42);
			this.buttonStatisticalData.TabIndex = 4;
			this.buttonStatisticalData.Text = "Статистические данные";
			this.buttonStatisticalData.UseVisualStyleBackColor = true;
			this.buttonStatisticalData.Click += new System.EventHandler(this.Button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выбирите таблицу";
			// 
			// groupBoxButtons
			// 
			this.groupBoxButtons.Controls.Add(this.buttonSave);
			this.groupBoxButtons.Controls.Add(this.buttonExit);
			this.groupBoxButtons.Controls.Add(this.label1);
			this.groupBoxButtons.Controls.Add(this.buttonDelete);
			this.groupBoxButtons.Controls.Add(this.buttonEdit);
			this.groupBoxButtons.Controls.Add(this.buttonStatisticalData);
			this.groupBoxButtons.Controls.Add(this.comboBoxTable);
			this.groupBoxButtons.Controls.Add(this.buttonAdd);
			this.groupBoxButtons.Location = new System.Drawing.Point(600, 5);
			this.groupBoxButtons.Name = "groupBoxButtons";
			this.groupBoxButtons.Size = new System.Drawing.Size(123, 434);
			this.groupBoxButtons.TabIndex = 5;
			this.groupBoxButtons.TabStop = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 451);
			this.Controls.Add(this.groupBoxButtons);
			this.Controls.Add(this.dataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Оказание транспортных улсуг";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBoxButtons.ResumeLayout(false);
			this.groupBoxButtons.PerformLayout();
			this.ResumeLayout(false);

		  }

		  #endregion

		  public System.Windows.Forms.DataGridView dataGridView;
		  public System.Windows.Forms.ComboBox comboBoxTable;
		  private System.Windows.Forms.Button buttonSave;
		  private System.Windows.Forms.Button buttonDelete;
		  private System.Windows.Forms.Button buttonEdit;
		  private System.Windows.Forms.Button buttonAdd;
		  private System.Windows.Forms.Button buttonExit;
		  private System.Windows.Forms.Button buttonStatisticalData;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.GroupBox groupBoxButtons;
	}
}

