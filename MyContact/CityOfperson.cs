//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyContact
{
    using System;
    using System.Collections.Generic;
    
    public partial class CityOfperson
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CityID { get; set; }
    
        public virtual City City { get; set; }
    }
}
