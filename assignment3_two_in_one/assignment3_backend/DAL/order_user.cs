//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_user
    {
        public int id { get; set; }
        public int id_product { get; set; }
        public int id_order { get; set; }
        public string product_price { get; set; }
        public string product_qty { get; set; }
    
        public virtual order_adminn order_adminn { get; set; }
        public virtual product product { get; set; }
    }
}
