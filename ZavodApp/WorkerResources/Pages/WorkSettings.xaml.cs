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

namespace ZavodApp.WorkerResources.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkSettings.xaml
    /// </summary>
    public partial class WorkSettings : Page
    {
        private Frame frame { get; set; }
        public WorkSettings(Frame frame)
        {
            this.frame = frame;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new NonePage());
        }

        private void GoButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (NumberDetailsBox.Text != null)
            {

                try
                {
                    WorkInfo wi = new WorkInfo(Convert.ToInt32(NumberDetailsBox.Text), Convert.ToBoolean(PercentBox.IsChecked), Convert.ToBoolean(CarvingBox.IsChecked));


                    if (wi != null)
                    {
                        frame.Navigate(new WorkPage(wi, frame));
                    }
                }
                catch (Exception ex)
                {
                    ErrorLabel.Content = "Неверно указаны данные. Проверьте!";
                }

            }
        }


       
    }
}