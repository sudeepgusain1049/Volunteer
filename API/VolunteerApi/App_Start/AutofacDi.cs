using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Volunteer.Data;
using Volunteer.Data.Repositories;
using VolunteerApi;
using VolunteerApi.DataAccess;
using VolunteerApi.Services;

public class AutofacDI
{
    public static void RegisterIOCContainer(HttpConfiguration configuration)
    {

        var builder = new ContainerBuilder();
        builder.RegisterControllers(Assembly.GetExecutingAssembly());

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsImplementedInterfaces().InstancePerHttpRequest();

        var assymply = Assembly.GetAssembly(typeof(IDependency));

        builder.RegisterAssemblyTypes(assymply)
       .AsImplementedInterfaces().InstancePerHttpRequest();

        builder.RegisterAssemblyTypes(assymply)
            .AsClosedTypesOf(typeof(IRepository<>));

        builder.Register(c => new ApiConsumerRepository(c.Resolve<VolunteerApiDbContext>())).InstancePerHttpRequest();
        builder.Register(c => new ApiTokenManagerRepository(c.Resolve<VolunteerApiDbContext>())).InstancePerHttpRequest();

        //builder.Register(c => new ApiConsumerRepository()).As<IApiConsumerRepository>().InstancePerHttpRequest();
        //builder.Register(c => new STSAuthorization(c.Resolve<ISTSService>()));

        builder.RegisterInstance<IJobService>(new JobService());
        builder.RegisterInstance<IVolunteerService>(new VolunteerService());


        builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        builder.RegisterFilterProvider();

        var container = builder.Build();
        DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        var resolver = new AutofacWebApiDependencyResolver(container);
       
        configuration.DependencyResolver = resolver;

    }
}