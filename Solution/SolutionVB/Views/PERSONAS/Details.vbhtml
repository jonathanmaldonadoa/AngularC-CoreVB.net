@ModelType SolutionVBDataAcces.PERSONA
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>PERSONA</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PersonaNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PersonaNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PersonaApelliso)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PersonaApelliso)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PersonaNroDocumento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PersonaNroDocumento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EMPRESAS.EmpresaNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TIPODOCUMENTO.TipoDocumentoNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TIPODOCUMENTO.TipoDocumentoNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.PersonaID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
