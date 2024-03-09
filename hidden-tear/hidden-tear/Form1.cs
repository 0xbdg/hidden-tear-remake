using System;
using System.Windows.Forms;
using hidden_tear.Tools;

namespace hidden_tear
{
    public partial class Form1 : Form
    {
        DateTime dt;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            richTextBox1.Text = Config.note;
            timer1.Start();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Visible = true;
            Opacity = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = new DateTime(Config.year,Config.month,Config.day);
            TimeSpan remaining = dt - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                timer1.Stop();
            }

            if (remaining.Days <= 9)
            {
                Config.days = "0" + remaining.Days.ToString();
                dayLabel.Text = Config.days;
            }
            else
            {
                Config.days = remaining.Days.ToString();
                dayLabel.Text = Config.days;
            }
            if (remaining.Hours <= 9)
            {
                Config.hours = "0" + remaining.Hours.ToString();
                hourLabel.Text = Config.hours;
            }
            else
            {
                Config.hours = remaining.Hours.ToString();
                hourLabel.Text = Config.hours;
            }
            if (remaining.Minutes <= 9)
            {
                Config.minutes = "0" + remaining.Minutes.ToString();
                minuteLabel.Text = Config.minutes;
            }
            else
            {
                Config.minutes = remaining.Minutes.ToString();
                minuteLabel.Text = Config.minutes;
            }
            if (remaining.Seconds <= 9)
            {
                Config.secs = "0" + remaining.Seconds.ToString();
                secondLabel.Text = Config.secs;
            }
            else
            {
                Config.secs = remaining.Seconds.ToString();
                secondLabel.Text = Config.secs;
            }
        }
    }
}
