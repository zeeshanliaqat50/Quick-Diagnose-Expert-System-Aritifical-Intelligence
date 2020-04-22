using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class bmb : Form
    {
        public bmb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( HeadachecheckBox.Checked || backpaincheckBox.Checked || lowerbackpaincheckBox.Checked || mdpCheckBox.Checked || jointpaincheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                bmbextd a = new bmbextd();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }


        }

        private void jointpaincheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bmb_Load(object sender, EventArgs e)
        {

        }

        private void HeadachecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mdpCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lowerbackpaincheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backpaincheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
