using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_App
{
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();
        }

        private string hour ,minute ,second,amOrPm;
        
        private int i = 0;
        private bool alarmDone ;
        private bool alarmIsSet;

        private static string messageInput;
        private GetMessageForm getMessageForm;

        private void setAlarmButton_Click(object sender, EventArgs e)
        {

            //setAlarmButton.Enabled = false;


            


            string time = System.DateTime.Now.ToString("h:mm:ss tt");
            string[] time2 = time.Split(new char[] { ' ', ':' });






           
            
            hour = setHourNumericUpDown.Text;
            minute = minuteNumericUpDown.Text;
            second = secondNumericUpDown.Text;
            amOrPm = amPmComboBox.Text.ToUpper();



            if (Convert.ToInt32(hour) < Convert.ToInt32(time2[0])
                || (Convert.ToInt32(hour) == Convert.ToInt32(time2[0])
                        && Convert.ToInt32(minute) < Convert.ToInt32(time2[1]))
                || (Convert.ToInt32(hour) == Convert.ToInt32(time2[0])
                        && Convert.ToInt32(minute) == Convert.ToInt32(time2[1])
                        && Convert.ToInt32(second) <= Convert.ToInt32(time2[2])))
            {
                if (time2[3].ToUpper().Contains("PM"))
                {
                    amPmComboBox.Text = "AM";
                    amOrPm = null;
                    amOrPm = "AM";
                }
                else
                {
                    amPmComboBox.Text = "PM";
                    amOrPm = null;
                    amOrPm = "PM";
                
                }

            }


            MessageBox.Show(@"Alarm Is Set To, " + hour + " : "+minute+" : "+second+"  "+amOrPm +
                                         "\n Please ,Lock Alarm To Prevent Accidental Alarm Stop") ;

            alarmTimer.Start();
            alarmDone = false;
            alarmIsSet = true;
            //MessageBox.Show(time2[1] +" "+time2[2]);

        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            string time = System.DateTime.Now.ToString("h:mm:ss tt");

            string[] time2 = time.Split(new char[] { ' ', ':' });




            //alarmDone = true;
            if ( time2[0].Contains(hour) &&
                    time2[1].Contains(minute) && 
                        time2[2].Contains(second) &&
                            time2[3].Contains(amOrPm)
                )
                {
                
                    if (alarmDone == false)
                    {


                        var player = new System.Media.SoundPlayer();

                        player.Stream = Properties.Resources.notification1;

                        for(int i = 0 ; i < 2 ; i ++)
                        player.Play();


                        MessageBox.Show(@messageInput);
                        alarmDone = true;
                        alarmIsSet = false;
                    }

                }

        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            getMessageForm = new GetMessageForm();
            getMessageForm.Visible = false;


            string time = System.DateTime.Now.ToString("h:mm:ss tt");
            string[] time2 = time.Split(new char[] { ' ', ':' });

            setHourNumericUpDown.Text = time2[0];
            minuteNumericUpDown.Text = time2[1];
            secondNumericUpDown.Text = time2 [2];
            amPmComboBox.Text = time2[3].ToUpper();


            alarmIsSet = false;


           // = new System.Media.SoundPlayer();


        }



        private void resetButton_Click(object sender, EventArgs e)
        {



            if (alarmIsSet)
            {
                MessageBox.Show("Alarm Is Set :( \n Stop Alarm To Set New Alarm.");
            
                return;
            }

            setAlarmButton.Enabled = true;

            if (setAlarmToZerCheckBox.Checked)
            {
                setHourNumericUpDown.Text = string.Empty;
                minuteNumericUpDown.Text = string.Empty;
                secondNumericUpDown.Text = string.Empty;
                amPmComboBox.Text = "PM";

            }
            else
            {
                string time = System.DateTime.Now.ToString("h:mm:ss tt");

                string[] time2 = time.Split(new char[] {' ', ':'});

                setHourNumericUpDown.Text = time2[0];
                minuteNumericUpDown.Text = time2[1];
                secondNumericUpDown.Text = time2[2];
                amPmComboBox.Text = time2[3].ToUpper();
            }

            
            alarmIsSet = false;
        }


        private void stopAlarmButton_Click(object sender, EventArgs e)
        {
            if (lockAlarmCheckBox.Checked)
            {
                MessageBox.Show("Alarm Is Locked. \nPlease, Uncheck Above Option To Unlock.");
                return;
            }



            setAlarmButton.Enabled = true;
            MessageBox.Show("Alarm Is Stopped!!\nReset To Set New Alarm.");
            alarmIsSet = false;

        }

        private void setAlarmToZerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addMessageButton_Click(object sender, EventArgs e)
        {


            getMessageForm.Visible = true;
            messageInput = getMessageForm.GetMessageToShow();



        }


        public static void SetInputMessage (string me)
        {
            messageInput = me;
        }
    }
}
