@ModelType SolutionVBDataAcces.TIPODOCUMENTO
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>TIPODOCUMENTO</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TipoDocumentoNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TipoDocumentoNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TipoDocumentoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
