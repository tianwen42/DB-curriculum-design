
namespace 数据库测试
{
    partial class modteam
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
            this.borrowid = new System.Windows.Forms.TextBox();
            this.rCurNum = new System.Windows.Forms.TextBox();
            this.rname = new System.Windows.Forms.TextBox();
            this.rBorrowedNum = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrowid
            // 
            this.borrowid.Location = new System.Drawing.Point(131, 52);
            this.borrowid.Margin = new System.Windows.Forms.Padding(4);
            this.borrowid.Name = "borrowid";
            this.borrowid.Size = new System.Drawing.Size(141, 25);
            this.borrowid.TabIndex = 10;
            // 
            // rCurNum
            // 
            this.rCurNum.Location = new System.Drawing.Point(379, 52);
            this.rCurNum.Margin = new System.Windows.Forms.Padding(4);
            this.rCurNum.Name = "rCurNum";
            this.rCurNum.Size = new System.Drawing.Size(141, 25);
            this.rCurNum.TabIndex = 20;
            // 
            // rname
            // 
            this.rname.Location = new System.Drawing.Point(131, 94);
            this.rname.Margin = new System.Windows.Forms.Padding(4);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(141, 25);
            this.rname.TabIndex = 11;
            // 
            // rBorrowedNum
            // 
            this.rBorrowedNum.Location = new System.Drawing.Point(379, 94);
            this.rBorrowedNum.Margin = new System.Windows.Forms.Padding(4);
            this.rBorrowedNum.Name = "rBorrowedNum";
            this.rBorrowedNum.Size = new System.Drawing.Size(141, 25);
            this.rBorrowedNum.TabIndex = 22;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(131, 134);
            this.job.Margin = new System.Windows.Forms.Padding(4);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(141, 25);
            this.job.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(379, 134);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(141, 25);
            this.phone.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "人数";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "联系方式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "所属单位";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "负责人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "主教练";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "球队名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(248, 368);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // modteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 428);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.borrowid);
            this.Controls.Add(this.rCurNum);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.rBorrowedNum);
            this.Controls.Add(this.job);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modteam";
            this.Text = "addteam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox borrowid;
        private System.Windows.Forms.TextBox rCurNum;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.TextBox rBorrowedNum;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
    }
}