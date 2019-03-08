Imports ppedv.HalloMVVM.Model

''' <summary>
''' Todo alles was in die Erfassungsmatrix rein muss, hier als Property hinzufügen
''' </summary>
Public Class ArtikelItem
    Inherits ViewModelBase

    Property Artikel As Artikel

    Public Property Name() As String
        Get
            Return Artikel.Name
        End Get
        Set(ByVal value As String)
            Artikel.Name = value
            OnPropertyChanged(NameOf(ArtikelItem.Name))
        End Set
    End Property

    Public Property Preis() As Decimal
        Get
            Return Artikel.Preis
        End Get
        Set(ByVal value As Decimal)
            Artikel.Preis = value
            OnPropertyChanged(NameOf(ArtikelItem.Preis))
            OnPropertyChanged(NameOf(ArtikelItem.RabattPreis))
        End Set
    End Property


    Public ReadOnly Property RabattPreis As Decimal
        Get
            If Artikel Is Nothing Then
                Return -999
            End If
            Return Artikel.Preis * 0.2D
        End Get
    End Property

End Class
