Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.Composition
Imports DevExpress.XtraReports.Service.Extensions
Imports DevExpress.XtraReports.UI

Namespace DXReportServer_Container.Web
	<Export(GetType(IReportResolver))> _
	Public Class MyReportsResolver
		Implements IReportResolver
		Private privateTypeResolveService As ITypeResolveService
		<Import> _
		Public Property TypeResolveService() As ITypeResolveService
			Get
				Return privateTypeResolveService
			End Get
			Set(ByVal value As ITypeResolveService)
				privateTypeResolveService = value
			End Set
		End Property

		Private Function IReportResolver_Resolve(ByVal reportName As String, ByVal getParameters As Boolean) As XtraReport Implements IReportResolver.Resolve
			Dim type = TypeResolveService.Resolve(reportName)
			Return CType(Activator.CreateInstance(type), XtraReport)
		End Function
	End Class
End Namespace