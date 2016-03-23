using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace Mascot {
  class AnimationMascote {
    static public void Animation(Grid mascote, string WayMascote) {
      mascote.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(mascote), WayMascote)));
    }
  }
}
