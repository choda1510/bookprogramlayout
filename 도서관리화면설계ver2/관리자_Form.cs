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
    public partial class 관리자_Form : Form
    {
        방문자_검색Form 방문자검색폼;
        대출관리_Form 대출관리폼;
        연체관리_Form 연체관리폼;
        도서관리_Form 도서관리폼;
        알바관리_Form 알바관리폼;
        회원관리_Form 회원관리폼;
        Form 현재폼;
        Button 현재비활성버튼;
        public 관리자_Form(방문자_검색Form 부모폼)
        {
            InitializeComponent();
            방문자검색폼 = 부모폼;
            대출관리폼 = new 대출관리_Form(this);
            연체관리폼 = new 연체관리_Form(this);
            도서관리폼 = new 도서관리_Form(this);
            알바관리폼 = new 알바관리_Form(this);
            회원관리폼 = new 회원관리_Form(this);
            대출관리폼.Show();
            현재폼 = 대출관리폼;
            현재비활성버튼 = 대출_button;
            현재비활성버튼.Enabled = false;
            연체관리폼.Hide();
            도서관리폼.Hide();
            알바관리폼.Hide();
            회원관리폼.Hide();
        }

        private void 대출_button_Click(object sender, EventArgs e)
        {
            대출관리폼.Show();
            현재폼.Hide();
            현재비활성버튼.Enabled = true;
            현재폼 = 대출관리폼;
            대출_button.Enabled = false;
            현재비활성버튼 = 대출_button;
        }

        private void 관리자_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            방문자검색폼.관리자폼 = null;
        }

        private void 연체_button_Click(object sender, EventArgs e)
        {
            연체관리폼.Show();
            현재폼.Hide();
            현재비활성버튼.Enabled = true;
            현재폼 = 연체관리폼;
            연체_button.Enabled = false;
            현재비활성버튼 = 연체_button;
        }
        private void 도서_button_Click(object sender, EventArgs e)
        {
            도서관리폼.Show();
            현재폼.Hide();
            현재비활성버튼.Enabled = true;
            현재폼 = 도서관리폼;
            도서_button.Enabled = false;
            현재비활성버튼 = 도서_button;
        }

        private void 알바_button_Click(object sender, EventArgs e)
        {
            알바관리폼.Show();
            현재폼.Hide();
            현재비활성버튼.Enabled = true;
            현재폼 = 알바관리폼;
            알바_button.Enabled = false;
            현재비활성버튼 = 알바_button;
        }

        private void 회원_button_Click(object sender, EventArgs e)
        {
            회원관리폼.Show();
            현재폼.Hide();
            현재비활성버튼.Enabled = true;
            현재폼 =회원관리폼;
            회원_button.Enabled = false;
            현재비활성버튼 = 회원_button;
        }

    }
}
