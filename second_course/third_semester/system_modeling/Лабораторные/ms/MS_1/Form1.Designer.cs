namespace MS_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCountWorkers = new System.Windows.Forms.TextBox();
            this.tbValH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvProbs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAvgQ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAvgTimeInQ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAvgNs = new System.Windows.Forms.Label();
            this.labelProbQ = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrefTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart2nd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.prefNumWorker = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.moreThan1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во операторов";
            // 
            // tbCountWorkers
            // 
            this.tbCountWorkers.Location = new System.Drawing.Point(134, 29);
            this.tbCountWorkers.Name = "tbCountWorkers";
            this.tbCountWorkers.Size = new System.Drawing.Size(72, 20);
            this.tbCountWorkers.TabIndex = 1;
            // 
            // tbValH
            // 
            this.tbValH.Location = new System.Drawing.Point(134, 57);
            this.tbValH.Name = "tbValH";
            this.tbValH.Size = new System.Drawing.Size(72, 20);
            this.tbValH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Плотность л";
            // 
            // tbValT
            // 
            this.tbValT.Location = new System.Drawing.Point(134, 87);
            this.tbValT.Name = "tbValT";
            this.tbValT.Size = new System.Drawing.Size(72, 20);
            this.tbValT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Мат ожидание т";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 122);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Запустить ч1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // dgvProbs
            // 
            this.dgvProbs.AllowUserToDeleteRows = false;
            this.dgvProbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProbs.Location = new System.Drawing.Point(234, 170);
            this.dgvProbs.Name = "dgvProbs";
            this.dgvProbs.ReadOnly = true;
            this.dgvProbs.RowHeadersVisible = false;
            this.dgvProbs.Size = new System.Drawing.Size(323, 161);
            this.dgvProbs.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "probabilty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // labelAvgQ
            // 
            this.labelAvgQ.AutoSize = true;
            this.labelAvgQ.Location = new System.Drawing.Point(428, 29);
            this.labelAvgQ.Name = "labelAvgQ";
            this.labelAvgQ.Size = new System.Drawing.Size(13, 13);
            this.labelAvgQ.TabIndex = 8;
            this.labelAvgQ.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Средняя длина очереди";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Среднее время ожидания в очереди";
            // 
            // labelAvgTimeInQ
            // 
            this.labelAvgTimeInQ.AutoSize = true;
            this.labelAvgTimeInQ.Location = new System.Drawing.Point(428, 65);
            this.labelAvgTimeInQ.Name = "labelAvgTimeInQ";
            this.labelAvgTimeInQ.Size = new System.Drawing.Size(13, 13);
            this.labelAvgTimeInQ.TabIndex = 10;
            this.labelAvgTimeInQ.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Среднее число занятых каналов";
            // 
            // labelAvgNs
            // 
            this.labelAvgNs.AutoSize = true;
            this.labelAvgNs.Location = new System.Drawing.Point(428, 95);
            this.labelAvgNs.Name = "labelAvgNs";
            this.labelAvgNs.Size = new System.Drawing.Size(13, 13);
            this.labelAvgNs.TabIndex = 12;
            this.labelAvgNs.Text = "0";
            // 
            // labelProbQ
            // 
            this.labelProbQ.AutoSize = true;
            this.labelProbQ.Location = new System.Drawing.Point(428, 132);
            this.labelProbQ.Name = "labelProbQ";
            this.labelProbQ.Size = new System.Drawing.Size(13, 13);
            this.labelProbQ.TabIndex = 14;
            this.labelProbQ.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Вероятность наличия очереди";
            // 
            // tbPrefTime
            // 
            this.tbPrefTime.Location = new System.Drawing.Point(28, 212);
            this.tbPrefTime.Name = "tbPrefTime";
            this.tbPrefTime.Size = new System.Drawing.Size(72, 20);
            this.tbPrefTime.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Предподчт-е среднее время ожидания";
            // 
            // btnStart2nd
            // 
            this.btnStart2nd.Location = new System.Drawing.Point(28, 238);
            this.btnStart2nd.Name = "btnStart2nd";
            this.btnStart2nd.Size = new System.Drawing.Size(178, 31);
            this.btnStart2nd.TabIndex = 18;
            this.btnStart2nd.Text = "Запустить ч2";
            this.btnStart2nd.UseVisualStyleBackColor = true;
            this.btnStart2nd.Click += new System.EventHandler(this.BtnStart2nd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Необходимое кол-во операторов";
            // 
            // prefNumWorker
            // 
            this.prefNumWorker.AutoSize = true;
            this.prefNumWorker.Location = new System.Drawing.Point(100, 318);
            this.prefNumWorker.Name = "prefNumWorker";
            this.prefNumWorker.Size = new System.Drawing.Size(13, 13);
            this.prefNumWorker.TabIndex = 19;
            this.prefNumWorker.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Вероятность того будет свободен более чем 1 оператор.";
            // 
            // moreThan1
            // 
            this.moreThan1.AutoSize = true;
            this.moreThan1.Location = new System.Drawing.Point(362, 363);
            this.moreThan1.Name = "moreThan1";
            this.moreThan1.Size = new System.Drawing.Size(13, 13);
            this.moreThan1.TabIndex = 22;
            this.moreThan1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 405);
            this.Controls.Add(this.moreThan1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prefNumWorker);
            this.Controls.Add(this.btnStart2nd);
            this.Controls.Add(this.tbPrefTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelProbQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAvgNs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAvgTimeInQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAvgQ);
            this.Controls.Add(this.dgvProbs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbValT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCountWorkers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCountWorkers;
        private System.Windows.Forms.TextBox tbValH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvProbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelAvgQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAvgTimeInQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAvgNs;
        private System.Windows.Forms.Label labelProbQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrefTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart2nd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label prefNumWorker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label moreThan1;
    }
}

