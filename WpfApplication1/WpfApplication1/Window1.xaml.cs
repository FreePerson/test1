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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        private Canvas _rootCanvas = new Canvas(); UserControl1 c = new UserControl1();
        public Window1()
        {
           
            this.Content = _rootCanvas;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //this.btn.IsEnabled = !this.btn.IsEnabled;
            this._rootCanvas.Children.Add(c);
            this.UpdateLayout();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
