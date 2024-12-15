using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace jiaowuguanlijiemian
{
    public partial class Tea_password_change : Form
    {
        public Tea_password_change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);  //连接数据库
            Data_Base.Open();                                             //打开数据库
            string select_SQL = "Select * from teacher_login where work_number = '" + textBox1.Text + "' and Pass_word='" + textBox3.Text + "'";
            //数据库SQL选择语句，从Educational_ad表中选择符合输入的管理员的账号密码的元组
            SqlCommand cmd = new SqlCommand(select_SQL, Data_Base);//SqlCommand对象允许指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            //cmd执行的SQL是CommandText里写出的SQL语句

            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();  //读取返回值
            if (sdr.Read())
            {                   //进入这里则说明登录成功
                flag = true;
            }
            else
            {
                MessageBox.Show("信息输入错误！");
                return;
            }
            Data_Base.Close();  //关闭连接
            if (flag == true)
            {
                Data_Base.Open();
                string insert_SQL_1 = "update teacher_login set Pass_word = " + textBox2.Text + " where work_number = '" + textBox1.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insert_SQL_1, Data_Base);
                cmd1.CommandType = CommandType.Text;
                SqlDataReader sdr1;
                sdr1 = cmd1.ExecuteReader();
                Data_Base.Close();
                MessageBox.Show("修改密码成功！");
                this.Close();
            }
        }
    }
}
