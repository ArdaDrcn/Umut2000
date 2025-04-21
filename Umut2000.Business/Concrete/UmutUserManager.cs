using MongoDB.Bson;
using System.Linq.Expressions;
using Umut2000.Business.Abstract;
using Umut2000.DataAccess.Apstract;
using Umut2000.Entity.Models;

namespace Umut2000.Business.Concrete
{
    public class UmutUserManager : IUmutUserService
    {
        private readonly IUmutUserDal _umutUserDal;

        public UmutUserManager(IUmutUserDal umutUserDal)
        {
            _umutUserDal = umutUserDal;
        }

        public async Task<int> TCountAsync()
        {
            return await _umutUserDal.CountAsync();
        }

        public async Task TCreateAsync(UmutUser entity)
        {
            await _umutUserDal.CreateAsync(entity);
        }

        public async Task TDeleteAsync(ObjectId id)
        {
            await _umutUserDal.DeleteAsync(id);
        }

        public async Task<UmutUser> TGetByIdAsync(ObjectId id)
        {
            return await _umutUserDal.GetByIdAsync(id);
        }

        public async Task<List<UmutUser>> TGetFilteredListAsync(Expression<Func<UmutUser, bool>> predicate)
        {
            return await _umutUserDal.GetFilteredListAsync(predicate);
        }

        public async Task<List<UmutUser>> TGetListAsync()
        {
            return await _umutUserDal.GetListAsync();
        }

        public async Task TUpdateAsync(UmutUser entity)
        {
            await _umutUserDal.UpdateAsync(entity);
        }
    }
}
