﻿using System.Web;
using System.Web.Optimization;

namespace QuestionAndAnswerMVC
{
    public class BundleConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

           
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
           
            bundles.Add(new ScriptBundle("~/Kendo").Include
                ("~/Kendo/js/kendo.all.min.js",
               "~/Kendo/js/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Kendo/styles").Include
                ("~/Kendo/styles/kendo.common.min.css",
                "~/Kendo/styles/kendo.default.min.css"));         

            bundles.IgnoreList.Clear();
        }
    }
}
