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

namespace ZavodApp.WorkerResources.Pages.TabelPages
{
    /// <summary>
    /// Логика взаимодействия для MainTabelPage.xaml
    /// </summary>
    public partial class MainTabelPage : Page
    {
        public MainTabelPage()
        {
            InitializeComponent();
            InsertItemsToScrollViewer();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var item = button.DataContext as ToInsertItem;
            OrderWindow ow = new OrderWindow(item.id);
            ow.Show();
        }

        private void InsertItemsToScrollViewer() 
        {
            List<ToInsertItem> items = new List<ToInsertItem>();
            using (var context = new ZavodPracticeEntities())
            {
                var zz = context.ReportCard
                    .Where(b => b.idWorker == UserInfo.id)
                    .ToList();
                

                foreach (var item in zz) 
                {
                    var aa = context.ReportBrak
                        .Where(b => b.idReportCard == item.idReportCard)
                        .ToList();

                    items.Add(new ToInsertItem(item.idReportCard, item.date, (int)item.workingTime, aa.Count, (int)item.numberOfDetails));
                }
            }

            orderItems.ItemsSource = items;
        }
    }
}
