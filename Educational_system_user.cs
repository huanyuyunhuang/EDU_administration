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
    public partial class Educational_system_user : UserControl
    {
        public Educational_system_user()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)//添加用户
        {
            new_user form = new new_user();
            form.Show();
        }



        private void button4_Click(object sender, EventArgs e)//删除用户
        {
            delete_user form = new delete_user();
            form.Show();
        }

    }
}
