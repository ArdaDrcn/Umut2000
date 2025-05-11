using Umut2000.Business.Abstract;
using Umut2000.Business.Concrete;
using Umut2000.DataAccess.Apstract;
using Umut2000.DataAccess.EntityFramework;
using Umut2000.DataAccess.Repositories;

namespace Umut2000.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection Services)
        {
            Services.AddScoped<IUmutUserDal, EfUmutUserDal>();
            Services.AddScoped<IUmutUserService, UmutUserManager>();

            Services.AddScoped<IMissionDal, EfMissionDal>();
            Services.AddScoped<IMissionService, MissionManager>();

            Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }
    }
}
