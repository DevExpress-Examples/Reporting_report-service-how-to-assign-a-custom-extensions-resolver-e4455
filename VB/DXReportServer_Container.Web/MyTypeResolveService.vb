Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.Composition
Imports System.Reflection

Namespace DXReportServer_Container.Web
	<Export(GetType(ITypeResolveService))> _
	Public Class MyTypeResolveService
		Implements ITypeResolveService
		Private Shared ReadOnly CurrentAssembly As System.Reflection.Assembly = GetType(MyTypeResolveService).Assembly

		Private Function ITypeResolveService_Resolve(ByVal typeName As String) As Type Implements ITypeResolveService.Resolve
			If typeName.Contains(",") Then
				Return Type.GetType(typeName)
			End If
			Return CurrentAssembly.GetType(typeName)
		End Function
	End Class
End Namespace
