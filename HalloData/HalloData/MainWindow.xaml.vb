
Imports System.ComponentModel

Class MainWindow

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim daten As New BindingList(Of Artikel)
        For i = 1 To 100
            '.Name = "Artikel #" + i.ToString("000"),
            '.Name = String.Format("Artikel #{0:00} {1}", i, Date.Now),

            daten.Add(New Artikel() With {
                         .Name = $"Artikel #{i:000}",
                         .Preis = i * 3.46D,
                         .HerstellDatum = Date.Now.AddMonths(i * -1).AddDays(i * 17),
                         .Verfügbar = i Mod 2 = 0
            })
        Next

        lb.ItemsSource = daten
    End Sub

    Public Class Artikel
        Public Property Name As String
        Public Property Verfügbar As Boolean
        Public Property HerstellDatum As Date
        Public Property Preis As Decimal
    End Class

End Class
