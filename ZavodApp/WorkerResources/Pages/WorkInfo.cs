using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZavodApp.WorkerResources.Pages.PagesForWork;

namespace ZavodApp.WorkerResources.Pages
{
  

    public class WorkInfo
    {
        public int numberDetails { get; set; }
        public bool percentCheck { get; set; }
        public bool carvingCheck { get; set; }
        public List<BrakInfo> braks { get; set; }
        
        public WorkInfo(int numberDetails, bool percentCheck, bool carvingCheck) 
        { 
            this.braks = new List<BrakInfo>();   
            this.numberDetails = numberDetails;
            this.percentCheck = percentCheck;
            this.carvingCheck = carvingCheck;
        }
    }
}
