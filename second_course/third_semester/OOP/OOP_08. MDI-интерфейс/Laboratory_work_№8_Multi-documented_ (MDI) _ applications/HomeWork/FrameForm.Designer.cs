namespace HomeWork {
    partial class FrameForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameForm));
            this.menuStripFrameForm = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.New_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.List_From_Other = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiWindowListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Set_Pink_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Set_Random_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Restore_all = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_all = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionMDIForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFrameForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFrameForm
            // 
            this.menuStripFrameForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.MdiWindowListItem});
            this.menuStripFrameForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripFrameForm.Name = "menuStripFrameForm";
            this.menuStripFrameForm.Size = new System.Drawing.Size(684, 24);
            this.menuStripFrameForm.TabIndex = 1;
            this.menuStripFrameForm.Text = "menuStripChild";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem5,
            this.toolStripSeparator3,
            this.New_6,
            this.Save_as,
            this.Save_All,
            this.toolStripSeparator5,
            this.List_From_Other});
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.toolStripMenuItem1.MergeIndex = 0;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "&New";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "&Open";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "&Exit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // New_6
            // 
            this.New_6.Name = "New_6";
            this.New_6.Size = new System.Drawing.Size(180, 22);
            this.New_6.Text = "New 6";
            this.New_6.Click += new System.EventHandler(this.New_6_Click);
            // 
            // Save_as
            // 
            this.Save_as.Name = "Save_as";
            this.Save_as.Size = new System.Drawing.Size(180, 22);
            this.Save_as.Text = "Save as";
            this.Save_as.Click += new System.EventHandler(this.Save_as_Click);
            // 
            // Save_All
            // 
            this.Save_All.Name = "Save_All";
            this.Save_All.Size = new System.Drawing.Size(180, 22);
            this.Save_All.Text = "Save All ";
            this.Save_All.Click += new System.EventHandler(this.Save_All_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // List_From_Other
            // 
            this.List_From_Other.Name = "List_From_Other";
            this.List_From_Other.Size = new System.Drawing.Size(180, 22);
            this.List_From_Other.Text = "List From Other";
            this.List_From_Other.Click += new System.EventHandler(this.List_From_Other_Click);
            // 
            // MdiWindowListItem
            // 
            this.MdiWindowListItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripSeparator2,
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.Set_Pink_Color,
            this.Set_Random_Color,
            this.Restore_all,
            this.Close_all,
            this.Info,
            this.collectionMDIForm});
            this.MdiWindowListItem.MergeIndex = 9;
            this.MdiWindowListItem.Name = "MdiWindowListItem";
            this.MdiWindowListItem.Size = new System.Drawing.Size(68, 20);
            this.MdiWindowListItem.Text = "&Windows";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem7.Text = "&Cascade";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem8.Text = "Tile &Horisontal";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem9.Text = "Tile &Vertical";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem2.Text = "Minimize &All ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // Set_Pink_Color
            // 
            this.Set_Pink_Color.Name = "Set_Pink_Color";
            this.Set_Pink_Color.Size = new System.Drawing.Size(184, 22);
            this.Set_Pink_Color.Text = "Set Pink Color";
            this.Set_Pink_Color.Click += new System.EventHandler(this.Set_Pink_Color_Click);
            // 
            // Set_Random_Color
            // 
            this.Set_Random_Color.Name = "Set_Random_Color";
            this.Set_Random_Color.Size = new System.Drawing.Size(184, 22);
            this.Set_Random_Color.Text = "Set Random Color ";
            this.Set_Random_Color.Click += new System.EventHandler(this.Set_Random_Color_Click);
            // 
            // Restore_all
            // 
            this.Restore_all.Name = "Restore_all";
            this.Restore_all.Size = new System.Drawing.Size(184, 22);
            this.Restore_all.Text = "Restore all ";
            this.Restore_all.Click += new System.EventHandler(this.Restore_all_Click);
            // 
            // Close_all
            // 
            this.Close_all.Name = "Close_all";
            this.Close_all.Size = new System.Drawing.Size(184, 22);
            this.Close_all.Text = "Close all ";
            this.Close_all.Click += new System.EventHandler(this.Close_all_Click);
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(184, 22);
            this.Info.Text = "Info";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // collectionMDIForm
            // 
            this.collectionMDIForm.Name = "collectionMDIForm";
            this.collectionMDIForm.Size = new System.Drawing.Size(184, 22);
            this.collectionMDIForm.Text = "Collection MDI Form";
            // 
            // FrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.menuStripFrameForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrameForm";
            this.Text = "MDI Application";
            this.Load += new System.EventHandler(this.FrameForm_Load);
            this.LocationChanged += new System.EventHandler(this.FrameForm_LocationChanged);
            this.menuStripFrameForm.ResumeLayout(false);
            this.menuStripFrameForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFrameForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MdiWindowListItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem New_6;
        private System.Windows.Forms.ToolStripMenuItem Save_as;
        private System.Windows.Forms.ToolStripMenuItem Save_All;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Set_Pink_Color;
        private System.Windows.Forms.ToolStripMenuItem Set_Random_Color;
        private System.Windows.Forms.ToolStripMenuItem Restore_all;
        private System.Windows.Forms.ToolStripMenuItem Close_all;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem collectionMDIForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem List_From_Other;
    }
}

