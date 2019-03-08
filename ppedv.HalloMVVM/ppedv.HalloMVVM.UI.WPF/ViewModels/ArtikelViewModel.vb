Imports System.Collections.ObjectModel
Imports ppedv.HalloMVVM.Logic
Imports ppedv.HalloMVVM.Model

Public Class ArtikelViewModel

    Public Property ArtikelList As ObservableCollection(Of Artikel) = New ObservableCollection(Of Artikel)()

    Public Property SelectedArtikel As Artikel

    Dim core As New Core()

    Sub New()
        ArtikelList = New ObservableCollection(Of Artikel)(core.Repository.GetAll(Of Artikel))
    End Sub


End Class
