//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UVSproject
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardProduct
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public int CardId { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual Product Product { get; set; }
    }
}
