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
    
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            this.Zakazpit = new HashSet<Zakazpit>();
        }
    
        public int ID { get; set; }
        public string Дата_заказа { get; set; }
        public string Номер_заказа { get; set; }
        public string Состав_заказа { get; set; }
        public string Сумма_заказа { get; set; }
        public string Сумма_скидки { get; set; }
        public Nullable<int> Пункт_выдачи { get; set; }
        public string Код_получения { get; set; }
    
        public virtual Vidacha Vidacha { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakazpit> Zakazpit { get; set; }
    }
}
