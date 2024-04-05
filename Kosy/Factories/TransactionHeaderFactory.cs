using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int id, int userId, DateTime TransactionDate)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionId = id;
            transactionHeader.UserId = userId;
            transactionHeader.TransactionDate = TransactionDate;
            return transactionHeader;
        }
    }
}