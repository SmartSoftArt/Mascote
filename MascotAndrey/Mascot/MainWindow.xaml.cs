using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
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

      private System.Windows.Forms.ContextMenu contextMenu1;
      private System.Windows.Forms.MenuItem menuItem1;

      Mascote mascote;
        public MainWindow() 
        {
            InitializeComponent();
            mascote = new Mascote(grid, MainWindow1);
            //Таймер для анимации
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            //Описание трея
            System.Windows.Forms.NotifyIcon tray = new System.Windows.Forms.NotifyIcon();
            tray.Icon = new System.Drawing.Icon("icon.ico");
            tray.Visible = true;
            tray.MouseClick += tray_MouseClick;
            //Создание объекта контекстного меню и его элемента(ов)
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Инициализация элемента
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            //Инициализация контекстного меню
            tray.ContextMenu = this.contextMenu1;

        }

        void tray_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left){
              notification.IsOpen = true;
            }
        }
        private void menuItem1_Click(object sender, EventArgs e)
        {
            {
                this.Close();
                Process.GetCurrentProcess().Kill();
            }
        }
        private void TimerTick(object sender, EventArgs e) 
        {
          mascote.ActionMascote();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
          notification.IsOpen = false;
        }
    }
}
