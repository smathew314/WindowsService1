//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System.Data.Services;
using System.Data.Services.Providers;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Linq.Expressions;
using System;
using System.Security;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using OAuth;

namespace ODataService314e
{
    public class ODataService : EntityFrameworkDataService<Entities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

       /* [QueryInterceptor("Appointments")]
        public Expression<Func<Appointment, bool>> OnQueryAppointments()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return a => true;
            }

            return a => false;
        }*/

        protected override void OnStartProcessingRequest(ProcessRequestArgs args)
        {
            /*if (!Authenticate(WebOperationContext.Current.IncomingRequest))
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
                throw new UnauthorizedAccessException();
            }*/
            OAuthHelper authHelper = new OAuthHelper();
            authHelper.doOAuth();
            base.OnStartProcessingRequest(args);
        }

        private static bool Authenticate(IncomingWebRequestContext context)
        {
            bool Authenticated = false;
            string normalizedUrl;
            string normalizedRequestParameters;
            //context.Headers
            NameValueCollection pa = context.UriTemplateMatch.QueryParameters;
            if (pa != null && pa["oauth_consumer_key"] != null)
            {
                // to get uri without oauth parameters
                string uri = context.UriTemplateMatch.RequestUri.OriginalString.Replace
                    (context.UriTemplateMatch.RequestUri.Query, "");
                string consumersecret = "314eCorp";
                OAuthBase oauth = new OAuthBase();
                uri = "http://2e3fe764.ngrok.io";
                string hash = oauth.GenerateSignature(
                    new Uri(uri),
                    pa["oauth_consumer_key"],
                    consumersecret,
                    null, // totken
                    null, //token secret
                    "GET",
                    pa["oauth_timestamp"],
                    pa["oauth_nonce"],
                    out normalizedUrl,
                    out normalizedRequestParameters
                    );
                Authenticated = pa["oauth_signature"] == hash;
            }
            return Authenticated;
        }
    }
}
