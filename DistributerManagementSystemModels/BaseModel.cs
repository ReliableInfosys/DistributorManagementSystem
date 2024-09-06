using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.Id = Guid.NewGuid();
            this.TempId = Guid.NewGuid();
            this.DateCreated = DateTime.Today;
            this.IsActive = true;
        }

        [Key]
        public Guid Id { get; set; }

        public Guid TempId { get; set; }

        public DateTime DateCreated { get; set; } 

        public string? CreatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public string? UpdatedBy { get;set; }

        public DateTime? DeletedDate { get; set; }

        public string? DeletedBy { get; set ; }

        public bool IsActive { get; set; }
    }
}
