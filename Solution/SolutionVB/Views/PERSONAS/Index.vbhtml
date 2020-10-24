@ModelType IEnumerable(Of SolutionVBDataAcces.PERSONA)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PersonaNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PersonaApelliso)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PersonaNroDocumento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TIPODOCUMENTO.TipoDocumentoNombre)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.PersonaNombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.PersonaApelliso)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.PersonaNroDocumento)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EMPRESAS.EmpresaNombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TIPODOCUMENTO.TipoDocumentoNombre)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.PersonaID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.PersonaID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.PersonaID})
            </td>
        </tr>
    Next

</table>
