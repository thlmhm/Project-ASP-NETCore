using Domain.Common;
using Domain.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Thiết lập không theo dõi . Vì khi mà một entity đưa lên db context nó sẽ mặc định theo dõi
        /// </summary>
        /// <param name="options"> Lựa chọn ko theo dõi</param>
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }


        public DbSet<TodoWork> TodoWork { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        break;
                    case EntityState.Modified:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }



    }
}
