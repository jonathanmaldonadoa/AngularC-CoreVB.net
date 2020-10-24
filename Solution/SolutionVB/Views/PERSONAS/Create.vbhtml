@ModelType SolutionVBDataAcces.PERSONA
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>PERSONA</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.PersonaNombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.PersonaNombre, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.PersonaNombre, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.PersonaApelliso, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.PersonaApelliso, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.PersonaApelliso, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.PersonaNroDocumento, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.PersonaNroDocumento, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.PersonaNroDocumento, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.EmpresaID, "EmpresaID", htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("EmpresaID", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.EmpresaID, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.TipoDocumentoID, "TipoDocumentoID", htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("TipoDocumentoID", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.TipoDocumentoID, "", New With {.class = "text-danger"})
        </div>
    </div>
    @Code
        Html.BeginForm()
        @:<a href="#" onclick="SaveData();">Guardar</a>
        Html.EndForm()
    End Code


</div>
        End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>






    <script>
        function SaveData() {
            console.log();
            var payload = {
                PersonaNombre: document.getElementById("PersonaNombre").value,
                PersonaApelliso: document.getElementById("PersonaApelliso").value,
                PersonaNroDocumento: document.getElementById("PersonaNroDocumento").value,
                EmpresaID: document.getElementById("EmpresaID").value,
                TipoDocumentoID: document.getElementById("TipoDocumentoID").value
            };
            console.log(payload);
            // Calls controller correctly but data is null
            $.ajax({
                url: "/PERSONAS/SaveData/",
                type: "POST",
                data: payload,
            })
                .done(function () {

                    alert('Application saved.');
                    window.location = "http://localhost:44303/PERSONAS";

                })
                .fail(function () { alert('Application failed to save.'); });

        }

    </script>
