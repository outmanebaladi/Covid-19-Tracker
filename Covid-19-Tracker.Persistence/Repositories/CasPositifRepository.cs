using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Persistence.Repositories
{
    public class CasPositifRepository : Repository<CasPositif, AppDbContext>, ICasPositifRepository
    {
        public CasPositifRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<CasSuivi>> GetCasSuivis(int id)
        {
            var casPositif = await context.Set<CasPositif>().Include(c => c.CasSuivis).SingleOrDefaultAsync(c => c.Id == id);
            if(casPositif == null)
            {
                return null;
            }
            return casPositif.CasSuivis.ToList();
        }
    }
}
