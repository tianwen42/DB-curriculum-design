
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modteam));
            this.Teamname = new System.Windows.Forms.TextBox();
            this.Belong = new System.Windows.Forms.TextBox();
            this.Coach = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Principal = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Remark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Teamname
            // 
            this.Teamname.Location = new System.Drawing.Point(131, 52);
            this.Teamname.Margin = new System.Windows.Forms.Padding(4);
            this.Teamname.Name = "Teamname";
            this.Teamname.Size = new System.Drawing.Size(141, 25);
            this.Teamname.TabIndex = 10;
            // 
            // Belong
            // 
            this.Belong.Location = new System.Drawing.Point(379, 52);
            this.Belong.Margin = new System.Windows.Forms.Padding(4);
            this.Belong.Name = "Belong";
            this.Belong.Size = new System.Drawing.Size(141, 25);
            this.Belong.TabIndex = 20;
            // 
            // Coach
            // 
            this.Coach.Location = new System.Drawing.Point(131, 94);
            this.Coach.Margin = new System.Windows.Forms.Padding(4);
            this.Coach.Name = "Coach";
            this.Coach.Size = new System.Drawing.Size(141, 25);
            this.Coach.TabIndex = 11;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(379, 94);
            this.Tel.Margin = new System.Windows.Forms.Padding(4);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(141, 25);
            this.Tel.TabIndex = 22;
            // 
            // Principal
            // 
            this.Principal.Location = new System.Drawing.Point(131, 134);
            this.Principal.Margin = new System.Windows.Forms.Padding(4);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(141, 25);
            this.Principal.TabIndex = 14;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(379, 134);
            this.Num.Margin = new System.Windows.Forms.Padding(4);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(141, 25);
            this.Num.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "人数(可选)";
            this.label6.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "联系方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "所属单位";
            this.label4.Click += new System.EventHandler(this.label6_Click);
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
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "球队名(必填)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(242, 354);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "备注(可选)";
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(131, 182);
            this.Remark.Multiline = true;
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(389, 121);
            this.Remark.TabIndex = 29;
            this.Remark.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 418);
            this.Controls.Add(this.Remark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Teamname);
            this.Controls.Add(this.Belong);
            this.Controls.Add(this.Coach);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modteam";
            this.Text = "添加队伍";
            this.Load += new System.EventHandler(this.modteam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Teamname;
        private System.Windows.Forms.TextBox Belong;
        private System.Windows.Forms.TextBox Coach;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Principal;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Remark;
    }
}