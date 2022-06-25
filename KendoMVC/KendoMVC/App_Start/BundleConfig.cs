using System.Web;
using System.Web.Optimization;

namespace KendoMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles.Add(new ScriptBundle("~/bundles/Kendo/js").Include(
                    "~/Kendo/js/jquery.min.js",
                    "~/Kendo/js/kendo.all.min.js",
                    "~/Kendo/js/kendo.aspnetmvc.min.js"
                ));
           
            bundles.Add(new StyleBundle("~/Kendo/styles").Include("~/Kendo/styles/kendo.common.min.css",
               "~/Kendo/styles/kendo.default.min.css"));
           
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.IgnoreList.Clear();
        }
    }
}
