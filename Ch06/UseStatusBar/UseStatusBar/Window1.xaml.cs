using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UseStatusBar
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
        System.Windows.Threading.DispatcherTimer dt = new System.Windows.Threading.DispatcherTimer();
		public Window1()
		{
			this.InitializeComponent();
            dt.Interval = new TimeSpan(0,0,1);
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
			// Insert code required on object creation below this point.
            lblDate.Content = DateTime.Now.ToShortDateString();
            lblClock.Content = DateTime.Now.ToLongTimeString();
		}

        void dt_Tick(object sender, EventArgs e)
        {
            lblClock.Content = DateTime.Now.ToLongTimeString();
        }
	}
}