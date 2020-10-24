﻿@ModelType SolutionVBDataAcces.PERSONA
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
