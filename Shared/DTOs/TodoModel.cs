using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class TodoModel
    {
        public long Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
