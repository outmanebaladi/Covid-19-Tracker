using Covid_19_Tracker.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Covid_19_Tracker.Persistence.Repositories.Interfaces.IRepository;

namespace Covid_19_Tracker.Persistence.Repositories.Interfaces
{
	public interface ICasPositifRepository : IRepository<CasPositif>
	{
		Task<List<CasSuivi>> GetCasSuivis(int id);
	}
}
