using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jiaowuguanlijiemian
{
    public partial class guanliyuanjiemian : Form
    {
        public Educational_student S_form;//学生信息窗体变量S_form
        public Educational_teacher T_form;//教师信息窗体变量T_form
        public Educational_system_user U_form;//用户信息窗体变量U_form
        public Educational_course C_form;//用户信息窗体变量U_form
        public guanliyuanjiemian()
        {
            InitializeComponent();
        }
        private void guanliyuanjiemian_Load(object sender, EventArgs e)
        {
            S_form = new Educational_student();
            T_form = new Educational_teacher();
            U_form = new Educational_system_user();
            C_form = new Educational_course();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            S_form.Show();//显示窗体1控件
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(S_form);//加载窗体1控件
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T_form.Show();
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(T_form);//加载窗体1控件
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            U_form.Show();
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(U_form);//加载窗体1控件
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C_form.Show();
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(C_form);//加载窗体1控件
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
