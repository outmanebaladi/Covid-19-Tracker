using Covid_19_Tracker.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Covid_19_Tracker.Persistence.Repositories.Interfaces.IRepository;

namespace Covid_19_Tracker.Persistence.Repositories.Interfaces
{
	public interface ICasSuiviRepository : IRepository<CasSuivi>
	{
		Task<List<FicheSuivi>> GetFichesSuivi(int id);
	}
}
