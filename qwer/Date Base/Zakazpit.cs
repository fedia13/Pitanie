//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qwer.Date_Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakazpit
    {
        public int ZakazID { get; set; }
        public int PitanieID { get; set; }
        public string Countigr { get; set; }
    
        public virtual Pitanie Pitanie { get; set; }
        public virtual Zakaz Zakaz { get; set; }
    }
}
