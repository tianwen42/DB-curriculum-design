﻿
namespace 数据库测试
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Plan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editTeam = new System.Windows.Forms.Button();
            this.deleteReader = new System.Windows.Forms.Button();
            this.addTeam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeamManagement = new System.Windows.Forms.DataGridView();
            this.teamCondition = new System.Windows.Forms.GroupBox();
            this.teamSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayerManagement = new System.Windows.Forms.DataGridView();
            this.bookCondition = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumTeam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Playername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RefereeManagemant = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RefereeLevel = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Refereename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Ranking = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Competion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.球队TableAdapter = new 数据库测试.competitionDataSetTableAdapters.球队TableAdapter();
            this.competitionDataSet1 = new 数据库测试.competitionDataSet();
            this.球队BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Plan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamManagement)).BeginInit();
            this.teamCondition.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerManagement)).BeginInit();
            this.bookCondition.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefereeManagemant)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Plan
            // 
            this.Plan.Controls.Add(this.tabPage1);
            this.Plan.Controls.Add(this.tabPage2);
            this.Plan.Controls.Add(this.tabPage5);
            this.Plan.Controls.Add(this.tabPage3);
            this.Plan.Controls.Add(this.tabPage4);
            this.Plan.Location = new System.Drawing.Point(-1, -2);
            this.Plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plan.Name = "Plan";
            this.Plan.SelectedIndex = 0;
            this.Plan.Size = new System.Drawing.Size(1151, 566);
            this.Plan.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.editTeam);
            this.tabPage1.Controls.Add(this.deleteReader);
            this.tabPage1.Controls.Add(this.addTeam);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.teamCondition);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1143, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "球队管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editTeam
            // 
            this.editTeam.Location = new System.Drawing.Point(1017, 476);
            this.editTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editTeam.Name = "editTeam";
            this.editTeam.Size = new System.Drawing.Size(100, 29);
            this.editTeam.TabIndex = 7;
            this.editTeam.Text = "编辑";
            this.editTeam.UseVisualStyleBackColor = true;
            this.editTeam.Click += new System.EventHandler(this.editTeam_Click);
            // 
            // deleteReader
            // 
            this.deleteReader.Location = new System.Drawing.Point(539, 476);
            this.deleteReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteReader.Name = "deleteReader";
            this.deleteReader.Size = new System.Drawing.Size(100, 29);
            this.deleteReader.TabIndex = 6;
            this.deleteReader.Text = "删除";
            this.deleteReader.UseVisualStyleBackColor = true;
            this.deleteReader.Click += new System.EventHandler(this.deleteTeam_Click);
            // 
            // addTeam
            // 
            this.addTeam.Location = new System.Drawing.Point(75, 476);
            this.addTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(100, 29);
            this.addTeam.TabIndex = 5;
            this.addTeam.Text = "新增";
            this.addTeam.UseVisualStyleBackColor = true;
            this.addTeam.Click += new System.EventHandler(this.addteam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeamManagement);
            this.groupBox2.Location = new System.Drawing.Point(11, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1115, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // TeamManagement
            // 
            this.TeamManagement.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.TeamManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamManagement.GridColor = System.Drawing.Color.Black;
            this.TeamManagement.Location = new System.Drawing.Point(7, 25);
            this.TeamManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamManagement.Name = "TeamManagement";
            this.TeamManagement.RowHeadersWidth = 51;
            this.TeamManagement.RowTemplate.Height = 27;
            this.TeamManagement.Size = new System.Drawing.Size(1100, 332);
            this.TeamManagement.TabIndex = 0;
            this.TeamManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teamCondition
            // 
            this.teamCondition.Controls.Add(this.teamSearch);
            this.teamCondition.ForeColor = System.Drawing.Color.Black;
            this.teamCondition.Location = new System.Drawing.Point(13, 8);
            this.teamCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamCondition.Name = "teamCondition";
            this.teamCondition.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamCondition.Size = new System.Drawing.Size(1111, 75);
            this.teamCondition.TabIndex = 1;
            this.teamCondition.TabStop = false;
            this.teamCondition.Text = "球队查询";
            // 
            // teamSearch
            // 
            this.teamSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamSearch.Location = new System.Drawing.Point(497, 26);
            this.teamSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamSearch.Name = "teamSearch";
            this.teamSearch.Size = new System.Drawing.Size(157, 31);
            this.teamSearch.TabIndex = 16;
            this.teamSearch.Text = "查询";
            this.teamSearch.UseVisualStyleBackColor = true;
            this.teamSearch.Click += new System.EventHandler(this.readerSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.bookCondition);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1143, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "球员管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(995, 482);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 44;
            this.button5.Text = "编辑";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(516, 482);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 29);
            this.button6.TabIndex = 43;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 482);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 29);
            this.button7.TabIndex = 42;
            this.button7.Text = "新增";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlayerManagement);
            this.groupBox3.Location = new System.Drawing.Point(4, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1120, 355);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询结果";
            // 
            // PlayerManagement
            // 
            this.PlayerManagement.BackgroundColor = System.Drawing.Color.White;
            this.PlayerManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerManagement.Location = new System.Drawing.Point(5, 25);
            this.PlayerManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerManagement.Name = "PlayerManagement";
            this.PlayerManagement.RowHeadersWidth = 51;
            this.PlayerManagement.RowTemplate.Height = 27;
            this.PlayerManagement.Size = new System.Drawing.Size(1107, 318);
            this.PlayerManagement.TabIndex = 40;
            // 
            // bookCondition
            // 
            this.bookCondition.Controls.Add(this.button4);
            this.bookCondition.Controls.Add(this.Position);
            this.bookCondition.Controls.Add(this.label4);
            this.bookCondition.Controls.Add(this.NumTeam);
            this.bookCondition.Controls.Add(this.label3);
            this.bookCondition.Controls.Add(this.button1);
            this.bookCondition.Controls.Add(this.Playername);
            this.bookCondition.Controls.Add(this.label10);
            this.bookCondition.Location = new System.Drawing.Point(4, 8);
            this.bookCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookCondition.Name = "bookCondition";
            this.bookCondition.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookCondition.Size = new System.Drawing.Size(1120, 91);
            this.bookCondition.TabIndex = 39;
            this.bookCondition.TabStop = false;
            this.bookCondition.Text = "查询条件";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(979, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "清除查询条件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(491, 32);
            this.Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(100, 25);
            this.Position.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "位置";
            // 
            // NumTeam
            // 
            this.NumTeam.Location = new System.Drawing.Point(253, 32);
            this.NumTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumTeam.Name = "NumTeam";
            this.NumTeam.Size = new System.Drawing.Size(111, 25);
            this.NumTeam.TabIndex = 18;
            this.NumTeam.TextChanged += new System.EventHandler(this.NumTeam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "队伍";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Playername
            // 
            this.Playername.Location = new System.Drawing.Point(65, 32);
            this.Playername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Playername.Name = "Playername";
            this.Playername.Size = new System.Drawing.Size(111, 25);
            this.Playername.TabIndex = 1;
            this.Playername.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "姓名";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.button10);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(1143, 537);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "裁判管理";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1000, 478);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 29);
            this.button8.TabIndex = 45;
            this.button8.Text = "编辑";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(523, 478);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 29);
            this.button9.TabIndex = 44;
            this.button9.Text = "删除";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(57, 478);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 29);
            this.button10.TabIndex = 43;
            this.button10.Text = "新增";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RefereeManagemant);
            this.groupBox5.Location = new System.Drawing.Point(7, 108);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1117, 345);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "查询结果";
            // 
            // RefereeManagemant
            // 
            this.RefereeManagemant.BackgroundColor = System.Drawing.Color.White;
            this.RefereeManagemant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefereeManagemant.Location = new System.Drawing.Point(5, 25);
            this.RefereeManagemant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefereeManagemant.Name = "RefereeManagemant";
            this.RefereeManagemant.RowHeadersWidth = 51;
            this.RefereeManagemant.RowTemplate.Height = 27;
            this.RefereeManagemant.Size = new System.Drawing.Size(1104, 312);
            this.RefereeManagemant.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.refresh);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.RefereeLevel);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.Refereename);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(4, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1120, 92);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询条件";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(859, 36);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 29);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "清除查询条件";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "级别：";
            // 
            // RefereeLevel
            // 
            this.RefereeLevel.FormattingEnabled = true;
            this.RefereeLevel.Items.AddRange(new object[] {
            "特级",
            "一级",
            "二级"});
            this.RefereeLevel.Location = new System.Drawing.Point(401, 32);
            this.RefereeLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefereeLevel.Name = "RefereeLevel";
            this.RefereeLevel.Size = new System.Drawing.Size(121, 23);
            this.RefereeLevel.TabIndex = 17;
            this.RefereeLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1000, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Refereename
            // 
            this.Refereename.Location = new System.Drawing.Point(65, 32);
            this.Refereename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Refereename.Name = "Refereename";
            this.Refereename.Size = new System.Drawing.Size(136, 25);
            this.Refereename.TabIndex = 1;
            this.Refereename.TextChanged += new System.EventHandler(this.Refereename_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1143, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "比赛安排";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(9, 291);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 240);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(379, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 253);
            this.panel1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(240, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(230, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "队伍1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(230, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "队伍2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(226, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "VS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox3);
            this.tabPage4.Controls.Add(this.Ranking);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1143, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "积分排名";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Ranking
            // 
            this.Ranking.BackgroundColor = System.Drawing.Color.White;
            this.Ranking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ranking.Location = new System.Drawing.Point(680, 101);
            this.Ranking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ranking.Name = "Ranking";
            this.Ranking.RowHeadersWidth = 51;
            this.Ranking.RowTemplate.Height = 27;
            this.Ranking.Size = new System.Drawing.Size(444, 413);
            this.Ranking.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Competion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1117, 86);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // Competion
            // 
            this.Competion.FormattingEnabled = true;
            this.Competion.Items.AddRange(new object[] {
            "虹桥杯",
            "金标杯",
            "晓庄杯"});
            this.Competion.Location = new System.Drawing.Point(103, 34);
            this.Competion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Competion.Name = "Competion";
            this.Competion.Size = new System.Drawing.Size(121, 23);
            this.Competion.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "选择赛事";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(999, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 球队TableAdapter
            // 
            this.球队TableAdapter.ClearBeforeFill = true;
            // 
            // competitionDataSet1
            // 
            this.competitionDataSet1.DataSetName = "competitionDataSet";
            this.competitionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 球队BindingSource
            // 
            this.球队BindingSource.DataMember = "球队";
            this.球队BindingSource.DataSource = this.competitionDataSet1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(533, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 225);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(667, 413);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 558);
            this.Controls.Add(this.Plan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "冰球比赛管理系统";
            this.Load += new System.EventHandler(this.main_Load);
            this.Plan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamManagement)).EndInit();
            this.teamCondition.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerManagement)).EndInit();
            this.bookCondition.ResumeLayout(false);
            this.bookCondition.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefereeManagemant)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Plan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox teamCondition;
        private System.Windows.Forms.Button teamSearch;
        private System.Windows.Forms.Button editTeam;
        private System.Windows.Forms.Button deleteReader;
        private System.Windows.Forms.Button addTeam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TeamManagement;
        private competitionDataSetTableAdapters.球队TableAdapter 球队TableAdapter;
        private competitionDataSet competitionDataSet1;
        private System.Windows.Forms.BindingSource 球队BindingSource;
        private System.Windows.Forms.GroupBox bookCondition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Playername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Ranking;
        private System.Windows.Forms.DataGridView PlayerManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView RefereeManagemant;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Refereename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RefereeLevel;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumTeam;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Competion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}