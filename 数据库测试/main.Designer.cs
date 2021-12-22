
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Plan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editReader = new System.Windows.Forms.Button();
            this.deleteReader = new System.Windows.Forms.Button();
            this.addReader = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeamManagement = new System.Windows.Forms.DataGridView();
            this.teamCondition = new System.Windows.Forms.GroupBox();
            this.teamSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayerManagement = new System.Windows.Forms.DataGridView();
            this.bookCondition = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Ranking = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.球队TableAdapter = new 数据库测试.competitionDataSetTableAdapters.球队TableAdapter();
            this.competitionDataSet1 = new 数据库测试.competitionDataSet();
            this.球队BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RefereeManagemant = new System.Windows.Forms.DataGridView();
            this.Plan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamManagement)).BeginInit();
            this.teamCondition.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerManagement)).BeginInit();
            this.bookCondition.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefereeManagemant)).BeginInit();
            this.SuspendLayout();
            // 
            // Plan
            // 
            this.Plan.Controls.Add(this.tabPage1);
            this.Plan.Controls.Add(this.tabPage2);
            this.Plan.Controls.Add(this.tabPage5);
            this.Plan.Controls.Add(this.tabPage3);
            this.Plan.Controls.Add(this.tabPage4);
            this.Plan.Location = new System.Drawing.Point(-1, -3);
            this.Plan.Name = "Plan";
            this.Plan.SelectedIndex = 0;
            this.Plan.Size = new System.Drawing.Size(932, 594);
            this.Plan.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.editReader);
            this.tabPage1.Controls.Add(this.deleteReader);
            this.tabPage1.Controls.Add(this.addReader);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.teamCondition);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "球队管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editReader
            // 
            this.editReader.Location = new System.Drawing.Point(808, 476);
            this.editReader.Margin = new System.Windows.Forms.Padding(4);
            this.editReader.Name = "editReader";
            this.editReader.Size = new System.Drawing.Size(100, 29);
            this.editReader.TabIndex = 7;
            this.editReader.Text = "编辑";
            this.editReader.UseVisualStyleBackColor = true;
            // 
            // deleteReader
            // 
            this.deleteReader.Location = new System.Drawing.Point(391, 476);
            this.deleteReader.Margin = new System.Windows.Forms.Padding(4);
            this.deleteReader.Name = "deleteReader";
            this.deleteReader.Size = new System.Drawing.Size(100, 29);
            this.deleteReader.TabIndex = 6;
            this.deleteReader.Text = "删除";
            this.deleteReader.UseVisualStyleBackColor = true;
            // 
            // addReader
            // 
            this.addReader.Location = new System.Drawing.Point(74, 476);
            this.addReader.Margin = new System.Windows.Forms.Padding(4);
            this.addReader.Name = "addReader";
            this.addReader.Size = new System.Drawing.Size(100, 29);
            this.addReader.TabIndex = 5;
            this.addReader.Text = "新增";
            this.addReader.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeamManagement);
            this.groupBox2.Location = new System.Drawing.Point(10, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(907, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // TeamManagement
            // 
            this.TeamManagement.BackgroundColor = System.Drawing.Color.White;
            this.TeamManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamManagement.GridColor = System.Drawing.Color.Black;
            this.TeamManagement.Location = new System.Drawing.Point(7, 25);
            this.TeamManagement.Name = "TeamManagement";
            this.TeamManagement.RowHeadersWidth = 51;
            this.TeamManagement.RowTemplate.Height = 27;
            this.TeamManagement.Size = new System.Drawing.Size(891, 332);
            this.TeamManagement.TabIndex = 0;
            this.TeamManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teamCondition
            // 
            this.teamCondition.Controls.Add(this.teamSearch);
            this.teamCondition.ForeColor = System.Drawing.Color.Black;
            this.teamCondition.Location = new System.Drawing.Point(13, 7);
            this.teamCondition.Margin = new System.Windows.Forms.Padding(4);
            this.teamCondition.Name = "teamCondition";
            this.teamCondition.Padding = new System.Windows.Forms.Padding(4);
            this.teamCondition.Size = new System.Drawing.Size(903, 75);
            this.teamCondition.TabIndex = 1;
            this.teamCondition.TabStop = false;
            this.teamCondition.Text = "球队查询";
            // 
            // teamSearch
            // 
            this.teamSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamSearch.Location = new System.Drawing.Point(363, 26);
            this.teamSearch.Margin = new System.Windows.Forms.Padding(4);
            this.teamSearch.Name = "teamSearch";
            this.teamSearch.Size = new System.Drawing.Size(158, 31);
            this.teamSearch.TabIndex = 16;
            this.teamSearch.Text = "查询";
            this.teamSearch.UseVisualStyleBackColor = true;
            this.teamSearch.Click += new System.EventHandler(this.readerSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.bookCondition);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "球员管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PlayerManagement);
            this.groupBox3.Location = new System.Drawing.Point(4, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(913, 399);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询结果";
            // 
            // PlayerManagement
            // 
            this.PlayerManagement.BackgroundColor = System.Drawing.Color.Maroon;
            this.PlayerManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerManagement.Location = new System.Drawing.Point(6, 25);
            this.PlayerManagement.Name = "PlayerManagement";
            this.PlayerManagement.RowHeadersWidth = 51;
            this.PlayerManagement.RowTemplate.Height = 27;
            this.PlayerManagement.Size = new System.Drawing.Size(900, 367);
            this.PlayerManagement.TabIndex = 40;
            // 
            // bookCondition
            // 
            this.bookCondition.Controls.Add(this.button1);
            this.bookCondition.Controls.Add(this.textBox6);
            this.bookCondition.Controls.Add(this.label10);
            this.bookCondition.Location = new System.Drawing.Point(4, 7);
            this.bookCondition.Margin = new System.Windows.Forms.Padding(4);
            this.bookCondition.Name = "bookCondition";
            this.bookCondition.Padding = new System.Windows.Forms.Padding(4);
            this.bookCondition.Size = new System.Drawing.Size(913, 92);
            this.bookCondition.TabIndex = 39;
            this.bookCondition.TabStop = false;
            this.bookCondition.Text = "查询条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(65, 32);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 25);
            this.textBox6.TabIndex = 1;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Font = new System.Drawing.Font("黑体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "比赛安排";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(409, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "队伍2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(109, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "队伍1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(252, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 70);
            this.label5.TabIndex = 3;
            this.label5.Text = "VS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(909, 278);
            this.dataGridView2.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(653, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Ranking);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(924, 565);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "积分排名";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Ranking
            // 
            this.Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ranking.Location = new System.Drawing.Point(7, 100);
            this.Ranking.Name = "Ranking";
            this.Ranking.RowHeadersWidth = 51;
            this.Ranking.RowTemplate.Height = 27;
            this.Ranking.Size = new System.Drawing.Size(909, 415);
            this.Ranking.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(910, 86);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox2.Location = new System.Drawing.Point(277, 27);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 23);
            this.comboBox2.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "性别";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(924, 565);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "裁判管理";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(4, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(913, 92);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询条件";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(787, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 32);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 25);
            this.textBox3.TabIndex = 1;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RefereeManagemant);
            this.groupBox5.Location = new System.Drawing.Point(7, 107);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(913, 399);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "查询结果";
            // 
            // RefereeManagemant
            // 
            this.RefereeManagemant.BackgroundColor = System.Drawing.Color.Maroon;
            this.RefereeManagemant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefereeManagemant.Location = new System.Drawing.Point(6, 25);
            this.RefereeManagemant.Name = "RefereeManagemant";
            this.RefereeManagemant.RowHeadersWidth = 51;
            this.RefereeManagemant.RowTemplate.Height = 27;
            this.RefereeManagemant.Size = new System.Drawing.Size(900, 367);
            this.RefereeManagemant.TabIndex = 40;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 545);
            this.Controls.Add(this.Plan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefereeManagemant)).EndInit();
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
        private System.Windows.Forms.Button editReader;
        private System.Windows.Forms.Button deleteReader;
        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TeamManagement;
        private competitionDataSetTableAdapters.球队TableAdapter 球队TableAdapter;
        private competitionDataSet competitionDataSet1;
        private System.Windows.Forms.BindingSource 球队BindingSource;
        private System.Windows.Forms.GroupBox bookCondition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Ranking;
        private System.Windows.Forms.DataGridView PlayerManagement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView RefereeManagemant;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}