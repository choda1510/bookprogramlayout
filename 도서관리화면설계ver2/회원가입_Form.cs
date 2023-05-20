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
    public partial class 회원가입_Form : Form
    {
        방문자_검색Form 방문자검색폼;
        public 회원가입_Form(방문자_검색Form 부모폼)
        {
            InitializeComponent();
            방문자검색폼 = 부모폼;
        }

        private void 회원가입_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("테스트 회원가입입니다.");
            방문자검색폼.로그인폼 = new 로그인_Form(방문자검색폼);
            방문자검색폼.로그인폼.Show();
            방문자검색폼.회원가입폼 = null;
            this.Close();
        }

        private void 로그인_button_Click(object sender, EventArgs e)
        {
            방문자검색폼.로그인폼 = new 로그인_Form(방문자검색폼);
            방문자검색폼.로그인폼.Show();
            방문자검색폼.회원가입폼 = null;
            this.Close();
        }

        private void 회원가입_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

            방문자검색폼.회원가입폼 = null;
        }
    }
}
