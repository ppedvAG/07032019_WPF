Public Class Artikel
    Inherits Entity

    Property Name As String
    Property Preis As Decimal
    Property HerstellDatum As Date
    Overridable Property Gruppe As Gruppe 'overridable für LazyLoading
    Overridable Property Kategorie As New HashSet(Of Kategorie)
End Class
