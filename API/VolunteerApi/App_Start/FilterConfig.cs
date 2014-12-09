using System.Web;
using System.Web.Mvc;
using VolunteerApi.Filters;
using VolunteerApi.Services;

namespace VolunteerApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new VolunteerAuthorization(DependencyResolver.Current.GetService<IVolunteerService>()));
        }
    }
}