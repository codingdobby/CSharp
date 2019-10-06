using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace 인사관리
{
    public partial class Form1 : Form
    {
        private int n = 0;
        private bool b_insert = true;//insert, false 면 update 


        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Program.ProgramName +" " + Program.ProgramVersion;
            
            tSLabel1.Text = "1712124 조민영";
            tsLabel2.Text = DateTime.Now.ToShortDateString();//날짜만
            //재직상태 메서드 사용
            재직상태();
            부서();
            직급();
            listViewTitle();
            string pic_folder = "pics";
            if (!Directory.Exists(pic_folder)) {
                Directory.CreateDirectory(pic_folder);


            }
            TextClear();

        }
        private void listViewTitle()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("No. ", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("사원번호", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("이름", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("성별", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("생년월일", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("재직", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("부서", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("전화1", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("사진파일명", 150, HorizontalAlignment.Left);






        }
        private void 재직상태() {
            DBConn conn = new DBConn();
            string sql = "select 재직상태명 from 재직상태 order by 코드";
            OleDbDataReader r = conn.ExecuteReader(sql);
            while (r.Read()) {

                cb재직상태.Items.Add(r["재직상태명"]);
                

            }
            r.Close();
            conn.Close();
            cb재직상태.SelectedIndex = 0;
        }
        private void 부서()
        {
            DBConn conn = new DBConn();
            string sql = "select 부서명 from 부서 order by 코드명";
            OleDbDataReader r = conn.ExecuteReader(sql);
            while (r.Read())
            {

                cb부서.Items.Add(r["부서명"]);


            }
            r.Close();
            conn.Close();
            cb부서.SelectedIndex = 0;

        }
        private void 직급()
        {
            DBConn conn = new DBConn();
            string sql = "select 직급명 from 직급 order by 코드";
            OleDbDataReader r = conn.ExecuteReader(sql);
            while (r.Read())
            {

                cb직급.Items.Add(r["직급명"]);


            }
            r.Close();
            conn.Close();
            cb직급.SelectedIndex = 0;

        }

        private void btn검색_Click(object sender, EventArgs e)
        {
           
            if (txt사원번호.Text.Trim() == "")
            {
                MessageBox.Show("사원번호를 입력해주세요", "입력",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt사원번호.Focus();
                return;
            }

            

            string sql = "select * from 인사 where 사원번호='"+txt사원번호.Text+"'";
            DBConn conn = new DBConn();
            OleDbDataReader r = conn.ExecuteReader(sql);
            if (r.Read())
            {

                txtname.Text = r["이름"].ToString();
                rb남.Checked = false;
                rb여.Checked = false;
                if (r["성별"].ToString() == "1") {
                    rb남.Checked = true;

                }
                if (r["성별"].ToString() == "2")
                {
                    rb여.Checked = true;

                }
                txt생일.Text = r["생년월일"].ToString();
                cb재직상태.Text = r["재직상태"].ToString();
                cb부서.Text = r["부서"].ToString();
                txt전화1.Text = r["전화1"].ToString();

                if (r["사진파일명"].ToString() != "")
                {
                    try
                    {
                        pictureBox1.Tag = r["사진파일명"].ToString();
                        pictureBox1.Load(@"pics\" + r["사진파일명"].ToString());
                    }
                    catch { }
                }
                b_insert = false;

               



            }
            else {
                MessageBox.Show("등록된 사원번호가 아닙니다.","입력오류",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            r.Close();
            conn.Close();

        }

        private void btn우편검색_Click(object sender, EventArgs e)
        {

        }

        private void btn저장_Click(object sender, EventArgs e)
        {

            if (txt사원번호.Text.Trim() == "") {
                MessageBox.Show("사원번호를 입력해주세요","입력",
                   MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt사원번호.Focus();
                return;
            }

            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("이름을 입력해주세요", "입력",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

            string sql = String.Empty;


            if (b_insert == true) {
                //insert
                sql = "insert into 인사(이름,성별,생년월일,재직상태,부서,전화1,사진파일명,사원번호) " +
                    "values(@이름,@성별,@생년월일,@재직상태,@부서,@전화1,@사진파일명,@사원번호)";

            }
            else {

                //update
                sql = "update 인사 set 이름=@이름,성별=@성별,생년월일=@생년월일,재직상태=@재직상태,부서=@부서,전화1=@전화1,사진파일명=@사진파일명 where 사원번호=@사원번호 ";

            }

            DBConn conn = new DBConn();
            OleDbCommand cmd = new OleDbCommand(sql, conn.GetConn());

            cmd.Parameters.Add("@이름", txtname.Text);

            /*******************************************************/

            string gender = "0";
            if (rb남.Checked) {
                gender = "1";

            }
            if (rb여.Checked)
            {
                gender = "2";

            }

            /*******************************************************/
            cmd.Parameters.Add("@성별", gender);
            cmd.Parameters.Add("@생년월일", txt생일.Text);
            cmd.Parameters.Add("@재직상태", cb재직상태.Text);
            cmd.Parameters.Add("@부서", cb부서.Text);
            cmd.Parameters.Add("@전화1", txt전화1.Text);
            string temp사진 = "";
            if (pictureBox1.Tag.ToString() != "")
            {
                temp사진 = pictureBox1.Tag.ToString();
            }

            cmd.Parameters.Add("@사진파일명", temp사진);
            cmd.Parameters.Add("@사원번호", txt사원번호.Text);




            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다");
                TextClear();
            }
            catch(Exception ee)//버튼 이벤트 변수가 e
            {


                MessageBox.Show(ee.Message);

            }
            finally {

                conn.Close();

            }

        }

        private void TextClear() {
            txt사원번호.Clear();
            txtname.Clear();
            rb남.Checked = false;
            rb여.Checked = false;
            txt생일.Clear();
            txt전화1.Clear();
           
            pictureBox1.Image = null;
            pictureBox1.Tag = "";

            b_insert = true;

        }

        private void btn삭제_Click(object sender, EventArgs e)
        {

        }

        private void btn화면클리어_Click(object sender, EventArgs e)
        {
            TextClear();
        }

        private void tBtn검색_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            n=0;

            string sql = "select * from 인사 order by 사원번호";
            DBConn conn = new DBConn();
            OleDbDataReader r = conn.ExecuteReader(sql);
            while (r.Read()) {
                n++;
                ListViewItem item = new ListViewItem(n.ToString());
                item.SubItems.Add(r["사원번호"].ToString());
                item.SubItems.Add(r["이름"].ToString());
                item.SubItems.Add(r["성별"].ToString());
                item.SubItems.Add(r["생년월일"].ToString());
                item.SubItems.Add(r["재직상태"].ToString());
                item.SubItems.Add(r["부서"].ToString());
                item.SubItems.Add(r["전화1"].ToString());
              
                item.SubItems.Add(r["사진파일명"].ToString());
                listView1.Items.Add(item);



            }

            r.Close();
            conn.Close();

        }

        private void btn찾아보기_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "그림 파일|*.jpg;*.gif;*.png;|모든 파일|*.*";
            openFileDialog1.FilterIndex = 1;
            pictureBox1.Tag = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Load(openFileDialog1.FileName);//전체경로
                File.Copy(openFileDialog1.FileName,
                    "pics\\"+ openFileDialog1.SafeFileName,true);//safeFilename 경로를 뺀 파일 이름
                pictureBox1.Tag = openFileDialog1.SafeFileName;
               
                


            }
            
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
