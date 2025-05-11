using MongoDB.Bson;
using System.Linq.Expressions;
using Umut2000.Business.Abstract;
using Umut2000.DataAccess.Apstract;
using Umut2000.Entity.Models;

namespace Umut2000.Business.Concrete
{
    public class UmutUserManager : GenericManager<UmutUser>, IUmutUserService
    {
        public UmutUserManager(IGenericDal<UmutUser> genericdal) : base(genericdal)
        {
        }
    }
}
