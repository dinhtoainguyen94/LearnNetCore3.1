using System;
using System.Transactions;

namespace eShopSolution.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ExternalTransactionId{ get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public int Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus Status { set; get; }
        public string Provider { get; set; }
    }
}
