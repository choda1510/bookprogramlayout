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
    public partial class 회원_Form : Form
    {
        방문자_검색Form 방문자검색폼;
        public 회원_Form(방문자_검색Form 부모폼)
        {
            InitializeComponent();
            방문자검색폼 = 부모폼;
        }

        private void 회원정보수정_button_Click(object sender, EventArgs e)
        {

        }

        private void 회원_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            방문자검색폼.회원폼 = null;
        }
    }
}
