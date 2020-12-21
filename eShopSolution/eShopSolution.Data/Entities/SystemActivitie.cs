using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class SystemActivitie
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionDate { get; set; }
        public int FunctionId { get; set; }
        public int UserId { get; set; }
        public string ClientIp { get; set; }
    }
}
