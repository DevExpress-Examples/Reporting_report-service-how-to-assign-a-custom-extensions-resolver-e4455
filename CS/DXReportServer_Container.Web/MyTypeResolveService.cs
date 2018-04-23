using System;
using System.ComponentModel.Composition;
using System.Reflection;

namespace DXReportServer_Container.Web {
    [Export(typeof(ITypeResolveService))]
    public class MyTypeResolveService : ITypeResolveService {
        static readonly Assembly CurrentAssembly = typeof(MyTypeResolveService).Assembly;

        Type ITypeResolveService.Resolve(string typeName) {
            if(typeName.Contains(",")) {
                return Type.GetType(typeName);
            }
            return CurrentAssembly.GetType(typeName);
        }
    }
}
