using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tables
{
    public class TodoWork : BaseEntity
    {
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        public bool IsComplete { get; set; }    
    }
}
