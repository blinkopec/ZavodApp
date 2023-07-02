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
using ZavodApp.WorkerResources.Pages.PagesForWork;

namespace ZavodApp.WorkerResources.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkPage.xaml
    /// </summary>
    public partial class WorkPage : Page
    {
        public WorkInfo workInfo { get; set; }
        private Frame frame { get; set; }
        private double percentNumber { get; set; }
        private bool comment = true;
        public WorkPage(WorkInfo wi, Frame frame)
        {
            WorkingActualInfo.numberBrak = 0;
            WorkingActualInfo.numberGreatDetails = 0;
            this.frame = frame;
            this.workInfo = wi;
            InitializeComponent();
            if (!workInfo.percentCheck)
                RefreshInfo();
            if (workInfo.percentCheck && workInfo.carvingCheck)
                RefreshWithPercentAndCarvingCheck();
            if (workInfo.percentCheck && !workInfo.carvingCheck)
                RefreshWithPercentCheck();
            DateLabel.Content = DateTime.Now;
            MainFrame.Navigate(new BrakOrNoPage(MainFrame, this));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new NonePage());
        }

        public void RefreshInfo()
        {
            if (WorkingActualInfo.numberGreatDetails < workInfo.numberDetails)
            {
                NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + workInfo.numberDetails;
                BrakLabel.Content = WorkingActualInfo.numberBrak;
            }
            else
            {
                MainFrame.Navigate(new NonePage());
                NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + workInfo.numberDetails;
                BrakLabel.Content = WorkingActualInfo.numberBrak;
                MessageBox.Show("Все детали проверены");
                CloseJob();
            }
        }
        public void RefreshWithPercentAndCarvingCheck()
        {
            bool firstCheck = false;
           
            percentNumber = workInfo.numberDetails * 0.1;

            if (WorkingActualInfo.numberGreatDetails < Convert.ToInt32(percentNumber))
            {
                NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + Convert.ToInt32(percentNumber);
                BrakLabel.Content = WorkingActualInfo.numberBrak;
            }
            else
            {
                firstCheck = true;
                if (comment)
                {
                    comment = false;
                    NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + Convert.ToInt32(percentNumber);
                    BrakLabel.Content = WorkingActualInfo.numberBrak;
                    MessageBox.Show("10% проверено");
                }
            }
            
            if (firstCheck)
            {
                MainFrame.Navigate(new CarvingBrakOrNo(this));
                if (WorkingActualInfo.numberGreatDetails < workInfo.numberDetails)
                {
                    NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + workInfo.numberDetails;
                    BrakLabel.Content = WorkingActualInfo.numberBrak;
                }
                else
                {
                    NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + workInfo.numberDetails;
                    BrakLabel.Content = WorkingActualInfo.numberBrak;
                    CloseJob();
                    MessageBox.Show("Все детали проверены");
                    MainFrame.Navigate(new NonePage());
                    
                }
            }
            
        }
        public void RefreshWithPercentCheck()
        {
            percentNumber = workInfo.numberDetails  * 0.1;
            if (WorkingActualInfo.numberGreatDetails < Convert.ToInt32(percentNumber))
            {
                NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + Convert.ToInt32(percentNumber);
                BrakLabel.Content = WorkingActualInfo.numberBrak;
            }
            else
            {
                MessageBox.Show("10 процентов проверено");
                NumberDetailsLabel.Content = WorkingActualInfo.numberGreatDetails + "/" + Convert.ToInt32(percentNumber);
                BrakLabel.Content = WorkingActualInfo.numberBrak;
                CloseJob();
                MainFrame.Navigate(new NonePage());
            }
        }

        private void SaveJobButton_Click(object sender, RoutedEventArgs e)
        {
            CloseJob();
        }

        private void CloseJob()
        {
            try
            {
                ReportCard rc = new ReportCard()
                {
                    idDetail = 1,
                    idWorker = UserInfo.id,
                    numberOfDetails = workInfo.numberDetails,
                    date = Convert.ToDateTime(DateLabel.Content),
                    workingTime = CalculateWorkingTime()
                };


                ZavodPracticeEntities.GetContext().ReportCard.Add(rc);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ZavodPracticeEntities.GetContext().SaveChanges();
            }

            try
            {

                using (var context = new ZavodPracticeEntities())
                {
                    foreach (var c in context.Brak)
                    {
                        foreach (BrakInfo bi in workInfo.braks)
                        {
                            if (bi.NameBrak.ToString() == c.name)
                            {
                                ReportBrak rb = new ReportBrak()
                                {
                                    idReportCard = CalculateIdReportCard(),
                                    idBrak = c.idBrak,
                                };

                                ZavodPracticeEntities.GetContext().ReportBrak.Add(rb);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ZavodPracticeEntities.GetContext().SaveChanges();
                frame.Navigate(new NonePage());
            }
        }

        private int CalculateIdReportCard()
        {
            using (var context = new ZavodPracticeEntities())
            {
                foreach (var card in context.ReportCard)
                {
                    if (card.idWorker ==  UserInfo.id)
                    {
                        if (card.date == DateTime.Today.Date)
                        {
                            if (card.numberOfDetails == workInfo.numberDetails) 
                                return card.idReportCard;
                        }
                    }
                }
            }
            return 0;
        }

        private int CalculateWorkingTime()
        {
            int x = Convert.ToInt32(Convert.ToDateTime(DateLabel.Content).ToString("HH"));
            int y = Convert.ToInt32(DateTime.Now.ToString("HH"));
            int tmp =  y - x;
            return tmp;
        }
    }
}
