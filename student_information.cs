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
    public partial class student_information : Form
    {
        string st;
        public student_information(string chuan)
        {
            InitializeComponent();
            st = chuan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter select_SQL = new SqlDataAdapter("select student.ID,student.Sname,student.Sgender,student.Class,course_grade.CNo,course.CName,course_grade.Grade from student,course_grade,course where student.ID='" + st+ "' and student.ID=course_grade.SNo and course_grade.CNo=course.Course_No", Data_Base);
            DataSet dds = new DataSet();
            select_SQL.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course_selection form = new Course_selection();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stu_password_change form = new Stu_password_change();
            form.Show();
        }
    }
}
