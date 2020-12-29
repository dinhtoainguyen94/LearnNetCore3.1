using eShopSolution.Data.Enum;
using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CartId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public int ShipPhoneNumber { get; set; }
        public string ShipEmail { get; set; }
        public OrderStatus Status { set; get; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
