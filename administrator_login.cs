using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jiaowuguanlijiemian
{
    public partial class guanliyuan1 : UserControl
    {
        public guanliyuanjiemian form;
        public guanliyuan1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名,integrated Security=True  
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";  
            SqlConnection Data_Base = new SqlConnection(Temp);  //连接数据库
            Data_Base.Open();                                             //打开数据库
            string select_SQL = "Select * from Educational_ad where account = '" + textBox1.Text+ "' and Pass_word='" + textBox2.Text+ "'";  
            //数据库SQL选择语句，从Educational_ad表中选择符合输入的管理员的账号密码的元组
            SqlCommand cmd = new SqlCommand(select_SQL, Data_Base);//SqlCommand对象允许指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;  
            //cmd执行的SQL是CommandText里写出的SQL语句
  
            SqlDataReader sdr;  
            sdr = cmd.ExecuteReader();  //读取返回值
            if (sdr.Read())  
            {                   //进入这里则说明登录成功
                this.Hide();//这里实现登陆成功后隐藏登录界面  
                form = new guanliyuanjiemian();//登陆成功显示主界面  
                form.Show();  //显示
            }  
            else   
            {  
                MessageBox.Show("登陆失败!请检查用户名或者密码重新登陆！");  
                return;  
            }
            Data_Base.Close();  //关闭连接
        }

        private void guanliyuan1_Load(object sender, EventArgs e)
        {

        }
    }
}

