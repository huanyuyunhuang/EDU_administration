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
    public partial class jiaowuguanlijiemian : Form
    {
        public jiaowuguanlijiemian()
        {
            InitializeComponent();
        }
        public guanliyuan1 AD_login_form;//定义管理员登录窗体变量
        public teacher_login TEA_login_form;//定义教师登录窗体变量
        public student_login STU_login_form;//定义学生登录窗体变量

        private void jiaowuguanlijiemian_Load(object sender, EventArgs e)
        {
            AD_login_form = new guanliyuan1();
            TEA_login_form = new teacher_login();
            STU_login_form = new student_login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AD_login_form.Show();//显示窗体1控件
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(AD_login_form);//加载窗体1控件
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TEA_login_form.Show();//显示窗体2控件
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(TEA_login_form);//加载窗体2控件
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STU_login_form.Show();//显示窗体3控件
            groupBox1.Controls.Clear();//清空之间加载的控件
            groupBox1.Controls.Add(STU_login_form);//加载窗体3控件
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出教务管理系统，此函数强制退出所有窗体
        }
    }
}
