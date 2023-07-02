using System;
using System.Linq;
using System.Windows;
using ZavodApp.AdminResources;
using ZavodApp.WorkerResources;

namespace ZavodApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (PsswdBox.Password != null && LoginBox.Text != null)
            {
                string pswdOnDatabase = null;
                bool isWorker = false;
                bool isAdmin = false;

                using (var context = new ZavodPracticeEntities())
                {
                    try
                    {
                        try
                        {
                            pswdOnDatabase = context.Worker
                                .Where(b => b.login == LoginBox.Text)
                                .Select(b => b.password)
                                .Single();
                        }
                        catch (Exception ex)
                        {

                        }
                        if (pswdOnDatabase != null)
                            isWorker = true;
                        else
                        {
                            pswdOnDatabase = context.Admin
                                .Where(b => b.login == LoginBox.Text)
                                .Select(b => b.password)
                                .Single();
                            if (pswdOnDatabase != null)
                                isAdmin = true;
                            else
                                ErrorLabel.Content = "Неверный логин или пароль";
                        }

                        if (pswdOnDatabase != null && pswdOnDatabase == PsswdBox.Password)
                        {
                            if (isWorker)
                            {
                                UserInfo.id = context.Worker
                                    .Where(b => b.login == LoginBox.Text)
                                    .Select(b => b.idWorker)
                                    .Single();
                                UserInfo.type = TypeUserEnum.Worker;

                                WorkMainWindow wmw = new WorkMainWindow();
                                wmw.Show();
                                this.Close();
                            }

                            if (isAdmin) 
                            {
                                UserInfo.id = context.Admin
                                   .Where(b => b.login == LoginBox.Text)
                                   .Select(b => b.idAdmin)
                                   .Single();
                                UserInfo.type = TypeUserEnum.Admin;

                                AdminMainWindow amw = new AdminMainWindow();
                                amw.Show();
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex) 
                    {
                        ErrorLabel.Content = "Неверный логин или пароль";
                    }

                    
                }
            }
        }
    }
}
