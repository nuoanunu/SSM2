//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_responsible
    {
        public int id { get; set; }
        public int productID { get; set; }
        public string saleRepID { get; set; }
        public double minCommision { get; set; }
        public double maxCommision { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> TotalRevenue { get; set; }
        public Nullable<double> monthlyCommision { get; set; }
        public Nullable<double> AvarageDealSize { get; set; }
        public Nullable<double> KPIforthisProduct { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual softwareProduct softwareProduct { get; set; }
    }
}