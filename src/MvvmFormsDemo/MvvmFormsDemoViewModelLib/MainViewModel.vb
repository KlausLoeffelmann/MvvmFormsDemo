Imports System.Collections.ObjectModel
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports DataLayer
Imports Microsoft.EntityFrameworkCore
Imports MvvmFormsDemoViewModelLib

Public Class MainViewModel
    Inherits BindableBase

    Private myKontaktListe As ObservableCollection(Of KontaktViewModel)
    Private mySelectedKontakt As KontaktViewModel
    Private myKontaktToEdit As KontaktViewModel
    Private myIsAdding As Boolean

    Public Async Function RefreshKontakteAsync() As Task
        Dim oc As New EventRecorderContext

        Dim anzahlItem = Aggregate item In oc.Kontakte
                           Into Count

        If anzahlItem = 0 Then
            For Each item In KontaktViewModel.SampleRecords
                oc.Kontakte.Add(New Kontakt With
                                {.ID = item.ID,
                                 .LastName = item.Lastname,
                                 .FirstName = item.Firstname,
                                 .DateOfBirth = item.DateOfBirth})
            Next
            Await oc.SaveChangesAsync()
        End If

        KontaktListe = New ObservableCollection(Of KontaktViewModel)(
            Await (From item In oc.Kontakte
                   Order By item.LastName
                   Select New KontaktViewModel With
                               {.ID = item.ID,
                                .Lastname = item.LastName,
                                .Firstname = item.FirstName,
                                .DateOfBirth = item.DateOfBirth}).ToListAsync)

    End Function

    Public Property KontaktListe As ObservableCollection(Of KontaktViewModel)
        Get
            Return myKontaktListe
        End Get
        Set(value As ObservableCollection(Of KontaktViewModel))
            SetProperty(myKontaktListe, value)
        End Set
    End Property

    Public Property SelectedKontakt As KontaktViewModel
        Get
            Return mySelectedKontakt
        End Get
        Set(value As KontaktViewModel)
            If SetProperty(mySelectedKontakt, value) Then
                EditCommand.RaiseCanExecuteChanged()
            End If
        End Set
    End Property

    Public Property KontaktToEdit As KontaktViewModel
        Get
            Return myKontaktToEdit
        End Get
        Set(value As KontaktViewModel)
            SetProperty(myKontaktToEdit, value)
        End Set
    End Property

    Private myAddCommand As New RelayCommand(
        Sub()
            KontaktToEdit = New KontaktViewModel With {.ID = Guid.NewGuid}
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
            KontaktToEdit = MvvmViewModelBase.FromModel(Of KontaktViewModel, KontaktViewModel)(SelectedKontakt)
            HandleButtons()
        End Sub,
        Function() As Boolean
            Return SelectedKontakt IsNot Nothing
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
                    Dim oc = New EventRecorderContext

                    oc.Kontakte.Add(New Kontakt With
                                {.ID = KontaktToEdit.ID,
                                 .FirstName = KontaktToEdit.Firstname,
                                 .LastName = KontaktToEdit.Lastname,
                                 .DateOfBirth = KontaktToEdit.DateOfBirth})

                    Await oc.SaveChangesAsync()
                    Await RefreshKontakteAsync()
                Else
                    SelectedKontakt.DateOfBirth = KontaktToEdit.DateOfBirth
                    SelectedKontakt.Firstname = KontaktToEdit.Firstname
                    SelectedKontakt.Lastname = KontaktToEdit.Lastname
                End If
                KontaktToEdit = Nothing
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
            KontaktToEdit = Nothing
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
