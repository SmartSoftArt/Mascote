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

        class ManagThread
        {
            private Thread mngThread;
            private Random random = new Random();
            public ManagThread()
            {
                mngThread = new Thread(this.manageRun);
                mngThread.Start();
            }

            private void manageRun()
            {
                while (true)
                {
                    Thread.Sleep(random.Next(5000));
                    int buf = random.Next(2);
                    if (buf == 1)
                    {
                        Common.XToMove = random.Next(1366);
                    }
                    Common.NumAct = buf;
                }
            }
        }
        class Common
        {
            public static volatile int NumAct = 0;
            public static volatile int GotTicks = 0;
            public static volatile bool Step = true;

            public static volatile int XToMove;

        }
        
        ImageBrush image = new ImageBrush();
        private string shime2;
        private string shime3;
        private bool toRight;

        public MainWindow() 
        {

            InitializeComponent();
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            ManagThread mt = new ManagThread();

        }

        private void TimerTick(object sender, EventArgs e) 
        {
            switch (Common.NumAct)
            {

                case 0: 

                    this.doStand();
                    break;

                case 1:

                    if (this.Left > Common.XToMove)
                    {
                        shime2 = "img/mov/shime2.png";
                        shime3 = "img/mov/shime3.png";
                        toRight = false;
                    }
                    else
                    {
                        shime2 = "img/mov/shime2R.png";
                        shime3 = "img/mov/shime3R.png";
                        toRight = true;
                    }

                    if (Common.Step)
                    {
                        image.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), shime3));
                        grid.Background = image;
                        Common.Step = false;
                    }
                    else
                    {
                        image.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), shime2));
                        grid.Background = image;
                        if (toRight == true)
                            if (this.Left < Common.XToMove)
                            {
                                this.Left += 10;
                            }
                            else
                            {
                                Common.NumAct = 0;
                            }
                        else
                            if (this.Left > Common.XToMove)
                            {
                                this.Left -= 10;
                            }
                            else
                            {
                                Common.NumAct = 0;
                            }

                        Common.Step = true;
                    }

                    break;
            }

            
        }
        private void doStand()
        {
            image.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "img/shime1.png"));
            grid.Background = image;
        }
  }
}
