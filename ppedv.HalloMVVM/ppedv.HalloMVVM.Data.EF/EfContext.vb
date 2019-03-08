Imports System.Data.Entity
Imports ppedv.HalloMVVM.Model

'msdn.com/data/ef <--- Anleitung
Public Class EfContext
    Inherits DbContext

    Property Artikel As DbSet(Of Artikel)
    Property Kategorien As DbSet(Of Kategorie)
    Property Gruppen As DbSet(Of Gruppe)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention)()

        modelBuilder.Properties(Of DateTime).Configure(Sub(c) c.HasColumnType("datetime2"))
    End Sub

    Sub New(conString As String)
        MyBase.New(conString)
    End Sub

    Sub New()
        Me.New("Server=.;Database=HalloMVVM;Trusted_Connection=true")
    End Sub

End Class
