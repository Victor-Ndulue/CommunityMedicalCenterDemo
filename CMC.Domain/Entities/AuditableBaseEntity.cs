using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Domain.Entities
{
    public abstract class AuditableBaseEntity
    {
        
        public int Staff_Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set;} = DateTime.Now;
        public string? LastModifiedBy { get; set; }
        public DateTime DateModified { get; set;} 
    }
}
