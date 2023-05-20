using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서관리화면설계ver2
{
    public partial class 로그인_Form : Form
    {
        방문자_검색Form 방문자검색폼;
        public 로그인_Form(방문자_검색Form 부모폼)
        {
            InitializeComponent();
            방문자검색폼 = 부모폼;
        }

        private void 로그인_button_Click(object sender, EventArgs e)
        {
            if ((아이디_textBox.Text.Length > 0 || 비밀번호_textBox.Text.Length > 0) && 방문자검색폼.관리자폼 == null)
            {
                MessageBox.Show("테스트 로그인입니다.");
                방문자검색폼.관리자폼 = new 관리자_Form(방문자검색폼);
                방문자검색폼.관리자폼.Show();
                방문자검색폼.로그인폼 = null;
                this.Close();
            }
            else if (아이디_textBox.Text.Length == 0 && 비밀번호_textBox.Text.Length == 0 && 방문자검색폼.회원폼 == null) 
            {
                MessageBox.Show("테스트 로그인입니다.");
                방문자검색폼.회원폼 = new 회원_Form(방문자검색폼);
                방문자검색폼.회원폼.Show();
                방문자검색폼.로그인폼 = null;
                this.Close();

            }
            else
            {
                MessageBox.Show("로그인 불가 경우입니다.");
            }
        }

        private void 회원가입_label_Click(object sender, EventArgs e)
        {
            방문자검색폼.회원가입폼 = new 회원가입_Form(방문자검색폼);
            방문자검색폼.회원가입폼.Show();
            방문자검색폼.로그인폼 = null;
            this.Close();
        }

        private void 로그인_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            방문자검색폼.로그인폼 = null;
        }
    }
}
