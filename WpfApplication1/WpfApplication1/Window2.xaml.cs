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
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        Storyboard sb;
        public Window2()
        {
            InitializeComponent();
            string a="123,123,233 .";
            char[] MyChar = { '.'};

            a = a.TrimEnd(MyChar);
            sb = this.Resources["story"] as Storyboard;
            //img.Source = new BitmapImage(new Uri("pack://application:,,,/image/86.png"));
            //txt.IsManipulationEnabled = true;
            //sv.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(sv_ManipulationDelta);
        }

        void sv_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            //sv.ScrollToVerticalOffset(e.DeltaManipulation.Translation.Y + sv.VerticalOffset);
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            if (sb == null)
                return;
            sb.Remove(this);
            sb = null;
            //fromToAnimatedRectangle.Width = 400;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.BeginStoryboard(sb, HandoffBehavior.SnapshotAndReplace, true);
            //sb.Begin(this);
        }
    }
}
