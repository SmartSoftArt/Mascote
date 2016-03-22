using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Threading;

namespace Mascot {
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  /// 
    public partial class MainWindow : Window {

      Mascote mascote;
        public MainWindow() 
        {
            InitializeComponent();
            mascote = new Mascote(grid, MainWindow1);
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            System.Windows.Forms.NotifyIcon tray = new System.Windows.Forms.NotifyIcon();
            tray.Icon = new System.Drawing.Icon("icon.ico");
            tray.Visible = true;
            tray.MouseClick += tray_MouseClick;
        }
        void tray_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
          if (e.Button == System.Windows.Forms.MouseButtons.Left) {
            
          }
        }
        private void TimerTick(object sender, EventArgs e) 
        {
          mascote.Walk();
        }
  }
}
