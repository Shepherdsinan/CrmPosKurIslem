//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmPosKurİşlem
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOVIZ_AD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOVIZ_AD()
        {
            this.FINANS_DETAY = new HashSet<FINANS_DETAY>();
        }
    
        public long ID { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
        public string ALT_AD { get; set; }
        public Nullable<int> KASA_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANS_DETAY> FINANS_DETAY { get; set; }
    }
}
