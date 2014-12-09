using System.Web;
using System.Web.Optimization;

namespace Volunteer.UI.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryDD").Include(
                        "~/Scripts/jquery.dd.js", "~/Scripts/Layout.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css","~/Content/dd.css", "~/Content/font-awesome/font-awesome.css"));
            
            //to include date picker css and js
            bundles.Add(new StyleBundle("~/Content/datePickerCss").Include("~/Content/datePicker/bootstrap-datetimepicker.min.css"));
            bundles.Add(new ScriptBundle("~/bundles/datePickerJs").Include("~/Scripts/datePicker/moment.min.js", "~/Scripts/datePicker/bootstrap-datetimepicker.min.js"));

            //to include typeAhead
            bundles.Add(new StyleBundle("~/Content/typeAheadCSS").Include("~/Content/typeAhead/bootstrap-tagsinput.css"));
            bundles.Add(new ScriptBundle("~/bundles/typeAheadJS").Include("~/Scripts/typeAhead/bootstrap.taginput.js", "~/Scripts/typeAhead/bootstrap3-typeahead.js", "~/Scripts/typeAhead/jasny-bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css", 
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/postjobJs").Include("~/Scripts/VolunteerApp/Job/postjob/control.js", "~/Scripts/VolunteerApp/Job/postjob/validations.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap/bootstrap.css", "~/Content/bootstrap/bootstrap.min.css", "~/Content/bootstrap/bootstrap-responsive.css"));
            bundles.IgnoreList.Clear();
        }
    }
}