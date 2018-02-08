Imports System.Collections.ObjectModel
Imports System.Windows.Input
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm

Public Class Kontakt
    Inherits MvvmViewModelBase

    Private myID As Guid
    Private myFirstname As String
    Private myLastname As String
    Private myDateOfBirth As DateTimeOffset?

    <MvvmViewModelInclude>
    Public Property ID As Guid
        Get
            Return myID
        End Get
        Set(value As Guid)
            SetProperty(myID, value)
        End Set
    End Property

    Public Property Firstname As String
        Get
            Return myFirstname
        End Get
        Set(value As String)
            SetProperty(myFirstname, value)
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return myLastname
        End Get
        Set(value As String)
            SetProperty(myLastname, value)
        End Set
    End Property

    <MvvmViewModelInclude>
    Public Property DateOfBirth As DateTimeOffset?
        Get
            Return myDateOfBirth
        End Get
        Set(value As DateTimeOffset?)
            SetProperty(myDateOfBirth, value)
        End Set
    End Property

    Public Shared Function SampleRecords() As ObservableCollection(Of Kontakt)

        Dim collectionToReturn As New ObservableCollection(Of Kontakt)
        collectionToReturn.Add(New Kontakt With {.ID = Guid.NewGuid, .Firstname = "Adriana", .Lastname = "Löffelmann", .DateOfBirth = #1978-10-13#})
        collectionToReturn.Add(New Kontakt With {.ID = Guid.NewGuid, .Firstname = "Stephan", .Lastname = "Urgien", .DateOfBirth = #1969-07-24#})
        collectionToReturn.Add(New Kontakt With {.ID = Guid.NewGuid, .Firstname = "Andreas", .Lastname = "Belke", .DateOfBirth = #1985-11-1#})
        collectionToReturn.Add(New Kontakt With {.ID = Guid.NewGuid, .Firstname = "Rosenau", .Lastname = "Daniel", .DateOfBirth = #1990-2-1#})
        collectionToReturn.Add(New Kontakt With {.ID = Guid.NewGuid, .Firstname = "Grottendieck", .Lastname = "Guido", .DateOfBirth = #1968-10-22#})
        Return collectionToReturn

    End Function

End Class
