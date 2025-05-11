using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Umut2000.Business.Abstract;
using Umut2000.DataAccess.Apstract;

namespace Umut2000.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericdal;

        public GenericManager(IGenericDal<T> genericdal)
        {
            _genericdal = genericdal;
        }

        public async Task<int> TCountAsync()
        {
            return await _genericdal.CountAsync();
        }

        public async Task TCreateAsync(T entity)
        {
            await _genericdal.CreateAsync(entity);
        }

        public async Task TDeleteAsync(ObjectId id)
        {
            await _genericdal.DeleteAsync(id);
        }

        public async Task<T> TGetByIdAsync(ObjectId id)
        {
            return await _genericdal.GetByIdAsync(id);
        }

        public async Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate)
        {
            return await _genericdal.GetFilteredListAsync(predicate);
        }

        public async Task<List<T>> TGetListAsync()
        {
            return await _genericdal.GetListAsync();
        }

        public async Task TUpdateAsync(T entity)
        {
            await _genericdal.UpdateAsync(entity);
        }
    }
}
