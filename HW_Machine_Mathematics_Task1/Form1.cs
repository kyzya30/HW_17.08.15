using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Machine_Mathematics_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for byte "+ byte.MaxValue.ToString()+ "\nMin value for byte " +byte.MinValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for sbyte " + sbyte.MaxValue.ToString() + "\nMin value for sbyte " + sbyte.MinValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for short " + short.MaxValue.ToString() + "\nMin value for short " + short.MinValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for ushort " + ushort.MaxValue.ToString() + "\nMin value for ushort " + ushort.MinValue.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for int " + int.MaxValue.ToString() + "\nMin value for int " + int.MinValue.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for uint " + uint.MaxValue.ToString() + "\nMin value for uint " + uint.MinValue.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for long " + long.MaxValue.ToString() + "\nMin value for long " + long.MinValue.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max value for ulong " + ulong.MaxValue.ToString() + "\nMin value for ulong " + ulong.MinValue.ToString());
        }
    }
}
