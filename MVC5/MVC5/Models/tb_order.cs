//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_order
    {
        public int ID_order { get; set; }
        public string Code_order { get; set; }
        public string Name_order { get; set; }
        public string Type_order { get; set; }
        public Nullable<System.DateTime> Create_date { get; set; }
        public Nullable<double> Total_money { get; set; }
    }
}