//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace avtiruz.Model2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovars()
        {
            this.Postavshic = new HashSet<Postavshic>();
        }
    
        public int Kod_Tovar { get; set; }
        public string Nazvanie { get; set; }
        public string Edinica_Izmerenia { get; set; }
        public string Kl_na_cklade { get; set; }
        public string Opisanie { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Postavshic> Postavshic { get; set; }
    }
}