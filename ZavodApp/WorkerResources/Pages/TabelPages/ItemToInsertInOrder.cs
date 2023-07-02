using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavodApp.WorkerResources.Pages.TabelPages
{
    internal class ItemToInsertInOrder
    {
        public string NameBrak { get; set; }
        public int Count { get; set; }

        public ItemToInsertInOrder(string NameBrak, int Count) 
        {
            this.NameBrak = NameBrak;
            this.Count = Count;
        }    
    }
}
