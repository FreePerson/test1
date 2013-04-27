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

namespace WpfApplication1
{
    /// <summary>
    /// Window3.xaml 的交互逻辑
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
           
        }

        private void Image_TouchUp(object sender, TouchEventArgs e)
        {

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void ToggleButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void ToggleButton_TouchUp(object sender, TouchEventArgs e)
        {

        }
    }
}
