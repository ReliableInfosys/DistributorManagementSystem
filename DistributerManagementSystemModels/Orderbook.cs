using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class Orderbook : BaseModel
    {
        public int OrderNumber { get; set; }

        public string RetailerName { get; set; }

        public string ProductName { get; set; }

        public string? ProductType { get; set; }
        
        public int Quantity { get; set; }

        [NotMapped]
        public int AmountWihtoutGST { get; set; }

        public int TotalAmount { get; set; }

        [NotMapped]
        public int? AmountPaid { get; set; }
        
        //public int? BalanceAmount => TotalAmount - AmountPaid;
        public int? BalanceAmount { get; set; }

        public bool IsPaid { get; set; } = false;

        public DateTime PaymentDueDate { get; set; }

        public string OrderStatus { get; set; }



        //observe and add later
    }
}
