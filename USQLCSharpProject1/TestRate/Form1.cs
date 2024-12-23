using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USQLCSharpProject2;

namespace TestRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = Rates.SumRate(Convert.ToInt32(txtBt.Text), Convert.ToDecimal(txtBV.Text),
            Convert.ToInt32(txtBx.Text));
            lblS.Text = S.ToString();

        }

        private void lblS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
