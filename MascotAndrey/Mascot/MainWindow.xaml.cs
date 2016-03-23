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
// Скрытие Альттаба
using System.Runtime.InteropServices;
using System.Windows.Interop;
// Конец Скрытия
namespace Mascot {
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  /// 
  public partial class MainWindow : Window {
    // Параметры для скрытие Альттаба
    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr window, int index, int value);

    [DllImport("user32.dll")]
    private static extern int GetWindowLong(IntPtr window, int index);
    private IntPtr Handle {
      get {
        return new WindowInteropHelper(this).Handle;
      }
    }
    // Конец параметров
    private System.Windows.Forms.ContextMenu contextMenu1;
    private System.Windows.Forms.MenuItem menuItemExit;
    private System.Windows.Forms.MenuItem menuItemHide;

    public static volatile bool MascotIsHidden = false;
    public static volatile bool MenuIsShow = false;

    Mascote mascote;
    public MainWindow() {
      InitializeComponent();
      mascote = new Mascote(grid, MainWindow1);
      //Таймер для анимации
      System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
      timer.Tick += new EventHandler(TimerTick);
      timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
      timer.Start();

      //Работа с гридом
      grid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.grid_Click);

      //Работа с гридом. Прозрачность кнопок.
      But1.Opacity = 0;
      But2.Opacity = 0;
      But3.Opacity = 0;
      But4.Opacity = 0;

      //Описание трея
      System.Windows.Forms.NotifyIcon tray = new System.Windows.Forms.NotifyIcon();
      tray.Icon = new System.Drawing.Icon("icon.ico");
      tray.Visible = true;
      tray.MouseClick += tray_MouseClick;

      //Создание объекта контекстного меню и его элемента(ов)
      this.contextMenu1 = new System.Windows.Forms.ContextMenu();
      this.menuItemExit = new System.Windows.Forms.MenuItem();
      this.menuItemHide = new System.Windows.Forms.MenuItem();
      this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { 
                this.menuItemExit, 
                this.menuItemHide
            });

      // Инициализация элемента Exit
      this.menuItemExit.Index = 1;
      this.menuItemExit.Text = "E&xit";
      this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);

      this.menuItemHide.Index = 0;
      this.menuItemHide.Text = "H&ide";
      this.menuItemHide.Click += new System.EventHandler(this.menuItemHide_Click);

      //Инициализация контекстного меню

      tray.ContextMenu = this.contextMenu1;
    }

    void tray_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        if (notification.IsOpen) {
          this.Top += 17;
        }
        notification.IsOpen = true;
        mascote.threadMascot.Suspend();
        mascote.NumAction = 2;
      }
    }
    private void menuItemExit_Click(object sender, EventArgs e) {
      this.Close();
      Process.GetCurrentProcess().Kill();
    }
    private void menuItemHide_Click(object sender, EventArgs e) {
      if (MascotIsHidden == false) {
        this.Hide();
        MascotIsHidden = true;
        this.menuItemHide.Text = "S&how";
      } else {
        this.Show();
        MascotIsHidden = false;
        this.menuItemHide.Text = "H&ide";
      }
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      mascote.threadMascot.Resume();
      notification.IsOpen = false;
    }

    private void grid_Click(object sender, EventArgs e) {
      if (MenuIsShow == false) {
        MenuShow();
        MenuIsShow = true;
      } else {
        MenuClose();
        MenuIsShow = false;
      }

    }
    private void TimerTick(object sender, EventArgs e) {
      mascote.ActionMascote();
    }
    public void MenuShow() {
      var animation1 = new DoubleAnimation();
      var animation2 = new ThicknessAnimation();

      animation1.From = But1.Opacity;
      animation1.To = 1;
      animation1.Duration = TimeSpan.FromSeconds(0.35);
      But1.BeginAnimation(OpacityProperty, animation1);
      But2.BeginAnimation(OpacityProperty, animation1);
      But3.BeginAnimation(OpacityProperty, animation1);
      But4.BeginAnimation(OpacityProperty, animation1);

      Thickness FromThicness = new Thickness();

      Thickness ToThicness2 = new Thickness();
      FromThicness = But2.Margin;
      ToThicness2 = But2.Margin;
      ToThicness2.Top = 150;
      animation2.From = FromThicness;
      animation2.To = ToThicness2;
      animation2.Duration = TimeSpan.FromSeconds(0.35);
      But2.BeginAnimation(MarginProperty, animation2);

      ToThicness2.Top = 200;
      animation2.To = ToThicness2;
      But3.BeginAnimation(MarginProperty, animation2);

      ToThicness2.Top = 250;
      animation2.To = ToThicness2;
      But4.BeginAnimation(MarginProperty, animation2);

    }

    private void MenuClose() {
      var animation1 = new DoubleAnimation();
      var animation2 = new ThicknessAnimation();

      animation1.From = But1.Opacity;
      animation1.To = 0;
      animation1.Duration = TimeSpan.FromSeconds(0.35);
      But1.BeginAnimation(OpacityProperty, animation1);
      But2.BeginAnimation(OpacityProperty, animation1);
      But3.BeginAnimation(OpacityProperty, animation1);
      But4.BeginAnimation(OpacityProperty, animation1);

      Thickness FromThicness = new Thickness();

      Thickness ToThicness2 = new Thickness();
      FromThicness = But2.Margin;
      ToThicness2 = But2.Margin;
      ToThicness2.Top = 100;
      animation2.From = FromThicness;
      animation2.To = ToThicness2;
      animation2.Duration = TimeSpan.FromSeconds(0.35);
      But2.BeginAnimation(MarginProperty, animation2);

      ToThicness2.Top = 100;
      animation2.To = ToThicness2;
      But3.BeginAnimation(MarginProperty, animation2);

      ToThicness2.Top = 100;
      animation2.To = ToThicness2;
      But4.BeginAnimation(MarginProperty, animation2);
    }

    public void HideFromAltTab(IntPtr Handle) {
      SetWindowLong(Handle, -20, GetWindowLong(Handle, -20) | 0x00000080);
    }

    private void MainWindow1_Loaded(object sender, RoutedEventArgs e) {
     HideFromAltTab(Handle);
    }
  }
}
