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
    public partial class internalresult : Form
    {
        public internalresult()
        {
            InitializeComponent();
        }

        private void Denguebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM LUNGS DISORDER HAVING SYMPTOMS : PAINFUL COUGHING, INTENSE BACK PAIN :SUDDEN VOMITTING", "QUICK DIAGNOSE");
        }

        private void kidneyinfbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM KIDNEY PROBLEMS HAVING SYMPTOMS : PAINFUL COUGHING, IRRESTIBLE ABDOMIN PAIN :SUDDEN VOMITTING :WHEEZING", "QUICK DIAGNOSE");
        }

        private void stomachButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM KIDNEY PROBLEMS HAVING SYMPTOMS : STOMACH PAIN,LOSS MOTIONS :CONSTIPATION : HEARTBURNS", "QUICK DIAGNOSE");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
