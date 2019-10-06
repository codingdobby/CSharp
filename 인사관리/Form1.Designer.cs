namespace 인사관리
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기본코드BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재직상태코드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.부서코드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직급코드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계산기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt생일 = new System.Windows.Forms.TextBox();
            this.txtBox9 = new System.Windows.Forms.TextBox();
            this.txt입사일자 = new System.Windows.Forms.TextBox();
            this.btn검색 = new System.Windows.Forms.Button();
            this.btn화면클리어 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn저장 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb여 = new System.Windows.Forms.RadioButton();
            this.rb남 = new System.Windows.Forms.RadioButton();
            this.txt전화1 = new System.Windows.Forms.TextBox();
            this.txt전화2 = new System.Windows.Forms.TextBox();
            this.txt주소2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt주소1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn우편검색 = new System.Windows.Forms.Button();
            this.txt우편번호 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb직급 = new System.Windows.Forms.ComboBox();
            this.btn찾아보기 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cb부서 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cb재직상태 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txt사원번호 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tBtn검색 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.기본코드BToolStripMenuItem,
            this.도구TToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 기본코드BToolStripMenuItem
            // 
            this.기본코드BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재직상태코드ToolStripMenuItem,
            this.부서코드ToolStripMenuItem,
            this.직급코드ToolStripMenuItem});
            this.기본코드BToolStripMenuItem.Name = "기본코드BToolStripMenuItem";
            this.기본코드BToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.기본코드BToolStripMenuItem.Text = "기본 코드(&B)";
            // 
            // 재직상태코드ToolStripMenuItem
            // 
            this.재직상태코드ToolStripMenuItem.Name = "재직상태코드ToolStripMenuItem";
            this.재직상태코드ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.재직상태코드ToolStripMenuItem.Text = "재직 상태 코드";
            // 
            // 부서코드ToolStripMenuItem
            // 
            this.부서코드ToolStripMenuItem.Name = "부서코드ToolStripMenuItem";
            this.부서코드ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.부서코드ToolStripMenuItem.Text = "부서 코드";
            // 
            // 직급코드ToolStripMenuItem
            // 
            this.직급코드ToolStripMenuItem.Name = "직급코드ToolStripMenuItem";
            this.직급코드ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.직급코드ToolStripMenuItem.Text = "직급 코드";
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계산기CToolStripMenuItem});
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(&T)";
            // 
            // 계산기CToolStripMenuItem
            // 
            this.계산기CToolStripMenuItem.Name = "계산기CToolStripMenuItem";
            this.계산기CToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.계산기CToolStripMenuItem.Text = "계산기(&C)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 프로그램정보AToolStripMenuItem
            // 
            this.프로그램정보AToolStripMenuItem.Name = "프로그램정보AToolStripMenuItem";
            this.프로그램정보AToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.프로그램정보AToolStripMenuItem.Text = "프로그램 정보(&A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabel1,
            this.tsLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSLabel1
            // 
            this.tSLabel1.Name = "tSLabel1";
            this.tSLabel1.Size = new System.Drawing.Size(839, 17);
            this.tSLabel1.Spring = true;
            this.tSLabel1.Text = "toolStripStatusLabel1";
            this.tSLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsLabel2
            // 
            this.tsLabel2.Name = "tsLabel2";
            this.tsLabel2.Size = new System.Drawing.Size(121, 17);
            this.tsLabel2.Text = "toolStripStatusLabel2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 481);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txt생일);
            this.tabPage1.Controls.Add(this.txtBox9);
            this.tabPage1.Controls.Add(this.txt입사일자);
            this.tabPage1.Controls.Add(this.btn검색);
            this.tabPage1.Controls.Add(this.btn화면클리어);
            this.tabPage1.Controls.Add(this.btn삭제);
            this.tabPage1.Controls.Add(this.btn저장);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt전화1);
            this.tabPage1.Controls.Add(this.txt전화2);
            this.tabPage1.Controls.Add(this.txt주소2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt주소1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn우편검색);
            this.tabPage1.Controls.Add(this.txt우편번호);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cb직급);
            this.tabPage1.Controls.Add(this.btn찾아보기);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.cb부서);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.cb재직상태);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.txtname);
            this.tabPage1.Controls.Add(this.txt사원번호);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본";
            // 
            // txt생일
            // 
            this.txt생일.Location = new System.Drawing.Point(444, 104);
            this.txt생일.MaxLength = 10;
            this.txt생일.Name = "txt생일";
            this.txt생일.Size = new System.Drawing.Size(100, 21);
            this.txt생일.TabIndex = 34;
            // 
            // txtBox9
            // 
            this.txtBox9.Location = new System.Drawing.Point(444, 204);
            this.txtBox9.MaxLength = 10;
            this.txtBox9.Name = "txtBox9";
            this.txtBox9.Size = new System.Drawing.Size(100, 21);
            this.txtBox9.TabIndex = 33;
            // 
            // txt입사일자
            // 
            this.txt입사일자.Location = new System.Drawing.Point(444, 172);
            this.txt입사일자.MaxLength = 10;
            this.txt입사일자.Name = "txt입사일자";
            this.txt입사일자.Size = new System.Drawing.Size(100, 21);
            this.txt입사일자.TabIndex = 32;
            // 
            // btn검색
            // 
            this.btn검색.Location = new System.Drawing.Point(550, 25);
            this.btn검색.Name = "btn검색";
            this.btn검색.Size = new System.Drawing.Size(75, 23);
            this.btn검색.TabIndex = 31;
            this.btn검색.Text = "검색";
            this.btn검색.UseVisualStyleBackColor = true;
            this.btn검색.Click += new System.EventHandler(this.btn검색_Click);
            // 
            // btn화면클리어
            // 
            this.btn화면클리어.Location = new System.Drawing.Point(685, 407);
            this.btn화면클리어.Name = "btn화면클리어";
            this.btn화면클리어.Size = new System.Drawing.Size(75, 23);
            this.btn화면클리어.TabIndex = 30;
            this.btn화면클리어.Text = "화면 Clear";
            this.btn화면클리어.UseVisualStyleBackColor = true;
            this.btn화면클리어.Click += new System.EventHandler(this.btn화면클리어_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(561, 407);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 23);
            this.btn삭제.TabIndex = 29;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // btn저장
            // 
            this.btn저장.Location = new System.Drawing.Point(444, 407);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(75, 23);
            this.btn저장.TabIndex = 28;
            this.btn저장.Text = "저장";
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb여);
            this.groupBox1.Controls.Add(this.rb남);
            this.groupBox1.Location = new System.Drawing.Point(645, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 52);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // rb여
            // 
            this.rb여.AutoSize = true;
            this.rb여.Location = new System.Drawing.Point(61, 20);
            this.rb여.Name = "rb여";
            this.rb여.Size = new System.Drawing.Size(35, 16);
            this.rb여.TabIndex = 1;
            this.rb여.TabStop = true;
            this.rb여.Text = "여";
            this.rb여.UseVisualStyleBackColor = true;
            // 
            // rb남
            // 
            this.rb남.AutoSize = true;
            this.rb남.Location = new System.Drawing.Point(6, 20);
            this.rb남.Name = "rb남";
            this.rb남.Size = new System.Drawing.Size(35, 16);
            this.rb남.TabIndex = 0;
            this.rb남.TabStop = true;
            this.rb남.Text = "남";
            this.rb남.UseVisualStyleBackColor = true;
            // 
            // txt전화1
            // 
            this.txt전화1.Location = new System.Drawing.Point(444, 345);
            this.txt전화1.MaxLength = 15;
            this.txt전화1.Name = "txt전화1";
            this.txt전화1.Size = new System.Drawing.Size(195, 21);
            this.txt전화1.TabIndex = 26;
            // 
            // txt전화2
            // 
            this.txt전화2.Location = new System.Drawing.Point(648, 345);
            this.txt전화2.MaxLength = 15;
            this.txt전화2.Name = "txt전화2";
            this.txt전화2.Size = new System.Drawing.Size(192, 21);
            this.txt전화2.TabIndex = 25;
            // 
            // txt주소2
            // 
            this.txt주소2.Location = new System.Drawing.Point(444, 306);
            this.txt주소2.MaxLength = 100;
            this.txt주소2.Name = "txt주소2";
            this.txt주소2.Size = new System.Drawing.Size(393, 21);
            this.txt주소2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "전화";
            // 
            // txt주소1
            // 
            this.txt주소1.Location = new System.Drawing.Point(444, 279);
            this.txt주소1.MaxLength = 100;
            this.txt주소1.Name = "txt주소1";
            this.txt주소1.Size = new System.Drawing.Size(393, 21);
            this.txt주소1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "주소";
            // 
            // btn우편검색
            // 
            this.btn우편검색.Enabled = false;
            this.btn우편검색.Location = new System.Drawing.Point(561, 242);
            this.btn우편검색.Name = "btn우편검색";
            this.btn우편검색.Size = new System.Drawing.Size(75, 23);
            this.btn우편검색.TabIndex = 20;
            this.btn우편검색.Text = "검색";
            this.btn우편검색.UseVisualStyleBackColor = true;
            this.btn우편검색.Click += new System.EventHandler(this.btn우편검색_Click);
            // 
            // txt우편번호
            // 
            this.txt우편번호.Location = new System.Drawing.Point(444, 243);
            this.txt우편번호.MaxLength = 5;
            this.txt우편번호.Name = "txt우편번호";
            this.txt우편번호.Size = new System.Drawing.Size(100, 21);
            this.txt우편번호.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "우편번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "직급";
            // 
            // cb직급
            // 
            this.cb직급.FormattingEnabled = true;
            this.cb직급.Location = new System.Drawing.Point(719, 214);
            this.cb직급.Name = "cb직급";
            this.cb직급.Size = new System.Drawing.Size(121, 20);
            this.cb직급.TabIndex = 16;
            // 
            // btn찾아보기
            // 
            this.btn찾아보기.Location = new System.Drawing.Point(144, 264);
            this.btn찾아보기.Name = "btn찾아보기";
            this.btn찾아보기.Size = new System.Drawing.Size(75, 23);
            this.btn찾아보기.TabIndex = 15;
            this.btn찾아보기.Text = "찾아보기";
            this.btn찾아보기.UseVisualStyleBackColor = true;
            this.btn찾아보기.Click += new System.EventHandler(this.btn찾아보기_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(122, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(561, 208);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(57, 21);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // cb부서
            // 
            this.cb부서.FormattingEnabled = true;
            this.cb부서.Location = new System.Drawing.Point(719, 178);
            this.cb부서.Name = "cb부서";
            this.cb부서.Size = new System.Drawing.Size(121, 20);
            this.cb부서.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(561, 175);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(57, 21);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // cb재직상태
            // 
            this.cb재직상태.FormattingEnabled = true;
            this.cb재직상태.Location = new System.Drawing.Point(444, 144);
            this.cb재직상태.Name = "cb재직상태";
            this.cb재직상태.Size = new System.Drawing.Size(100, 20);
            this.cb재직상태.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "퇴사일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "부서";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "입사일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "재직상태";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(561, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(57, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(444, 59);
            this.txtname.MaxLength = 20;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 4;
            // 
            // txt사원번호
            // 
            this.txt사원번호.Location = new System.Drawing.Point(444, 25);
            this.txt사원번호.MaxLength = 5;
            this.txt사원번호.Name = "txt사원번호";
            this.txt사원번호.Size = new System.Drawing.Size(100, 21);
            this.txt사원번호.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "생년월일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원번호";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tBtn검색);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "조회";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 449);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tBtn검색
            // 
            this.tBtn검색.Location = new System.Drawing.Point(884, 24);
            this.tBtn검색.Name = "tBtn검색";
            this.tBtn검색.Size = new System.Drawing.Size(75, 23);
            this.tBtn검색.TabIndex = 1;
            this.tBtn검색.Text = "검색";
            this.tBtn검색.UseVisualStyleBackColor = true;
            this.tBtn검색.Click += new System.EventHandler(this.tBtn검색_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 552);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기본코드BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재직상태코드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 부서코드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직급코드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 계산기CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tSLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cb재직상태;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txt사원번호;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox cb부서;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb직급;
        private System.Windows.Forms.Button btn찾아보기;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn우편검색;
        private System.Windows.Forms.TextBox txt우편번호;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt주소1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt전화1;
        private System.Windows.Forms.TextBox txt전화2;
        private System.Windows.Forms.TextBox txt주소2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn화면클리어;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb여;
        private System.Windows.Forms.RadioButton rb남;
        private System.Windows.Forms.Button btn검색;
        private System.Windows.Forms.TextBox txt생일;
        private System.Windows.Forms.TextBox txtBox9;
        private System.Windows.Forms.TextBox txt입사일자;
        private System.Windows.Forms.Button tBtn검색;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
    }
}

