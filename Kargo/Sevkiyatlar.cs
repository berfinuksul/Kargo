//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kargo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sevkiyatlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sevkiyatlar()
        {
            this.Musterilers = new HashSet<Musteriler>();
        }
    
        public int SevkiyatNo { get; set; }
        public string SevkiyatAdı { get; set; }
        public string SevkiyatAlimNoktasi { get; set; }
        public string SevkiyatUlasimNoktasi { get; set; }
        public Nullable<int> Mesafe { get; set; }
        public Nullable<decimal> MesafeTutar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteriler> Musterilers { get; set; }
    }
}
