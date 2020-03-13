Imports System.Web.Mvc

Namespace Controllers
    Public Class test1Controller
        Inherits Controller

        ' GET: test1
        Function Index() As ActionResult
            Return View()
        End Function

        Function TestModel() As ActionResult
            Dim a As New ActionForm1
            a.name = "こんにちは"
            Return View(a)
        End Function
    End Class
End Namespace