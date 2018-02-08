Imports MvvmFormsDemoViewModelLib

Public Class Form1

    Private myMainViewModel As MainViewModel

    Private Sub Form1_Load(sender As Object,
                           e As EventArgs) Handles MyBase.Load

        myMainViewModel = New MainViewModel With {
                .KontaktListe = Kontakt.SampleRecords
        }

        MvvmManager1.DataContext = myMainViewModel

    End Sub
End Class
