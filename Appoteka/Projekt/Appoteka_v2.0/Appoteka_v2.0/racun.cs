//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appoteka_v2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class racun
    {
        public racun()
        {
            this.lijekovi = new HashSet<lijekovi>();
        }
    
        public int IdrRacuna { get; set; }
        public System.DateTime datum { get; set; }
        public double iznos { get; set; }
        public string OIB { get; set; }
    
        public virtual zaposlenici zaposlenici { get; set; }
        public virtual ICollection<lijekovi> lijekovi { get; set; }
    }
}
