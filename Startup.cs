using BearerTokenAuthenticationSample.Providers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Security.Claims;
using System.Web.Http;

[assembly: OwinStartup(typeof(ODataService314e.Startup))]

namespace ODataService314e
{
    public class Startup
    {
        public static string googleClientSecret { get; set; }
        public static string googleClientId { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigureAuth(app);
        }
    
        public void ConfigureAuth(IAppBuilder app)
        {
            var googleOAuth2AuthenticationOptions = new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "334351741869-h3j70sdv921u6m4ajghua747orcjoou9.apps.googleusercontent.com",
                ClientSecret = "CkofXYQNvxrcaDVJ318jamXI",
            };

            app.UseGoogleAuthentication(googleOAuth2AuthenticationOptions);
        }
    }
}
