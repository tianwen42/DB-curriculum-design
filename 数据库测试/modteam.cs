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
        public string Modifytype;
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
            if (Modifytype == "添加")
            {
                try
                {
                    AddTeamSql = "INSERT INTO 球队 (球队名称, 所属单位, 主教练, 球队人数, 负责人, 联系方式, 备注) VALUES(";
                    if (string.IsNullOrEmpty(this.Teamname.Text.ToString()))
                    {
                        MessageBox.Show("球队名不能为空");
                        return;
                    }
                    else
                    {
                        AddTeamSql += "'" + this.Teamname.Text.ToString() + "',";
                    }
                    AddTeamSql += "'" + this.Belong.Text.ToString() + "',";
                    AddTeamSql += "'" + this.Coach.Text.ToString() + "',";
                    AddTeamSql += "'" + this.Num.Text.ToString() + "',";
                    AddTeamSql += "'" + this.Principal.Text.ToString() + "',";
                    AddTeamSql += "'" + this.Tel.Text.ToString() + "',";
                    AddTeamSql += "'" + this.Remark.Text.ToString() + "'";
                    AddTeamSql += ")";

                    SqlConnection cnn = new SqlConnection();//实例化一个连接
                    cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter();

                    //string testc = "INSERT INTO 球队 (球队名称,所属单位,主教练,球队人数,负责人,联系方式) VALUES('QWQWQ','WQWQ','W12','12','QWQW','2141')";
                    SqlDataAdapter command = new SqlDataAdapter(AddTeamSql, cnn);
                    DataSet ds = new DataSet();
                    command.Fill(ds, "ds");
                    cnn.Close();
                    MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }else if (Modifytype == "修改") {
                try
                {
                    if (string.IsNullOrEmpty(this.Teamname.Text.ToString()))
                    {
                        MessageBox.Show("球队名不能为空");
                        return;
                    }
                    else
                    {
                        string ModifyTeamSql = string.Format(@"UPDATE 球队 SET 所属单位= '{0}',
                                                    主教练= '{1}',球队人数= '{2}',负责人= '{3}',
                                                    联系方式= '{4}',备注= '{5}' WHERE 球队名称='{6}'"
    , Belong.Text, Coach.Text, Num.Text, Principal.Text, Tel.Text, Remark.Text, Teamname.Text);
                        try {

                            SqlConnection cnn2 = new SqlConnection();//实例化一个连接
                            cnn2.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                            cnn2.Open();
                            SqlDataAdapter da2 = new SqlDataAdapter();

                            //string testc = "INSERT INTO 球队 (球队名称,所属单位,主教练,球队人数,负责人,联系方式) VALUES('QWQWQ','WQWQ','W12','12','QWQW','2141')";
                            SqlDataAdapter command2 = new SqlDataAdapter(ModifyTeamSql, cnn2);
                            DataSet ds2 = new DataSet();
                            command2.Fill(ds2, "ds2");
                            cnn2.Close();
                            MessageBox.Show("修改成功");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    SqlConnection cnn = new SqlConnection();//实例化一个连接
                    cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter();

                    //string testc = "INSERT INTO 球队 (球队名称,所属单位,主教练,球队人数,负责人,联系方式) VALUES('QWQWQ','WQWQ','W12','12','QWQW','2141')";
                    SqlDataAdapter command = new SqlDataAdapter("select * from 球队", cnn);
                    DataSet ds = new DataSet();
                    command.Fill(ds, "ds");
                    
                }

            }
            this.Close();
        }

        private void modteam_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
