
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editReader = new System.Windows.Forms.Button();
            this.deleteReader = new System.Windows.Forms.Button();
            this.addReader = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeamManagement = new System.Windows.Forms.DataGridView();
            this.球队名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属单位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主教练DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.球队人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerCondition = new System.Windows.Forms.GroupBox();
            this.readerSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.球队TableAdapter = new 数据库测试.competitionDataSetTableAdapters.球队TableAdapter();
            this.competitionDataSet1 = new 数据库测试.competitionDataSet();
            this.球队BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bookCondition = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamManagement)).BeginInit();
            this.readerCondition.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).BeginInit();
            this.bookCondition.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 594);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editReader);
            this.tabPage1.Controls.Add(this.deleteReader);
            this.tabPage1.Controls.Add(this.addReader);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.readerCondition);
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
            this.editReader.Location = new System.Drawing.Point(808, 499);
            this.editReader.Margin = new System.Windows.Forms.Padding(4);
            this.editReader.Name = "editReader";
            this.editReader.Size = new System.Drawing.Size(100, 29);
            this.editReader.TabIndex = 7;
            this.editReader.Text = "编辑";
            this.editReader.UseVisualStyleBackColor = true;
            // 
            // deleteReader
            // 
            this.deleteReader.Location = new System.Drawing.Point(391, 499);
            this.deleteReader.Margin = new System.Windows.Forms.Padding(4);
            this.deleteReader.Name = "deleteReader";
            this.deleteReader.Size = new System.Drawing.Size(100, 29);
            this.deleteReader.TabIndex = 6;
            this.deleteReader.Text = "删除";
            this.deleteReader.UseVisualStyleBackColor = true;
            // 
            // addReader
            // 
            this.addReader.Location = new System.Drawing.Point(17, 499);
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
            this.TeamManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.球队名称DataGridViewTextBoxColumn,
            this.所属单位DataGridViewTextBoxColumn,
            this.主教练DataGridViewTextBoxColumn,
            this.球队人数DataGridViewTextBoxColumn,
            this.负责人DataGridViewTextBoxColumn,
            this.联系方式DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn});
            this.TeamManagement.Location = new System.Drawing.Point(7, 25);
            this.TeamManagement.Name = "TeamManagement";
            this.TeamManagement.RowHeadersWidth = 51;
            this.TeamManagement.RowTemplate.Height = 27;
            this.TeamManagement.Size = new System.Drawing.Size(891, 332);
            this.TeamManagement.TabIndex = 0;
            this.TeamManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 球队名称DataGridViewTextBoxColumn
            // 
            this.球队名称DataGridViewTextBoxColumn.DataPropertyName = "球队名称";
            this.球队名称DataGridViewTextBoxColumn.HeaderText = "球队名称";
            this.球队名称DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.球队名称DataGridViewTextBoxColumn.Name = "球队名称DataGridViewTextBoxColumn";
            this.球队名称DataGridViewTextBoxColumn.ReadOnly = true;
            this.球队名称DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.球队名称DataGridViewTextBoxColumn.Width = 110;
            // 
            // 所属单位DataGridViewTextBoxColumn
            // 
            this.所属单位DataGridViewTextBoxColumn.DataPropertyName = "所属单位";
            this.所属单位DataGridViewTextBoxColumn.HeaderText = "所属单位";
            this.所属单位DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.所属单位DataGridViewTextBoxColumn.Name = "所属单位DataGridViewTextBoxColumn";
            this.所属单位DataGridViewTextBoxColumn.ReadOnly = true;
            this.所属单位DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.所属单位DataGridViewTextBoxColumn.Width = 125;
            // 
            // 主教练DataGridViewTextBoxColumn
            // 
            this.主教练DataGridViewTextBoxColumn.DataPropertyName = "主教练";
            this.主教练DataGridViewTextBoxColumn.HeaderText = "主教练";
            this.主教练DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.主教练DataGridViewTextBoxColumn.Name = "主教练DataGridViewTextBoxColumn";
            this.主教练DataGridViewTextBoxColumn.ReadOnly = true;
            this.主教练DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.主教练DataGridViewTextBoxColumn.Width = 125;
            // 
            // 球队人数DataGridViewTextBoxColumn
            // 
            this.球队人数DataGridViewTextBoxColumn.DataPropertyName = "球队人数";
            this.球队人数DataGridViewTextBoxColumn.HeaderText = "球队人数";
            this.球队人数DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.球队人数DataGridViewTextBoxColumn.Name = "球队人数DataGridViewTextBoxColumn";
            this.球队人数DataGridViewTextBoxColumn.ReadOnly = true;
            this.球队人数DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.球队人数DataGridViewTextBoxColumn.Width = 125;
            // 
            // 负责人DataGridViewTextBoxColumn
            // 
            this.负责人DataGridViewTextBoxColumn.DataPropertyName = "负责人";
            this.负责人DataGridViewTextBoxColumn.HeaderText = "负责人";
            this.负责人DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.负责人DataGridViewTextBoxColumn.Name = "负责人DataGridViewTextBoxColumn";
            this.负责人DataGridViewTextBoxColumn.ReadOnly = true;
            this.负责人DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.负责人DataGridViewTextBoxColumn.Width = 125;
            // 
            // 联系方式DataGridViewTextBoxColumn
            // 
            this.联系方式DataGridViewTextBoxColumn.DataPropertyName = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.联系方式DataGridViewTextBoxColumn.Name = "联系方式DataGridViewTextBoxColumn";
            this.联系方式DataGridViewTextBoxColumn.ReadOnly = true;
            this.联系方式DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.联系方式DataGridViewTextBoxColumn.Width = 150;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            this.备注DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.备注DataGridViewTextBoxColumn.Width = 125;
            // 
            // readerCondition
            // 
            this.readerCondition.Controls.Add(this.readerSearch);
            this.readerCondition.Location = new System.Drawing.Point(13, 7);
            this.readerCondition.Margin = new System.Windows.Forms.Padding(4);
            this.readerCondition.Name = "readerCondition";
            this.readerCondition.Padding = new System.Windows.Forms.Padding(4);
            this.readerCondition.Size = new System.Drawing.Size(903, 75);
            this.readerCondition.TabIndex = 1;
            this.readerCondition.TabStop = false;
            this.readerCondition.Text = "球队查询";
            // 
            // readerSearch
            // 
            this.readerSearch.Location = new System.Drawing.Point(363, 26);
            this.readerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.readerSearch.Name = "readerSearch";
            this.readerSearch.Size = new System.Drawing.Size(158, 31);
            this.readerSearch.TabIndex = 16;
            this.readerSearch.Text = "查询";
            this.readerSearch.UseVisualStyleBackColor = true;
            this.readerSearch.Click += new System.EventHandler(this.readerSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bookCondition);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "球员管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "比赛安排";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(924, 565);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "积分排名";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(653, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // bookCondition
            // 
            this.bookCondition.Controls.Add(this.comboBox1);
            this.bookCondition.Controls.Add(this.button1);
            this.bookCondition.Controls.Add(this.label1);
            this.bookCondition.Controls.Add(this.textBox4);
            this.bookCondition.Controls.Add(this.label9);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(277, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 23);
            this.comboBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "性别";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(516, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 25);
            this.textBox4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "年龄";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(57, 26);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 25);
            this.textBox6.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "姓名";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(913, 92);
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 563);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "冰球比赛管理系统";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamManagement)).EndInit();
            this.readerCondition.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).EndInit();
            this.bookCondition.ResumeLayout(false);
            this.bookCondition.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox readerCondition;
        private System.Windows.Forms.Button readerSearch;
        private System.Windows.Forms.Button editReader;
        private System.Windows.Forms.Button deleteReader;
        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TeamManagement;
        private competitionDataSetTableAdapters.球队TableAdapter 球队TableAdapter;
        private competitionDataSet competitionDataSet1;
        private System.Windows.Forms.BindingSource 球队BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 球队名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属单位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主教练DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 球队人数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 负责人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox bookCondition;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
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
    }
}