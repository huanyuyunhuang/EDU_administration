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
    public partial class Course_selection : Form
    {
        public Course_selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            string insert_SQL = "insert into course_grade(SNo,CNo) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            //课程选择，实质是在course_grade表格里添加学号和课程号信息
            SqlCommand cmd1 = new SqlCommand(insert_SQL, Data_Base);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader sdr1;
            sdr1 = cmd1.ExecuteReader();
            Data_Base.Close();
            this.Close();  
        }
    }
}
