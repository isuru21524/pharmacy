using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class watch : UserControl
    {
        Timer t = new Timer();
        public watch()
        {
            InitializeComponent();
        }

        private void watch_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick +=  new EventHandler(this.t_Tick);

            t.Start();
        }
        private void t_Tick(object sender, EventArgs e) {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time="";

            if (hh < 10)
            {
                time +="0" + hh;
            }
            else {
                time += hh;
            }
            time += ":";

            if (mm< 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time +=ss;
            }
            label1.Text = time;
        }
    }
}
