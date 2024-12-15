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
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            string insert_SQL = "insert into Educational_ad values('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(insert_SQL, Data_Base);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            Data_Base.Close();

            this.Close();  
        }

        private void new_teacher_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
