using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Persistence.Repositories.Interfaces;

namespace Covid_19_Tracker.Persistence.Repositories
{
    public class CasSuiviRepository : Repository<CasSuivi, AppDbContext>, ICasSuiviRepository
    {
        public CasSuiviRepository(AppDbContext context) : base(context)
        {
        }
    }
}
