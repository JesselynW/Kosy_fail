using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class AdvertisementFactory
    {
        public static Advertisement Create(int AdvertisementId, int PropertyId, String status, float fee)
        {
            Advertisement ad = new Advertisement();
            ad.AdvertisementId = AdvertisementId;
            ad.PropertyId = PropertyId;
            ad.Status = status;
            ad.Fee = fee;
            return ad;
        }
    }
}