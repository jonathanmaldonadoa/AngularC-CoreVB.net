Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Net
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Description
Imports SolutionVBDataAcces

Namespace Controllers

    Public Class TIPODOCUMENTOesController
        Inherits System.Web.Http.ApiController

        Private db As New SOLUTIONEntities1

        ' GET: api/TIPODOCUMENTOes
        Function GetTIPODOCUMENTO() As List(Of Tipodocumentomap)

            Using OEntidad As New SOLUTIONEntities1
                Dim query = From a In OEntidad.TIPODOCUMENTO
                            Select a

                Dim lista As New List(Of Tipodocumentomap)
                For Each item In query
                    Dim info As New Tipodocumentomap With {
                        .TipoDocumentoID = item.TipoDocumentoID,
                        .TipoDocumentoNombre = item.TipoDocumentoNombre
                    }
                    lista.Add(info)
                Next
                Return lista
            End Using

        End Function

        ' GET: api/TIPODOCUMENTOes/5
        <ResponseType(GetType(Tipodocumentomap))>
        Async Function GetTIPODOCUMENTO(ByVal id As Integer) As Task(Of IHttpActionResult)
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            If IsNothing(tIPODOCUMENTO) Then
                Return NotFound()
            End If

            Dim _tipoDocumentoMap As New Tipodocumentomap With {
                .TipoDocumentoID = tIPODOCUMENTO.TipoDocumentoID,
                .TipoDocumentoNombre = tIPODOCUMENTO.TipoDocumentoNombre
            }

            Return Ok(_tipoDocumentoMap)
        End Function


        ' PUT: api/TIPODOCUMENTOes/5
        <ResponseType(GetType(Void))>
        Async Function PutTIPODOCUMENTO(ByVal id As Integer, ByVal tIPODOCUMENTO As TIPODOCUMENTO) As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = tIPODOCUMENTO.TipoDocumentoID Then
                Return BadRequest()
            End If

            db.Entry(tIPODOCUMENTO).State = EntityState.Modified

            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateConcurrencyException
                If Not (TIPODOCUMENTOExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/TIPODOCUMENTOes
        <ResponseType(GetType(TIPODOCUMENTO))>
        Async Function PostTIPODOCUMENTO(ByVal tIPODOCUMENTO As TIPODOCUMENTO) As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.TIPODOCUMENTO.Add(tIPODOCUMENTO)
            Await db.SaveChangesAsync()

            Return CreatedAtRoute("DefaultApi", New With {.id = tIPODOCUMENTO.TipoDocumentoID}, tIPODOCUMENTO)
        End Function

        ' DELETE: api/TIPODOCUMENTOes/5
        <ResponseType(GetType(TIPODOCUMENTO))>
        Async Function DeleteTIPODOCUMENTO(ByVal id As Integer) As Task(Of IHttpActionResult)
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            If IsNothing(tIPODOCUMENTO) Then
                Return NotFound()
            End If

            db.TIPODOCUMENTO.Remove(tIPODOCUMENTO)
            Await db.SaveChangesAsync()

            Return Ok(tIPODOCUMENTO)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function TIPODOCUMENTOExists(ByVal id As Integer) As Boolean
            Return db.TIPODOCUMENTO.Count(Function(e) e.TipoDocumentoID = id) > 0
        End Function
    End Class
End Namespace