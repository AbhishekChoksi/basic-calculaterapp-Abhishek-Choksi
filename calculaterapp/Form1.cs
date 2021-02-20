using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculaterapp
{
    public partial class home : Form
    {
        float n1, n2, ans;
        public home()
        {
            InitializeComponent();
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Have A Nice Day!");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToSingle(txtnumber1.Text);
            n2 = Convert.ToSingle(txtnumber2.Text);
            ans = n1 + n2;
            //lblanswer.Text = Convert.ToString(ans);
            lblanswer.Text = ans.ToString();
            lblanswer.Visible = true;
            txtnumber1.Text = "";
            txtnumber2.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToSingle(txtnumber1.Text);
            n2 = Convert.ToSingle(txtnumber2.Text);
            ans = n1 - n2;
            lblanswer.Text = ans.ToString();
            lblanswer.Visible = true;
            txtnumber1.Text = "";
            txtnumber2.Text = "";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToSingle(txtnumber1.Text);
            n2 = Convert.ToSingle(txtnumber2.Text);
            ans = n1 * n2;
            lblanswer.Text = ans.ToString();
            lblanswer.Visible = true;
            txtnumber1.Text = "";
            txtnumber2.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToSingle(txtnumber1.Text);
            n2 = Convert.ToSingle(txtnumber2.Text);
            ans = n1 / n2;
            lblanswer.Text = ans.ToString();
            lblanswer.Visible = true;
            txtnumber1.Text = "";
            txtnumber2.Text = "";
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToSingle(txtnumber1.Text);
            n2 = Convert.ToSingle(txtnumber2.Text);
            ans = n1 % n2;
            lblanswer.Text = ans.ToString();
            lblanswer.Visible = true;
            txtnumber1.Text = "";
            txtnumber2.Text = "";
        }
    }
}
