Imports System.Collections.ObjectModel
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports MvvmFormsDemoViewModelLib

Public Class MainViewModel
    Inherits BindableBase

    Private myKontaktListe As ObservableCollection(Of Kontakt)
    Private mySelectedKontakt As Kontakt
    Private myKontaktToEdit As Kontakt
    Private myIsAdding As Boolean

    Public Property KontaktListe As ObservableCollection(Of Kontakt)
        Get
            Return myKontaktListe
        End Get
        Set(value As ObservableCollection(Of Kontakt))
            SetProperty(myKontaktListe, value)
        End Set
    End Property

    Public Property SelectedKontakt As Kontakt
        Get
            Return mySelectedKontakt
        End Get
        Set(value As Kontakt)
            If SetProperty(mySelectedKontakt, value) Then
                EditCommand.RaiseCanExecuteChanged()
            End If
        End Set
    End Property

    Public Property KontaktToEdit As Kontakt
        Get
            Return myKontaktToEdit
        End Get
        Set(value As Kontakt)
            SetProperty(myKontaktToEdit, value)
        End Set
    End Property

    Private myAddCommand As New RelayCommand(
        Sub()
            KontaktToEdit = New Kontakt With {.ID = Guid.NewGuid}
            HandleButtons
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
            KontaktToEdit = MvvmViewModelBase.FromModel(Of Kontakt, Kontakt)(SelectedKontakt)
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
        Sub()
            If myIsAdding Then
                KontaktListe.Add(KontaktToEdit)
            Else
                SelectedKontakt.DateOfBirth = KontaktToEdit.DateOfBirth
                SelectedKontakt.Firstname = KontaktToEdit.Firstname
                SelectedKontakt.Lastname = KontaktToEdit.Lastname
            End If
            KontaktToEdit = Nothing
            HandleButtons()
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
