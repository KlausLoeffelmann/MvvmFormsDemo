Imports System.Collections.ObjectModel
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Windows.Input
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports DataLayer
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ContactViewModel
    Inherits MvvmViewModelBase

    Private myID As Guid
    Private myFirstName As String
    Private myLastName As String
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

    Public Property FirstName As String
        Get
            Return myFirstName
        End Get
        Set(value As String)
            SetProperty(myFirstName, value)
        End Set
    End Property

    Public Property LastName As String
        Get
            Return myLastName
        End Get
        Set(value As String)
            SetProperty(myLastName, value)
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
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .FirstName = "Adriana", .LastName = "Löffelmann", .DateOfBirth = #1978-10-13#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .FirstName = "Stephan", .LastName = "Urgien", .DateOfBirth = #1969-07-24#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .FirstName = "Andreas", .LastName = "Belke", .DateOfBirth = #1985-11-1#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .FirstName = "Rosenau", .LastName = "Daniel", .DateOfBirth = #1990-2-1#})
        collectionToReturn.Add(New ContactViewModel With {.ID = Guid.NewGuid, .FirstName = "Grottendieck", .LastName = "Guido", .DateOfBirth = #1968-10-22#})
        Return collectionToReturn
    End Function

    ''' <summary>
    ''' GET one spacific contact from the WebAPI.
    ''' </summary>
    ''' <param name="guid"></param>
    ''' <returns></returns>
    Public Shared Async Function GetContactAsync(guid As Guid) As Task(Of ContactViewModel)

        Dim url = MainViewModel.WEBAPI_URL
        Dim response = Await MainViewModel.HttpClient.GetAsync($"{url}/contacts/{guid.ToString}")
        If response.StatusCode = HttpStatusCode.OK Then
            Dim responseContent = Await response.Content.ReadAsStringAsync()

        End If

        Return New ContactViewModel

    End Function

    ''' <summary>
    ''' GETs all contacts from the WebAPI
    ''' </summary>
    ''' <returns></returns>
    Public Shared Async Function GetContactsAsync() As Task(Of ObservableCollection(Of ContactViewModel))
        Dim url = MainViewModel.WEBAPI_URL
        Dim response = Await MainViewModel.HttpClient.GetAsync($"{url}/contacts")
        Dim vmsToReturn As ObservableCollection(Of ContactViewModel) = Nothing

        If response.StatusCode = HttpStatusCode.OK Then
            Dim responseContent = Await response.Content.ReadAsStringAsync()

            Dim contactList = JsonConvert.DeserializeObject(Of List(Of Contact))(responseContent)
            vmsToReturn = New ObservableCollection(Of ContactViewModel)(
                          From item In contactList
                          Select New ContactViewModel With
                               {.ID = item.ID,
                                .LastName = item.LastName,
                                .FirstName = item.FirstName,
                                .DateOfBirth = item.DateOfBirth})
        End If

        Return vmsToReturn

    End Function

    ''' <summary>
    ''' Edits a contact by using PUT on /api/contacts
    ''' </summary>
    ''' <returns></returns>
    Public Async Function PutContactAsync() As Task(Of HttpStatusCode)

        Dim url = MainViewModel.WEBAPI_URL
        Dim contact = New Contact
        CopyPropertiesTo(contact)

        Dim content = New StringContent(JsonConvert.SerializeObject(contact),
                                        Encoding.UTF8, "application/json")

        Dim response = Await MainViewModel.HttpClient.PutAsync($"{url}/contacts",
                                                               content)
        Return response.StatusCode

    End Function

    ''' <summary>
    ''' Adds a contact by using POST on /api/contacts
    ''' </summary>
    ''' <returns></returns>
    Public Async Function PostContactAsync() As Task(Of HttpStatusCode)

        Dim url = MainViewModel.WEBAPI_URL
        Dim contact = New Contact
        CopyPropertiesTo(contact)

        Dim content = New StringContent(JsonConvert.SerializeObject(contact),
                                        Encoding.UTF8, "application/json")

        Dim response = Await MainViewModel.HttpClient.PostAsync($"{url}/contacts",
                                                               content)
        Return response.StatusCode

    End Function

End Class
