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
    public partial class loginDsigner : Form
    {
        public loginDsigner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connsql = "server=localhost;database=YANGLIN;Integrated Security=TRUE";  // 数据库连接字符串,database设置为自己的数据库名，以Windows身份验证
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select * from S"; // 查询语句

                    SqlDataAdapter myda = new SqlDataAdapter(sql, conn); // 实例化适配器

                    DataTable dt = new DataTable(); // 实例化数据表
                    MessageBox.Show("数据库连接成功");
                    conn.Close(); // 关闭数据库连接
                }
            }
            catch (InvalidOperationException exception)
            {
                if (MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    return;
            }

            if (MessageBox.Show("登录成功！", "提示") == DialogResult.OK)
            {

                //验证成功进入系统
                main mainForm = new main();
                mainForm.Show(this);
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginDsigner_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// 从指定数据库中查找所有表名
            //string sqlTableName = "Select * From Information_Schema.Tables";
            //StringBuilder tableNames = new StringBuilder();
            //using (SqlDataReader dr = SqlHelper.ExecuteReaderByText(sqlTableName, null))
            //{
            //    while (dr.Read())
            //    {
            //        // 表名
            //        tableNames.Append(dr["Table_Name"] + ",");
            //    }
            //}
            //MessageBox.Show("数据库中所有表名：" + tableNames.ToString(), "小赖温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
