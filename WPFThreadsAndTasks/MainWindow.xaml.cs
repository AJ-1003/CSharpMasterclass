using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WPFThreadsAndTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached
            (
                "Html",
                typeof(string),
                typeof(MainWindow),
                new FrameworkPropertyMetadata(OnHtmlChanged)
            );

        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Test_Btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Task.Run(() =>
        //    {
        //        Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId}");
        //        HttpClient webClient = new HttpClient();
        //        string html = webClient.GetStringAsync("http://google.com").Result;

        //        Test_Btn.Dispatcher.Invoke(() =>
        //        {
        //            Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId} owns the Button");
        //            Test_Btn.Content = "Done";
        //        });
        //    });
        //}

        private async void Test_Btn_Click(object sender, RoutedEventArgs e)
        {
            var downloadedHtml = "";

            Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId} before awaiting task!");
            await Task.Run(() =>
            {
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                downloadedHtml = html;
                Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId} during awaiting task!");
            });
            Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId} after awaiting task!");
            Test_Btn.Content = "Done";
            Test_WebBrowser.SetValue(HtmlProperty, downloadedHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
