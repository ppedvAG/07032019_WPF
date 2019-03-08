Imports System.Collections.ObjectModel
Imports ppedv.HalloMVVM.Logic
Imports ppedv.HalloMVVM.Model

Public Class ArtikelViewModel
    Inherits ViewModelBase

    Public Property ArtikelList As ObservableCollection(Of Artikel) = New ObservableCollection(Of Artikel)()

    Private _selectedArtikel As Artikel
    Public Property SelectedArtikel() As Artikel
        Get
            Return _selectedArtikel
        End Get
        Set(ByVal value As Artikel)
            _selectedArtikel = value

            OnPropertyChanged(NameOf(SelectedArtikel))
            OnPropertyChanged(NameOf(RabattPreis))

        End Set
    End Property

    Public Property Preis() As Decimal
        Get
            If SelectedArtikel Is Nothing Then
                Return -999
            End If
            Return SelectedArtikel.Preis
        End Get
        Set(ByVal value As Decimal)
            If Not SelectedArtikel Is Nothing Then
                SelectedArtikel.Preis = value
                OnPropertyChanged(NameOf(Preis))
                OnPropertyChanged(NameOf(RabattPreis))
                AllPropertiesChanged()
            End If
        End Set
    End Property


    Public ReadOnly Property RabattPreis As Decimal
        Get
            If SelectedArtikel Is Nothing Then
                Return -999
            End If
            Return SelectedArtikel.Preis * 0.2D
        End Get
    End Property

    Dim core As New Core()

    Sub New()
        ArtikelList = New ObservableCollection(Of Artikel)(core.Repository.GetAll(Of Artikel))
    End Sub


End Class
