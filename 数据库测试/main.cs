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

            SqlConnection cnn = new SqlConnection();//实例化一个连接
            cnn.ConnectionString = "server=localhost;database=competition;uid=sa;pwd=123456";//设置连接字符串
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter command = new SqlDataAdapter("select 球队名称,所属单位,主教练,负责人,联系方式 from 球队", cnn);
            DataSet ds = new DataSet();
            command.Fill(ds, "ds");
            this.TeamManagement.DataSource = ds.Tables[0];

            try
            {
                MessageBox.Show("try");
            }
            catch
            {
                MessageBox.Show("查询出错喽");
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“competitionDataSet1.球队”中。您可以根据需要移动或删除它。
            this.球队TableAdapter.Fill(this.competitionDataSet1.球队);

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
    }
}
