Imports System.Data.Entity
Imports System.Net
Imports System.Threading.Tasks
Imports SolutionVBDataAcces

Namespace Controllers
    Public Class PERSONASController
        Inherits System.Web.Mvc.Controller

        Private db As New SOLUTIONEntities1

        ' GET: PERSONAS
        Async Function Index() As Task(Of ActionResult)
            Dim pERSONA = db.PERSONA.Include(Function(p) p.EMPRESAS).Include(Function(p) p.TIPODOCUMENTO)
            Return View(Await pERSONA.ToListAsync())
        End Function

        ' GET: PERSONAS/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pERSONA As PERSONA = Await db.PERSONA.FindAsync(id)
            If IsNothing(pERSONA) Then
                Return HttpNotFound()
            End If
            Return View(pERSONA)
        End Function

        ' GET: PERSONAS/Create
        Function Create() As ActionResult
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre")
            ViewBag.TipoDocumentoID = New SelectList(db.TIPODOCUMENTO, "TipoDocumentoID", "TipoDocumentoNombre")
            Return View()
        End Function

        <HttpPost>
        Async Function SaveData(payload As PERSONA) As Task(Of Boolean)
            If ModelState.IsValid Then
                Try
                    db.PERSONA.Add(payload)
                    Await db.SaveChangesAsync()
                    Return True

                Catch ex As Exception
                    Return False
                End Try

            Else
                Return False
            End If
        End Function

        ' GET: PERSONAS/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pERSONA As PERSONA = Await db.PERSONA.FindAsync(id)
            If IsNothing(pERSONA) Then
                Return HttpNotFound()
            End If
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre", pERSONA.EmpresaID)
            ViewBag.TipoDocumentoID = New SelectList(db.TIPODOCUMENTO, "TipoDocumentoID", "TipoDocumentoNombre", pERSONA.TipoDocumentoID)
            Return View(pERSONA)
        End Function

        ' POST: PERSONAS/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="PersonaID,PersonaNombre,PersonaApelliso,PersonaNroDocumento,EmpresaID,TipoDocumentoID")> ByVal pERSONA As PERSONA) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(pERSONA).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre", pERSONA.EmpresaID)
            ViewBag.TipoDocumentoID = New SelectList(db.TIPODOCUMENTO, "TipoDocumentoID", "TipoDocumentoNombre", pERSONA.TipoDocumentoID)
            Return View(pERSONA)
        End Function

        ' GET: PERSONAS/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pERSONA As PERSONA = Await db.PERSONA.FindAsync(id)
            If IsNothing(pERSONA) Then
                Return HttpNotFound()
            End If
            Return View(pERSONA)
        End Function

        ' POST: PERSONAS/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim pERSONA As PERSONA = Await db.PERSONA.FindAsync(id)
            db.PERSONA.Remove(pERSONA)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
