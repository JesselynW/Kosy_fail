using Kosy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosy.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int id, int propertyId, float paymentTotal)
        {
            TransactionDetail transactionDetail = new TransactionDetail(); 
            transactionDetail.TransactionId = id;
            transactionDetail.PropertyId = propertyId;
            transactionDetail.PaymentTotal = paymentTotal;
            return transactionDetail;
        }
    }
}