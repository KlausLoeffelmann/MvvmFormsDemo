Imports System.ComponentModel

Public Class NotifyChangeDemo
    Implements INotifyPropertyChanged

    Private myFoo As Integer
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property Foo As Integer
        Get
            Return myFoo
        End Get
        Set(value As Integer)
            If Not Object.Equals(value, myFoo) Then
                myFoo = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Foo)))
            End If
        End Set
    End Property

End Class
