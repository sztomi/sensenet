﻿using System;
using System.Web;

namespace SenseNet.TokenAuthentication
{
    public static class CookieHelper
    {
        public static void InsertSecureCookie(HttpResponseBase response, string token, string cookieName, DateTime expiration)
        {
            var authCookie = new HttpCookie(cookieName, token);
            authCookie.HttpOnly = true;
            authCookie.Secure = true;
            authCookie.Expires = expiration;
            response.Cookies.Add(authCookie);
        }

        public static HttpCookie GetCookie(HttpRequestBase request, string cookieName)
        {
            return request.Cookies[cookieName];
        }
    }
}