﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace upload.Controllers
{
    public static class HtmlHelperDis
    {
        public static string Image(this HtmlHelper helper, string name, string url)
        {
            return Image(helper, name, url, null);
        }
        public static string Image(this HtmlHelper helper, string name, string url, object htmlAttributes)
        {
            var tagBuilder = new TagBuilder("img");
            tagBuilder.GenerateId(name);
            tagBuilder.Attributes["src"] = new UrlHelper(helper.ViewContext.RequestContext).Content(url);
            tagBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return tagBuilder.ToString();

        }
    }
}