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
    public partial class Educational_student : UserControl
    {
        public Educational_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//显示学生
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from student", Data_Base);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];//显示表格
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
            Data_Base.Close();  
        }

        private void button3_Click(object sender, EventArgs e)//修改学生
        {
            score_change modifyS_form = new score_change();
            modifyS_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)//新建学生
        {
            new_student newS_form = new new_student();
            newS_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)//看学生分数
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from course_grade", Data_Base);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];//显示表格
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
            Data_Base.Close();  
        }

        private void button4_Click(object sender, EventArgs e)//删除学生
        {
            delete_student deleteS_form=new delete_student();
            deleteS_form.Show();
        }

    }
}
