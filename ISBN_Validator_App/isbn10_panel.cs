using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBN_Validator_App
{
    public partial class isbn10_panel : UserControl
    {
        public isbn10_panel()
        {
            InitializeComponent();
        }
        // only numbers and backspace input
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
