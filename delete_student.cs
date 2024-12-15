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
namespace jiaowuguanlijiemian
{
    public partial class delete_student : Form
    {
        public delete_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            string delete_SQL = "delete from student where ID = '" + textBox1.Text + "'";//删除的SQL语句
            //SQL删除语句，依据ID条件尽心删除
            SqlCommand cmd = new SqlCommand(delete_SQL, Data_Base);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            Data_Base.Close();
            //student表中删除后，登录表中也要进行删除
            Data_Base.Open();
            string delete_SQL_1 = "delete from student_login where ID= '" + textBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(delete_SQL_1, Data_Base);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader sdr1;
            sdr1 = cmd1.ExecuteReader();
            Data_Base.Close();
            //student表中删除后，成绩表中也要进行删除
            Data_Base.Open();
            string delete_SQL_2 = "delete from course_grade where SNo= '" + textBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(delete_SQL_2, Data_Base);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader sdr2;
            sdr2 = cmd2.ExecuteReader();
            Data_Base.Close();
  
            this.Close();
        }

        private void delete_student_Load(object sender, EventArgs e)
        {

        }
    }
}
