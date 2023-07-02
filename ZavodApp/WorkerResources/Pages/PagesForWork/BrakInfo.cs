using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavodApp.WorkerResources.Pages.PagesForWork
{
    public enum NameBrakEnum
    {
        K40,
        K43,
        K50,
        K37,
        K26,
        None
    }
    public class BrakInfo
    {
        public NameBrakEnum NameBrak { get; set; }

        public BrakInfo(NameBrakEnum nameBrak) 
        {
            this.NameBrak = nameBrak;
        }
    }
}
