using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class Retailer : BaseModel
    {
        public string ReailerName { get; set; }

        public string Address { get; set; }

        public string GSTIN { get; set; }

        public string? ContactNumber { get; set; }

        public int OnCredit { get; set; }

    }
}
