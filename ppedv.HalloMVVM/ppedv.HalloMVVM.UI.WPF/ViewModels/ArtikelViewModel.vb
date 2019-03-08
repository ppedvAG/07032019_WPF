Imports System.Collections.ObjectModel
Imports ppedv.HalloMVVM.Logic
Imports ppedv.HalloMVVM.Model

Public Class ArtikelViewModel
    Inherits ViewModelBase

    Public Property ArtikelList As ObservableCollection(Of ArtikelItem) = New ObservableCollection(Of ArtikelItem)()

    Private _selectedArtikel As ArtikelItem
    Public Property SelectedArtikel() As ArtikelItem
        Get
            Return _selectedArtikel
        End Get
        Set(ByVal value As ArtikelItem)
            _selectedArtikel = value

            OnPropertyChanged(NameOf(SelectedArtikel))

        End Set
    End Property

    'Public Property Preis() As Decimal
    '    Get
    '        If SelectedArtikel Is Nothing Then
    '            Return -999
    '        End If
    '        Return SelectedArtikel.Preis
    '    End Get
    '    Set(ByVal value As Decimal)
    '        If Not SelectedArtikel Is Nothing Then
    '            SelectedArtikel.Preis = value
    '            OnPropertyChanged(NameOf(Preis))
    '            OnPropertyChanged(NameOf(RabattPreis))
    '            AllPropertiesChanged()
    '        End If
    '    End Set
    'End Property




    Dim core As New Core()

    Sub New()
        ArtikelList = New ObservableCollection(Of ArtikelItem)()
        LoadItems()
    End Sub

    Private Sub LoadItems()
        ArtikelList.Clear()
        For Each item In core.Repository.GetAll(Of Artikel)()
            ArtikelList.Add(New ArtikelItem() With {.Artikel = item})
        Next

    End Sub
End Class

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
