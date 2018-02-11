Imports System.Net
Imports System.Net.Http
Imports DataLayer
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.EntityFrameworkCore

<Route("api/[controller]")>
Public Class ContactsController
    Inherits Controller

    ' GET api/contacts
    <HttpGet>
    Public Async Function [Get]() As Task(Of IEnumerable(Of Contact))

        Dim oc As New EventRecorderContext

        Dim contacts = Await (From item In oc.Kontakte
                              Order By item.LastName).ToListAsync.ConfigureAwait(False)

        Return Await Task.FromResult(contacts)
    End Function

    ' GET api/contacts/guid
    <HttpGet("{id}")>
    Public Async Function [Get](ByVal id As Guid) As Task(Of Contact)
        Return Await (New EventRecorderContext).Kontakte.
                            Where(Function(item) item.ID = id).FirstOrDefaultAsync
    End Function

    ' PUT api/contacts
    <HttpPut()>
    Public Async Sub Put(<FromBody> ByVal contact As Contact)
        Dim oc = New EventRecorderContext
        oc.Update(contact)
        Await oc.SaveChangesAsync()
    End Sub

    ' PUT api/contacts/contact
    <HttpPost()>
    Public Async Function Post(<FromBody> ByVal contact As Contact) As Task(Of ActionResult)
        Dim oc = New EventRecorderContext
        oc.Add(contact)
        Await oc.SaveChangesAsync()
        Return New OkObjectResult(42)
    End Function

End Class
