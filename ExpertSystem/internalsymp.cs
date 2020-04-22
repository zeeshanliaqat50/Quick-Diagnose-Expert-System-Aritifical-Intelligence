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
    public partial class internalsymp : Form
    {
        public internalsymp()
        {
            InitializeComponent();
        }

        private void HeadachecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mdpCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgnButton_Click(object sender, EventArgs e)
        {
            if(appweightchecheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                internalresult a = new internalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (appweightchecheckBox.Checked || wheezcheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                internalresult a = new internalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (appweightchecheckBox.Checked || wheezcheckBox.Checked || backpaincheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                internalresult a = new internalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }

            if(backpaincheckBox.Checked && percoughCheckBox.Checked && paincoughcheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                internalresult a = new internalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (appweightchecheckBox.Checked || wheezcheckBox.Checked || backpaincheckBox.Checked || percoughCheckBox.Checked || paincoughcheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                internalresult a = new internalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
        }

        private void internalsymp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backpaincheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paincoughcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wheezcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void heartburncheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resultpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
