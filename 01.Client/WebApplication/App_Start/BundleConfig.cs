using System.Web.Optimization;
using WebApplication.Constants;

namespace WebApplication
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(ScriptBundlePaths.Angular)
                .Include(
                    "~/Scripts/Lib/Angular/angular.*"
                ));

            bundles.Add(new ScriptBundle(ScriptBundlePaths.JQuery)
                .Include(
                    "~/Scripts/Lib/JQuery/jquery-{version}.js",
                    "~/Scripts/Lib/JQuery/jquery.*",
                    "~/Scripts/Lib/JQuery/jquery-ui-{version}.js")
                );

            bundles.Add(new ScriptBundle(ScriptBundlePaths.JQueryMobile)
                .Include(
                    "~/Scripts/Lib/JQueryMobile*.*"
                ));

            bundles.Add(new ScriptBundle(ScriptBundlePaths.Modernizer)
                .Include(
                    "~/Scripts/modernizr-*"
                ));

            bundles.Add(new StyleBundle(StyleBundlePaths.JQueryMobile)
                .Include(
                    "~/Content/Lib/JQueryMobile/jquery.mobile.*.css"
             ));
        }
    }
}