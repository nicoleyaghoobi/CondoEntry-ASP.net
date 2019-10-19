using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CondoEntryLogs.Models
{
    public class CondoEntryLogsContext : DbContext
    {
        internal IEnumerable<object> Visitors;

        public CondoEntryLogsContext (DbContextOptions<CondoEntryLogsContext> options)
            : base(options)
        {
        }

        public DbSet<CondoEntryLogs.Models.Visitor> Visitor { get; set; }
    }
}
