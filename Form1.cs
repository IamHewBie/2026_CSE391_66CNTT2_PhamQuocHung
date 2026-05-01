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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(TenDanhMuc.Text);
            item1.SubItems.Add(TienDuKien.Text);
            string t = TenDanhMuc.Text;
            string s = TienDuKien.Text;
            if (s == "" || t == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (!long.TryParse(s, out long number)){
                MessageBox.Show("Chỉ được nhập số");
                return;
            }
            BangTongHop.Items.Add(item1);
            TinhTongDuKien();
            TenDanhMuc.Text = "";
            TienDuKien.Text = "";
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string s = TienDuKien.Text;
            //if (!long.TryParse(s, out long number))
            //{
            //    MessageBox.Show("Không được nhập khoảng trắng và các kí tự. Chỉ được nhập số");
            //}
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (BangTongHop.SelectedItems.Count > 0)
            {
                ListViewItem item1 = BangTongHop.SelectedItems[0];
                //string ten = item1.SubItems[0].Text;
                //string tien = item1.SubItems[1].Text;
                //TenDanhMuc.Text = ten;
                //TienDuKien.Text = tien;
                TenDanhMuc.Text = item1.SubItems[0].Text;
                TienDuKien.Text = item1.SubItems[1].Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (BangTongHop.SelectedItems.Count > 0)
            {
                BangTongHop.Items.Remove(BangTongHop.SelectedItems[0]);
                TenDanhMuc.Text = "";
                TienDuKien.Text = "";
                TinhTongDuKien();
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (BangTongHop.SelectedItems.Count > 0)
            {
                ListViewItem item = BangTongHop.SelectedItems[0];
                string t = TenDanhMuc.Text;
                string s = TienDuKien.Text;
                if (s == "" || t == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }
                if (!long.TryParse(s, out long number))
                {
                    MessageBox.Show("Chỉ được nhập số");
                    return;
                }
                item.SubItems[0].Text = TenDanhMuc.Text;
                item.SubItems[1].Text = TienDuKien.Text;
            }
            TinhTongDuKien();
            TenDanhMuc.Text = "";
            TienDuKien.Text = "";
        }

        private void TinhTongDuKien()
        {
            long tong = 0;
            foreach (ListViewItem item in BangTongHop.Items)
            {
                tong += long.Parse(item.SubItems[1].Text); 
            }
            TongDuKien.Text = tong.ToString();
        }

        //private void TinhTongThucChi()
        //{
        //    long tong = 0;
        //    foreach (ListViewItem item in BangTongHop.Items)
        //    {
        //        tong += long.Parse(item.SubItems[2].Text);
        //    }
        //    TongThucChi.Text = tong.ToString();
        //}

        private void TongThucChi_Click(object sender, EventArgs e)
        {
            //TinhTongThucChi();
        }

        //private void CapNhatChenhlech(ListViewItem item)
        //{
        //    long duKien = 0;
        //    long thucChi = 0;

        //    long.TryParse(item.SubItems[1].Text.Replace(",", "").Replace(" ", ""), out duKien);
        //    long.TryParse(item.SubItems[2].Text.Replace(",", "").Replace(" ", ""), out thucChi);

        //    long chenhlech = duKien - thucChi;

        //    item.SubItems[3].Text = chenhlech.ToString("N0");
        //}
    }
}
