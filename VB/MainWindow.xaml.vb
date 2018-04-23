Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class StringsSource
		Inherits System.Windows.Markup.MarkupExtension
		Public Sub New()
		End Sub
		Private count As Integer = 0
		Public Sub New(ByVal count As Integer)
			Me.count = count
		End Sub
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Dim list As New List(Of String)()
			For i As Integer = 0 To count - 1
				list.Add("item " & i)
			Next i
			Return list
		End Function
	End Class
End Namespace
