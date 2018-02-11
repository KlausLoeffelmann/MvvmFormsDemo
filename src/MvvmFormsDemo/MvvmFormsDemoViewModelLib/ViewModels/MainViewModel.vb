Imports System.Collections.ObjectModel
Imports System.Net.Http
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports DataLayer
Imports Microsoft.EntityFrameworkCore
Imports MvvmFormsDemoViewModelLib

Public Class MainViewModel
    Inherits BindableBase

    Friend Const WEBAPI_URL = "http://localhost:5678/api/"
    Friend Shared ReadOnly HttpClient As New HttpClient

    Private myKontaktListe As ObservableCollection(Of ContactViewModel)
    Private mySelectedKontakt As ContactViewModel
    Private myKontaktToEdit As ContactViewModel
    Private myIsAdding As Boolean

    Public Async Function RefreshKontakteAsync() As Task
        Dim oc As New EventRecorderContext

        Dim anzahlItem = Aggregate item In oc.Kontakte
                           Into Count

        If anzahlItem = 0 Then
            For Each item In ContactViewModel.SampleRecords
                oc.Kontakte.Add(New Contact With
                                {.ID = item.ID,
                                 .LastName = item.Lastname,
                                 .FirstName = item.Firstname,
                                 .DateOfBirth = item.DateOfBirth})
            Next
            Await oc.SaveChangesAsync()
        End If

        Contacts = Await ContactViewModel.GetContactsAsync()

    End Function

    Public Property Contacts As ObservableCollection(Of ContactViewModel)
        Get
            Return myKontaktListe
        End Get
        Set(value As ObservableCollection(Of ContactViewModel))
            SetProperty(myKontaktListe, value)
        End Set
    End Property

    Public Property SelectedContact As ContactViewModel
        Get
            Return mySelectedKontakt
        End Get
        Set(value As ContactViewModel)
            If SetProperty(mySelectedKontakt, value) Then
                EditCommand.RaiseCanExecuteChanged()
            End If
        End Set
    End Property

    Public Property ContactToEdit As ContactViewModel
        Get
            Return myKontaktToEdit
        End Get
        Set(value As ContactViewModel)
            SetProperty(myKontaktToEdit, value)
        End Set
    End Property

    Private myAddCommand As New RelayCommand(
        Sub()
            ContactToEdit = New ContactViewModel With {.ID = Guid.NewGuid}
            HandleButtons()
            myIsAdding = True
        End Sub,
        Function() As Boolean
            Return myKontaktToEdit Is Nothing
        End Function)

    Private Sub HandleButtons()
        AddCommand.RaiseCanExecuteChanged()
        EditCommand.RaiseCanExecuteChanged()
        OKCommand.RaiseCanExecuteChanged()
        CancelCommand.RaiseCanExecuteChanged()
    End Sub

    Public Property AddCommand As RelayCommand
        Get
            Return myAddCommand
        End Get
        Set(value As RelayCommand)
            SetProperty(myAddCommand, value)
        End Set
    End Property

    Private myEditCommand As New RelayCommand(
        Sub()
            ContactToEdit = MvvmViewModelBase.FromModel(Of ContactViewModel, ContactViewModel)(SelectedContact)
            HandleButtons()
        End Sub,
        Function() As Boolean
            Return SelectedContact IsNot Nothing
        End Function)

    Public Property EditCommand As RelayCommand
        Get
            Return myEditCommand
        End Get
        Set(value As RelayCommand)
            SetProperty(myEditCommand, value)
        End Set
    End Property

    Private myOkCommand As New RelayCommand(
        Async Sub()
            Try
                If myIsAdding Then
                    If Await myKontaktToEdit.PostContactAsync = Net.HttpStatusCode.OK Then
                        Await RefreshKontakteAsync()
                    Else
                        'TODO: Signal Error message.
                    End If
                Else
                    SelectedContact.DateOfBirth = ContactToEdit.DateOfBirth
                    SelectedContact.Firstname = ContactToEdit.Firstname
                    SelectedContact.Lastname = ContactToEdit.Lastname
                End If
                ContactToEdit = Nothing
                HandleButtons()
            Catch ex As Exception
            End Try
        End Sub,
        Function() As Boolean
            Return myKontaktToEdit IsNot Nothing
        End Function)

    Public Property OKCommand As RelayCommand
        Get
            Return myOkCommand
        End Get
        Set(value As RelayCommand)
            SetProperty(myOkCommand, value)
        End Set
    End Property

    Private myCancelCommand As New RelayCommand(
        Sub()
            ContactToEdit = Nothing
            HandleButtons()
        End Sub,
        Function() As Boolean
            Return myKontaktToEdit IsNot Nothing
        End Function)

    Public Property CancelCommand As RelayCommand
        Get
            Return myCancelCommand
        End Get
        Set(value As RelayCommand)
            SetProperty(myCancelCommand, value)
        End Set
    End Property

End Class
