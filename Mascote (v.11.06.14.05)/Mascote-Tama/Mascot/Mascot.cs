using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace Mascot
{
    class Mascote
    {
        private volatile int num_Action = 0;
        private volatile int i_step = 1;
        private volatile int i_xToMove;
        private List<string> list_wayShime;
        private bool b_toRight;
        public Thread thread_Mascot;
        private Random random = new Random();
        private MainWindow window;
        private Grid grid;
        private int ScreenHeight = (int)SystemParameters.PrimaryScreenHeight;
        private int ScreenWidth = (int)SystemParameters.PrimaryScreenWidth;
        private int gridWidth;
        private int windowWidth;
        public int NumAction { set { num_Action = value; } }


        public Mascote(Grid mascote, MainWindow mainwindow)
        {
            thread_Mascot = new Thread(MascotAI);
            thread_Mascot.Start();
            grid = mascote;
            gridWidth = (int)grid.Width;
            window = mainwindow;
            windowWidth = (int)window.Height;
      //Начальное положение окна вычисляется с учетом данных формы.
            window.Left = ScreenWidth - 250;
            window.Top = ScreenHeight - 300 - 40;
            list_wayShime = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                list_wayShime.Add("");
            }
        }

        private void MascotAI()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5000));
                int buf = random.Next(2);
                if (buf == 1)
                {
                    i_xToMove = i_xToMove = ScreenWidth - random.Next(341) - windowWidth;
                }

                num_Action = buf;
            }
        }

        public void ActionMascote()
        {
        // 0 - стоять на месте
        // 1 - ходить в какую-либо сторону
        // 2 - анимация во время оповещения
        // 3 - Анимация во время меню
            switch (num_Action)
            {
        
                case 0:
                    {
                        this.doStand();
                        break;
                    }
                case 1:
                    {
                        this.doWalk();
                        break;
                    }
                case 2:
                    {
                        this.doNotification();
                        break;
                    }
                case 3:
                    {
                        this.doMenu();
                        break;
                    }
            }
        }

        private void doStand()
        {
            AnimationMascote.Animation(grid, "img/shime1.png");
        }

        private void doWalk()
        {
            if (window.Left > i_xToMove)
            {
                list_wayShime[0] = "img/mov/shime2.png";
                list_wayShime[1] = "img/mov/shime3.png";
                b_toRight = false;
            } else
            {
                list_wayShime[0] = "img/mov/shime2R.png";// shime 2
                list_wayShime[1] = "img/mov/shime3R.png";// shime 3
                b_toRight = true;
            }

            switch (i_step)
            {
                case 0:
                    {
                        AnimationMascote.Animation(grid, list_wayShime[i_step]);

                        if (b_toRight == true)
                        {
                            if (window.Left < i_xToMove)
                            {
                                window.Left += 10;
                            } else
                            {
                                num_Action = 0;
                            }
                        } else
                        {
                            if (window.Left > i_xToMove)
                            {
                                window.Left -= 10;
                            } else
                            {
                                num_Action = 0;
                            }
                        }

                        i_step = 1;
                        break;
                    }
                case 1:
                    {
                        AnimationMascote.Animation(grid, list_wayShime[i_step]);
                        i_step = 0;
                        break;
                    }

                default:
                    {
                        i_step = 0;
                        break;
                    }
            }
        }

        private void doNotification()
        {
            list_wayShime[0] = ("img/shime31.png");
            list_wayShime[1] = ("img/shime32.png");
            list_wayShime[2] = ("img/shime33.png");
            AnimationMascote.Animation(grid, list_wayShime[i_step]);
            switch (i_step)
            {
                case 0:
                    {
                        i_step = 1;
                        break;
                    }
                case 1:
                    {
                        i_step = 2;
                        break;
                    }
                case 2:
                    {
                        i_step = 0;
                        break;
                    }
            }

        }

        private void doMenu()
        {
            list_wayShime[0] = ("img/shime54.png");
            list_wayShime[1] = ("img/shime55.png");
            AnimationMascote.Animation(grid, list_wayShime[i_step]);
            switch (i_step)
            {
                case 0:
                    {
                        i_step = 1;
                        break;
                    }
                case 1:
                    {
                        i_step = 0;
                        break;
                    }
            }
        }

    }

}