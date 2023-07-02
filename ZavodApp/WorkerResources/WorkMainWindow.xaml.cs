using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ZavodApp.WorkerResources.Pages;
using ZavodApp.WorkerResources.Pages.TabelPages;

namespace ZavodApp.WorkerResources
{
    /// <summary>
    /// Логика взаимодействия для WorkMainWindow.xaml
    /// </summary>
    public partial class WorkMainWindow : Window
    {
        public WorkMainWindow()
        {
            InitializeComponent();
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            //  MainFrame.Navigate(new TimeTablePage());
        }

        private void TabelButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainTabelPage());
        }

        private void WorkButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WorkSettings(MainFrame));
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            UserInfo.id = 0;
            UserInfo.type = TypeUserEnum.None;
            mw.Show();
            this.Close();
        }
    }
}
