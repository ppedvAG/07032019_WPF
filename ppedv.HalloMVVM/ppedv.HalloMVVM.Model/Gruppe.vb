Public Class Gruppe
    Inherits Entity

    Property Name As String
    Property Kürzel As String

    Overridable Property Artikel As New HashSet(Of Artikel)
End Class
