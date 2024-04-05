using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class ReviewFactory
    {
        public static Review Create(int id, int propertyId, float rating, String review)
        {
            Review rev = new Review();
            rev.ReviewId = id;
            rev.PropertyId = propertyId;
            rev.Rating = rating;
            rev.Review1 = review;
            return rev;

        }
    }
}