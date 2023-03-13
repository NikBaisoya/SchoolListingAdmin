using Microsoft.Extensions.DependencyInjection;
using SchoolListingAdmin.BusinessObjects.IService;
using SchoolListingAdmin.BusinessObjects.Service;
using SchoolListingAdmin.DataObjects.IRepository;
using SchoolListingAdmin.DataObjects.Repository;

namespace SchoolListingAdmin.DomainModels.Dependency
{
    public static class ServiceDependency
    {

        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUserLoginService), typeof(UserLoginService));
                 services.AddScoped(typeof(ISchoolService), typeof(SchoolService));
        }

        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUserLoginRepository), typeof(UserLoginRepository));
            services.AddScoped(typeof(ISchoolRepository), typeof(SchoolRepository));
        }

    }
}
