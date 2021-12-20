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

                    String sql = "select * from student"; // 查询语句

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
