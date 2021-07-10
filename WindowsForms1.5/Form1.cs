using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1._5
{
    public partial class myform : Form
    {
        public myform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                myform.ActiveForm.Opacity -= .1;
            }
            else if (sender == button2)
            {
                myform.ActiveForm.Opacity += .1;
            }
        }
    }
}
