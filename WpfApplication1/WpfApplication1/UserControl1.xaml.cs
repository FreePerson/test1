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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    
    public partial class UserControl1 : UserControl
    {
        private string _px;
        public string PX
        {
            get
            {
                return _px;
            }
            set
            {
                _px = value;
            }
        }
        
        public UserControl1()
        {
            this.Loaded += new RoutedEventHandler(UserControl1_Loaded);
            InitializeComponent();
        }
      
        void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
