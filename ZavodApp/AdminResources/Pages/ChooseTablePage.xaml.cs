using System;
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

namespace ZavodApp.AdminResources.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChooseTablePage.xaml
    /// </summary>
    public partial class ChooseTablePage : Page
    {
        private Frame frame { get; set; } 
        public ChooseTablePage(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }

        private void EditBrak_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DataGridPage(NameTableEnum.Brak));
        }

        private void EditReportBrak_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DataGridPage(NameTableEnum.ReportBrak));
        }

        private void EditWorker_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DataGridPage(NameTableEnum.Worker));
        }

        private void EditReportCard_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DataGridPage(NameTableEnum.ReportCard));
        }

        private void EditAdmin_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DataGridPage(NameTableEnum.Admin));
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new NonePage());
        }
    }
}
