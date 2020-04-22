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
    public partial class vid : Form
    {
        public vid()
        {
            InitializeComponent();

        }

        private void playbutton_Click(object sender, EventArgs e)
        {


        }


        private void testbutton_Click(object sender, EventArgs e)
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

        private void vid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String vid1 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\a.mp4";
            string vid2 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\shoulderr.mp4";
            String vid3 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\headache.mp4";
            

            String selitem = vidselectioncomboBox.SelectedItem.ToString();


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
                else if (selitem.Equals("SHOULD PAIN RELIEF"))
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

        private void plybutton_Click(object sender, EventArgs e)
        {
            String vid1 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\a.mp4";
            string vid2 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\shoulderr.mp4";
            String vid3 = "C:\\Users\\Zeeshan Liaqat\\Documents\\Visual Studio 2015\\Projects\\ExpertSystem\\headache.mp4";


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
            else if (selitem.Equals("SHOULD PAIN RELIEF"))
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
    }

   }
    
