using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class PropertyFactory
    {
        public Property Create(int id, String name, String address, float area, String facility, String shortDesc, String image, int availability, float price, float negotiationLimit, int OwnerId)
        {
            Property pro = new Property();
            pro.PropertyId = id;
            pro.PropertyName = name;
            pro.Address = address;
            pro.Area = area;    
            pro.Facility = facility;    
            pro.ShortDescription = shortDesc;
            pro.Image = image;
            pro.Availability = availability;
            pro.Price = price;
            pro.NegotiationLimit = negotiationLimit;
            pro.OwnerId = OwnerId;  
            return pro;
        }
    }
}