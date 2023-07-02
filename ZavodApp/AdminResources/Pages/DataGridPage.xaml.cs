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
    public enum NameTableEnum 
    {
        Brak,
        ReportBrak,
        ReportCard,
        Worker,
        Admin,
        None,
    }
    /// <summary>
    /// Логика взаимодействия для DataGridPage.xaml
    /// </summary>
    public partial class DataGridPage : Page
    {
        private NameTableEnum tableName { get; set; }
        public DataGridPage(NameTableEnum tableName)
        {
            this.tableName = tableName;
            InitializeComponent();
            InsertDataGrid();
        }

        private void InsertDataGrid()
        {
            
            if (tableName == NameTableEnum.Brak)
            {
                dataGrid.ItemsSource = ZavodPracticeEntities.GetContext().Brak.ToList();
                //dataGrid.Columns    [2].MaxWidth = 0;
            }
            if (tableName == NameTableEnum.ReportBrak)
            {
                dataGrid.ItemsSource = ZavodPracticeEntities.GetContext().ReportBrak.ToList();
                //dataGrid.Columns[3].MaxWidth = 0;
                //dataGrid.Columns[4].MaxWidth = 0;
            }
            if (tableName == NameTableEnum.ReportCard)
            {
                dataGrid.ItemsSource = ZavodPracticeEntities.GetContext().ReportCard.ToList();
                //dataGrid.Columns[6].MaxWidth = 0;
                //dataGrid.Columns[7].MaxWidth = 0;
                //dataGrid.Columns[8].MaxWidth = 0;
            }
            if (tableName == NameTableEnum.Worker)
            {
                dataGrid.ItemsSource = ZavodPracticeEntities.GetContext().Worker.ToList();
                //dataGrid.Columns[7].MaxWidth = 0;
            }
            if (tableName == NameTableEnum.Admin)
            {
                dataGrid.ItemsSource = ZavodPracticeEntities.GetContext().Admin.ToList();
                //dataGrid.Columns[3].MaxWidth = 0;
            }
        }
    }
}
