using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Persistence.Repositories
{
    public class CasSuiviRepository : Repository<CasSuivi, AppDbContext>, ICasSuiviRepository
    {
        public CasSuiviRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<FicheSuivi>> GetFichesSuivi(int id)
        {
            var casPositif = await context.Set<CasSuivi>().Include(c => c.FichesSuivi).SingleOrDefaultAsync(c => c.Id == id);
            if (casPositif == null)
            {
                return null;
            }
            return casPositif.FichesSuivi.ToList();
        }
    }
}
