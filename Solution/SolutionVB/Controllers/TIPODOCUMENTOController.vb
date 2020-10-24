Imports System.Data.Entity
Imports System.Net
Imports System.Threading.Tasks
Imports SolutionVBDataAcces

Namespace Controllers
    Public Class TIPODOCUMENTOController
        Inherits System.Web.Mvc.Controller

        Private db As New SOLUTIONEntities1

        ' GET: TIPODOCUMENTO
        Async Function Index() As Task(Of ActionResult)
            Dim tIPODOCUMENTO = db.TIPODOCUMENTO.Include(Function(t) t.EMPRESAS)
            Return View(Await tIPODOCUMENTO.ToListAsync())
        End Function

        ' GET: TIPODOCUMENTO/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            If IsNothing(tIPODOCUMENTO) Then
                Return HttpNotFound()
            End If
            Return View(tIPODOCUMENTO)
        End Function

        ' GET: TIPODOCUMENTO/Create
        Function Create() As ActionResult
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre")
            Return View()
        End Function

        <HttpPost>
        Function SaveData(payload As String) As Boolean
            If payload IsNot Nothing AndAlso payload.Length > 0 Then
                Return True
            Else
                Return False
            End If
        End Function


        ' POST: TIPODOCUMENTO/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="TipoDocumentoID,TipoDocumentoNombre,EmpresaID")> ByVal tIPODOCUMENTO As TIPODOCUMENTO) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.TIPODOCUMENTO.Add(tIPODOCUMENTO)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre", tIPODOCUMENTO.EmpresaID)
            Return View(tIPODOCUMENTO)
        End Function

        ' GET: TIPODOCUMENTO/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            If IsNothing(tIPODOCUMENTO) Then
                Return HttpNotFound()
            End If
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre", tIPODOCUMENTO.EmpresaID)
            Return View(tIPODOCUMENTO)
        End Function

        ' POST: TIPODOCUMENTO/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="TipoDocumentoID,TipoDocumentoNombre,EmpresaID")> ByVal tIPODOCUMENTO As TIPODOCUMENTO) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(tIPODOCUMENTO).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            ViewBag.EmpresaID = New SelectList(db.EMPRESAS, "EmpresaID", "EmpresaNombre", tIPODOCUMENTO.EmpresaID)
            Return View(tIPODOCUMENTO)
        End Function

        ' GET: TIPODOCUMENTO/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            If IsNothing(tIPODOCUMENTO) Then
                Return HttpNotFound()
            End If
            Return View(tIPODOCUMENTO)
        End Function

        ' POST: TIPODOCUMENTO/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim tIPODOCUMENTO As TIPODOCUMENTO = Await db.TIPODOCUMENTO.FindAsync(id)
            db.TIPODOCUMENTO.Remove(tIPODOCUMENTO)
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
