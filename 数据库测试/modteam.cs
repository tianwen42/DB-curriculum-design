using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static DataBase_Project.PubConstant;
namespace 数据库测试
{
    public partial class modteam : Form
    {
        public modteam()
        {
            InitializeComponent();
        }
        public modteam(string inTeamname, string inBelong, string inTel, string inNum, string inCoach, string inPrincipal,string inRemark)
        {
            InitializeComponent();
            //获取在main中选中的各字段信息显示在文本框中
            Teamname.Text = inTeamname;
            Belong.Text = inBelong;
            Tel.Text = inTel;
            Num.Text = inNum;
            Coach.Text = inCoach;
            Principal.Text = inPrincipal;
            Remark.Text = inRemark;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            String AddTeamSql = string.Empty;
            AddTeamSql = "INSERT INTO 球队(球队名称, 所属单位, 主教练, 球队人数, 负责人, 联系方式) VALUES('";
            if (string.IsNullOrEmpty(this.Teamname.Text.ToString()))
            {
                MessageBox.Show("球队名不能为空");
                return;
            }
            else {
                AddTeamSql += "'" + this.Teamname.Text.ToString() + "',";
            }
            AddTeamSql += "'" + this.Teamname.Text.ToString() + "',";
            AddTeamSql += "'" + this.Belong.Text.ToString() + "',";
            AddTeamSql += "'" + this.Coach.Text.ToString() + "',";
            AddTeamSql += "'" + this.Num.Text.ToString() + "',";
            AddTeamSql += "'" + this.Principal.Text.ToString() + "',";
            AddTeamSql += "'" + this.Tel.Text.ToString() + "'";
            AddTeamSql += ")";

            
        }

        private void modteam_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
