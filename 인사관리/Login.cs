using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 인사관리
{
    public partial class Login : Form
    {
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") {
                MessageBox.Show("아이디를 입력하세요");
                txtID.Focus();
                return;
            }
            if (txt비번.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                txt비번.Focus();
                return;
            }

            //DB아이디 비번
            string id = "abc";
            string pwd = "1234";

            if (txtID.Text == id && txt비번.Text == pwd)
            {
                Form1 f = new Form1();
                //close하면 안됨
                this.Hide();
                f.Show();

            }
            else {

                count++;
                if (count >= 5)
                    Application.Exit();





            }



        }

        private void btn종료_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
