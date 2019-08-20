using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RandomNumber.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // Permettre le Cross-Origin Resource Sharing entre la couche Web API et les appelants d'APPUI.
            var origins = ConfigurationManager.AppSettings["CorsOrigins"];
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*") { SupportsCredentials = true };
            config.EnableCors(cors);
        }
    }
}
