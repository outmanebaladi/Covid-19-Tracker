using Covid_19_Tracker.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Persistence.Repositories.Interfaces
{
	public interface IRepository
	{
        public interface IRepository<T> where T : class, IEntity
        {
            Task<List<T>> GetAll();
            Task<T> Get(int id);
            Task<T> Add(T entity);
            Task<T> Update(T entity);
            Task<T> Delete(int id);
            Task<bool> Any(int id);
        }
    }
}
