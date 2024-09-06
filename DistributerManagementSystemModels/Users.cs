using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class Users : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        public string ContactNumber { get; set; }

        public string? Email { get; set; }

        public string? UserType { get; set; }

        public string? Password { get; set; }
    }
}
