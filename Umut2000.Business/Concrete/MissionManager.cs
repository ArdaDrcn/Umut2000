using Umut2000.Entity.Models;
using Umut2000.Business.Abstract;
using Umut2000.DataAccess.Apstract;

namespace Umut2000.Business.Concrete
{
    public class MissionManager : GenericManager<Mission>, IMissionService
    {
        public MissionManager(IGenericDal<Mission> genericdal) : base(genericdal)
        {
        }
    }
}
