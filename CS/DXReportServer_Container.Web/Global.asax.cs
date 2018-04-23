using System;
using System.ComponentModel.Composition.Hosting;
using DevExpress.Xpf.Printing.Service;
using DevExpress.XtraReports.Service.Extensions;

namespace DXReportServer_Container.Web {
    public class Global : System.Web.HttpApplication {
        static readonly CompositionContainer container;

        static Global() {
            var catalog = new TypeCatalog(typeof(MyReportsResolver), typeof(MyTypeResolveService));
            container = new CompositionContainer(catalog);
        }

        protected void Application_Start(object sender, EventArgs e) {
            DevExpress.XtraReports.Service.ReportServiceExtensionsResolver.SetResolver(new MefExtensionsResolver(container));
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}