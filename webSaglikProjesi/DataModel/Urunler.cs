//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webSaglikProjesi.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.SatisDetaylari = new HashSet<SatisDetaylari>();
        }
    
        public int urunid { get; set; }
        public string urunkodu { get; set; }
        public string urunad { get; set; }
        public int urunkategorino { get; set; }
        public int urunaltkategorino { get; set; }
        public int miktar { get; set; }
        public decimal urunfiyat { get; set; }
        public string urunbilgisi { get; set; }
        public string urunresimyolu1 { get; set; }
        public string urunresimyolu2 { get; set; }
        public bool silindi { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisDetaylari> SatisDetaylari { get; set; }
    }
}