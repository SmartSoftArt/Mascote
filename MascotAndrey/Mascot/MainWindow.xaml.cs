﻿using System;
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
  public partial class MainWindow : Window {
    ImageBrush image = new ImageBrush();
    ImageBrush image1 = new ImageBrush();
    bool i = true;

    public MainWindow() {
      InitializeComponent();
      System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
      image.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "img/shime1.png"));
      image1.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "img/shime2.png"));
      timer.Tick += new EventHandler(TimerTick);
      timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
      timer.Start();

    }

    private void TimerTick(object sender, EventArgs e) {
      if (i) {
        grid.Background = image;
        i = false;
      } else {
        grid.Background = image1;
        i = true;
      }
    }
  }
}
