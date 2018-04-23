using System;

namespace DXReportServer_Container.Web {
    public interface ITypeResolveService {
        Type Resolve(string typeName);
    }
}
