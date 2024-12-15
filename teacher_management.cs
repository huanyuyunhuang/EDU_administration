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
    public partial class teacher_management : Form
    {
        String st;
        public teacher_management(string chuan)
        {
            InitializeComponent();
            st = chuan;
        }

        private void button1_Click(object sender, EventArgs e)//显示学生信息
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter select_SQL = new SqlDataAdapter("Select student.ID,student.Sname,student.Sgender,student.Class,course.Course_No,course.CName,course_grade.Grade from student,course_grade,course,teach_arrange where teach_arrange.Tnumber=" + st+ " AND teach_arrange.Course_No=course_grade.CNo AND course_grade.SNo=student.ID AND course_grade.CNo=course.Course_No", Data_Base);
            DataSet dds = new DataSet();
            select_SQL.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scores_modify form = new scores_modify();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tea_password_change form = new Tea_password_change();
            form.Show();
        }
    }
}
