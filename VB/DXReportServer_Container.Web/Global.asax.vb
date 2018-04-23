Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.Composition.Hosting
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service.Extensions

Namespace DXReportServer_Container.Web
	Public Class [Global]
		Inherits System.Web.HttpApplication
		Private Shared ReadOnly container As CompositionContainer

		Shared Sub New()
			Dim catalog = New TypeCatalog(GetType(MyReportsResolver), GetType(MyTypeResolveService))
			container = New CompositionContainer(catalog)
		End Sub

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			DevExpress.XtraReports.Service.ReportServiceExtensionsResolver.SetResolver(New MefExtensionsResolver(container))
		End Sub

		Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace