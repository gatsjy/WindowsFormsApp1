using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 글자를 변경해보자.
            lbl1.Text = "글자입니다.";
            lbl2.Text = "글자2.";
        }

        // 버튼을 클릭했을 때 동작하는 함수
        private void button1_Click(object sender, EventArgs e)
        {
            lbl3.Text = "글자3";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("체크박스1을 클릭하였습니다.");
        }
    }
}
