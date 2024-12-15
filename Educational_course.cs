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
    public partial class Educational_course : UserControl
    {
        public Educational_course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//显示学生
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from course", Data_Base);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];//显示表格
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
            Data_Base.Close();  
        }


        private void button2_Click(object sender, EventArgs e)//新建课程
        {
            new_course newS_form = new new_course();
            newS_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)//删除课程
        {
            delete_course newS_form = new delete_course();
            newS_form.Show();
        }


    }
}
