using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EntityHelpers.Classes
{
    /// <summary>
    /// SaveChangesInterceptor interceptor which in it's current state
    /// has commented out code which works, provides alternate possibilities
    ///
    /// Objective here is to assert for Region property equal to specific value
    /// and if so reject the save.
    /// </summary>
    public class LoggingSavingChangesInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = new())
        {

            if (InspectCustomerRegion(eventData.Context.ChangeTracker.Entries()))
            {
                result = InterceptionResult<int>.SuppressWithResult(0);
            }

            return new ValueTask<InterceptionResult<int>>(result);
        }

        private static bool InspectCustomerRegion(IEnumerable<EntityEntry> entries)
        {
            foreach (EntityEntry entry in entries)
            {
                if (entry.State != EntityState.Modified) continue;
                if (entry.Entity is not Customer customer) continue;

                /*
                 * Here we are asserting for a single condition
                 * What makes more sense is to use data annotations and
                 * not perform assertion in an override of SaveChanges using
                 * this interceptor
                 */
                if (customer.Region == "KP")
                {
                    return true;
                }

            }

            return false;
        }
    }
}