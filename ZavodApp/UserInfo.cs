using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavodApp
{
    public enum TypeUserEnum
    {
        Worker,
        Admin,
        None
    }

    public static class UserInfo
    {
        public static int id { get; set; }
        public static TypeUserEnum type { get; set; }
    }
}
