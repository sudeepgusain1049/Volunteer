using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Application;
using Swashbuckle.Swagger;
using VolunteerApi;
using VolunteerApi.Filters;
using WebActivatorEx;
using Volunteer.Data.Models;
using System.Collections.Generic;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace VolunteerApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            Swashbuckle.Bootstrapper.Init(GlobalConfiguration.Configuration);


            // NOTE: If you want to customize the generated swagger or UI, use SwaggerSpecConfig and/or SwaggerUiConfig here ...
            SwaggerSpecConfig.Customize(c =>
            {
                c.ResolveTargetVersionUsing((req) => "2.0");
                c.IncludeXmlComments(GetXmlCommentsPath());
                c.OperationFilter<AddStandardResponseCodes>();
                c.OperationFilter<AddAuthorizationResponseCodes>();
                c.GroupDeclarationsBy(o=>o.ActionDescriptor.ControllerDescriptor.ControllerName);
            });

            SwaggerUiConfig.Customize(u =>
            {
                //u.InjectJavaScript(typeof(SwaggerConfig).Assembly, "VolunteerApi.SwaggerExtensions.onComplete.js");
                u.InjectStylesheet(typeof(SwaggerConfig).Assembly, "onComplete.css");
                u.InjectJavaScript(typeof(SwaggerConfig).Assembly, "onComplete.js");
            });
        }
        
        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\VolunteerApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }

}

public class AddStandardResponseCodes : IOperationFilter
{
    public void Apply(Operation operation, DataTypeRegistry dataTypeRegistry, ApiDescription apiDescription)
    {
        operation.ResponseMessages.Add(new ResponseMessage
        {
            Code = (int)HttpStatusCode.OK,
            Message = "It's all good!"
        });

        operation.ResponseMessages.Add(new ResponseMessage
        {
            Code = (int)HttpStatusCode.Unauthorized,
            Message = "Token is not sufficient!"
        });
    }
}

public class AddAuthorizationResponseCodes : IOperationFilter
{
    public void Apply(Operation operation, DataTypeRegistry dataTypeRegistry, ApiDescription apiDescription)
    {
        if (apiDescription.ActionDescriptor.GetFilters().OfType<AuthorizeAttribute>().Any())
        {
            operation.ResponseMessages.Add(new ResponseMessage
            {
                Code = (int)HttpStatusCode.Unauthorized,
                Message = "Authentication required"
            });
        }
    }
}
