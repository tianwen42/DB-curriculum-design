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

        private void addReader_Click(object sender, EventArgs e)
        {
            //验证成功进入系统
            modteam modteamForm = new modteam();
            modteamForm.ShowDialog();
            modteamForm.Dispose();
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
    }
}
