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
    public partial class 회원관리_Form : Form
    {
        관리자_Form 관리자폼;
        public 회원관리_Form(관리자_Form 부모폼)
        {
            InitializeComponent();
            관리자폼 = 부모폼;
            this.MdiParent = 관리자폼;
        }
    }
}
