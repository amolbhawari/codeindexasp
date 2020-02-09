Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Welcome") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("This is production server") = "Your contact page."

        Return View()
    End Function
End Class
