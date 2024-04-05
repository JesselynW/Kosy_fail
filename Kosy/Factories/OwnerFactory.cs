using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class OwnerFactory
    {
        public static Owner Create(int OwnerId, String name, String phone, String email, String password)
        {
            Owner owner = new Owner();
            owner.OwnerId = OwnerId;
            owner.OwnerName = name;
            owner.OwnerPhone = phone;
            owner.OwnerEmail = email;
            owner.OwnerPassword = password;
            return owner;
        }
    }
}