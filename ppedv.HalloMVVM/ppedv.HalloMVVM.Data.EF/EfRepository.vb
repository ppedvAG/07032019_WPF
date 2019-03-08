Imports ppedv.HalloMVVM.Model

Public Class EfRepository
    Implements IRepository

    Dim con As New EfContext()

    Public Sub Add(Of T As Entity)(entity As T) Implements IRepository.Add
        con.Set(Of T)().Add(entity)
    End Sub

    Public Sub Delete(Of T As Entity)(entity As T) Implements IRepository.Delete
        con.Set(Of T)().Remove(entity)
    End Sub

    Public Sub Update(Of T As Entity)(entity As T) Implements IRepository.Update
        'nur für "Disconnected access" wie WCF,ASP...
        'wird nicht für desktop WinForms oder WPF benötigt
        Dim loaded = GetById(Of T)(entity.Id)
        If Not loaded Is Nothing Then
            con.Entry(loaded).CurrentValues.SetValues(entity)
        End If
    End Sub

    Public Sub SaveAll() Implements IRepository.SaveAll
        con.SaveChanges()
    End Sub

    Public Function GetAll(Of T As Entity)() As IEnumerable(Of T) Implements IRepository.GetAll
        Return con.Set(Of T)().ToList()
    End Function

    Public Function GetById(Of T As Entity)(id As Integer) As T Implements IRepository.GetById
        Return con.Set(Of T)().Find(id)
    End Function

    Public Function Query(Of T As Entity)() As IQueryable(Of T) Implements IRepository.Query
        Return con.Set(Of T)()
    End Function
End Class
