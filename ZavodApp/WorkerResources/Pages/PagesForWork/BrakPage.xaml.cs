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

namespace ZavodApp.WorkerResources.Pages.PagesForWork
{
    /// <summary>
    /// Логика взаимодействия для BrakPage.xaml
    /// </summary>
    public partial class BrakPage : Page
    {
        private Frame frame { get; set; } 
        private WorkPage workPage { get; set; } 
        public BrakPage(Frame frame, WorkPage wp)
        {
            this.workPage = wp;
            this.frame = frame;
            InitializeComponent();

            using (var context = new ZavodPracticeEntities())
            {
                TypeOfBrakBox.ItemsSource = context.Brak
                    .Select(b => b.name).ToList();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            WorkingActualInfo.numberGreatDetails += 1;
            WorkingActualInfo.numberBrak += 1;

            if (ConvertStringToType(TypeOfBrakBox.Text) != NameBrakEnum.None)
            {
                workPage.workInfo.braks.Add(new BrakInfo(ConvertStringToType(TypeOfBrakBox.Text)));
                frame.Navigate(new BrakOrNoPage(frame, workPage));

                if (!workPage.workInfo.percentCheck)
                    workPage.RefreshInfo();
                if (workPage.workInfo.percentCheck && workPage.workInfo.carvingCheck)
                    workPage.RefreshWithPercentAndCarvingCheck();
                if (workPage.workInfo.percentCheck && !workPage.workInfo.carvingCheck)
                    workPage.RefreshWithPercentCheck(); 
            }
            else
                MessageBox.Show("Ошибка!");
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new BrakOrNoPage(frame, workPage));
        }

        private NameBrakEnum ConvertStringToType(string name)
        {
            if (name == "K40")
                return NameBrakEnum.K40;
            if (name == "K43")
                return NameBrakEnum.K43;
            if (name == "K50")
                return NameBrakEnum.K50;
            if (name == "K37")
                return NameBrakEnum.K37;
            if (name == "K26")
                return NameBrakEnum.K26;

            return NameBrakEnum.None;
        }
    }
}
