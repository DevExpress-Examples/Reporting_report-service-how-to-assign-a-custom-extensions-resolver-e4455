Imports Microsoft.VisualBasic
Imports System

Namespace DXReportServer_Container.Web
	Public Interface ITypeResolveService
		Function Resolve(ByVal typeName As String) As Type
	End Interface
End Namespace
