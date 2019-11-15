using System.Web;
using System.Web.Optimization;

namespace Footwear
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/style.css",
                "~/Content/css/megamenu.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Content/js/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Content/js/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/megamenu").Include("~/Content/js/megamenu.js"));
            bundles.Add(new ScriptBundle("~/bundles/movetop").Include("~/Content/js/move-top.js"));
            bundles.Add(new ScriptBundle("~/bundles/easing").Include("~/Content/js/easing.js"));
            bundles.Add(new ScriptBundle("~/bundles/wmuSlider").Include("~/Content/js/jquery.wmuSlider.js"));

            bundles.Add(new ScriptBundle("~/bundles/index").Include("~/Content/script/index.js"));
            bundles.Add(new ScriptBundle("~/bundles/main").Include("~/Content/script/main.js"));

        }
    }
}
