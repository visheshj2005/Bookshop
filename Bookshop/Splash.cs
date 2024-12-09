namespace Bookshop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogressbar.Value = startpos;
            PercentageLabel.Text = startpos + "%";
            if (Myprogressbar.Value == 100)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
