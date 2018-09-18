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

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now.Hour == AlarmHour && now.Minute == AlarmMin)
            {
                Player(true);
                AlarmTimer.Enabled = false;
            }
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
            if (btnSet.Text == "break")
            {
                btnSet.Text = "Set";
                AlarmTimer.Enabled = false;
            }
            else
            {
                AlarmTimer.Enabled = true;
                AlarmHour = Convert.ToInt32(txbH.Text);
                AlarmMin = Convert.ToInt32(txbM.Text);
                btnSet.Text = "break";
            }
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

        


    }
}
