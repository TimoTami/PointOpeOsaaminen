//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointOpeOsaaminen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Opettaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opettaja()
        {
            this.Osaamiset = new HashSet<Osaamiset>();
        }
    
        public int OpettajaID { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Sähköposti { get; set; }
        public string Henkilönumero { get; set; }
        public string Yksikkö { get; set; }
        public string Toimenkuva { get; set; }
        
        public string Nimi
        {
            get
            {
                return  Etunimi + " " + Sukunimi;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Osaamiset> Osaamiset { get; set; }
    }
}
