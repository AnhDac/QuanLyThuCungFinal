//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuCung.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract_Sell
    {
        public int ID_ConSell { get; set; }
        public Nullable<int> ID_Emp { get; set; }
        public Nullable<int> ID_Cus { get; set; }
        public Nullable<int> ID_Pet { get; set; }
        public Nullable<int> CateInsurance { get; set; }
        public Nullable<System.DateTime> DateSell { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual WarrantyType WarrantyType { get; set; }
    }
}
