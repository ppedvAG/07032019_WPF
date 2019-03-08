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
