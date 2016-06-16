using System.Web.Optimization;
using WebApplication.Constants;

namespace WebApplication
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScriptBundles(bundles);
            RegisterStyleBundles(bundles);
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(ScriptBundlePaths.App)
                .Include(
                    "~/Scripts/App/app.js"
                ));

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
                    "~/Scripts/Lib/JQueryMobile/jquery.mobile*"
                ));

            bundles.Add(new ScriptBundle(ScriptBundlePaths.Modernizr)
                .Include(
                    "~/Scripts/modernizr-*"
                ));

            bundles.Add(new ScriptBundle(ScriptBundlePaths.HomePage)
                .Include(
                    "~/Scripts/App/Controllers/AutomobileController.js",
                    "~/Scripts/App/Controllers/AutomobileEditController.js",
                    "~/Scripts/App/Services/AutomobileService.js"
                ));
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle(StyleBundlePaths.JQueryMobile)
                .Include(
                    "~/Content/Lib/JQueryMobile/jquery.mobile*"
                ));

            bundles.Add(new StyleBundle(StyleBundlePaths.Reset)
                .Include(
                    "~/Content/Lib/Reset/reset.css"
                ));

            bundles.Add(new StyleBundle(StyleBundlePaths.App)
                .Include(
                    "~/Content/App/angular.css",
                    "~/Content/App/app.css"
                ));
        }
    }
}