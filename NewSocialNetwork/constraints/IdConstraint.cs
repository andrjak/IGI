﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSocialNetwork.constraints
{
    public class IdConstraint : IRouteConstraint
    {
        private string uri;
        public IdConstraint(string uri)
        {
            this.uri = uri;
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey,
                RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !(uri == httpContext.Request.Path);
        }
    }
}
