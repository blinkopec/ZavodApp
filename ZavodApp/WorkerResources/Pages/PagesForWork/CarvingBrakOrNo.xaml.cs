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
    /// Логика взаимодействия для CarvingBrakOrNo.xaml
    /// </summary>
    public partial class CarvingBrakOrNo : Page
    {
        private WorkPage workPage { get;set; }
        public CarvingBrakOrNo(WorkPage workPage)
        {
            this.workPage = workPage;   
            InitializeComponent();
        }

        private void BrakButton_Click(object sender, RoutedEventArgs e)
        {
            WorkingActualInfo.numberGreatDetails += 1;
            WorkingActualInfo.numberBrak += 1;
            if (!workPage.workInfo.percentCheck)
                workPage.RefreshInfo();
            if (workPage.workInfo.percentCheck && workPage.workInfo.carvingCheck)
                workPage.RefreshWithPercentAndCarvingCheck();
            if (workPage.workInfo.percentCheck && !workPage.workInfo.carvingCheck)
                workPage.RefreshWithPercentCheck();
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
