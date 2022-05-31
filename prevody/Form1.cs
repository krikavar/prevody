using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prevody
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
        public string BinToDec(string text)
        {
            return Convert.ToString(Convert.ToInt64(text, 2));
        }

        public string DecToBin(string text)
        {
            return Convert.ToString(Convert.ToInt64(text), 2);
        }

        public string HexToDec(string text)
        {
            return Convert.ToString(Convert.ToInt64(text, 16));
        }

        public string DecToHex(string text)
        {
            return Convert.ToInt64(text).ToString("X");
        }

        public string HexToBin(String text)
        {
            return DecToBin(HexToDec(text));
        }

        public string BinToHex(string text)
        {
            return DecToHex(BinToDec(text));
        }
        private void textBox_dec_TextChanged_1(object sender, EventArgs e)
        {
            textBox_bin.Text = DecToBin(textBox_dec.Text);
            textBox_hex.Text = DecToHex(textBox_dec.Text);
        }

        private void textBox_dec_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) { return; }
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }

        }

        private void textBox_bin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) { return; }
            if (e.KeyChar != '0' && e.KeyChar != '1') { e.Handled = true; }
        }

        private void textBox_hex_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) { return; }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F')) { e.Handled = true; }
        }

        private void textBox_bin_TextChanged(object sender, EventArgs e)
        {
            textBox_dec.Text = BinToDec(textBox_bin.Text);
            textBox_hex.Text = BinToHex(textBox_bin.Text);
        }

        private void textBox_hex_TextChanged(object sender, EventArgs e)
        {
            textBox_bin.Text = HexToBin(textBox_hex.Text);
            textBox_dec.Text = HexToDec(textBox_hex.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
