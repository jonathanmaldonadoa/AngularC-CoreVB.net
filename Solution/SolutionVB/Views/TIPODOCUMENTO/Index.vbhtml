@ModelType IEnumerable(Of SolutionVBDataAcces.TIPODOCUMENTO)
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
            @Html.DisplayNameFor(Function(model) model.TipoDocumentoNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TipoDocumentoNombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EMPRESAS.EmpresaNombre)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.TipoDocumentoID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.TipoDocumentoID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.TipoDocumentoID})
            </td>
        </tr>
    Next

</table>
