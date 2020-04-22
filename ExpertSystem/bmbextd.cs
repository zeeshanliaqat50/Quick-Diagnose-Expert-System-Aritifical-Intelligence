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
    public partial class bmbextd : Form
    {
        public bmbextd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM DENGUE HAVING SYMPTOMS : Sudden, high fever :Severe headaches :Pain behind the eyes : Severe joint and muscle pain :Fatigue. ","QUICK DIAGNOSE");
                
        }

        private void Anemiabutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU MAY SUFFERING FROM ANEMIA HAVING SYMPTOMS : Easy fatigue and loss of energy : Dizziness : Unusually rapid heart beat","QUICK DIAGNOSE");
        }

        private void ColdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" YOU MAY SUFFERING FROM COLD FEVER HAVING SYMPTOMS : Dry hacking cough : sore throat : severe muscle or body aches ", "QUICK DIAGNOSE");

        }
    }
}
