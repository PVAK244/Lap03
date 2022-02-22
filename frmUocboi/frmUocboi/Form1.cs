using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUocboi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int USCLN(int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                if (b == 0) return a;
                return USCLN(b, a % b);
            }
            else throw new ArgumentException("Please enter number than 0");
            
        }
        private int BSCNN(int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                if (a == 0 && b == 0) return 0;
                return (a * b) / USCLN(a, b);
            }
            else throw new ArgumentException("Please enter number than 0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetqua.ReadOnly = true;
            rdoUCLN.Checked = true;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rdoUCLN.Checked == true)
            {
                try
                {
                    result = USCLN(int.Parse(txtA.Text), int.Parse(txtB.Text));
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter number\n{ex.Message}");
                }

            }else if (rdoBCNN.Checked == true)
            {
                try
                {
                    result = BSCNN(int.Parse(txtA.Text), int.Parse(txtB.Text));
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter number\n{ex.Message}");
                }
            }

            txtKetqua.Text = result.ToString();
        }
    }
}
