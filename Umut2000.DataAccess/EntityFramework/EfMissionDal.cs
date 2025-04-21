using Umut2000.DataAccess.Apstract;
using Umut2000.DataAccess.Context;
using Umut2000.DataAccess.Repositories;
using Umut2000.Entity.Models;

namespace Umut2000.DataAccess.EntityFramework
{
    internal class EfMissionDal : GenericRepository<Mission>, IMissionDal
    {
        public EfMissionDal(UmutContext context) : base(context)
        {
        }
    }
}
