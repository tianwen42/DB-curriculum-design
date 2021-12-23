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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void readerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();//实例化一个连接
                cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                cnn.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter command = new SqlDataAdapter("select * from 球队", cnn);
                DataSet ds = new DataSet();
                command.Fill(ds, "ds");
                this.TeamManagement.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("查询出错喽");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“competitionDataSet1.球队”中。您可以根据需要移动或删除它。
            //this.球队TableAdapter.Fill(this.competitionDataSet1.球队);

        }

        private void bookSearch_Click(object sender, EventArgs e)
        {

        }

        private void numberInputOnly(object sender, KeyPressEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void addteam_Click(object sender, EventArgs e)
        {

            //添加
            modteam modteamForm = new modteam();
            modteamForm.Modifytype = "添加";
            modteamForm.Text = "添加队伍";
            modteamForm.ShowDialog();
            modteamForm.Dispose();
            SqlConnection cnn = new SqlConnection();//实例化一个连接
            cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter command = new SqlDataAdapter("select * from 球队", cnn);
            DataSet ds = new DataSet();
            command.Fill(ds, "ds");
            this.TeamManagement.DataSource = ds.Tables[0];
            cnn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumTeam.Text.Length > 0 || Playername.Text.Length > 0 || Position.Text.Length > 0) {
                try {
                    
                    SqlConnection cnn = new SqlConnection();//实例化一个连接
                    cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                    cnn.Open();
                    string PlayerSearchSql = String.Format("select * from 球员 where 球员姓名 like '%{0}%' and 球队名称 like '%{1}%' and 位置 like '%{2}%'", Playername.Text, NumTeam.Text,Position.Text);
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlDataAdapter command = new SqlDataAdapter(PlayerSearchSql, cnn);
                    DataSet ds = new DataSet();
                    command.Fill(ds, "ds");
                    this.PlayerManagement.DataSource = ds.Tables[0];
                } catch
                {
                    MessageBox.Show("查询出错了哦");
                }
            }else{
                MessageBox.Show("至少输入一个查询条件");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Refereename.Text.Length  > 0 || RefereeLevel.Text.Length >0)
            {
                try
                {
                    string RefereeSearchSql = String.Format("select * from 裁判表 where 裁判姓名 like '%{0}%' and 裁判级别 like '%{1}%'", Refereename.Text, RefereeLevel.Text);
                    //string inRefereename = Refereename.Text;
                    //MessageBox.Show(inRefereename);
                    SqlConnection cnn = new SqlConnection();//实例化一个连接
                    cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
                    cnn.Open();

                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlDataAdapter command = new SqlDataAdapter(RefereeSearchSql, cnn);
                    DataSet ds = new DataSet();
                    command.Fill(ds, "ds");
                    this.RefereeManagemant.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("查询出了点小问题");
                }
            }
            else
            {
                MessageBox.Show("请填入至少一个查询条件！");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refereename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refereename.Text = "";
            RefereeLevel.Text = "";
            this.RefereeManagemant.DataSource = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumTeam_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NumTeam.Text = "";
            Playername.Text = "";
            Position.Text = "";

            this.PlayerManagement.DataSource = null;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Sql = String.Format("SELECT [积分排名汇总表].[比赛序号],[积分排名汇总表].[球队名称],[积分排名汇总表].[总分] FROM [积分排名汇总表] WHERE [积分排名汇总表].[赛事名称] = '{0}' GROUP BY [积分排名汇总表].[球队名称],[积分排名汇总表].[总分],[积分排名汇总表].[比赛序号] ORDER BY SUM([积分排名汇总表].[总分]) DESC", Competion.Text);
            //string inRefereename = Refereename.Text;
            //MessageBox.Show(inRefereename);
            SqlConnection cnn = new SqlConnection();//实例化一个连接
            cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter command = new SqlDataAdapter(Sql, cnn);
            DataSet ds = new DataSet();
            command.Fill(ds, "ds");
            this.Ranking.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void editTeam_Click(object sender, EventArgs e)
        {
            //验证成功进入系统
            modteam modteamForm = new modteam();
            modteamForm.Modifytype = "修改";
            modteamForm.Text = "修改队伍信息";
            modteamForm.ShowDialog();
            modteamForm.Dispose();
            SqlConnection cnn = new SqlConnection();//实例化一个连接
            cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter command = new SqlDataAdapter("select * from 球队", cnn);
            DataSet ds = new DataSet();
            command.Fill(ds, "ds");
            this.TeamManagement.DataSource = ds.Tables[0];
            cnn.Close();
            modteamForm.Close();
        }

        private void deleteTeam_Click(object sender, EventArgs e)
        {
            try
            {
                int index = TeamManagement.CurrentRow.Index;//获取当前选中行
                string account = TeamManagement.Rows[index].Cells[6].Value.ToString().Trim();
                string deleteTeamSql = String.Format(@"exec sp_droplogin '{0}' 
                                    exec sp_dropuser '{1}'
                                    delete from 球队 where account='{2}'", account, account, account);
                if (DialogResult.Yes == MessageBox.Show("确定要删除该记录", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL删除语句字符串
                    if (1> 0) //向源数据库传递SQL命令字符串，得到删除结果
                    {
                        MessageBox.Show("删除成功");
                        TeamManagement.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string Datesql = String.Format(@"select * from 比赛安排表 WHERE [比赛日期]='{0}'",date );
            SqlConnection cnn = new SqlConnection();//实例化一个连接
            cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter command = new SqlDataAdapter(Datesql, cnn);
            DataSet ds = new DataSet();
            command.Fill(ds, "ds");
            this.dataGridView2.DataSource = ds.Tables[0];
            cnn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;//获取当前选中行
            //string account = TeamManagement.Rows[index].Cells[6].Value.ToString().Trim();
            string team1=dataGridView2.Rows[index].Cells[5].Value.ToString();
            string team2 = dataGridView2.Rows[index].Cells[6].Value.ToString();
            label6.Text = team1;
            label7.Text = team2;
        }
    }
}
