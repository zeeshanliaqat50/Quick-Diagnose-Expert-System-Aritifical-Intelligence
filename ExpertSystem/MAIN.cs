using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using vv;

namespace ExpertSystem
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void logopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            bmb a = new bmb();
            a.TopLevel = false;
            mainpanel.Controls.Add(a);
            a.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(splitContainer1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            internalsymp a = new internalsymp();
            a.TopLevel = false;
            mainpanel.Controls.Add(a);
            a.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {



             Thread th = new Thread(new ThreadStart(ss));
             th.SetApartmentState(ApartmentState.STA);
             th.Start();
            

            
          /*  mainpanel.Controls.Clear();
            vvd a = new vvd();
            a.TopLevel = false;
            mainpanel.Controls.Add(a);
            a.Show(); */
        }

        public void ss()
        {
          //  mainpanel.Controls.Clear();
            vvd a = new vvd();
            // a.TopLevel = false;
            //mainpanel.Controls.Add(a);
            a.Activate();
            a.ShowDialog();

        }
        private void sidepanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            externalsymp a = new externalsymp();
            a.TopLevel = false;
            mainpanel.Controls.Add(a);
            a.Show();
        }
    }
}
