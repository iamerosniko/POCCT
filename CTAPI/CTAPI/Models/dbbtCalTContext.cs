using Microsoft.EntityFrameworkCore;

namespace CTAPI.Models
{
    public partial class dbbtCalTContext : DbContext
    {
        public dbbtCalTContext(DbContextOptions<dbbtCalTContext> options) : base(options)
        {
        }

        public DbSet<CtdCallCategories> CtdCallCategories { get; set; }
        public DbSet<CtdCallerAssocs> CtdCallerAssocs { get; set; }
        public DbSet<CtdCalls> CtdCalls { get; set; }
        public DbSet<CTAPI.Models.CtdCallStatuses> CtdCallStatuses { get; set; }
        //public DbSet<CtdCallStatuses> CtdCallStatuses { get; set; }

    }
}
