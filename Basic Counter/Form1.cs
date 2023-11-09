using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Counter
{
    public partial class Form1 : Form
    {

        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            counter += 1;
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            counter -= 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
            label1.Invalidate();
            label1.Update();
            Application.DoEvents(); // Force an immediate UI update
        }
    }
}
