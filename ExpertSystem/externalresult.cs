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
    public partial class externalresult : Form
    {
        public externalresult()
        {
            InitializeComponent();
        }

        private void Eyeinfbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM EYES INFECTION HAVING SYMPTOMS : PAINFUL EYES, EYES SORENESS :VISON WEAKNESS", "QUICK DIAGNOSE");
        }

        private void eyesdryfbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM EYES DRY SYNDROME HAVING SYMPTOMS : PAINFUL EYES, EYES DRYNESS :CORINA REDNESS", "QUICK DIAGNOSE");
        }

        private void presbyopiaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM EYES PRESBYOPA HAVING SYMPTOMS : EYESTRAIN ,DIFFICULTY IN READING SMALL PRINTS,HAVING FATIGUE IN EYES", "QUICK DIAGNOSE");
        }

        private void externalresult_Load(object sender, EventArgs e)
        {

        }
    }
}
