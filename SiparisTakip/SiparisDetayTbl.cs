//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiparisTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiparisDetayTbl
    {
        public int SiparisDetayID { get; set; }
        public Nullable<int> SiparisID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> UrunAdet { get; set; }
        public Nullable<decimal> AdetFiyat { get; set; }
        public Nullable<decimal> ToplamFiyat { get; set; }
    
        public virtual SiparisTbl SiparisTbl { get; set; }
        public virtual UrunTbl UrunTbl { get; set; }
    }
}
