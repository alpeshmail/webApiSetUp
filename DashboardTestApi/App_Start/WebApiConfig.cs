using DashboardTestApi.App_Start;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DashboardTestApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API configuration and services
            //enable X-domain request for all controllers.
            //This should be refined later on to allow only from Ipreo networks
            //var allowedHost = ConfigurationManager.AppSettings["AllowedDomain"];
            var cors = new EnableCorsAttribute("*", "*", "*") {SupportsCredentials = true};

            config.EnableCors(cors);
            // Web API routes (webApi 2.0)

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = config.Formatters.JsonFormatter;

            json.SerializerSettings.Formatting = Formatting.Indented;
            json.SerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //config.Services.Add(typeof(IExceptionLogger), new GlobalExceptionLogger());
            //config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());

            //var jsonFormatter = new JsonMediaTypeFormatter();
            ////optional: set serializer settings here
            //config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
        }
    }
}
