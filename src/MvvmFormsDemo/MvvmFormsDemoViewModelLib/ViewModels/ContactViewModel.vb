Imports System.Collections.ObjectModel
Imports System.Net
Imports System.Net.Http
Imports System.Windows.Input
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports DataLayer
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ContactViewModel
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

    Public Shared Function SampleRecords() As ObservableCollection(Of ContactViewModel)

        Dim collectionToReturn As New ObservableCollection(Of ContactViewModel)
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .Firstname = "Adriana", .Lastname = "Löffelmann", .DateOfBirth = #1978-10-13#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .Firstname = "Stephan", .Lastname = "Urgien", .DateOfBirth = #1969-07-24#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .Firstname = "Andreas", .Lastname = "Belke", .DateOfBirth = #1985-11-1#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .Firstname = "Rosenau", .Lastname = "Daniel", .DateOfBirth = #1990-2-1#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .Firstname = "Grottendieck", .Lastname = "Guido", .DateOfBirth = #1968-10-22#})
        Return collectionToReturn
    End Function

    Public Shared Async Function GetContactAsync(guid As Guid) As Task(Of ContactViewModel)

        Dim url = MainViewModel.WEBAPI_URL
        Dim response = Await MainViewModel.HttpClient.GetAsync($"{url}/contacts/{guid.ToString}")
        If response.StatusCode = HttpStatusCode.OK Then
            Dim responseContent = Await response.Content.ReadAsStringAsync()

        End If

        Return New ContactViewModel

    End Function

    Public Shared Async Function GetContactsAsync() As Task(Of ObservableCollection(Of ContactViewModel))
        Dim url = MainViewModel.WEBAPI_URL
        Dim response = Await MainViewModel.HttpClient.GetAsync($"{url}/contacts")
        Dim vmsToReturn As ObservableCollection(Of ContactViewModel) = Nothing

        If response.StatusCode = HttpStatusCode.OK Then
            Dim responseContent = Await response.Content.ReadAsStringAsync()
            'TODO: Deserialize JSON
            Dim contactList = JsonConvert.DeserializeObject(Of List(Of Contact))(responseContent)
            vmsToReturn = New ObservableCollection(Of ContactViewModel)(
                          From item In contactList
                          Select New ContactViewModel With
                               {.ID = item.ID,
                                .Lastname = item.LastName,
                                .Firstname = item.FirstName,
                                .DateOfBirth = item.DateOfBirth})
        End If

        Return vmsToReturn

    End Function

    Public Shared Async Function PutContactAsync(contact As Contact) As Task(Of HttpStatusCode)

        Dim url = MainViewModel.WEBAPI_URL
        Dim parameters = New Dictionary(Of String, String) From
        {
            {"param1", "1"}
        }

        Dim encodedContent = New FormUrlEncodedContent(parameters)

        Dim response = Await MainViewModel.HttpClient.GetAsync(url).ConfigureAwait(False)
        Return response.StatusCode

    End Function

End Class
