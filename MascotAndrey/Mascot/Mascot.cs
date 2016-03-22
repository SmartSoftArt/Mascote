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
    private volatile int gotTicks = 0;
    private volatile bool step = true;
    private volatile int xToMove;
    private string wayShimeOne;
    private string wayWhimeTwo;
    private bool toRight;
    private Thread threadMascot;
    private Random random = new Random();
    private MainWindow window;
    private Grid grid;
    private int dx = 10;
    public int ScreenHeight = (int)SystemParameters.PrimaryScreenHeight;
    public int ScreenWidth = (int)SystemParameters.PrimaryScreenWidth;
    

    public Mascote(Grid mascote, MainWindow mainwindow) {
      threadMascot = new Thread(MascotAI);
      threadMascot.Start();
      grid = mascote;
      window = mainwindow;
    }

    private void MascotAI() {
      while (true) {
        Thread.Sleep(random.Next(5000));
        int buf = random.Next(2);
        if (buf == 1) {
          xToMove = random.Next(341) + 1024;
        }
        numAction = buf;
      }
    }
    public void ActionMascote() {
      switch (numAction) {
        case 0: {
            this.doStand();
            break;
          }
        case 1: {
            if (window.Left > xToMove) {
              wayShimeOne = "img/mov/shime2.png";
              wayWhimeTwo = "img/mov/shime3.png";
              toRight = false;
            } else {
              wayShimeOne = "img/mov/shime2R.png";// shime 2
              wayWhimeTwo = "img/mov/shime3R.png";// shime 3
              toRight = true;
            }

            if (step) {
                AnimationMascote.Animation(grid, wayWhimeTwo);
                step = false;
            } else {
              AnimationMascote.Animation(grid, wayShimeOne);
              if (toRight == true) {
                if (window.Left < xToMove) {
                  if (window.Left < ScreenWidth - grid.Width){
                    window.Left += dx;
                  }
                } else {
                  numAction = 0;
                }
              } else {
                if (window.Left > xToMove) {
                  if (window.Left > (ScreenWidth % 2)) {
                    window.Left -= dx;
                  } 
                } else {
                  numAction = 0;
                }
              }
              step = true;
            }
            break;
          }
      }
    }
    private void doStand() {
      AnimationMascote.Animation(grid, "img/shime1.png");
    }
  }
}
