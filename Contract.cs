//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Immovables
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int IDContract { get; set; }
        public Nullable<int> IDBuilding { get; set; }
        public Nullable<int> IDEmployee { get; set; }
        public Nullable<int> IDClient { get; set; }
        public System.DateTime BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
    }
}