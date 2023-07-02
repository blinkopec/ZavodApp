using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavodApp.WorkerResources.Pages.TabelPages
{
    internal class ToInsertItem
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int workingTime { get; set; }
        public int CountBrak { get; set; }
        public int numberOfDetails { get; set; }
        public ToInsertItem(int id, DateTime date, int workingTime, int CountBrak, int numberOfDetails)
        {
            this.id = id;
            this.date = date;
            this.workingTime = workingTime;
            this.CountBrak = CountBrak;
            this.numberOfDetails = numberOfDetails;
        }
    }
}
