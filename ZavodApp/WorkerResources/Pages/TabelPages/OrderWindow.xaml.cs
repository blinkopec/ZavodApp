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
using System.Windows.Shapes;

namespace ZavodApp.WorkerResources.Pages.TabelPages
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private int idReportCard { get;set; }
        public OrderWindow(int idReportCard)
        {
            this.idReportCard = idReportCard;
            InitializeComponent();
            Insert();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Insert()
        {
            List<ItemToInsertInOrder> items = new List<ItemToInsertInOrder>();

            using (var context = new ZavodPracticeEntities())
            {
                var braks = context.ReportBrak
                    .Where(b => b.idReportCard == idReportCard)
                    .Select(b => b.idBrak)
                    .ToList();

                foreach (var brak in braks.Distinct())
                {
                    string name = context.Brak
                        .Where(b => b.idBrak == brak)
                        .Select(b => b.name)
                        .Single();

                    int tmp = braks.Where(x => x == brak).Count();
                    items.Add(new ItemToInsertInOrder(name, tmp));
                }
            }
            orderItems2.ItemsSource = items;
        }
    }
}
