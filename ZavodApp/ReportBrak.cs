//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZavodApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportBrak
    {
        public int idBrakCard { get; set; }
        public Nullable<int> idBrak { get; set; }
        public Nullable<int> idReportCard { get; set; }
    
        public virtual Brak Brak { get; set; }
        public virtual ReportCard ReportCard { get; set; }
    }
}