Public Class Kategorie
    Inherits Entity

    Property Name As String

    Overridable Property Artikel As New HashSet(Of Artikel)

End Class
