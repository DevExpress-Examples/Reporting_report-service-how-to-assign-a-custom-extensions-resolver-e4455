using System;
using System.ComponentModel.Composition;
using DevExpress.XtraReports.Service.Extensions;
using DevExpress.XtraReports.UI;

namespace DXReportServer_Container.Web {
    [Export(typeof(IReportResolver))]
    public class MyReportsResolver : IReportResolver {
        [Import]
        public ITypeResolveService TypeResolveService { get; set; }

        XtraReport IReportResolver.Resolve(string reportName, bool getParameters) {
            var type = TypeResolveService.Resolve(reportName);
            return (XtraReport)Activator.CreateInstance(type);
        }
    }
}