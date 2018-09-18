using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class MainForm : Form
    {   
        public Int32[] NumDaysOfWeek = new Int32[7];
        public Int32 NumToday;
        public Int32 AlarmHour, AlarmMin;
        public bool AlarmIsOn = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetToday();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblTimeNow.Text = now.ToString("HH:mm:ss");

            if(now.Hour == 0)
                SetToday();
        }

        void SetToday()
        {
            DateTime now = DateTime.Now;
            
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    lbl_sun.BackColor = Color.White;
                    lbl_mon.BackColor = Color.Aqua;
                    NumToday = 1;
                    break;
                case DayOfWeek.Tuesday:
                    lbl_mon.BackColor = Color.White;
                    lbl_tue.BackColor = Color.Aqua;
                    NumToday = 2;
                    break;
                case DayOfWeek.Wednesday:
                    lbl_tue.BackColor = Color.White;
                    lbl_wed.BackColor = Color.Aqua;
                    NumToday = 3;
                    break;
                case DayOfWeek.Thursday:
                    lbl_wed.BackColor = Color.White;
                    lbl_thu.BackColor = Color.Aqua;
                    NumToday = 4;
                    break;
                case DayOfWeek.Friday:
                    lbl_thu.BackColor = Color.White;
                    lbl_fri.BackColor = Color.Aqua;
                    NumToday = 5;
                    break;
                case DayOfWeek.Saturday:
                    lbl_fri.BackColor = Color.White;
                    lbl_sat.BackColor = Color.Aqua;
                    NumToday = 6;
                    break;
                case DayOfWeek.Sunday:
                    lbl_sat.BackColor = Color.White;
                    lbl_sun.BackColor = Color.Aqua;
                    NumToday = 0;
                    break;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            var nowTime = DateTime.Now;

            double hour, min;

            //if the alarm is set to the current day
            for (int i = 0; i < 7; i++)
            {
                if (NumDaysOfWeek[i] == 1)
                {
                    //alarm should ring today or not?
                    if (i == NumToday)
                    {
                        if (nowTime.Hour < Convert.ToInt32(txbH.Text))
                        {
                            AlarmHour = Convert.ToInt32(txbH.Text);
                            AlarmMin = Convert.ToInt32(txbM.Text);
                        }
                    }
                }
            }

            var futureTime = nowTime.AddHours(Convert.ToDouble(txbH.Text));
            futureTime = futureTime.AddMinutes(Convert.ToDouble(txbM.Text));
            MessageBox.Show(futureTime.ToString("HH:mm"));
        }

        private void cBTimerOn_CheckedChanged(object sender, EventArgs e)
        {
            AlarmIsOn = cBTimerOn.Checked;
        }

        #region Player

        void Player(bool play)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Nikiteezy\Desktop\untitled.wav");
            if (play)
                soundPlayer.Play();
            else
                soundPlayer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Player(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player(false);
        }
        #endregion

        #region SetDayOfWeek

        void SetDayOfWeek(Label lb)
        {
            if (lb.BackColor != Color.Aqua)
            {
                lb.BackColor = Color.Aqua;
                switch (lb.Name)
                {
                    case "lblSetMon":
                        NumDaysOfWeek[1] = 1;
                        break;
                    case "lblSetTue":
                        NumDaysOfWeek[2] = 1;
                        break;
                    case "lblSetWed":
                        NumDaysOfWeek[3] = 1;
                        break;
                    case "lblSetThu":
                        NumDaysOfWeek[4] = 1;
                        break;
                    case "lblSetFri":
                        NumDaysOfWeek[5] = 1;
                        break;
                    case "lblSetSat":
                        NumDaysOfWeek[6] = 1;
                        break;
                    case "lblSetSun":
                        NumDaysOfWeek[0] = 1;
                        break;
                }
            }
            else
            {
                lb.BackColor = Color.White;
                switch (lb.Name)
                {
                    case "lblSetMon":
                        NumDaysOfWeek[1] = 0;
                        break;
                    case "lblSetTue":
                        NumDaysOfWeek[2] = 0;
                        break;
                    case "lblSetWed":
                        NumDaysOfWeek[3] = 0;
                        break;
                    case "lblSetThu":
                        NumDaysOfWeek[4] = 0;
                        break;
                    case "lblSetFri":
                        NumDaysOfWeek[5] = 0;
                        break;
                    case "lblSetSat":
                        NumDaysOfWeek[6] = 0;
                        break;
                    case "lblSetSun":
                        NumDaysOfWeek[0] = 0;
                        break;
                }
            }
        }

        private void lblSetMon_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetMon);
        }

        private void lblSetTue_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetTue);
        }

        private void lblSetWed_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetWed);
        }

        private void lblSetThu_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetThu);
        }

        private void lblSetFri_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetFri);
        }

        private void lblSetSat_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetSat);
        }

        

        private void lblSetSun_Click(object sender, EventArgs e)
        {
            SetDayOfWeek(lblSetSun);
        }


        #endregion


    }
}
