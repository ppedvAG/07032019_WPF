Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ppedv.HalloMVVM.Model

<TestClass()>
Public Class EfContextTests

    <TestMethod>
    Public Sub EfContext_Can_Create_DB()

        Using con As New EfContext()
            If con.Database.Exists() Then
                con.Database.Delete()
            End If

            Assert.IsFalse(con.Database.Exists())
            con.Database.Create()
            Assert.IsTrue(con.Database.Exists())
        End Using

    End Sub


    <TestMethod>
    Public Sub EfContext_Can_CRUD_Artikel()

        Dim art As New Artikel()
        art.Name = "TestArtikel"

        Using con As New EfContext()
            con.Artikel.Add(art)
            con.SaveChanges()
        End Using
    End Sub


    <TestMethod()>
    Public Sub Calc_Sum_5_and_7_results_12()

        Dim a As Integer = 5
        Dim b As Integer = 7

        Dim result = a + b

        Assert.AreEqual(12, result)

    End Sub

End Class