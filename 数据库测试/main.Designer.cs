
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
            this.teamAdmin = new System.Windows.Forms.DataGridView();
            this.readerCondition = new System.Windows.Forms.GroupBox();
            this.readerSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.球队TableAdapter = new 数据库测试.competitionDataSetTableAdapters.球队TableAdapter();
            this.competitionDataSet1 = new 数据库测试.competitionDataSet();
            this.球队BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.球队名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属单位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主教练DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.球队人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamAdmin)).BeginInit();
            this.readerCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).BeginInit();
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
            this.groupBox2.Controls.Add(this.teamAdmin);
            this.groupBox2.Location = new System.Drawing.Point(10, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(907, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // teamAdmin
            // 
            this.teamAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.球队名称DataGridViewTextBoxColumn,
            this.所属单位DataGridViewTextBoxColumn,
            this.主教练DataGridViewTextBoxColumn,
            this.球队人数DataGridViewTextBoxColumn,
            this.负责人DataGridViewTextBoxColumn,
            this.联系方式DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn});
            this.teamAdmin.Location = new System.Drawing.Point(7, 25);
            this.teamAdmin.Name = "teamAdmin";
            this.teamAdmin.RowHeadersWidth = 51;
            this.teamAdmin.RowTemplate.Height = 27;
            this.teamAdmin.Size = new System.Drawing.Size(891, 332);
            this.teamAdmin.TabIndex = 0;
            this.teamAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.readerCondition.Text = "查询条件";
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
            // 
            // 球队人数DataGridViewTextBoxColumn
            // 
            this.球队人数DataGridViewTextBoxColumn.DataPropertyName = "球队人数";
            this.球队人数DataGridViewTextBoxColumn.HeaderText = "球队人数";
            this.球队人数DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.球队人数DataGridViewTextBoxColumn.Name = "球队人数DataGridViewTextBoxColumn";
            this.球队人数DataGridViewTextBoxColumn.ReadOnly = true;
            this.球队人数DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            ((System.ComponentModel.ISupportInitialize)(this.teamAdmin)).EndInit();
            this.readerCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.competitionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.球队BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView teamAdmin;
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
    }
}