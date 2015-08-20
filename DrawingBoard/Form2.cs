using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class Form2 : Form
    {
        public delegate void SendMessage(object sender, int message);
        public event SendMessage MessageSent;

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int size = 1;
            size = int.Parse(comboBox1.Text);
            if (this.MessageSent != null)
                MessageSent(this, size);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if((e.KeyChar>='0'&&e.KeyChar<='9')||e.KeyChar==8)
            {
                e.Handled = false;
            }
        }

    }
}
