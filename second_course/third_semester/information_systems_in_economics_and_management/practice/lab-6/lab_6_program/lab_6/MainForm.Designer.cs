using lab_6.Properties;

namespace lab_6 {
  partial class MainForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose ( bool disposing ) {
      if ( disposing && ( components != null ) ) {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent ( ) {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel_menu = new System.Windows.Forms.Panel();
      this.button8 = new System.Windows.Forms.Button();
      this.button_showButtons = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel_logo = new System.Windows.Forms.Panel();
      this.label_logo = new System.Windows.Forms.Label();
      this.panel_header = new System.Windows.Forms.Panel();
      this.button_minimize = new System.Windows.Forms.Button();
      this.button_closeForm = new System.Windows.Forms.Button();
      this.label_header = new System.Windows.Forms.Label();
      this.button_maximize = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.DGV_dishes = new System.Windows.Forms.DataGridView();
      this.dishidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dishnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dishcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.databaseCafeDataSet = new lab_6.DatabaseCafeDataSet();
      this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_drinks = new System.Windows.Forms.DataGridView();
      this.drinkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.drinknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.drinkcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.categoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.drinkcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_final_orders = new System.Windows.Forms.DataGridView();
      this.finalorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.finalOrderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.finalordertablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.finalorderwaiterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.finalordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_general_orders = new System.Windows.Forms.DataGridView();
      this.generalorderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.generalordersdishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.dishesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.generalordersdrinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.drinksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.generalordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_ingredients = new System.Windows.Forms.DataGridView();
      this.ingredientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingredientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingredientunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingredientcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_recipes = new System.Windows.Forms.DataGridView();
      this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_staff = new System.Windows.Forms.DataGridView();
      this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.stafffullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.staffphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.staffpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DGV_categories = new System.Windows.Forms.DataGridView();
      this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.button_save = new System.Windows.Forms.Button();
      this.button_delete = new System.Windows.Forms.Button();
      this.button_add = new System.Windows.Forms.Button();
      this.categoriesTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.categoriesTableAdapter();
      this.dishesTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.dishesTableAdapter();
      this.drinksTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.drinksTableAdapter();
      this.final_ordersTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.final_ordersTableAdapter();
      this.general_ordersTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.general_ordersTableAdapter();
      this.ingredientsTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.ingredientsTableAdapter();
      this.recipesTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.recipesTableAdapter();
      this.staffTableAdapter = new lab_6.DatabaseCafeDataSetTableAdapters.staffTableAdapter();
      this.dishidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ingredientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ingredientsquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel_menu.SuspendLayout();
      this.panel_logo.SuspendLayout();
      this.panel_header.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_dishes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseCafeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_drinks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_final_orders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.finalordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_general_orders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.generalordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_ingredients)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_recipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_staff)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_categories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel_menu
      // 
      this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.panel_menu.Controls.Add(this.button8);
      this.panel_menu.Controls.Add(this.button_showButtons);
      this.panel_menu.Controls.Add(this.button7);
      this.panel_menu.Controls.Add(this.button6);
      this.panel_menu.Controls.Add(this.button5);
      this.panel_menu.Controls.Add(this.button4);
      this.panel_menu.Controls.Add(this.button3);
      this.panel_menu.Controls.Add(this.button2);
      this.panel_menu.Controls.Add(this.button1);
      this.panel_menu.Controls.Add(this.panel_logo);
      this.panel_menu.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel_menu.Location = new System.Drawing.Point(1176, 0);
      this.panel_menu.Name = "panel_menu";
      this.panel_menu.Size = new System.Drawing.Size(200, 778);
      this.panel_menu.TabIndex = 0;
      // 
      // button8
      // 
      this.button8.Dock = System.Windows.Forms.DockStyle.Top;
      this.button8.FlatAppearance.BorderSize = 0;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button8.ForeColor = System.Drawing.Color.Gainsboro;
      this.button8.Location = new System.Drawing.Point(0, 345);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(200, 40);
      this.button8.TabIndex = 8;
      this.button8.Text = "Staff";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button_showButtons
      // 
      this.button_showButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.button_showButtons.FlatAppearance.BorderSize = 0;
      this.button_showButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_showButtons.Image = ((System.Drawing.Image)(resources.GetObject("button_showButtons.Image")));
      this.button_showButtons.Location = new System.Drawing.Point(0, 708);
      this.button_showButtons.Name = "button_showButtons";
      this.button_showButtons.Size = new System.Drawing.Size(200, 70);
      this.button_showButtons.TabIndex = 5;
      this.button_showButtons.UseVisualStyleBackColor = true;
      this.button_showButtons.Click += new System.EventHandler(this.button_showButtons_Click);
      // 
      // button7
      // 
      this.button7.Dock = System.Windows.Forms.DockStyle.Top;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.ForeColor = System.Drawing.Color.Gainsboro;
      this.button7.Location = new System.Drawing.Point(0, 305);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(200, 40);
      this.button7.TabIndex = 7;
      this.button7.Text = "Recipes";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button6
      // 
      this.button6.Dock = System.Windows.Forms.DockStyle.Top;
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.ForeColor = System.Drawing.Color.Gainsboro;
      this.button6.Location = new System.Drawing.Point(0, 265);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(200, 40);
      this.button6.TabIndex = 6;
      this.button6.Text = "Ingredients";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button5
      // 
      this.button5.Dock = System.Windows.Forms.DockStyle.Top;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.ForeColor = System.Drawing.Color.Gainsboro;
      this.button5.Location = new System.Drawing.Point(0, 225);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(200, 40);
      this.button5.TabIndex = 5;
      this.button5.Text = "General orders";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Top;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.Color.Gainsboro;
      this.button4.Location = new System.Drawing.Point(0, 185);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(200, 40);
      this.button4.TabIndex = 4;
      this.button4.Text = "Final orders";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Top;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.ForeColor = System.Drawing.Color.Gainsboro;
      this.button3.Location = new System.Drawing.Point(0, 145);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(200, 40);
      this.button3.TabIndex = 3;
      this.button3.Text = "Drinks";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Top;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.Color.Gainsboro;
      this.button2.Location = new System.Drawing.Point(0, 105);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(200, 40);
      this.button2.TabIndex = 2;
      this.button2.Text = "Dishes";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.Gainsboro;
      this.button1.Location = new System.Drawing.Point(0, 65);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(200, 40);
      this.button1.TabIndex = 1;
      this.button1.Text = "Categories";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel_logo
      // 
      this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      this.panel_logo.Controls.Add(this.label_logo);
      this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_logo.Location = new System.Drawing.Point(0, 0);
      this.panel_logo.Name = "panel_logo";
      this.panel_logo.Size = new System.Drawing.Size(200, 65);
      this.panel_logo.TabIndex = 1;
      this.panel_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_logo_MouseDown);
      // 
      // label_logo
      // 
      this.label_logo.AutoSize = true;
      this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label_logo.ForeColor = System.Drawing.Color.LightGray;
      this.label_logo.Location = new System.Drawing.Point(40, 22);
      this.label_logo.Name = "label_logo";
      this.label_logo.Size = new System.Drawing.Size(121, 20);
      this.label_logo.TabIndex = 2;
      this.label_logo.Text = "Database Cafe";
      // 
      // panel_header
      // 
      this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(129)))));
      this.panel_header.Controls.Add(this.button_minimize);
      this.panel_header.Controls.Add(this.button_closeForm);
      this.panel_header.Controls.Add(this.label_header);
      this.panel_header.Controls.Add(this.button_maximize);
      this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_header.Location = new System.Drawing.Point(0, 0);
      this.panel_header.Name = "panel_header";
      this.panel_header.Size = new System.Drawing.Size(1176, 65);
      this.panel_header.TabIndex = 1;
      this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
      // 
      // button_minimize
      // 
      this.button_minimize.FlatAppearance.BorderSize = 0;
      this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_minimize.ForeColor = System.Drawing.Color.White;
      this.button_minimize.Location = new System.Drawing.Point(63, 2);
      this.button_minimize.Name = "button_minimize";
      this.button_minimize.Size = new System.Drawing.Size(25, 25);
      this.button_minimize.TabIndex = 4;
      this.button_minimize.Text = "_";
      this.button_minimize.UseVisualStyleBackColor = true;
      this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
      // 
      // button_closeForm
      // 
      this.button_closeForm.FlatAppearance.BorderSize = 0;
      this.button_closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_closeForm.ForeColor = System.Drawing.Color.White;
      this.button_closeForm.Location = new System.Drawing.Point(3, 5);
      this.button_closeForm.Name = "button_closeForm";
      this.button_closeForm.Size = new System.Drawing.Size(25, 25);
      this.button_closeForm.TabIndex = 4;
      this.button_closeForm.Text = "X";
      this.button_closeForm.UseVisualStyleBackColor = true;
      this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
      // 
      // label_header
      // 
      this.label_header.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label_header.AutoSize = true;
      this.label_header.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label_header.ForeColor = System.Drawing.Color.White;
      this.label_header.Location = new System.Drawing.Point(531, 14);
      this.label_header.Name = "label_header";
      this.label_header.Size = new System.Drawing.Size(0, 38);
      this.label_header.TabIndex = 0;
      // 
      // button_maximize
      // 
      this.button_maximize.FlatAppearance.BorderSize = 0;
      this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_maximize.Font = new System.Drawing.Font("Symbol", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_maximize.ForeColor = System.Drawing.Color.White;
      this.button_maximize.Location = new System.Drawing.Point(31, 4);
      this.button_maximize.Name = "button_maximize";
      this.button_maximize.Size = new System.Drawing.Size(25, 25);
      this.button_maximize.TabIndex = 4;
      this.button_maximize.Text = "O";
      this.button_maximize.UseVisualStyleBackColor = true;
      this.button_maximize.Click += new System.EventHandler(this.button_maximize_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.DGV_dishes);
      this.panel1.Controls.Add(this.DGV_drinks);
      this.panel1.Controls.Add(this.DGV_final_orders);
      this.panel1.Controls.Add(this.DGV_general_orders);
      this.panel1.Controls.Add(this.DGV_ingredients);
      this.panel1.Controls.Add(this.DGV_recipes);
      this.panel1.Controls.Add(this.DGV_staff);
      this.panel1.Controls.Add(this.DGV_categories);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 65);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1176, 713);
      this.panel1.TabIndex = 6;
      // 
      // DGV_dishes
      // 
      this.DGV_dishes.AutoGenerateColumns = false;
      this.DGV_dishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_dishes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_dishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_dishes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_dishes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_dishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
      this.DGV_dishes.ColumnHeadersHeight = 65;
      this.DGV_dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishidDataGridViewTextBoxColumn,
            this.dishnameDataGridViewTextBoxColumn,
            this.dishcategoryDataGridViewTextBoxColumn});
      this.DGV_dishes.DataSource = this.dishesBindingSource;
      this.DGV_dishes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_dishes.EnableHeadersVisualStyles = false;
      this.DGV_dishes.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_dishes.Location = new System.Drawing.Point(0, 0);
      this.DGV_dishes.Name = "DGV_dishes";
      this.DGV_dishes.RowHeadersVisible = false;
      this.DGV_dishes.RowHeadersWidth = 45;
      dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_dishes.RowsDefaultCellStyle = dataGridViewCellStyle18;
      this.DGV_dishes.Size = new System.Drawing.Size(1176, 713);
      this.DGV_dishes.TabIndex = 14;
      // 
      // dishidDataGridViewTextBoxColumn
      // 
      this.dishidDataGridViewTextBoxColumn.DataPropertyName = "dish_id";
      this.dishidDataGridViewTextBoxColumn.HeaderText = "dish_id";
      this.dishidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.dishidDataGridViewTextBoxColumn.Name = "dishidDataGridViewTextBoxColumn";
      // 
      // dishnameDataGridViewTextBoxColumn
      // 
      this.dishnameDataGridViewTextBoxColumn.DataPropertyName = "dish_name";
      this.dishnameDataGridViewTextBoxColumn.HeaderText = "dish_name";
      this.dishnameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.dishnameDataGridViewTextBoxColumn.Name = "dishnameDataGridViewTextBoxColumn";
      // 
      // dishcategoryDataGridViewTextBoxColumn
      // 
      this.dishcategoryDataGridViewTextBoxColumn.DataPropertyName = "dish_category";
      this.dishcategoryDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource1;
      this.dishcategoryDataGridViewTextBoxColumn.DisplayMember = "category_name";
      this.dishcategoryDataGridViewTextBoxColumn.HeaderText = "dish_category";
      this.dishcategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.dishcategoryDataGridViewTextBoxColumn.Name = "dishcategoryDataGridViewTextBoxColumn";
      this.dishcategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dishcategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.dishcategoryDataGridViewTextBoxColumn.ValueMember = "category_id";
      // 
      // categoriesBindingSource1
      // 
      this.categoriesBindingSource1.DataMember = "categories";
      this.categoriesBindingSource1.DataSource = this.databaseCafeDataSet;
      // 
      // databaseCafeDataSet
      // 
      this.databaseCafeDataSet.DataSetName = "DatabaseCafeDataSet";
      this.databaseCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dishesBindingSource
      // 
      this.dishesBindingSource.DataMember = "dishes";
      this.dishesBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_drinks
      // 
      this.DGV_drinks.AutoGenerateColumns = false;
      this.DGV_drinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_drinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_drinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_drinks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_drinks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_drinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
      this.DGV_drinks.ColumnHeadersHeight = 65;
      this.DGV_drinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinkidDataGridViewTextBoxColumn,
            this.drinknameDataGridViewTextBoxColumn,
            this.drinkcategoryDataGridViewTextBoxColumn,
            this.drinkcostDataGridViewTextBoxColumn});
      this.DGV_drinks.DataSource = this.drinksBindingSource;
      this.DGV_drinks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_drinks.EnableHeadersVisualStyles = false;
      this.DGV_drinks.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_drinks.Location = new System.Drawing.Point(0, 0);
      this.DGV_drinks.Name = "DGV_drinks";
      this.DGV_drinks.RowHeadersVisible = false;
      this.DGV_drinks.RowHeadersWidth = 45;
      dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_drinks.RowsDefaultCellStyle = dataGridViewCellStyle20;
      this.DGV_drinks.Size = new System.Drawing.Size(1176, 713);
      this.DGV_drinks.TabIndex = 15;
      // 
      // drinkidDataGridViewTextBoxColumn
      // 
      this.drinkidDataGridViewTextBoxColumn.DataPropertyName = "drink_id";
      this.drinkidDataGridViewTextBoxColumn.HeaderText = "drink_id";
      this.drinkidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.drinkidDataGridViewTextBoxColumn.Name = "drinkidDataGridViewTextBoxColumn";
      // 
      // drinknameDataGridViewTextBoxColumn
      // 
      this.drinknameDataGridViewTextBoxColumn.DataPropertyName = "drink_name";
      this.drinknameDataGridViewTextBoxColumn.HeaderText = "drink_name";
      this.drinknameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.drinknameDataGridViewTextBoxColumn.Name = "drinknameDataGridViewTextBoxColumn";
      // 
      // drinkcategoryDataGridViewTextBoxColumn
      // 
      this.drinkcategoryDataGridViewTextBoxColumn.DataPropertyName = "drink_category";
      this.drinkcategoryDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource2;
      this.drinkcategoryDataGridViewTextBoxColumn.DisplayMember = "category_name";
      this.drinkcategoryDataGridViewTextBoxColumn.HeaderText = "drink_category";
      this.drinkcategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.drinkcategoryDataGridViewTextBoxColumn.Name = "drinkcategoryDataGridViewTextBoxColumn";
      this.drinkcategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.drinkcategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.drinkcategoryDataGridViewTextBoxColumn.ValueMember = "category_id";
      // 
      // categoriesBindingSource2
      // 
      this.categoriesBindingSource2.DataMember = "categories";
      this.categoriesBindingSource2.DataSource = this.databaseCafeDataSet;
      // 
      // drinkcostDataGridViewTextBoxColumn
      // 
      this.drinkcostDataGridViewTextBoxColumn.DataPropertyName = "drink_cost";
      this.drinkcostDataGridViewTextBoxColumn.HeaderText = "drink_cost";
      this.drinkcostDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.drinkcostDataGridViewTextBoxColumn.Name = "drinkcostDataGridViewTextBoxColumn";
      // 
      // drinksBindingSource
      // 
      this.drinksBindingSource.DataMember = "drinks";
      this.drinksBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_final_orders
      // 
      this.DGV_final_orders.AutoGenerateColumns = false;
      this.DGV_final_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_final_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_final_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_final_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_final_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_final_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
      this.DGV_final_orders.ColumnHeadersHeight = 65;
      this.DGV_final_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finalorderDataGridViewTextBoxColumn,
            this.finalOrderdateDataGridViewTextBoxColumn,
            this.finalordertablenumberDataGridViewTextBoxColumn,
            this.finalorderwaiterDataGridViewTextBoxColumn});
      this.DGV_final_orders.DataSource = this.finalordersBindingSource;
      this.DGV_final_orders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_final_orders.EnableHeadersVisualStyles = false;
      this.DGV_final_orders.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_final_orders.Location = new System.Drawing.Point(0, 0);
      this.DGV_final_orders.Name = "DGV_final_orders";
      this.DGV_final_orders.RowHeadersVisible = false;
      this.DGV_final_orders.RowHeadersWidth = 45;
      dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_final_orders.RowsDefaultCellStyle = dataGridViewCellStyle22;
      this.DGV_final_orders.Size = new System.Drawing.Size(1176, 713);
      this.DGV_final_orders.TabIndex = 16;
      // 
      // finalorderDataGridViewTextBoxColumn
      // 
      this.finalorderDataGridViewTextBoxColumn.DataPropertyName = "final_order";
      this.finalorderDataGridViewTextBoxColumn.HeaderText = "final_order";
      this.finalorderDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.finalorderDataGridViewTextBoxColumn.Name = "finalorderDataGridViewTextBoxColumn";
      // 
      // finalOrderdateDataGridViewTextBoxColumn
      // 
      this.finalOrderdateDataGridViewTextBoxColumn.DataPropertyName = "final order_date";
      this.finalOrderdateDataGridViewTextBoxColumn.HeaderText = "final order_date";
      this.finalOrderdateDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.finalOrderdateDataGridViewTextBoxColumn.Name = "finalOrderdateDataGridViewTextBoxColumn";
      // 
      // finalordertablenumberDataGridViewTextBoxColumn
      // 
      this.finalordertablenumberDataGridViewTextBoxColumn.DataPropertyName = "final_order_table_number";
      this.finalordertablenumberDataGridViewTextBoxColumn.HeaderText = "final_order_table_number";
      this.finalordertablenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.finalordertablenumberDataGridViewTextBoxColumn.Name = "finalordertablenumberDataGridViewTextBoxColumn";
      // 
      // finalorderwaiterDataGridViewTextBoxColumn
      // 
      this.finalorderwaiterDataGridViewTextBoxColumn.DataPropertyName = "final_order_waiter";
      this.finalorderwaiterDataGridViewTextBoxColumn.DataSource = this.staffBindingSource1;
      this.finalorderwaiterDataGridViewTextBoxColumn.DisplayMember = "staff_full_name";
      this.finalorderwaiterDataGridViewTextBoxColumn.HeaderText = "final_order_waiter";
      this.finalorderwaiterDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.finalorderwaiterDataGridViewTextBoxColumn.Name = "finalorderwaiterDataGridViewTextBoxColumn";
      this.finalorderwaiterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.finalorderwaiterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.finalorderwaiterDataGridViewTextBoxColumn.ValueMember = "staff_id";
      // 
      // staffBindingSource1
      // 
      this.staffBindingSource1.DataMember = "staff";
      this.staffBindingSource1.DataSource = this.databaseCafeDataSet;
      // 
      // finalordersBindingSource
      // 
      this.finalordersBindingSource.DataMember = "final_orders";
      this.finalordersBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_general_orders
      // 
      this.DGV_general_orders.AutoGenerateColumns = false;
      this.DGV_general_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_general_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_general_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_general_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_general_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_general_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
      this.DGV_general_orders.ColumnHeadersHeight = 65;
      this.DGV_general_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.generalorderidDataGridViewTextBoxColumn,
            this.generalordersdishDataGridViewTextBoxColumn,
            this.generalordersdrinkDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
      this.DGV_general_orders.DataSource = this.generalordersBindingSource;
      this.DGV_general_orders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_general_orders.EnableHeadersVisualStyles = false;
      this.DGV_general_orders.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_general_orders.Location = new System.Drawing.Point(0, 0);
      this.DGV_general_orders.Name = "DGV_general_orders";
      this.DGV_general_orders.RowHeadersVisible = false;
      this.DGV_general_orders.RowHeadersWidth = 45;
      dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_general_orders.RowsDefaultCellStyle = dataGridViewCellStyle24;
      this.DGV_general_orders.Size = new System.Drawing.Size(1176, 713);
      this.DGV_general_orders.TabIndex = 17;
      // 
      // generalorderidDataGridViewTextBoxColumn
      // 
      this.generalorderidDataGridViewTextBoxColumn.DataPropertyName = "general_order_id";
      this.generalorderidDataGridViewTextBoxColumn.HeaderText = "general_order_id";
      this.generalorderidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.generalorderidDataGridViewTextBoxColumn.Name = "generalorderidDataGridViewTextBoxColumn";
      // 
      // generalordersdishDataGridViewTextBoxColumn
      // 
      this.generalordersdishDataGridViewTextBoxColumn.DataPropertyName = "general_orders_dish";
      this.generalordersdishDataGridViewTextBoxColumn.DataSource = this.dishesBindingSource1;
      this.generalordersdishDataGridViewTextBoxColumn.DisplayMember = "dish_name";
      this.generalordersdishDataGridViewTextBoxColumn.HeaderText = "general_orders_dish";
      this.generalordersdishDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.generalordersdishDataGridViewTextBoxColumn.Name = "generalordersdishDataGridViewTextBoxColumn";
      this.generalordersdishDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.generalordersdishDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.generalordersdishDataGridViewTextBoxColumn.ValueMember = "dish_id";
      // 
      // dishesBindingSource1
      // 
      this.dishesBindingSource1.DataMember = "dishes";
      this.dishesBindingSource1.DataSource = this.databaseCafeDataSet;
      // 
      // generalordersdrinkDataGridViewTextBoxColumn
      // 
      this.generalordersdrinkDataGridViewTextBoxColumn.DataPropertyName = "general_orders_drink";
      this.generalordersdrinkDataGridViewTextBoxColumn.DataSource = this.drinksBindingSource1;
      this.generalordersdrinkDataGridViewTextBoxColumn.DisplayMember = "drink_name";
      this.generalordersdrinkDataGridViewTextBoxColumn.HeaderText = "general_orders_drink";
      this.generalordersdrinkDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.generalordersdrinkDataGridViewTextBoxColumn.Name = "generalordersdrinkDataGridViewTextBoxColumn";
      this.generalordersdrinkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.generalordersdrinkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.generalordersdrinkDataGridViewTextBoxColumn.ValueMember = "drink_id";
      // 
      // drinksBindingSource1
      // 
      this.drinksBindingSource1.DataMember = "drinks";
      this.drinksBindingSource1.DataSource = this.databaseCafeDataSet;
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
      this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      // 
      // generalordersBindingSource
      // 
      this.generalordersBindingSource.DataMember = "general_orders";
      this.generalordersBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_ingredients
      // 
      this.DGV_ingredients.AutoGenerateColumns = false;
      this.DGV_ingredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_ingredients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_ingredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_ingredients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_ingredients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_ingredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
      this.DGV_ingredients.ColumnHeadersHeight = 65;
      this.DGV_ingredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientidDataGridViewTextBoxColumn,
            this.ingredientnameDataGridViewTextBoxColumn,
            this.ingredientunitDataGridViewTextBoxColumn,
            this.ingredientcostDataGridViewTextBoxColumn});
      this.DGV_ingredients.DataSource = this.ingredientsBindingSource;
      this.DGV_ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_ingredients.EnableHeadersVisualStyles = false;
      this.DGV_ingredients.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_ingredients.Location = new System.Drawing.Point(0, 0);
      this.DGV_ingredients.Name = "DGV_ingredients";
      this.DGV_ingredients.RowHeadersVisible = false;
      this.DGV_ingredients.RowHeadersWidth = 45;
      dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_ingredients.RowsDefaultCellStyle = dataGridViewCellStyle26;
      this.DGV_ingredients.Size = new System.Drawing.Size(1176, 713);
      this.DGV_ingredients.TabIndex = 18;
      // 
      // ingredientidDataGridViewTextBoxColumn
      // 
      this.ingredientidDataGridViewTextBoxColumn.DataPropertyName = "ingredient_id";
      this.ingredientidDataGridViewTextBoxColumn.HeaderText = "ingredient_id";
      this.ingredientidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ingredientidDataGridViewTextBoxColumn.Name = "ingredientidDataGridViewTextBoxColumn";
      // 
      // ingredientnameDataGridViewTextBoxColumn
      // 
      this.ingredientnameDataGridViewTextBoxColumn.DataPropertyName = "ingredient_name";
      this.ingredientnameDataGridViewTextBoxColumn.HeaderText = "ingredient_name";
      this.ingredientnameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ingredientnameDataGridViewTextBoxColumn.Name = "ingredientnameDataGridViewTextBoxColumn";
      // 
      // ingredientunitDataGridViewTextBoxColumn
      // 
      this.ingredientunitDataGridViewTextBoxColumn.DataPropertyName = "ingredient_unit";
      this.ingredientunitDataGridViewTextBoxColumn.HeaderText = "ingredient_unit";
      this.ingredientunitDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ingredientunitDataGridViewTextBoxColumn.Name = "ingredientunitDataGridViewTextBoxColumn";
      // 
      // ingredientcostDataGridViewTextBoxColumn
      // 
      this.ingredientcostDataGridViewTextBoxColumn.DataPropertyName = "ingredient_cost";
      this.ingredientcostDataGridViewTextBoxColumn.HeaderText = "ingredient_cost";
      this.ingredientcostDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ingredientcostDataGridViewTextBoxColumn.Name = "ingredientcostDataGridViewTextBoxColumn";
      // 
      // ingredientsBindingSource
      // 
      this.ingredientsBindingSource.DataMember = "ingredients";
      this.ingredientsBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_recipes
      // 
      this.DGV_recipes.AutoGenerateColumns = false;
      this.DGV_recipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_recipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_recipes.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_recipes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_recipes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_recipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
      this.DGV_recipes.ColumnHeadersHeight = 65;
      this.DGV_recipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishidDataGridViewTextBoxColumn1,
            this.ingredientidDataGridViewTextBoxColumn1,
            this.ingredientsquantityDataGridViewTextBoxColumn});
      this.DGV_recipes.DataSource = this.recipesBindingSource;
      this.DGV_recipes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_recipes.EnableHeadersVisualStyles = false;
      this.DGV_recipes.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_recipes.Location = new System.Drawing.Point(0, 0);
      this.DGV_recipes.Name = "DGV_recipes";
      this.DGV_recipes.RowHeadersVisible = false;
      this.DGV_recipes.RowHeadersWidth = 45;
      dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_recipes.RowsDefaultCellStyle = dataGridViewCellStyle28;
      this.DGV_recipes.Size = new System.Drawing.Size(1176, 713);
      this.DGV_recipes.TabIndex = 19;
      // 
      // ingredientsBindingSource1
      // 
      this.ingredientsBindingSource1.DataMember = "ingredients";
      this.ingredientsBindingSource1.DataSource = this.databaseCafeDataSet;
      // 
      // recipesBindingSource
      // 
      this.recipesBindingSource.DataMember = "recipes";
      this.recipesBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_staff
      // 
      this.DGV_staff.AutoGenerateColumns = false;
      this.DGV_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_staff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
      this.DGV_staff.ColumnHeadersHeight = 65;
      this.DGV_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.stafffullnameDataGridViewTextBoxColumn,
            this.staffphoneDataGridViewTextBoxColumn,
            this.staffpostDataGridViewTextBoxColumn});
      this.DGV_staff.DataSource = this.staffBindingSource;
      this.DGV_staff.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_staff.EnableHeadersVisualStyles = false;
      this.DGV_staff.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_staff.Location = new System.Drawing.Point(0, 0);
      this.DGV_staff.Name = "DGV_staff";
      this.DGV_staff.RowHeadersVisible = false;
      this.DGV_staff.RowHeadersWidth = 45;
      dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_staff.RowsDefaultCellStyle = dataGridViewCellStyle30;
      this.DGV_staff.Size = new System.Drawing.Size(1176, 713);
      this.DGV_staff.TabIndex = 20;
      // 
      // staffidDataGridViewTextBoxColumn
      // 
      this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
      this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
      this.staffidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
      // 
      // stafffullnameDataGridViewTextBoxColumn
      // 
      this.stafffullnameDataGridViewTextBoxColumn.DataPropertyName = "staff_full_name";
      this.stafffullnameDataGridViewTextBoxColumn.HeaderText = "staff_full_name";
      this.stafffullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.stafffullnameDataGridViewTextBoxColumn.Name = "stafffullnameDataGridViewTextBoxColumn";
      // 
      // staffphoneDataGridViewTextBoxColumn
      // 
      this.staffphoneDataGridViewTextBoxColumn.DataPropertyName = "staff_phone";
      this.staffphoneDataGridViewTextBoxColumn.HeaderText = "staff_phone";
      this.staffphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.staffphoneDataGridViewTextBoxColumn.Name = "staffphoneDataGridViewTextBoxColumn";
      // 
      // staffpostDataGridViewTextBoxColumn
      // 
      this.staffpostDataGridViewTextBoxColumn.DataPropertyName = "staff_post";
      this.staffpostDataGridViewTextBoxColumn.HeaderText = "staff_post";
      this.staffpostDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.staffpostDataGridViewTextBoxColumn.Name = "staffpostDataGridViewTextBoxColumn";
      // 
      // staffBindingSource
      // 
      this.staffBindingSource.DataMember = "staff";
      this.staffBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // DGV_categories
      // 
      this.DGV_categories.AutoGenerateColumns = false;
      this.DGV_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DGV_categories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.DGV_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGV_categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.DGV_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Gainsboro;
      dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DGV_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
      this.DGV_categories.ColumnHeadersHeight = 65;
      this.DGV_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn});
      this.DGV_categories.DataSource = this.categoriesBindingSource;
      this.DGV_categories.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DGV_categories.EnableHeadersVisualStyles = false;
      this.DGV_categories.GridColor = System.Drawing.Color.SteelBlue;
      this.DGV_categories.Location = new System.Drawing.Point(0, 0);
      this.DGV_categories.Name = "DGV_categories";
      this.DGV_categories.RowHeadersVisible = false;
      this.DGV_categories.RowHeadersWidth = 45;
      dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
      dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SteelBlue;
      dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
      this.DGV_categories.RowsDefaultCellStyle = dataGridViewCellStyle32;
      this.DGV_categories.Size = new System.Drawing.Size(1176, 713);
      this.DGV_categories.TabIndex = 13;
      // 
      // categoryidDataGridViewTextBoxColumn
      // 
      this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
      this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
      this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
      // 
      // categorynameDataGridViewTextBoxColumn
      // 
      this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
      this.categorynameDataGridViewTextBoxColumn.HeaderText = "category_name";
      this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
      // 
      // categoriesBindingSource
      // 
      this.categoriesBindingSource.DataMember = "categories";
      this.categoriesBindingSource.DataSource = this.databaseCafeDataSet;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.panel2.Controls.Add(this.button_save);
      this.panel2.Controls.Add(this.button_delete);
      this.panel2.Controls.Add(this.button_add);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 671);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1176, 107);
      this.panel2.TabIndex = 7;
      // 
      // button_save
      // 
      this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(129)))));
      this.button_save.Enabled = false;
      this.button_save.FlatAppearance.BorderSize = 0;
      this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_save.ForeColor = System.Drawing.Color.White;
      this.button_save.Location = new System.Drawing.Point(993, 30);
      this.button_save.Name = "button_save";
      this.button_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.button_save.Size = new System.Drawing.Size(100, 54);
      this.button_save.TabIndex = 6;
      this.button_save.Text = "Сохранить";
      this.button_save.UseVisualStyleBackColor = false;
      this.button_save.Visible = false;
      this.button_save.Click += new System.EventHandler(this.button_save_Click_1);
      // 
      // button_delete
      // 
      this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(129)))));
      this.button_delete.FlatAppearance.BorderSize = 0;
      this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_delete.ForeColor = System.Drawing.Color.White;
      this.button_delete.Location = new System.Drawing.Point(897, 34);
      this.button_delete.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
      this.button_delete.Name = "button_delete";
      this.button_delete.Size = new System.Drawing.Size(90, 46);
      this.button_delete.TabIndex = 7;
      this.button_delete.Text = "Удалить";
      this.button_delete.UseVisualStyleBackColor = false;
      this.button_delete.Visible = false;
      this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
      // 
      // button_add
      // 
      this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(129)))));
      this.button_add.FlatAppearance.BorderSize = 0;
      this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button_add.ForeColor = System.Drawing.Color.White;
      this.button_add.Location = new System.Drawing.Point(811, 38);
      this.button_add.Name = "button_add";
      this.button_add.Size = new System.Drawing.Size(80, 38);
      this.button_add.TabIndex = 8;
      this.button_add.Text = "Добавить";
      this.button_add.UseVisualStyleBackColor = false;
      this.button_add.Visible = false;
      this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
      // 
      // categoriesTableAdapter
      // 
      this.categoriesTableAdapter.ClearBeforeFill = true;
      // 
      // dishesTableAdapter
      // 
      this.dishesTableAdapter.ClearBeforeFill = true;
      // 
      // drinksTableAdapter
      // 
      this.drinksTableAdapter.ClearBeforeFill = true;
      // 
      // final_ordersTableAdapter
      // 
      this.final_ordersTableAdapter.ClearBeforeFill = true;
      // 
      // general_ordersTableAdapter
      // 
      this.general_ordersTableAdapter.ClearBeforeFill = true;
      // 
      // ingredientsTableAdapter
      // 
      this.ingredientsTableAdapter.ClearBeforeFill = true;
      // 
      // recipesTableAdapter
      // 
      this.recipesTableAdapter.ClearBeforeFill = true;
      // 
      // staffTableAdapter
      // 
      this.staffTableAdapter.ClearBeforeFill = true;
      // 
      // dishidDataGridViewTextBoxColumn1
      // 
      this.dishidDataGridViewTextBoxColumn1.DataPropertyName = "dish_id";
      this.dishidDataGridViewTextBoxColumn1.DataSource = this.dishesBindingSource;
      this.dishidDataGridViewTextBoxColumn1.DisplayMember = "dish_name";
      this.dishidDataGridViewTextBoxColumn1.HeaderText = "dish_id";
      this.dishidDataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dishidDataGridViewTextBoxColumn1.Name = "dishidDataGridViewTextBoxColumn1";
      this.dishidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dishidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.dishidDataGridViewTextBoxColumn1.ValueMember = "dish_id";
      // 
      // ingredientidDataGridViewTextBoxColumn1
      // 
      this.ingredientidDataGridViewTextBoxColumn1.DataPropertyName = "ingredient_id";
      this.ingredientidDataGridViewTextBoxColumn1.DataSource = this.ingredientsBindingSource1;
      this.ingredientidDataGridViewTextBoxColumn1.DisplayMember = "ingredient_name";
      this.ingredientidDataGridViewTextBoxColumn1.HeaderText = "ingredient_id";
      this.ingredientidDataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.ingredientidDataGridViewTextBoxColumn1.Name = "ingredientidDataGridViewTextBoxColumn1";
      this.ingredientidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ingredientidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.ingredientidDataGridViewTextBoxColumn1.ValueMember = "ingredient_id";
      // 
      // ingredientsquantityDataGridViewTextBoxColumn
      // 
      this.ingredientsquantityDataGridViewTextBoxColumn.DataPropertyName = "ingredients_quantity";
      this.ingredientsquantityDataGridViewTextBoxColumn.HeaderText = "ingredients_quantity";
      this.ingredientsquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ingredientsquantityDataGridViewTextBoxColumn.Name = "ingredientsquantityDataGridViewTextBoxColumn";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
      this.ClientSize = new System.Drawing.Size(1376, 778);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel_header);
      this.Controls.Add(this.panel_menu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.panel_menu.ResumeLayout(false);
      this.panel_logo.ResumeLayout(false);
      this.panel_logo.PerformLayout();
      this.panel_header.ResumeLayout(false);
      this.panel_header.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DGV_dishes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseCafeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_drinks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_final_orders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.finalordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_general_orders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.generalordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_ingredients)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_recipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_staff)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DGV_categories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Button button_maximize;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_closeForm;
        private System.Windows.Forms.Button button_showButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_dishes;
        private System.Windows.Forms.DataGridView DGV_drinks;
        private System.Windows.Forms.DataGridView DGV_final_orders;
        private System.Windows.Forms.DataGridView DGV_general_orders;
        private System.Windows.Forms.DataGridView DGV_ingredients;
        private System.Windows.Forms.DataGridView DGV_recipes;
        private System.Windows.Forms.DataGridView DGV_staff;
        private System.Windows.Forms.DataGridView DGV_categories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private DatabaseCafeDataSet databaseCafeDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DatabaseCafeDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private DatabaseCafeDataSetTableAdapters.dishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private DatabaseCafeDataSetTableAdapters.drinksTableAdapter drinksTableAdapter;
        private System.Windows.Forms.BindingSource finalordersBindingSource;
        private DatabaseCafeDataSetTableAdapters.final_ordersTableAdapter final_ordersTableAdapter;
        private System.Windows.Forms.BindingSource generalordersBindingSource;
        private DatabaseCafeDataSetTableAdapters.general_ordersTableAdapter general_ordersTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private DatabaseCafeDataSetTableAdapters.ingredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private DatabaseCafeDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DatabaseCafeDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stafffullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dishcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drinkcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinkcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalOrderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalordertablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn finalorderwaiterDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generalorderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn generalordersdishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dishesBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn generalordersdrinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drinksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ingredientsBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dishidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ingredientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsquantityDataGridViewTextBoxColumn;
    }
}

