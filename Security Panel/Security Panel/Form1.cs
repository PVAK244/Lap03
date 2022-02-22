using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.read();
            btnEnter.Select();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            switch (txtSecurityCode.Text)
            {
                case "1645":
                    lbxAccessLog.Items.Add($"{time} Technicians");
                    break;
                case "1689":
                    lbxAccessLog.Items.Add($"{time} Technicians");
                    break;
                case "8345":
                    lbxAccessLog.Items.Add($"{time} Custodians");
                    break;
                case "9998":
                    lbxAccessLog.Items.Add($"{time} Scientist");
                    break;
                case "1006":
                    lbxAccessLog.Items.Add($"{time} Scientist");
                    break;
                case "1007":
                    lbxAccessLog.Items.Add($"{time} Scientist");
                    break;
                case "1008":
                    lbxAccessLog.Items.Add($"{time} Scientist");
                    break;
                default:
                    lbxAccessLog.Items.Add($"{time} Restricted Access!");
                    break;
            }
            this.save();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
            btnEnter.Select();
        }

        private void btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void btn9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                this.btn9_Click(sender, e);
            }
        }

        private void btnEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                btn0.Select();
                this.btn0_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D1)
            {
                btn1.Select();
                this.btn1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                btn2.Select();
                this.btn2_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                btn3.Select();
                this.btn3_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                btn4.Select();
                this.btn4_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                btn5.Select();
                this.btn5_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                btn6.Select();
                this.btn6_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                btn7.Select();
                this.btn7_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D8)
            {
                btn8.Select();
                this.btn8_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                btn9.Select();
                this.btn9_Click(sender, e);
            }
        }

        private void save()
        {
            string path = @"text.txt";
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
                foreach(Object obj in lbxAccessLog.Items)
                {
                    sw.WriteLine(obj.ToString());
                }
            }
            else
            {
                using StreamWriter sw = new StreamWriter(path);
                foreach (Object obj in lbxAccessLog.Items)
                {
                    sw.WriteLine(obj.ToString());
                }
            }
        }

        private void read()
        {
            string path = @"text.txt";
            if (File.Exists(path))
            {
                using StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lbxAccessLog.Items.Add(line);
                }
            }
        }
    }
}
