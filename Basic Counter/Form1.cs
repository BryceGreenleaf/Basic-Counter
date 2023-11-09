using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Basic_Counter
{
    public partial class Form1 : Form
    {

        private int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int valuetoadd = 1;
            result += valuetoadd;

            results.Text = result.ToString();
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            int valuetosubtract = 1;
            result -= valuetosubtract;

            results.Text = result.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            int valuetoclear = 0;
            result = valuetoclear;

            results.Text = result.ToString();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
