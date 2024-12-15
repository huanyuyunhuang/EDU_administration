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
    public partial class student_login : UserControl
    {
        public student_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
           //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，integrated Security=True  
           string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";  
           SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();   
           string select_SQL = "Select * from student_login where ID = '" + textBox1.Text+ "' and Pass_word='" + textBox2.Text+ "'";  
           SqlCommand cmd = new SqlCommand(select_SQL, Data_Base);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
           cmd.CommandType = CommandType.Text;    
  
           SqlDataReader sdr;  
           sdr = cmd.ExecuteReader();  
           if (sdr.Read())  
           {   
               this.Hide();//这里实现登陆成功后隐藏登录界面  
               String chuan = textBox1.Text;
               student_information form = new student_information(chuan);//登陆成功显示主界面  
               form.Show();  
           }  
           else   
           {  
               MessageBox.Show("登陆失败!请检查用户名或者密码重新登陆！");  
               return;  
           }
            Data_Base.Close();  
       }                  
    }
}
