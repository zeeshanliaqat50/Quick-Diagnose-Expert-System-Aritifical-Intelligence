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

namespace vv
{
    public partial class vvd : Form
    {
        public vvd()
        {
          /*  Thread th = new Thread(new ThreadStart(InitializeComponent));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
*/
             InitializeComponent();
        }

        private void vvd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String vid1 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\a.mp4";
            string vid2 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\shoulderr.mp4";
            String vid3 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\headache.mp4";
            String vid4= "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\relaxation.mp4";


            String selitem = vidslccomboBox.SelectedItem.ToString();


            if (selitem.Equals("BACK PAIN RELIEF"))
            {


                try
                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\a.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (selitem.Equals("SHOULDER PAIN RELIEF"))
            {
                try
                {
                    axWindowsMediaPlayer1.URL = vid2;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (selitem.Equals("Relaxation video"))
            {
                try
                {
                    axWindowsMediaPlayer1.URL = vid4;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (selitem.Equals("HEADACHE RELIEF"))
            {


                try
                {
                    axWindowsMediaPlayer1.URL = vid3;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        private void vidslccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
