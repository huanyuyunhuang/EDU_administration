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
    public partial class teacher_login : UserControl
    {
        public teacher_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";  
           SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();   
           string select_SQL = "Select * from teacher_login where work_number = '" + textBox1.Text+ "' and Pass_word='" + textBox2.Text+ "'";  
           SqlCommand cmd = new SqlCommand(select_SQL, Data_Base);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
           cmd.CommandType = CommandType.Text;    
  
           SqlDataReader sdr;  
           sdr = cmd.ExecuteReader();  
           if (sdr.Read())  
           {   
               this.Hide();//这里实现登陆成功后隐藏登录界面  
               String chuan = textBox1.Text;
               teacher_management form = new teacher_management(chuan);//登陆成功显示主界面  
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
