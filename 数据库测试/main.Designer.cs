
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.readerCondition = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.TextBox();
            this.rBorrowedNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rCurNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.readerSearch = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readerSearchResult = new System.Windows.Forms.DataGridView();
            this.editReader = new System.Windows.Forms.Button();
            this.deleteReader = new System.Windows.Forms.Button();
            this.addReader = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.readerCondition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerSearchResult)).BeginInit();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "球员管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(995, 541);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "比赛安排";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(995, 541);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "积分排名";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // readerCondition
            // 
            this.readerCondition.Controls.Add(this.label10);
            this.readerCondition.Controls.Add(this.dept);
            this.readerCondition.Controls.Add(this.rBorrowedNum);
            this.readerCondition.Controls.Add(this.label11);
            this.readerCondition.Controls.Add(this.rCurNum);
            this.readerCondition.Controls.Add(this.label12);
            this.readerCondition.Controls.Add(this.sex);
            this.readerCondition.Controls.Add(this.readerSearch);
            this.readerCondition.Controls.Add(this.phone);
            this.readerCondition.Controls.Add(this.label5);
            this.readerCondition.Controls.Add(this.job);
            this.readerCondition.Controls.Add(this.label4);
            this.readerCondition.Controls.Add(this.label3);
            this.readerCondition.Controls.Add(this.rname);
            this.readerCondition.Controls.Add(this.label2);
            this.readerCondition.Controls.Add(this.borrowid);
            this.readerCondition.Controls.Add(this.label1);
            this.readerCondition.Location = new System.Drawing.Point(13, 7);
            this.readerCondition.Margin = new System.Windows.Forms.Padding(4);
            this.readerCondition.Name = "readerCondition";
            this.readerCondition.Padding = new System.Windows.Forms.Padding(4);
            this.readerCondition.Size = new System.Drawing.Size(910, 220);
            this.readerCondition.TabIndex = 1;
            this.readerCondition.TabStop = false;
            this.readerCondition.Text = "查询条件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "工作部门";
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(672, 122);
            this.dept.Margin = new System.Windows.Forms.Padding(4);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(132, 25);
            this.dept.TabIndex = 23;
            // 
            // rBorrowedNum
            // 
            this.rBorrowedNum.Location = new System.Drawing.Point(400, 34);
            this.rBorrowedNum.Margin = new System.Windows.Forms.Padding(4);
            this.rBorrowedNum.Name = "rBorrowedNum";
            this.rBorrowedNum.Size = new System.Drawing.Size(132, 25);
            this.rBorrowedNum.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "最少已借数量";
            // 
            // rCurNum
            // 
            this.rCurNum.Location = new System.Drawing.Point(113, 72);
            this.rCurNum.Margin = new System.Windows.Forms.Padding(4);
            this.rCurNum.Name = "rCurNum";
            this.rCurNum.Size = new System.Drawing.Size(132, 25);
            this.rCurNum.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "最少可借数量";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(400, 78);
            this.sex.Margin = new System.Windows.Forms.Padding(4);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(132, 23);
            this.sex.TabIndex = 18;
            // 
            // readerSearch
            // 
            this.readerSearch.Location = new System.Drawing.Point(347, 167);
            this.readerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.readerSearch.Name = "readerSearch";
            this.readerSearch.Size = new System.Drawing.Size(158, 31);
            this.readerSearch.TabIndex = 16;
            this.readerSearch.Text = "查询";
            this.readerSearch.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(672, 79);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(132, 25);
            this.phone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "联系电话";
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(672, 34);
            this.job.Margin = new System.Windows.Forms.Padding(4);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(132, 25);
            this.job.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "职称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别";
            // 
            // rname
            // 
            this.rname.Location = new System.Drawing.Point(113, 118);
            this.rname.Margin = new System.Windows.Forms.Padding(4);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(132, 25);
            this.rname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // borrowid
            // 
            this.borrowid.Location = new System.Drawing.Point(113, 30);
            this.borrowid.Margin = new System.Windows.Forms.Padding(4);
            this.borrowid.Name = "borrowid";
            this.borrowid.Size = new System.Drawing.Size(132, 25);
            this.borrowid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readerSearchResult);
            this.groupBox2.Location = new System.Drawing.Point(10, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(906, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // readerSearchResult
            // 
            this.readerSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerSearchResult.Location = new System.Drawing.Point(3, 18);
            this.readerSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.readerSearchResult.Name = "readerSearchResult";
            this.readerSearchResult.RowHeadersWidth = 51;
            this.readerSearchResult.RowTemplate.Height = 23;
            this.readerSearchResult.Size = new System.Drawing.Size(895, 258);
            this.readerSearchResult.TabIndex = 0;
            // 
            // editReader
            // 
            this.editReader.Location = new System.Drawing.Point(808, 527);
            this.editReader.Margin = new System.Windows.Forms.Padding(4);
            this.editReader.Name = "editReader";
            this.editReader.Size = new System.Drawing.Size(100, 29);
            this.editReader.TabIndex = 7;
            this.editReader.Text = "编辑";
            this.editReader.UseVisualStyleBackColor = true;
            // 
            // deleteReader
            // 
            this.deleteReader.Location = new System.Drawing.Point(391, 527);
            this.deleteReader.Margin = new System.Windows.Forms.Padding(4);
            this.deleteReader.Name = "deleteReader";
            this.deleteReader.Size = new System.Drawing.Size(100, 29);
            this.deleteReader.TabIndex = 6;
            this.deleteReader.Text = "删除";
            this.deleteReader.UseVisualStyleBackColor = true;
            // 
            // addReader
            // 
            this.addReader.Location = new System.Drawing.Point(13, 527);
            this.addReader.Margin = new System.Windows.Forms.Padding(4);
            this.addReader.Name = "addReader";
            this.addReader.Size = new System.Drawing.Size(100, 29);
            this.addReader.TabIndex = 5;
            this.addReader.Text = "新增";
            this.addReader.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.readerCondition.ResumeLayout(false);
            this.readerCondition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readerSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox readerCondition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox rBorrowedNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rCurNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Button readerSearch;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editReader;
        private System.Windows.Forms.Button deleteReader;
        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView readerSearchResult;
    }
}