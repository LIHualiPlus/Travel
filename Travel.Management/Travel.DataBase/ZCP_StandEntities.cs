using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DataBase
{
    class ZCP_StandEntities
    {
        public override int SaveChanges()
        {
            try
            {
                this.ChangeTracker.DetectChanges();
                this.AuditEntity();

                return base.SaveChanges();
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public override Task<int> SaveChangesAsync()
        {
            this.ChangeTracker.DetectChanges();
            this.AuditEntity();

            return base.SaveChangesAsync();
        }

        public override Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            this.ChangeTracker.DetectChanges();
            this.AuditEntity();

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
