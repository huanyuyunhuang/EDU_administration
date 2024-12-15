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
    public partial class score_change : Form
    {
        public score_change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp = @"Data Source=DESKTOP-HYFMWDT;Initial catalog=EDUCATION;integrated Security=True";
            SqlConnection Data_Base = new SqlConnection(Temp);
            Data_Base.Open();
            string update_SQL = "update course_grade set Grade = " + textBox2.Text + " where SNo = '" + textBox1.Text + "'and CNo='" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(update_SQL, Data_Base);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            this.Close();
            Data_Base.Close();  
        }
    }
}
