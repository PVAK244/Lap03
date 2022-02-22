using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetqua.ReadOnly = true;
            txtSon.Select();

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int tong = 0;

            try
            {
                tong = int.Parse(txtSon.Text) + int.Parse(txtSom.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter number\n{ex.Message}");
            }
            txtKetqua.Text = tong.ToString();
        }



        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int hieu = 0;

            try
            {
                hieu = int.Parse(txtSon.Text) - int.Parse(txtSom.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter number\n{ex.Message}");
            }
            txtKetqua.Text = hieu.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int tich = 0;

            try
            {
                tich = int.Parse(txtSon.Text) * int.Parse(txtSom.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter number\n{ex.Message}");
            }
            txtKetqua.Text = tich.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int thuong = 0;

            try
            {
                thuong = int.Parse(txtSon.Text) / int.Parse(txtSom.Text);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show($"m cannot be equal 0\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter number\n{ex.Message}");
            }
            txtKetqua.Text = thuong.ToString();
        }
    }
}
