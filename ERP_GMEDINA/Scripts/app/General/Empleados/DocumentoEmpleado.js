var id = 0;
function tablaEditar(ID) {
    id = ID;
    _ajax(null,
        '/Cargos/Edit/' + ID,//no tocar...
        'GET',
        function (obj) {
            if (obj != "-1" && obj != "-2" && obj != "-3") {
                // $("#FormEditar").find("#car_Descripcion").val(obj.car_Descripcion);
                $('#ModalEditar').modal('show');
                $("#ModalNuevo").find("#FileUpload")[0] = '';
            }
        });
}
$("#btnUploadDocument").change(function () {
    var fileExtension = ['xls', 'xlsx', 'jpeg', 'jpg', 'png', 'pdf', 'svg', 'doc', 'docx'];
    if ($.inArray($(this).val().split('.').pop().toLowerCase(), fileExtension) == -1) {
        MsgError("¡Error!", "Debe Agregar el tipo de archivo correspondiente");
    }
});

//$("#FormEmpleados").submit(function (e) {
//    e.preventDefault();
//    var file = $("#FormEmpleados").
//});

$("#FormEmpleadosDocument").on("submit", function (event) {
    event.preventDefault();
    //var data = $("#FormEmpleadosDocument").serializeArray();
    //data = serializar(data);
    //var f = $(this);
    var parametros = new FormData($(this)[0]);
    if ($("#FileUpload").val()) {
        if ($("#tiposArchivo").val() == "Amonestaciones" || $("#tiposArchivo").val() == "Permisos" || $("#tiposArchivo").val() == "Incapacidades" ||
        $("#tiposArchivo").val() == "Constancia" || $("#tiposArchivo").val() == "Solicitud" || $("#tiposArchivo").val() == "Facturas" ||
        $("#tiposArchivo").val() == "Archivos_Personales" || $("#tiposArchivo").val() == "Otros") {

            var data = $("#FormEmpleadosDocument").serializeArray()[0].value;
            //var data=$('#tiposArchivo option:selected').val();
            //data = serializar(data);

            if (data != null) {
                //var data = new FormData($("#FormEmpleadosDocument")[0]);
                //data.append('file', $('#FileUpload')[0].files[0]);

                var FileData = ($('#FileUpload')[0].files[0]);
                var UploadFile = new FormData();

                UploadFile.append("File", FileData);
                UploadFile.append("tiposArchivo", data);
                UploadFile.append("id", id);

                //data = serializar(data);
                console.log(UploadFile);
                //data = JSON.stringify({ data: data });
                $.ajax({
                    url: "/Empleados/UploadDocumento",
                    type: "post",
                    dataType: "html",
                    data: UploadFile,
                    cache: false,
                    contentType: false,
                    processData: false
                })
                .done(function (res) {
                    if (res == "-1") {
                        MsgError("Error", "No se pudo agregar el archivo, contacte al administrador.");
                    }
                    else if (res == "-2") {
                        MsgError("Error", "El archivo ya existe");
                    }
                    else if (res == "-3") {
                        MsgError("Error", "El archivo ya existe o su nombre es duplicado");
                    }
                    else if (res == "1") {
                        MsgSuccess("Exito", "El archivo se agrego de forma exitosa");



                        $('#tiposArchivo').val('');
                        llenarTabla();
                        $('#ModalEditar').modal('hide');
                        var fileinputhtml = "<div class='fileinput fileinput-new' data-provides='fileinput'>" +
                                              "<span class='btn btn-default btn-file'>" +
                                                  "<span class='fileinput-new'>Seleccionar documento</span><span class='fileinput-exists'>Cambiar documento </span>" +
                                                 "<input type='file' name='FileUpload' id='FileUpload' accept='.xls,.xlsx,.JPEG,.JPG,.PNG,.PDF,.SVG,.doc,.docx' id='btnUploadDocument'>" +
                                              "</span>" +
                                              "<span class='fileinput-filename'></span>" +
                                             "<a href='#' class='close fileinput-exists' data-dismiss='fileinput' style='float: none'>×</a>" +
                                          "</div>"

                        $("#FileUpload_Expediente").html(fileinputhtml).show();
                    }
                    else if (res == "-4") {
                        MsgError("Error", "Debe Agregar el archivo correspondiente");
                    }

                });
            } else {
                MsgError("Error", "por favor llene todas las cajas de texto");
            }

        }
        else {
            MsgError("Error", "por favor seleccione el tipo de archivo");
        }
    }
    else {
        MsgError("Error", "por favor seleccione un archivo");
    }
});
