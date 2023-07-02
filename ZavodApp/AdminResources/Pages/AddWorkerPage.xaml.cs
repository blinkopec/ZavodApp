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
    /// Логика взаимодействия для AddWorkerPage.xaml
    /// </summary>
    public partial class AddWorkerPage : Page
    {
        private Frame _frame { get; set; }
        public AddWorkerPage(Frame frame)
        {
            _frame = frame;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new NonePage());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nameBox.Text != null && surnameBox.Text != null && middlenameBox.Text != null)
                {

                    Worker worker = new Worker()
                    {
                        name = nameBox.Text,
                        surname = surnameBox.Text,
                        middlename = middlenameBox.Text,
                        bet = Convert.ToInt32(betBox.Text),
                        login = loginBox.Text,
                        password = passwordBox.Text,
                    };
                    if (worker != null)
                        ZavodPracticeEntities.GetContext().Worker.Add(worker);
                }
            }
            catch(Exception ex)
            {
                ErrorLabel.Content = "Неправильно введены данные!";
            }
            finally
            {
                ZavodPracticeEntities.GetContext().SaveChanges();
                _frame.Navigate(new NonePage());
            }
            
                
        }
    }
}
