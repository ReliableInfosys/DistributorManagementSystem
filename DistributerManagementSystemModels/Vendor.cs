using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class Vendor : BaseModel
    {
        public string Name { get; set; }

        public string? Address { get; set; }

        public string? GSTIN { get; set; }

        public int OnCredit { get; set; }

        public string? ContactNumber { get; set; }

        public string? Email { get; set; }
    }
}
