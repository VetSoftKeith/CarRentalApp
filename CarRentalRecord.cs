//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Rental_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRentalRecord
    {
        public int id { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime DateRented { get; set; }
        public System.DateTime DateReturned { get; set; }
        public decimal Cost { get; set; }
        public Nullable<int> CarTypeId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
