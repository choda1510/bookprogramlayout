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
    public partial class 방문자_검색Form : Form
    {
        public 로그인_Form 로그인폼 = null;
        public 회원가입_Form 회원가입폼 = null;
        public 관리자_Form 관리자폼 = null;
        public 회원_Form 회원폼 = null;
        public 방문자_검색Form()
        {
            InitializeComponent();
        }

        private void 로그인_label_Click(object sender, EventArgs e)
        {
            if (로그인폼 == null && 회원가입폼 == null && (관리자폼 == null || 회원폼 == null))
            {
                로그인폼 = new 로그인_Form(this);
                로그인폼.Show();
            }
        }
        
        private void 회원가입_label_Click(object sender, EventArgs e)
        {
            if (로그인폼 == null && 회원가입폼 == null && (관리자폼 == null || 회원폼 == null))
            {
                회원가입폼 = new 회원가입_Form(this);
                회원가입폼.Show();
            }
        }
    }
}
