namespace Babeshin
{
    partial class About
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ACCESS");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("EXCEL");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Готовые решения данного прилодения", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Документация в виде отчета");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Дополнительные данные", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа предназначена для автоматизации учета выдачи книг \r\nв библиотеке" +
    " “библиотека”.\r\nФункционал данного приложения также представленно в \r\n *Excel Of" +
    "fice 365;\r\n *Access Office 365\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 97);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "access";
            treeNode1.Text = "ACCESS";
            treeNode2.Name = "excel";
            treeNode2.Text = "EXCEL";
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Готовые решения данного прилодения";
            treeNode4.ForeColor = System.Drawing.Color.Black;
            treeNode4.Name = "doc";
            treeNode4.Text = "Документация в виде отчета";
            treeNode5.ForeColor = System.Drawing.Color.Black;
            treeNode5.Name = "Узел0";
            treeNode5.Text = "Дополнительные данные";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(502, 111);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 224);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
    }
}