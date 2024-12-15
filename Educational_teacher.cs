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
    public partial class Educational_teacher : UserControl
    {
        public Educational_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from teacher", Data_Base);//获取数据
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
            Data_Base.Close();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from teach_arrange", Data_Base);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            Data_Base.Close();
        }        
        private void button3_Click(object sender, EventArgs e)//添加教师
        {
            new_teacher form = new new_teacher();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            delete_teacher deleteT_form = new delete_teacher();
            deleteT_form.Show();
        }
    }
}
