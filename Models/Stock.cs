//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tema3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int id { get; set; }
        public Nullable<int> quantity { get; set; }
        public string measure { get; set; }
        public Nullable<System.DateTime> arr_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public Nullable<double> buy_price { get; set; }
        public Nullable<double> sell_price { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
