using System.Timers;

namespace schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DurationDay = 1;
        }

        System.Timers.Timer timer;

        public int DurationDay { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            setup_Timer(DurationDay);
        }
        void setup_Timer(int durationDay)

        {
            DateTime nowTime = DateTime.Now;

            DateTime oneAmTime = DateTime.Now;

            oneAmTime = oneAmTime.AddMinutes(durationDay);

            double tickTime = (oneAmTime - nowTime).TotalMilliseconds;

            timer = new System.Timers.Timer(tickTime);

            timer.Elapsed += timer_Elapsed;

            timer.Start();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();

            MessageBox.Show("success");


            setup_Timer(DurationDay);
        }
    }
}