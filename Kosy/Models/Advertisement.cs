//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kosy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public int PropertyId { get; set; }
        public string Status { get; set; }
        public double Fee { get; set; }
    
        public virtual Property Property { get; set; }
    }
}