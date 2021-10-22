using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(DateTime.Now.DayOfWeek);
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5: label1.Text = "hafta içi"; break;
                case 6:
                case 0: label1.Text = "hafta sonu"; break;
                default: label1.Text = "hatalı giriş"; break;
            }



        }
    }
}
