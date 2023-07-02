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
    /// Логика взаимодействия для BrakOrNoPage.xaml
    /// </summary>
    public partial class BrakOrNoPage : Page
    {
        private Frame frame { get; set; }
        private WorkPage workPage { get; set; }
        public BrakOrNoPage(Frame frame,WorkPage wp)
        {
            this.workPage = wp;
            this.frame = frame;
            InitializeComponent();
        }

        private void BrakButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new BrakPage(frame, workPage)); 
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            WorkingActualInfo.numberGreatDetails += 1;

            if (!workPage.workInfo.percentCheck)
                workPage.RefreshInfo();
            if (workPage.workInfo.percentCheck && workPage.workInfo.carvingCheck)
                workPage.RefreshWithPercentAndCarvingCheck();
            if (workPage.workInfo.percentCheck && !workPage.workInfo.carvingCheck)
                workPage.RefreshWithPercentCheck();
        }
    }
}
