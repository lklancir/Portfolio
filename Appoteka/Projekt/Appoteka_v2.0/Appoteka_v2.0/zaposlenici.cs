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
    
    public partial class zaposlenici
    {
        public zaposlenici()
        {
            this.narudzbe = new HashSet<narudzbe>();
            this.racun = new HashSet<racun>();
        }
    
        public string OIB { get; set; }
        public string prezime { get; set; }
        public string ime { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }
        public string adresa { get; set; }
    
        public virtual ICollection<narudzbe> narudzbe { get; set; }
        public virtual ICollection<racun> racun { get; set; }
    }
}
