using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tính_tiền_bán_hàng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_ten.Clear();
            txt_so_luong.Clear();
            txt_gia.Clear();
            lb_thanh_tien.ResetText();
            txt_ten.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ten.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab) {
                txt_gia.Focus();
                txt_so_luong.Focus();
            }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(rl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }else if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_so_luong_TextChanged(object sender, EventArgs e)
        {
            if(txt_so_luong.Text == "0")
            {
                txt_so_luong.Clear();
            }
        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
            if(txt_gia.Text == "0")
            {
                txt_gia.Clear();
            }
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }else if(!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btn_tien_Click(object sender, EventArgs e)
        {
            if(txt_gia.Text.Length == 0 || txt_so_luong.Text.Length == 0 || txt_ten.Text.Length == 0) {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = int.Parse(txt_gia.Text);
                int b = int.Parse(txt_so_luong.Text);
                lb_thanh_tien.Text = (a * b).ToString();
            }
        }
    }
}
