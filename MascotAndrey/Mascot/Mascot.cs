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
  class Mascote {
    private volatile int numAction = 0;
    private volatile int step = 1;
    private volatile int xToMove;
    private List<string> wayShime;
    private bool toRight;
    public Thread threadMascot;
    private Random random = new Random();
    private MainWindow window;
    private Grid grid;
    private int ScreenHeight = (int)SystemParameters.PrimaryScreenHeight;
    private int ScreenWidth = (int)SystemParameters.PrimaryScreenWidth;
    private int gridWidth;
    private int windowWidth;
    public int NumAction { set { numAction = value; } }


    public Mascote(Grid mascote, MainWindow mainwindow) {
      threadMascot = new Thread(MascotAI);
      threadMascot.Start();
      grid = mascote;
      gridWidth = (int)grid.Width;
      window = mainwindow;
      windowWidth = (int)window.Height;
      //Начальное положение окна вычисляется с учетом данных формы.
      window.Left = ScreenWidth - 250;
      window.Top = ScreenHeight - 300 - 40;
      wayShime = new List<string>();
      for (int i = 0; i < 3; i++) {
        wayShime.Add("");
      }
    }

    private void MascotAI() {
      while (true) {
        Thread.Sleep(random.Next(5000));
        int buf = random.Next(2);
        if (buf == 1) { xToMove = xToMove = ScreenWidth - random.Next(341) - windowWidth; }
        numAction = buf;
      }
    }
    public void ActionMascote() {
      switch (numAction) {
        // 0 - стоять на месте
        // 1 - ходить в какую-либо сторону
        // 2 - анимация во время оповещения
        //
        case 0: {
            this.doStand();
            break;
          }
        case 1: {
            this.doWalk();
            break;
          }
        case 2: {
            this.doNotification();
            break;
          }
        case 3: {
            this.doMenu();
            break;
          }
      }
    }
    private void doStand() {
      AnimationMascote.Animation(grid, "img/shime1.png");
    }
    private void doWalk() {
      if (window.Left > xToMove) {
        wayShime[0] = "img/mov/shime2.png";
        wayShime[1] = "img/mov/shime3.png";
        toRight = false;
      } else {
        wayShime[0] = "img/mov/shime2R.png";// shime 2
        wayShime[1] = "img/mov/shime3R.png";// shime 3
        toRight = true;
      }
      switch (step) {
        case 0: {
            AnimationMascote.Animation(grid, wayShime[step]);
            if (toRight == true) {
              if (window.Left < xToMove) {
                window.Left += 10;
              } else {
                numAction = 0;
              }
            } else {
              if (window.Left > xToMove) {
                window.Left -= 10;
              } else {
                numAction = 0;
              }
            }
            step = 1;
            break;
          }
        case 1: {
            AnimationMascote.Animation(grid, wayShime[step]);
            step = 0;
            break;
          }
        default: {
            step = 0;
            break;
          }
      }
    }
    private void doNotification() {
      wayShime[0] = ("img/shime31.png");
      wayShime[1] = ("img/shime32.png");
      wayShime[2] = ("img/shime33.png");
      AnimationMascote.Animation(grid, wayShime[step]);
      switch (step) {
        case 0: {
            step = 1;
            break;
          }

        case 1: {
            step = 2;
            break;
          }

        case 2: {
            step = 0;
            break;
          }
      }
    }
    private void doMenu() {
      wayShime[0] = ("img/shime54.png");
      wayShime[1] = ("img/shime55.png");
      AnimationMascote.Animation(grid, wayShime[step]);
      switch (step) {
        case 0: {
          step = 1;
          break;
          }
        case 1: {
            step = 0;
            break;
          }
      }
    }
  }
}