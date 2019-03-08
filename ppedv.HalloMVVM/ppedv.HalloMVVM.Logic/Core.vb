Imports ppedv.HalloMVVM.Model

Public Class Core
    ReadOnly Property Repository As IRepository

    Sub New(repo As IRepository) 'do Dependency Injection in here
        Repository = repo
    End Sub

    Sub New()
        Me.New(New Data.EF.EfRepository())
    End Sub

    Function TolleBusinessRelevanteFuntion() As IEnumerable(Of Artikel)
        'todo
        'z.b. sage call 
    End Function

End Class
