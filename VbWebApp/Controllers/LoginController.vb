Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        <HttpGet()>
        Function Index() As ActionResult
            Return View(New login())
        End Function

        <HttpPost()>
        Function Index(info As login) As ActionResult
            Return View("Index", New login())
        End Function


    End Class
End Namespace