//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KindergartenJoy
{
    using System;
    using System.Collections.Generic;
    
    public partial class dijete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dijete()
        {
            this.biljeska = new HashSet<biljeska>();
            this.upis = new HashSet<upis>();
            this.evidencija = new HashSet<evidencija>();
        }
    
        public int dijete_id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string spol { get; set; }
        public System.DateTime datum_rodjenja { get; set; }
        public int oib { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<biljeska> biljeska { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<upis> upis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evidencija> evidencija { get; set; }
    }
}
