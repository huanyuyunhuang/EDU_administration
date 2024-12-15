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
    public partial class new_teacher : Form
    {
        public new_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            string insert_SQL = "insert into teacher values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(insert_SQL, Data_Base);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            Data_Base.Close();

            Data_Base.Open();
            string insert_SQL_1 = "insert into teacher_login values('" + textBox1.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd1 = new SqlCommand(insert_SQL_1, Data_Base);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader sdr1;
            sdr1 = cmd1.ExecuteReader();
            Data_Base.Close();

            Data_Base.Open();
            string insert_SQL_2 = "insert into teach_arrange values('" + textBox1.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd2 = new SqlCommand(insert_SQL_2, Data_Base);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader sdr2;
            sdr2 = cmd2.ExecuteReader();
            Data_Base.Close();

            this.Close();  
        }

        private void new_teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
