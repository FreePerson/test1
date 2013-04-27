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
using PDFLibNet;
using System.Net;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=initclient", "pipename=SageTouch");
            //BitmapImage b = new BitmapImage(new Uri("pack://application:,,,/image/86.png"));

            //img.Source = b; 
            //img.Width = 182;
            //img.Height = 182;
            //Button p = new Button();
            //VisualBrush _itemBG = (VisualBrush)TryFindResource("CandidateBackground");
            //(_itemBG.Visual as Grid).Width = 100d;
            //(_itemBG.Visual as Grid).Height = 100d;
            //stc.Background = _itemBG;
           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=sendmsg", string.Format("pipename={0}&destination={1}&event={2}&parameter={3}",
                "SageTouch", "HomePage", "MoveLeft", "area=3#id=cardchart5#sourcetype=bbsc"));
        }
        private string WebRequestPostData(string url, string postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentLength = postData.Length;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            StreamWriter writer = new StreamWriter(request.GetRequestStream());
            writer.Write(postData);
            writer.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string str = string.Empty;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                str = reader.ReadToEnd();
                reader.Close();
            }
            return str;
        }
        /// <summary> 
        /// 右移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=sendmsg", string.Format("pipename={0}&destination={1}&event={2}&parameter={3}",
                "SageTouch", "HomePage", "MoveRight", "area=3#id=cardchart5#sourcetype=bbsc"));
        }
        /// <summary>
        /// 进入2001年
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=sendmsg", string.Format("pipename={0}&destination={1}&event={2}&parameter={3}",
                "SageTouch", "HomePage", "NavitaionToYear", "year=2001"));
        }
        /// <summary>
        /// 进入2001年1月
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=sendmsg", string.Format("pipename={0}&destination={1}&event={2}&parameter={3}",
                "SageTouch", "HomePage", "NavitaionToMonth", "year=2001#month=1"));
        }
        /// <summary>
        /// 返回上一层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WebRequestPostData("http://192.168.10.112:8076/communication.aspx?action=sendmsg", string.Format("pipename={0}&destination={1}&event={2}&parameter={3}",
           "SageTouch", "HomePage", "ReturnPreviousPage", "year=2001#month=1"));
        }
    }
}
