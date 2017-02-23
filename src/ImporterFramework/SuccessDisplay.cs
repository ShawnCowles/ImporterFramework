using System;
using System.Windows.Forms;

namespace ImporterFramework
{
    public partial class SuccessDisplay : UserControl
    {
        private Timer _timer;

        public SuccessDisplay()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
