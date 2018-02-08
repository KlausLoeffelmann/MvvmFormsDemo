Imports System.Collections.ObjectModel
Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports MvvmFormsDemoViewModelLib

Public Class MainViewModel
    Inherits BindableBase

    Private myKontaktListe As ObservableCollection(Of Kontakt)
    Private mySelectedKontakt As Kontakt
    Private myKontaktToEdit As Kontakt

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
            SetProperty(mySelectedKontakt, value)
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
        End Sub)

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
            'TODO: Does this work that way??
            KontaktToEdit = SelectedKontakt
        End Sub)

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

        End Sub)

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

        End Sub)

    Public Property CancelCommand As RelayCommand
        Get
            Return myCancelCommand
        End Get
        Set(value As RelayCommand)
            SetProperty(myCancelCommand, value)
        End Set
    End Property

End Class
