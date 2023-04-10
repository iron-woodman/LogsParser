namespace LogsParser
{
    partial class frmGlobalUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlobalUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Window_Minimize = new System.Windows.Forms.Button();
            this.btn_Window_Close = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWorkParams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tssOptions = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBenchmark = new System.Windows.Forms.Label();
            this.tpGeneral = new LogsParser.XTabControl();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.xPanel_Itemns_Search = new LogsParser.XPanel();
            this.btnSearchItems = new LogsParser.XButton();
            this.tbItemsSearch = new LogsParser.XTextBox();
            this.xPanelItems = new LogsParser.XPanel();
            this.dgvItems = new LogsParser.XDataGridView();
            this.tpBuffs = new System.Windows.Forms.TabPage();
            this.xPanel_Buffs_Search = new LogsParser.XPanel();
            this.btnBuffsSearch = new LogsParser.XButton();
            this.tbBuffsSearch = new LogsParser.XTextBox();
            this.xPanelBuffs = new LogsParser.XPanel();
            this.dgvBuffs = new LogsParser.XDataGridView();
            this.tpSpawn = new System.Windows.Forms.TabPage();
            this.xPanel_MonsterSearch = new LogsParser.XPanel();
            this.btnMonsterSearch = new LogsParser.XButton();
            this.tbMonsterSearch = new LogsParser.XTextBox();
            this.xPanelMonster = new LogsParser.XPanel();
            this.dgvMonster = new LogsParser.XDataGridView();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnChangeColor = new LogsParser.XButton();
            this.lbAbout = new System.Windows.Forms.Label();
            this.pbMX = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpItems.SuspendLayout();
            this.xPanel_Itemns_Search.SuspendLayout();
            this.xPanelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tpBuffs.SuspendLayout();
            this.xPanel_Buffs_Search.SuspendLayout();
            this.xPanelBuffs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuffs)).BeginInit();
            this.tpSpawn.SuspendLayout();
            this.xPanel_MonsterSearch.SuspendLayout();
            this.xPanelMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonster)).BeginInit();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Window_Minimize);
            this.panel1.Controls.Add(this.btn_Window_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Window);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LogsParser.Properties.Resources.Resize3;
            this.button1.Location = new System.Drawing.Point(917, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Window_Resize_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::LogsParser.Properties.Resources.GM_ToolBlue;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(26, 26);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogsParser v1.0";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Window);
            // 
            // btn_Window_Minimize
            // 
            this.btn_Window_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Window_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Window_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Window_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Window_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Window_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Window_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Window_Minimize.Image = global::LogsParser.Properties.Resources.Minimize3;
            this.btn_Window_Minimize.Location = new System.Drawing.Point(892, 0);
            this.btn_Window_Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Window_Minimize.Name = "btn_Window_Minimize";
            this.btn_Window_Minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_Window_Minimize.TabIndex = 3;
            this.btn_Window_Minimize.UseVisualStyleBackColor = false;
            this.btn_Window_Minimize.Click += new System.EventHandler(this.btn_Window_Minimize_Click);
            // 
            // btn_Window_Close
            // 
            this.btn_Window_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Window_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Window_Close.FlatAppearance.BorderSize = 0;
            this.btn_Window_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Window_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_Window_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Window_Close.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Window_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_Window_Close.Location = new System.Drawing.Point(942, 0);
            this.btn_Window_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Window_Close.Name = "btn_Window_Close";
            this.btn_Window_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Window_Close.TabIndex = 1;
            this.btn_Window_Close.Text = "X";
            this.btn_Window_Close.UseVisualStyleBackColor = false;
            this.btn_Window_Close.Click += new System.EventHandler(this.btn_Window_Close_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 28);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(950, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fILEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWorkParams,
            this.tsmiDatabase,
            this.tssOptions,
            this.выйтиToolStripMenuItem});
            this.fILEToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.fILEToolStripMenuItem.Text = "OPTIONS";
            // 
            // tsmiWorkParams
            // 
            this.tsmiWorkParams.BackColor = System.Drawing.Color.Transparent;
            this.tsmiWorkParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tsmiWorkParams.Name = "tsmiWorkParams";
            this.tsmiWorkParams.Size = new System.Drawing.Size(200, 22);
            this.tsmiWorkParams.Text = "Рабочие параметры...";
            // 
            // tsmiDatabase
            // 
            this.tsmiDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tsmiDatabase.Name = "tsmiDatabase";
            this.tsmiDatabase.Size = new System.Drawing.Size(200, 22);
            this.tsmiDatabase.Text = "Подключение к БД...";
            this.tsmiDatabase.Click += new System.EventHandler(this.tsmiDatabase_Click);
            // 
            // tssOptions
            // 
            this.tssOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tssOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tssOptions.Name = "tssOptions";
            this.tssOptions.Size = new System.Drawing.Size(197, 6);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выйтиToolStripMenuItem.Text = "Завершить работу";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // lbBenchmark
            // 
            this.lbBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBenchmark.AutoSize = true;
            this.lbBenchmark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBenchmark.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbBenchmark.Location = new System.Drawing.Point(19, 411);
            this.lbBenchmark.Name = "lbBenchmark";
            this.lbBenchmark.Size = new System.Drawing.Size(101, 13);
            this.lbBenchmark.TabIndex = 7;
            this.lbBenchmark.Text = "Соединение с БД:";
            this.lbBenchmark.Click += new System.EventHandler(this.CopyrightClicked);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tpGeneral.ColorStyle = LogsParser.XColorStyle.Blue;
            this.tpGeneral.Controls.Add(this.tpItems);
            this.tpGeneral.Controls.Add(this.tpBuffs);
            this.tpGeneral.Controls.Add(this.tpSpawn);
            this.tpGeneral.Controls.Add(this.tpAbout);
            this.tpGeneral.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tpGeneral.ItemSize = new System.Drawing.Size(150, 28);
            this.tpGeneral.Location = new System.Drawing.Point(4, 53);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Drawing.Point(0, 0);
            this.tpGeneral.SelectedIndex = 0;
            this.tpGeneral.SelectedTabBackroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tpGeneral.Size = new System.Drawing.Size(955, 356);
            this.tpGeneral.TabBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tpGeneral.TabFont = new System.Drawing.Font("Segoe UI", 9F);
            this.tpGeneral.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tpGeneral.TabIndex = 2;
            // 
            // tpItems
            // 
            this.tpItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tpItems.Controls.Add(this.xPanel_Itemns_Search);
            this.tpItems.Controls.Add(this.xPanelItems);
            this.tpItems.Location = new System.Drawing.Point(4, 32);
            this.tpItems.Name = "tpItems";
            this.tpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpItems.Size = new System.Drawing.Size(947, 320);
            this.tpItems.TabIndex = 1;
            this.tpItems.Text = "Items";
            // 
            // xPanel_Itemns_Search
            // 
            this.xPanel_Itemns_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanel_Itemns_Search.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanel_Itemns_Search.Controls.Add(this.btnSearchItems);
            this.xPanel_Itemns_Search.Controls.Add(this.tbItemsSearch);
            this.xPanel_Itemns_Search.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanel_Itemns_Search.Location = new System.Drawing.Point(762, 6);
            this.xPanel_Itemns_Search.Name = "xPanel_Itemns_Search";
            this.xPanel_Itemns_Search.Size = new System.Drawing.Size(177, 308);
            this.xPanel_Itemns_Search.TabIndex = 7;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearchItems.ColorStyle = LogsParser.XColorStyle.Blue;
            this.btnSearchItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnSearchItems.Location = new System.Drawing.Point(112, 17);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(56, 23);
            this.btnSearchItems.TabIndex = 1;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            this.btnSearchItems.Click += new System.EventHandler(this.SearchGridView);
            // 
            // tbItemsSearch
            // 
            this.tbItemsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tbItemsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemsSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.tbItemsSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tbItemsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbItemsSearch.Location = new System.Drawing.Point(7, 18);
            this.tbItemsSearch.Name = "tbItemsSearch";
            this.tbItemsSearch.NumericTextBox = false;
            this.tbItemsSearch.Size = new System.Drawing.Size(99, 22);
            this.tbItemsSearch.TabIndex = 0;
            // 
            // xPanelItems
            // 
            this.xPanelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanelItems.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanelItems.Controls.Add(this.dgvItems);
            this.xPanelItems.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanelItems.Location = new System.Drawing.Point(6, 6);
            this.xPanelItems.Name = "xPanelItems";
            this.xPanelItems.Size = new System.Drawing.Size(757, 308);
            this.xPanelItems.TabIndex = 1;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColorStyle = LogsParser.XColorStyle.Blue;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dgvItems.Location = new System.Drawing.Point(3, 3);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(749, 302);
            this.dgvItems.TabIndex = 0;
            // 
            // tpBuffs
            // 
            this.tpBuffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tpBuffs.Controls.Add(this.xPanel_Buffs_Search);
            this.tpBuffs.Controls.Add(this.xPanelBuffs);
            this.tpBuffs.Location = new System.Drawing.Point(4, 32);
            this.tpBuffs.Name = "tpBuffs";
            this.tpBuffs.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuffs.Size = new System.Drawing.Size(947, 320);
            this.tpBuffs.TabIndex = 2;
            this.tpBuffs.Text = "Buffs";
            // 
            // xPanel_Buffs_Search
            // 
            this.xPanel_Buffs_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanel_Buffs_Search.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanel_Buffs_Search.Controls.Add(this.btnBuffsSearch);
            this.xPanel_Buffs_Search.Controls.Add(this.tbBuffsSearch);
            this.xPanel_Buffs_Search.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanel_Buffs_Search.Location = new System.Drawing.Point(762, 6);
            this.xPanel_Buffs_Search.Name = "xPanel_Buffs_Search";
            this.xPanel_Buffs_Search.Size = new System.Drawing.Size(177, 308);
            this.xPanel_Buffs_Search.TabIndex = 8;
            // 
            // btnBuffsSearch
            // 
            this.btnBuffsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuffsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuffsSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.btnBuffsSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuffsSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuffsSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnBuffsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffsSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuffsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnBuffsSearch.Location = new System.Drawing.Point(112, 17);
            this.btnBuffsSearch.Name = "btnBuffsSearch";
            this.btnBuffsSearch.Size = new System.Drawing.Size(56, 23);
            this.btnBuffsSearch.TabIndex = 1;
            this.btnBuffsSearch.Text = "Search";
            this.btnBuffsSearch.UseVisualStyleBackColor = false;
            this.btnBuffsSearch.Click += new System.EventHandler(this.SearchGridView);
            // 
            // tbBuffsSearch
            // 
            this.tbBuffsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuffsSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tbBuffsSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuffsSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.tbBuffsSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tbBuffsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbBuffsSearch.Location = new System.Drawing.Point(7, 18);
            this.tbBuffsSearch.Name = "tbBuffsSearch";
            this.tbBuffsSearch.NumericTextBox = false;
            this.tbBuffsSearch.Size = new System.Drawing.Size(99, 22);
            this.tbBuffsSearch.TabIndex = 0;
            // 
            // xPanelBuffs
            // 
            this.xPanelBuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanelBuffs.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanelBuffs.Controls.Add(this.dgvBuffs);
            this.xPanelBuffs.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanelBuffs.Location = new System.Drawing.Point(6, 6);
            this.xPanelBuffs.Name = "xPanelBuffs";
            this.xPanelBuffs.Size = new System.Drawing.Size(757, 308);
            this.xPanelBuffs.TabIndex = 2;
            // 
            // dgvBuffs
            // 
            this.dgvBuffs.AllowUserToAddRows = false;
            this.dgvBuffs.AllowUserToDeleteRows = false;
            this.dgvBuffs.AllowUserToResizeColumns = false;
            this.dgvBuffs.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBuffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuffs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvBuffs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuffs.ColorStyle = LogsParser.XColorStyle.Blue;
            this.dgvBuffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBuffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuffs.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBuffs.EnableHeadersVisualStyles = false;
            this.dgvBuffs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dgvBuffs.Location = new System.Drawing.Point(3, 3);
            this.dgvBuffs.MultiSelect = false;
            this.dgvBuffs.Name = "dgvBuffs";
            this.dgvBuffs.ReadOnly = true;
            this.dgvBuffs.RowHeadersVisible = false;
            this.dgvBuffs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvBuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuffs.Size = new System.Drawing.Size(749, 302);
            this.dgvBuffs.TabIndex = 1;
            // 
            // tpSpawn
            // 
            this.tpSpawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tpSpawn.Controls.Add(this.xPanel_MonsterSearch);
            this.tpSpawn.Controls.Add(this.xPanelMonster);
            this.tpSpawn.Location = new System.Drawing.Point(4, 32);
            this.tpSpawn.Name = "tpSpawn";
            this.tpSpawn.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpawn.Size = new System.Drawing.Size(947, 320);
            this.tpSpawn.TabIndex = 4;
            this.tpSpawn.Text = "Monster";
            // 
            // xPanel_MonsterSearch
            // 
            this.xPanel_MonsterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanel_MonsterSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanel_MonsterSearch.Controls.Add(this.btnMonsterSearch);
            this.xPanel_MonsterSearch.Controls.Add(this.tbMonsterSearch);
            this.xPanel_MonsterSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanel_MonsterSearch.Location = new System.Drawing.Point(762, 6);
            this.xPanel_MonsterSearch.Name = "xPanel_MonsterSearch";
            this.xPanel_MonsterSearch.Size = new System.Drawing.Size(177, 308);
            this.xPanel_MonsterSearch.TabIndex = 9;
            // 
            // btnMonsterSearch
            // 
            this.btnMonsterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonsterSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMonsterSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.btnMonsterSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMonsterSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMonsterSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnMonsterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonsterSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonsterSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnMonsterSearch.Location = new System.Drawing.Point(112, 17);
            this.btnMonsterSearch.Name = "btnMonsterSearch";
            this.btnMonsterSearch.Size = new System.Drawing.Size(56, 23);
            this.btnMonsterSearch.TabIndex = 1;
            this.btnMonsterSearch.Text = "Search";
            this.btnMonsterSearch.UseVisualStyleBackColor = false;
            this.btnMonsterSearch.Click += new System.EventHandler(this.SearchGridView);
            // 
            // tbMonsterSearch
            // 
            this.tbMonsterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonsterSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tbMonsterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMonsterSearch.ColorStyle = LogsParser.XColorStyle.Blue;
            this.tbMonsterSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tbMonsterSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbMonsterSearch.Location = new System.Drawing.Point(7, 18);
            this.tbMonsterSearch.Name = "tbMonsterSearch";
            this.tbMonsterSearch.NumericTextBox = false;
            this.tbMonsterSearch.Size = new System.Drawing.Size(99, 22);
            this.tbMonsterSearch.TabIndex = 0;
            // 
            // xPanelMonster
            // 
            this.xPanelMonster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xPanelMonster.ColorStyle = LogsParser.XColorStyle.Blue;
            this.xPanelMonster.Controls.Add(this.dgvMonster);
            this.xPanelMonster.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xPanelMonster.Location = new System.Drawing.Point(6, 6);
            this.xPanelMonster.Name = "xPanelMonster";
            this.xPanelMonster.Size = new System.Drawing.Size(757, 308);
            this.xPanelMonster.TabIndex = 2;
            // 
            // dgvMonster
            // 
            this.dgvMonster.AllowUserToAddRows = false;
            this.dgvMonster.AllowUserToDeleteRows = false;
            this.dgvMonster.AllowUserToResizeColumns = false;
            this.dgvMonster.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMonster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvMonster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonster.ColorStyle = LogsParser.XColorStyle.Blue;
            this.dgvMonster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMonster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonster.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMonster.EnableHeadersVisualStyles = false;
            this.dgvMonster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.dgvMonster.Location = new System.Drawing.Point(3, 3);
            this.dgvMonster.MultiSelect = false;
            this.dgvMonster.Name = "dgvMonster";
            this.dgvMonster.ReadOnly = true;
            this.dgvMonster.RowHeadersVisible = false;
            this.dgvMonster.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvMonster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonster.Size = new System.Drawing.Size(749, 302);
            this.dgvMonster.TabIndex = 0;
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tpAbout.Controls.Add(this.btnChangeColor);
            this.tpAbout.Controls.Add(this.lbAbout);
            this.tpAbout.Controls.Add(this.pbMX);
            this.tpAbout.Location = new System.Drawing.Point(4, 32);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(947, 320);
            this.tpAbout.TabIndex = 7;
            this.tpAbout.Text = "About";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChangeColor.ColorStyle = LogsParser.XColorStyle.Blue;
            this.btnChangeColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnChangeColor.Location = new System.Drawing.Point(542, 291);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(121, 23);
            this.btnChangeColor.TabIndex = 6;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbAbout.Location = new System.Drawing.Point(282, 25);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(398, 255);
            this.lbAbout.TabIndex = 1;
            this.lbAbout.Text = resources.GetString("lbAbout.Text");
            // 
            // pbMX
            // 
            this.pbMX.Image = global::LogsParser.Properties.Resources.GM_ToolBlueAbout;
            this.pbMX.Location = new System.Drawing.Point(25, 25);
            this.pbMX.Name = "pbMX";
            this.pbMX.Size = new System.Drawing.Size(250, 250);
            this.pbMX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMX.TabIndex = 0;
            this.pbMX.TabStop = false;
            // 
            // frmGlobalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(968, 429);
            this.Controls.Add(this.lbBenchmark);
            this.Controls.Add(this.tpGeneral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(968, 429);
            this.Name = "frmGlobalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xijezu\'s GM-Tool V5.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGlobalGUI_Closed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tpGeneral.ResumeLayout(false);
            this.tpItems.ResumeLayout(false);
            this.xPanel_Itemns_Search.ResumeLayout(false);
            this.xPanel_Itemns_Search.PerformLayout();
            this.xPanelItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tpBuffs.ResumeLayout(false);
            this.xPanel_Buffs_Search.ResumeLayout(false);
            this.xPanel_Buffs_Search.PerformLayout();
            this.xPanelBuffs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuffs)).EndInit();
            this.tpSpawn.ResumeLayout(false);
            this.xPanel_MonsterSearch.ResumeLayout(false);
            this.xPanel_MonsterSearch.PerformLayout();
            this.xPanelMonster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonster)).EndInit();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Window_Minimize;
        private System.Windows.Forms.Button btn_Window_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiWorkParams;
        private System.Windows.Forms.Label lbBenchmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabase;
        private System.Windows.Forms.ToolStripSeparator tssOptions;
        private System.Windows.Forms.TabPage tpAbout;
        private XButton btnChangeColor;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.PictureBox pbMX;
        private System.Windows.Forms.TabPage tpSpawn;
        private XPanel xPanel_MonsterSearch;
        private XButton btnMonsterSearch;
        private XTextBox tbMonsterSearch;
        private XPanel xPanelMonster;
        public XDataGridView dgvMonster;
        private System.Windows.Forms.TabPage tpBuffs;
        private XPanel xPanel_Buffs_Search;
        private XButton btnBuffsSearch;
        private XTextBox tbBuffsSearch;
        private XPanel xPanelBuffs;
        public XDataGridView dgvBuffs;
        private System.Windows.Forms.TabPage tpItems;
        private XPanel xPanel_Itemns_Search;
        private XButton btnSearchItems;
        private XTextBox tbItemsSearch;
        private XPanel xPanelItems;
        public XDataGridView dgvItems;
        private XTabControl tpGeneral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    }
}

