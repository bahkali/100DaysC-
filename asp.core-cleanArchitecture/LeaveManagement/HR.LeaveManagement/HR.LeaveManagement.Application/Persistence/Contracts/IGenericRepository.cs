using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        /*
         * @param: id of item
         * @return:
         */
        Task<T> Get(int id);

        /* 
         * @return: get all the data in readonlyList
         */
        Task<IReadOnlyList<T>> GetAll();
        /*
         * @param item
         */
        Task<T> Add(T entity);

        /*
         * @param item
         */
        Task<T> Update(T entity);

        /*
         * @param item
         */
        Task<T> Delete(T entity);
    }
}
