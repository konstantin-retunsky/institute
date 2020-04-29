namespace lab_2
{
	partial class FormMain
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panelMain = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.dgvFunction = new System.Windows.Forms.DataGridView();
      this.ColumnModules = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgvComparisonMatrix = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSumRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnShareOfSignificance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvCoreCosts = new System.Windows.Forms.DataGridView();
      this.ColumnStructuralElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDayOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSumOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDayTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSumTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDayThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSumThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnDayFour = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnSumFour = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.numericBoxFunctions = new System.Windows.Forms.NumericUpDown();
      this.numericBoxStructuralElement = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.numericBoxSystemCost = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.sumDays = new System.Windows.Forms.NumericUpDown();
      this.panelMain.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFunction)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonMatrix)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCoreCosts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxFunctions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxStructuralElement)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxSystemCost)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumDays)).BeginInit();
      this.SuspendLayout();
      // 
      // panelMain
      // 
      this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.panelMain.AutoScroll = true;
      this.panelMain.Controls.Add(this.groupBox3);
      this.panelMain.Controls.Add(this.groupBox2);
      this.panelMain.Controls.Add(this.groupBox1);
      this.panelMain.Location = new System.Drawing.Point(12, 12);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(1015, 653);
      this.panelMain.TabIndex = 2;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.chart);
      this.groupBox3.Controls.Add(this.dgvFunction);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox3.Location = new System.Drawing.Point(9, 1122);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(984, 974);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Совмещенная модель определения стоимости функций";
      // 
      // chart
      // 
      chartArea3.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart.Legends.Add(legend3);
      this.chart.Location = new System.Drawing.Point(14, 552);
      this.chart.Name = "chart";
      series5.ChartArea = "ChartArea1";
      series5.Legend = "Legend1";
      series5.Name = "Доля значимости матрицы";
      series6.ChartArea = "ChartArea1";
      series6.Legend = "Legend1";
      series6.Name = "Доля значимости модели совмещенной стоимости ";
      this.chart.Series.Add(series5);
      this.chart.Series.Add(series6);
      this.chart.Size = new System.Drawing.Size(954, 400);
      this.chart.TabIndex = 17;
      this.chart.Text = "chart";
      // 
      // dgvFunction
      // 
      this.dgvFunction.AllowUserToAddRows = false;
      this.dgvFunction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModules,
            this.ColumnCost});
      this.dgvFunction.Location = new System.Drawing.Point(14, 30);
      this.dgvFunction.Name = "dgvFunction";
      this.dgvFunction.RowHeadersWidth = 45;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dgvFunction.RowsDefaultCellStyle = dataGridViewCellStyle11;
      this.dgvFunction.Size = new System.Drawing.Size(954, 499);
      this.dgvFunction.TabIndex = 0;
      // 
      // ColumnModules
      // 
      this.ColumnModules.HeaderText = "Модули";
      this.ColumnModules.MinimumWidth = 6;
      this.ColumnModules.Name = "ColumnModules";
      // 
      // ColumnCost
      // 
      this.ColumnCost.HeaderText = "Стоимость";
      this.ColumnCost.MinimumWidth = 6;
      this.ColumnCost.Name = "ColumnCost";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dgvComparisonMatrix);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox2.Location = new System.Drawing.Point(9, 593);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(984, 510);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Матрица парных сравнений значимости функций";
      // 
      // dgvComparisonMatrix
      // 
      this.dgvComparisonMatrix.AllowUserToAddRows = false;
      this.dgvComparisonMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvComparisonMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvComparisonMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnSumRow,
            this.ColumnShareOfSignificance});
      this.dgvComparisonMatrix.Location = new System.Drawing.Point(14, 30);
      this.dgvComparisonMatrix.Name = "dgvComparisonMatrix";
      this.dgvComparisonMatrix.RowHeadersWidth = 45;
      dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dgvComparisonMatrix.RowsDefaultCellStyle = dataGridViewCellStyle12;
      this.dgvComparisonMatrix.Size = new System.Drawing.Size(954, 467);
      this.dgvComparisonMatrix.TabIndex = 0;
      this.dgvComparisonMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComparisonMatrix_CellValueChanged);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      // 
      // ColumnSumRow
      // 
      this.ColumnSumRow.HeaderText = "Сумма ряда";
      this.ColumnSumRow.MinimumWidth = 6;
      this.ColumnSumRow.Name = "ColumnSumRow";
      // 
      // ColumnShareOfSignificance
      // 
      this.ColumnShareOfSignificance.HeaderText = "Доля значимости";
      this.ColumnShareOfSignificance.MinimumWidth = 6;
      this.ColumnShareOfSignificance.Name = "ColumnShareOfSignificance";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.dgvCoreCosts);
      this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox1.Location = new System.Drawing.Point(9, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(984, 570);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Затраты для основных структурных элементов";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(520, 54);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(64, 20);
      this.label5.TabIndex = 2;
      this.label5.Text = "Этапы";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(760, 94);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 20);
      this.label4.TabIndex = 2;
      this.label4.Text = "Отладка";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(574, 94);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(122, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Кодирование";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(395, 94);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(151, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Проектирование";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(241, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(132, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Исследование";
      // 
      // dgvCoreCosts
      // 
      this.dgvCoreCosts.AllowUserToAddRows = false;
      this.dgvCoreCosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvCoreCosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
      this.dgvCoreCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCoreCosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStructuralElement,
            this.ColumnDayOne,
            this.ColumnSumOne,
            this.ColumnDayTwo,
            this.ColumnSumTwo,
            this.ColumnDayThree,
            this.ColumnSumThree,
            this.ColumnDayFour,
            this.ColumnSumFour,
            this.ColumnTotal});
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvCoreCosts.DefaultCellStyle = dataGridViewCellStyle14;
      this.dgvCoreCosts.Location = new System.Drawing.Point(14, 117);
      this.dgvCoreCosts.Name = "dgvCoreCosts";
      this.dgvCoreCosts.RowHeadersWidth = 45;
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dgvCoreCosts.RowsDefaultCellStyle = dataGridViewCellStyle15;
      this.dgvCoreCosts.Size = new System.Drawing.Size(954, 440);
      this.dgvCoreCosts.TabIndex = 0;
      this.dgvCoreCosts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoreCosts_CellValueChanged);
      // 
      // ColumnStructuralElement
      // 
      this.ColumnStructuralElement.FillWeight = 181.3472F;
      this.ColumnStructuralElement.HeaderText = "Структурный элемент";
      this.ColumnStructuralElement.MinimumWidth = 6;
      this.ColumnStructuralElement.Name = "ColumnStructuralElement";
      this.ColumnStructuralElement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // ColumnDayOne
      // 
      this.ColumnDayOne.FillWeight = 90.96143F;
      this.ColumnDayOne.HeaderText = "дни";
      this.ColumnDayOne.MinimumWidth = 6;
      this.ColumnDayOne.Name = "ColumnDayOne";
      // 
      // ColumnSumOne
      // 
      this.ColumnSumOne.FillWeight = 90.96143F;
      this.ColumnSumOne.HeaderText = "сумма";
      this.ColumnSumOne.MinimumWidth = 6;
      this.ColumnSumOne.Name = "ColumnSumOne";
      // 
      // ColumnDayTwo
      // 
      this.ColumnDayTwo.FillWeight = 90.96143F;
      this.ColumnDayTwo.HeaderText = "дни";
      this.ColumnDayTwo.MinimumWidth = 6;
      this.ColumnDayTwo.Name = "ColumnDayTwo";
      // 
      // ColumnSumTwo
      // 
      this.ColumnSumTwo.FillWeight = 90.96143F;
      this.ColumnSumTwo.HeaderText = "сумма";
      this.ColumnSumTwo.MinimumWidth = 6;
      this.ColumnSumTwo.Name = "ColumnSumTwo";
      // 
      // ColumnDayThree
      // 
      this.ColumnDayThree.FillWeight = 90.96143F;
      this.ColumnDayThree.HeaderText = "дни";
      this.ColumnDayThree.MinimumWidth = 6;
      this.ColumnDayThree.Name = "ColumnDayThree";
      // 
      // ColumnSumThree
      // 
      this.ColumnSumThree.FillWeight = 90.96143F;
      this.ColumnSumThree.HeaderText = "сумма";
      this.ColumnSumThree.MinimumWidth = 6;
      this.ColumnSumThree.Name = "ColumnSumThree";
      // 
      // ColumnDayFour
      // 
      this.ColumnDayFour.FillWeight = 90.96143F;
      this.ColumnDayFour.HeaderText = "дни";
      this.ColumnDayFour.MinimumWidth = 6;
      this.ColumnDayFour.Name = "ColumnDayFour";
      // 
      // ColumnSumFour
      // 
      this.ColumnSumFour.FillWeight = 90.96143F;
      this.ColumnSumFour.HeaderText = "сумма";
      this.ColumnSumFour.MinimumWidth = 6;
      this.ColumnSumFour.Name = "ColumnSumFour";
      // 
      // ColumnTotal
      // 
      this.ColumnTotal.FillWeight = 90.96143F;
      this.ColumnTotal.HeaderText = "Итого";
      this.ColumnTotal.MinimumWidth = 6;
      this.ColumnTotal.Name = "ColumnTotal";
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCalculate.Location = new System.Drawing.Point(1033, 15);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(324, 45);
      this.buttonCalculate.TabIndex = 3;
      this.buttonCalculate.Text = "Вычислить";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(1029, 101);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(142, 21);
      this.label6.TabIndex = 14;
      this.label6.Text = "Кол-во структ. эл.:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(1029, 131);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(131, 21);
      this.label7.TabIndex = 16;
      this.label7.Text = "Кол-во функций:";
      // 
      // numericBoxFunctions
      // 
      this.numericBoxFunctions.Location = new System.Drawing.Point(1219, 134);
      this.numericBoxFunctions.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.numericBoxFunctions.Name = "numericBoxFunctions";
      this.numericBoxFunctions.Size = new System.Drawing.Size(124, 20);
      this.numericBoxFunctions.TabIndex = 15;
      this.numericBoxFunctions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericBoxFunctions.ValueChanged += new System.EventHandler(this.numericBoxFunctions_ValueChanged);
      // 
      // numericBoxStructuralElement
      // 
      this.numericBoxStructuralElement.Location = new System.Drawing.Point(1219, 101);
      this.numericBoxStructuralElement.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericBoxStructuralElement.Name = "numericBoxStructuralElement";
      this.numericBoxStructuralElement.Size = new System.Drawing.Size(124, 20);
      this.numericBoxStructuralElement.TabIndex = 13;
      this.numericBoxStructuralElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericBoxStructuralElement.ValueChanged += new System.EventHandler(this.numericBoxStructuralElement_ValueChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(1029, 68);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(184, 21);
      this.label8.TabIndex = 12;
      this.label8.Text = "Себестоимость системы";
      // 
      // numericBoxSystemCost
      // 
      this.numericBoxSystemCost.DecimalPlaces = 2;
      this.numericBoxSystemCost.Location = new System.Drawing.Point(1219, 68);
      this.numericBoxSystemCost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.numericBoxSystemCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericBoxSystemCost.Name = "numericBoxSystemCost";
      this.numericBoxSystemCost.Size = new System.Drawing.Size(124, 20);
      this.numericBoxSystemCost.TabIndex = 11;
      this.numericBoxSystemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericBoxSystemCost.Value = new decimal(new int[] {
            35000,
            0,
            0,
            0});
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(1029, 165);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(103, 21);
      this.label9.TabIndex = 16;
      this.label9.Text = "Сумма дней:";
      // 
      // sumDays
      // 
      this.sumDays.Enabled = false;
      this.sumDays.Location = new System.Drawing.Point(1219, 165);
      this.sumDays.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.sumDays.Name = "sumDays";
      this.sumDays.ReadOnly = true;
      this.sumDays.Size = new System.Drawing.Size(124, 20);
      this.sumDays.TabIndex = 15;
      this.sumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.sumDays.ValueChanged += new System.EventHandler(this.numericBoxFunctions_ValueChanged);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1369, 677);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.sumDays);
      this.Controls.Add(this.numericBoxFunctions);
      this.Controls.Add(this.numericBoxStructuralElement);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.numericBoxSystemCost);
      this.Controls.Add(this.buttonCalculate);
      this.Controls.Add(this.panelMain);
      this.Name = "FormMain";
      this.Text = "s";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.panelMain.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFunction)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonMatrix)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCoreCosts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxFunctions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxStructuralElement)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxSystemCost)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumDays)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvCoreCosts;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericBoxFunctions;
		private System.Windows.Forms.NumericUpDown numericBoxStructuralElement;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericBoxSystemCost;
		private System.Windows.Forms.DataGridView dgvComparisonMatrix;
		private System.Windows.Forms.DataGridView dgvFunction;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStructuralElement;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDayOne;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumOne;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDayTwo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumTwo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDayThree;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumThree;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDayFour;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumFour;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModules;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShareOfSignificance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sumDays;
    }
}

