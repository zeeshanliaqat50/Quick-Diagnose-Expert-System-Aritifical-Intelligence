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
    public partial class externalsymp : Form
    {
        public externalsymp()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgnButton_Click(object sender, EventArgs e)
        {
            if (swelleyeschecheckBox.Checked)
            {
                resultpanel.Controls.Clear();
               externalresult a = new externalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (swelleyeschecheckBox.Checked || s.Checked)
            {
                resultpanel.Controls.Clear();
                externalresult a = new externalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (swelleyeschecheckBox.Checked || s.Checked || burningsensationcheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                externalresult a = new externalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }

            if (burningsensationcheckBox.Checked || CheckBoxbump.Checked || blurryvisioncheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                externalresult a = new externalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (swelleyeschecheckBox.Checked || s.Checked || burningsensationcheckBox.Checked || CheckBoxbump.Checked || blurryvisioncheckBox.Checked)
            {
                resultpanel.Controls.Clear();
                externalresult a = new externalresult();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (CheckBoxbump.Checked)
            {
                resultpanel.Controls.Clear();
                externalresultb a = new externalresultb();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (CheckBoxbump.Checked || checkBoxitching.Checked)
            {
                resultpanel.Controls.Clear();
                externalresultb a = new externalresultb();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (CheckBoxbump.Checked || checkBoxitching.Checked || checkBoxrashes.Checked)
            {
                resultpanel.Controls.Clear();
                externalresultb a = new externalresultb();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }

            if (CheckBoxbump.Checked && checkBoxitching.Checked && checkBoxrashes.Checked && checkBoxblister.Checked)
            {
                resultpanel.Controls.Clear();
                externalresultb a = new externalresultb();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }
            if (checkBoxblister.Checked)
            {
                resultpanel.Controls.Clear();
                externalresultb a = new externalresultb();
                a.TopLevel = false;
                resultpanel.Controls.Add(a);
                a.Show();

            }

        }
    }
}
