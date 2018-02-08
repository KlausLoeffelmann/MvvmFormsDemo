Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Diagnostics.Tracing
Imports Microsoft.EntityFrameworkCore

Public Class EventRecorderContext
    Inherits DbContext

    Public Property Kontakte As DbSet(Of Kontakt)
    Public Property Events As DbSet(Of [Event])

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        'With other NuGets, we can use SqLite at this point.
        optionsBuilder.UseSqlServer("Server=(localdb)\mssqllocaldb;Database=AloisHerta;Trusted_Connection=True;")
        'optionsBuilder.UseSqlServer("Server=SPNSURF3\SQLE2016;Database=EventRecorder;User ID=sa;Password=P@$$w0rd2407")
    End Sub
End Class

Public Class Kontakt

    <Key>
    Public Property ID As Guid
    <Column(TypeName:="nvarchar(200)")>
    Public Property LastName As String
    <Column(TypeName:="nvarchar(200)")>
    Public Property FirstName As String
    Public Property DateOfBirth As DateTimeOffset
    Public Property DateCreated As DateTimeOffset
    Public Property DateLastEdited As DateTimeOffset
End Class

Public Class [Event]

    <Key>
    Public Property IdEvent As Guid
    Public Property Kontakt As Kontakt
    Public Property StartTime As TimeSpan?
    Public Property EndTime As TimeSpan?
    Public Property BookingDate As DateTimeOffset?
    Public Property Duration As Long?

    <Column(TypeName:="nvarchar(200)")>
    Public Property Description As String

    Public Property DateCreated As DateTimeOffset
    Public Property DateLastEdited As DateTimeOffset

End Class