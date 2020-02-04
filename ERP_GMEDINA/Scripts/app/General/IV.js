﻿////FUNCION GENERICA PARA REUTILIZAR AJAX
function _ajax(params, uri, type, callback) {
    $.ajax({
        url: uri,
        type: type,
        data: { params },
        success: function (data) {
            callback(data);
        }
    });
}
var InactivarID = 0;

//formato fecha
$.getScript("../Scripts/app/General/SerializeDate.js")
  .done(function (script, textStatus) {

  })
  .fail(function (jqxhr, settings, exception) {

  });

// evitar postbacks
$("#frmEditIV").submit(function (e) {
    return false;
});
$("#frmIVCreate").submit(function (e) {
    return false;
});

//cargar grid
function cargarGridIV() {

    var esAdministrador = $("#rol_Usuario").val();
    $.ajax({
        url: "/TechoImpuestVecinal/GetData",
        method: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8"
    }).done(function (data) {

        if (data.length == 0) {
            iziToast.error({
                title: 'Error',
                message: 'No se cargó la información, contacte al administrador',
            });
        }
        else {
            var LitaIV = data, template = '';
            //limpiar datatable
            $('#tblIV').DataTable().clear();
            //recorrer data obtenida del backend
            for (var i = 0; i < LitaIV.length; i++) {

                //variable para verificar el estado del registro
                var estadoRegistro = LitaIV[i].timv_Activo == false ? 'Inactivo' : 'Activo';

                //variable boton detalles
                var botonDetalles = '<button data-id = "' + LitaIV[i].timv_IdTechoImpuestoVecinal + '" type="button" style="margin-right:3px;" class="btn btn-primary btn-xs"  id="btnDetalleIV">Detalles</button>';

                //variable boton editar
                var botonEditar = ListLitaIVaISR[i].timv_Activo == true ? '<button data-id = "' + LitaIV[i].timv_IdTechoImpuestoVecinal + '" type="button" class="btn btn-default btn-xs"  id="btnModalEditarIV">Editar</button>' : '';

                //variable boton activar
                var botonActivar = LitaIV[i].timv_Activo == false ? esAdministrador == "1" ? '<button data-id = "' + LitaIV[i].timv_IdTechoImpuestoVecinal + '" type="button" class="btn btn-default btn-xs"  id="btnActivarIVModal">Activar</button>' : '' : '';

                //agregar el row al datatable
                $('#tblIV').dataTable().fnAddData([
                    LitaIV[i].timv_IdTechoImpuestoVecinal,
                    LitaIV[i].tbMunicipio.mun_Nombre,
                    LitaIV[i].tbTipoDeduccion.tde_Descripcion,
                    (LitaIV[i].timv_RangoInicio % 1 == 0) ? LitaIV[i].timv_RangoInicio + ".00" : LitaIV[i].timv_RangoInicio,
                    (LitaIV[i].timv_RangoFin % 1 == 0) ? LitaIV[i].timv_RangoFin + ".00" : LitaIV[i].timv_RangoFin,
                    (LitaIV[i].timv_Rango % 1 == 0) ? LitaIV[i].timv_Rango + ".00" : LitaIV[i].timv_Rango,
                    (LitaIV[i].timv_Impuesto % 1 == 0) ? LitaIV[i].timv_Impuesto + ".00" : LitaIV[i].timv_Impuesto,
                    estadoRegistro,
                    botonDetalles + botonEditar + botonActivar
                ]);
            }
        }
        });
    FullBody();
}

//crear iv
$(document).on("click", "#btnAgregarIV", function () {
    //OCULTAR VALIDACIONES
    Vaciar_ModalCrear();
    //llenar ddls
    $.ajax({
        url: "/TechoImpuestoVecinal/EditGetDDLTipoDedu",
        method: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8"
    })
        //llenar los dropdownlists
        .done(function (data) {
            $("#Crear #tde_IdTipoDedu").empty();
            $("#Crear #tde_IdTipoDedu").append("<option value='0'>Selecione una opción...</option>");
            $.each(data, function (i, iter) {
                $("#Crear #tde_IdTipoDedu").append("<option value='" + iter.Id + "'>" + iter.Descripcion + "</option>");
            });
        });

    $.ajax({
        url: "/TechoImpuestoVecinal/EditGetDDLMuni",
        method: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8"
    })
        //llenar los dropdownlists
        .done(function (data) {
            $("#Crear #mun_Codigo").empty();
            $("#Crear #mun_Codigo").append("<option value='0'>Selecione una opción...</option>");
            $.each(data, function (i, iter) {
                $("#Crear #mun_Codigo").append("<option value='" + iter.Id + "'>" + iter.Descripcion + "</option>");
            });
        });
    //DESPLEGAR MODAL DE CREACION
    $("#AgregarIV").modal({ backdrop: 'static', keyboard: false });
});

//crear nuevo rango iv
$('#btnCreateIV').click(function () {

    var rangoInicio = $("#Crear #timv_RangoInicio").val();
    var rangoFin = $("#Crear #timv_RangoFin").val();
    var codmuni = $("#Crear #mun_Codigo").val();
    var rango = $("#Crear #timv_Rango").val();
    var tipoDeduccion = $("#Crear #tde_IdTipoDedu").val();
    var impuesto = $("#Crear #timv_Impuesto").val();

  //  if (DataAnnotationsCrear(codmuni, tipoDeduccion, rangoInicio, rangoFin, rango, impuesto)) {
        $('#btnCreateIV').attr('disabled', true);


        //var data = $("#frmISRCreate").serializeArray();
        var data = {
            mun_Codigo: FormatearMonto($("#Crear #mun_Codigo").val()),
            tde_IdTipoDedu: $("#Crear #tde_IdTipoDedu").val(),
            timv_RangoInicio: FormatearMonto($("#Crear #timv_RangoInicio").val()),
            timv_RangoFin: FormatearMonto($("#Crear #timv_RangoFin").val()),
            timv_Rango: FormatearMonto($("#Crear #timv_Rango").val()),
            timv_Impuesto: FormatearMonto($("#Crear #timv_Impuesto").val())
        };

        $.ajax({
            url: "/TechoImpuestoVecinal/Create",
            method: "POST",
            data: data
        }).done(function (data) {
            //validar respuesta del backend
            if (data == "error") {
                iziToast.error({
                    title: 'Error',
                    message: 'No guardó el registro, contacte al administrador',
                });
            }
            else if (data == "bien") {
                $("#AgregarIV").modal('hide');
                cargarGridISR();
                // Mensaje de exito cuando un registro se ha guardado bien
                iziToast.success({
                    title: 'Exito',
                    message: '¡El registro se agregó de forma exitosa!',
                });
            }
        });
        $('#btnCreateIV').attr('disabled', false);
    

});








//FUNCION: PRIMERA FASE DE EDICION DE REGISTROS, MOSTRAR MODAL CON LA INFORMACIÓN DEL REGISTRO SELECCIONADO
$(document).on("click", "#tblIV tbody tr td #btnModalEditarIV", function () {
    //DESBLOQUEAR BOTON DE EDITAR
    $('#btnEditarIV').attr('disabled', false);
    //CAPTURAR EL ID
    var ID = $(this).data('id');
    $('#frmIVEdit #Validation_tde_IdTipoDedu').css('display', 'none');
    $('#frmIVEdit .messageValidation').css('display', 'none');
    $('#frmIVEdit .asterisco').removeClass('text-danger');
    //SETEAR LA VARIABLE GLOBAL DE INACTIVAR
    InactivarID = ID;
    //OCULTAR VALIDACIONES
    Vaciar_ModalEditar();
    //EJECUTAR LA PETICION AL SERVIDOR
    $.ajax({
        url: "/TechoImpuestoVecinal/EditIV/" + ID,
        method: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ ID: ID })
    })
        .done(function (data) {
            if (data) {
                $("#EditarIV #timv_IdTechoImpuestoVecinal").val(data.timv_IdTechoImpuestoVecinal);
                $("#EditarIV #timv_RangoInicio").val((data.timv_RangoInicio % 1 == 0) ? data.timv_RangoInicio + ".00" : data.timv_RangoInicio);
                $("#EditarIV #timv_RangoFin").val((data.timv_RangoFin % 1 == 0) ? data.timv_RangoFin + ".00" : data.timv_RangoFin);
                $("#EditarIV #timv_Rango").val((data.timv_Rango % 1 == 0) ? data.timv_Rango + ".00" : data.timv_Rango);
                $("#EditarIV #timv_Porcentaje").val((data.timv_Porcentaje % 1 == 0) ? data.timv_Porcentaje + ".00" : data.timv_Porcentaje);
                $("#EditarIV #tde_IdTipoDedu").val(data.tde_IdTipoDedu);
                $("#EditarIV #mun_Nombre").val(data.mun_Nombre);
                $("#EditarIV").modal({ backdrop: 'static', keyboard: false });
                $(".rangoInicial").focus();
                //GUARDAR EL ID DEL DROPDOWNLIST (QUE ESTA EN EL REGISTRO SELECCIONADO) QUE NECESITAREMOS PONER SELECTED EN EL DDL DEL MODAL DE EDICION
                var SelectedId = data.tde_IdTipoDedu;
                //CARGAR INFORMACIÓN DEL DROPDOWNLIST PARA EL MODAL
                $.ajax({
                    url: "/TechoImpuestoVecinal/EditGetDDLTipoDedu",
                    method: "GET",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ ID })
                })
                    .done(function (data) {
                        //LIMPIAR EL DROPDOWNLIST ANTES DE VOLVER A LLENARLO
                        $("#Editar #tde_IdTipoDedu").empty();
                        //LLENAR EL DROPDOWNLIST
                        $("#Editar #tde_IdTipoDedu").append("<option value=0>Selecione una opción...</option>");
                        $.each(data, function (i, iter) {
                            $("#Editar #tde_IdTipoDedu").append("<option" + (iter.Id == SelectedId ? " selected" : " ") + " value='" + iter.Id + "'>" + iter.Descripcion + "</option>");
                        });
                    });
            }
            else {
                //Mensaje de error si no hay data
                iziToast.error({
                    title: 'Error',
                    message: 'No se cargó la información, contacte al administrador',
                });
            }
        });
});

//EJECUTAR EDICIÓN DEL REGISTRO EN EL MODAL
$("#btnEditarIV").click(function () {
    var rangoInicial = $("#EditarIV #timv_RangoInicio").val();
    var rangoFinal = $("#EditarIV #timv_RangoFin").val();
    var rango = $("#EditarIV #timv_Rango").val();
    var tipoDeduccion = $("#EditarIV #tde_IdTipoDedu").val();
    var municipio = $("#EditarIV #mun_Nombre").val();
    var porcentaje = $("#EditarIV #timv_Porcentaje").val();

    if (DataAnnotationsEditar(rangoInicial, rangoFinal, tipoDeduccion, porcentaje)) {
        //BLOQUEAR BOTON DE EDITAR
        $('#btnEditarIV').attr('disabled', true);
        //SERIALIZAR EL FORMULARIO
        //var data = $("#frmEditISR").serializeArray();

        var data = {
            timv_IdTechoImpuestoVecinal: $("#EditarIV #timv_IdTechoImpuestoVecinal").val(),
            timv_RangoInicio: FormatearMonto($("#EditarIV #timv_RangoInicio").val()),
            timv_RangoFin: FormatearMonto($("#EditarIV #timv_RangoFin").val()),
            tde_IdTipoDedu: $("#EditarIV #tde_IdTipoDedu").val(),
            timv_Porcentaje: FormatearMonto($("#EditarIV #timv_Porcentaje").val()),
            timv_Rango: $("#EditarIV #timv_Rango").val(),
            mun_Nombre: $("#EditarIV #mun_Nombre").val()

        };

        //SE ENVIA EL JSON AL SERVIDOR PARA EJECUTAR LA EDICIÓN
        $.ajax({
            url: "/TechoImpuestoVecinal/Edit",
            method: "POST",
            data: data
        }).done(function (data) {
            //DESBLOQUEAR BOTON DE EDITAR
            $('#btnEditarIV').attr('disabled', false);
            if (data == "error") {
                iziToast.error({
                    title: 'Error',
                    message: 'No se editó el registro, contacte al administrador',
                });
            }
            else {
                //BLOQUEAR BOTON DE EDITAR
                $('#btnEditarIV').attr('disabled', true);
                //REFRESCAR LA DATA DEL DATATABLE
                cargarGridISR();
                //OCULTAR MODAL DE EDICION
                $("#EditarIV").modal('hide');
                //Mensaje de exito de la edicion
                iziToast.success({
                    title: 'Éxito',
                    message: '¡El registro se editó de forma exitosa!',
                });
            }
        });
    }
});


//FUNCION: OCULTAR MODAL DE EDICIÓN
$("#btnCerrarEditar").click(function () {
    //OCULTAR MODAL DE EDITAR
    $("#EditarIV").modal('hide');
});






//DESPLEGAR MODAL DE INACTIVACION
$(document).on("click", "#btnModalInactivarISR", function () {
    //DESBLOQUEAR BOTON
    $("#btnInactivarISR").attr("disabled", false);
    //OCULTAR EL MODAL DE EDICION
    $("#EditarISR").modal('hide');
    //MOSTRAR MODAL DE INACTIVACION
    $("#InactivarISR").modal({ backdrop: 'static', keyboard: false });
});

//CERRAR MODAL DE INACTIVACION
$(document).on("click", "#btnBack", function () {
    //OCULTAR MODAL DE INACTIVACION
    $("#InactivarISR").modal('hide');
    //MOSTRAR MODAL DE EDICION
    $("#EditarISR").modal({ backdrop: 'static', keyboard: false });
});

//Inactivar registro Techos Deducciones
$("#btnInactivarISR").click(function () {
    //BLOQUEAR BOTON
    $("#btnInactivarISR").attr("disabled", true);
    var data = $("#frmInactivarISR").serializeArray();
    //SE ENVIA EL JSON AL SERVIDOR PARA EJECUTAR LA EDICIÓN
    $.ajax({
        url: "/ISR/Inactivar/" + InactivarID,
        method: "POST",
        data: { id: InactivarID }
    }).done(function (data) {
        if (data == "error") {
            //DESBLOQUEAR BOTON
            $("#btnInactivarISR").attr("disabled", false);
            //MOSTRAR MENSAJE DE ERROR
            iziToast.error({
                title: 'Error',
                message: 'No se inactivó el registro, contacte al administrador',
            });
        }
        else {
            $("#InactivarISR").modal('hide');
            cargarGridISR();
            //Mensaje de exito de la edicion
            iziToast.success({
                title: 'Éxito',
                message: '¡El registro se inactivó de forma exitosa!',
            });
        }
    });
    InactivarID = 0;
});

//DECLARAR LA VARIABLE DE ACTIVACION
var ActivarID = 0;
//DESPLEGAR MODAL DE ACTIVACION
$(document).on("click", "#tblISR tbody tr td #btnActivarISRModal", function () {
    //CAPTURAR EL ID DEL REGISTRO
    ActivarID = $(this).data('id');
    //DESBLOQUEAR BOTON
    $("#btnActivarISR").attr("disabled", false);
    //MOSTRAR MODAL DE ACTIVACION
    $("#ActivarISR").modal({ backdrop: 'static', keyboard: false });
});

//CERRAR MODAL DE ACTIVACION
$(document).on("click", "#btnBackActivar", function () {
    //OCULTAR MODAL DE INACTIVACION
    $("#ActivarISR").modal('hide');
});

//ACTIVAR REGISTRO
$("#btnActivarISR").click(function () {
    //BLOQUEAR BOTON
    $("#btnActivarISR").attr("disabled", true);
    //SE ENVIA EL JSON AL SERVIDOR PARA EJECUTAR LA EDICIÓN
    $.ajax({
        url: "/ISR/Activar/" + ActivarID,
        method: "POST",
        data: { id: ActivarID }
    }).done(function (data) {
        if (data == "error") {
            //DESBLOQUEAR BOTON
            $("#btnActivarISR").attr("disabled", false);
            //MOSTRAR MENSAJE DE ERROR
            iziToast.error({
                title: 'Error',
                message: 'No se activó el registro, contacte al administrador',
            });
        }
        else {
            $("#ActivarISR").modal('hide');
            cargarGridISR();
            //Mensaje de exito de la edicion
            iziToast.success({
                title: 'Éxito',
                message: '¡El registro se activó de forma exitosa!',
            });
        }
    });
    ActivarID = 0;
});





//DETALLES
$(document).on("click", "#tblIV tbody tr td #btnDetalleIV", function () {
    var ID = $(this).data('id');
    $.ajax({
        url: "/TechoImpuestoVecinal/Details/" + ID,
        method: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ ID: ID })
    })
        .done(function (data) {
          
            //SI SE OBTIENE DATA, LLENAR LOS CAMPOS DEL MODAL CON ELLA
            if (data) {
                var FechaCrea = FechaFormato(data[0].timv_FechaCrea);
                var FechaModifica = FechaFormato(data[0].timv_FechaModifica);
                $("#DetailsIV #mun_Codigo").html(data[0].mun_Nombre);
                $("#DetailsIV #tde_IdTipoDedu").html(data[0].tde_Descripcion);
                $("#DetailsIV #timv_RangoInicio").html((data[0].timv_RangoInicio % 1 == 0) ? data[0].timv_RangoInicio + ".00" : data[0].timv_RangoInicio);
                $("#DetailsIV #timv_RangoFin").html((data[0].timv_RangoFin % 1 == 0) ? data[0].timv_RangoFin + ".00" : data[0].timv_RangoFin);
                $("#DetailsIV #timv_Rango").html((data[0].timv_Rango % 1 == 0) ? data[0].timv_Rango + ".00" : data[0].timv_Rango);
                $("#DetailsIV #timv_Impuesto").html((data[0].timv_Impuesto % 1 == 0) ? data[0].timv_Impuesto + ".00" : data[0].timv_Impuesto);
                $("#DetailsIV #timv_UsuarioCrea").html(data[0].timv_UsuarioCrea);
                $("#tbUsuario_usu_NombreUsuario").html(data[0].UsuCrea);
                $("#FechaCrea").html(FechaCrea);
                $("#timv_UsuarioModifica").html(data.timv_UsuarioModifica);
                data[0].UsuModifica == null ? $("#Detalles #tbUsuario1_usu_NombreUsuario").html('Sin modificaciones') : $("#Detalles #tbUsuario1_usu_NombreUsuario").html(data[0].UsuModifica);
                $("#DetailsIV #timv_FechaModifica").html(FechaModifica);
                //GUARDAR EL ID DEL DROPDOWNLIST (QUE ESTA EN EL REGISTRO SELECCIONADO) QUE NECESITAREMOS PONER SELECTED EN EL DDL DEL MODAL DE EDICION
                var SelectedId = data[0].tde_IdTipoDedu;
                //CARGAR INFORMACIÓN DEL DROPDOWNLIST PARA EL MODAL
                $.ajax({
                    url: "/TechoImpuestoVecinal/EditGetDDLTipoDedu",
                    method: "GET",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ ID })
                })
                    .done(function (data) {
                        $("#DetailsIV #tde_IdTipoDedu").html(data[0].tde_IdTipoDedu);
                    });
                $("#DetailsIV").modal({ backdrop: 'static', keyboard: false });

                var SelectedIdmuni = data[0].mun_Codigo;
                //CARGAR INFORMACIÓN DEL DROPDOWNLIST AFP PARA EL MODAL
                $.ajax({
                    url: "/TechoImpuestoVecinal/EditGetDDLMuni",
                    method: "GET",
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ ID })
                    })
                    .done(function (data) {
                        //LLENAR EL DROPDOWNLIST
                        $.each(data, function (i, iter) {
                            if (iter.Id == SelectedIdmuni) {
                                $("#DetailsIV #mun_Codigo").html(iter.mun_Codigo);
                            }
                        });
                    });

                $("#DetailsIV").modal({ backdrop: 'static', keyboard: false });
            }
            else {
                //Mensaje de error si no hay data
                iziToast.error({
                    title: 'Error',
                    message: 'No cargó la información, contacte al administrador',
                });
            }
        });
});




//FUNCION: OCULTAR VALIDACIONES DE CREACION
function Vaciar_ModalCrear() {
    //VACIADO DE INPUTS
    $("#Crear #isr_RangoInicial").val("");
    $("#Crear #isr_RangoFinal").val("");
    $("#Crear #tde_IdTipoDedu").val(0);
    $("#Crear #isr_Porcentaje").val("");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Crear #isr_RangoInicialValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Crear #AsteriscoRangoInicial").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Crear #isr_RangoFinalValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Crear #AsteriscoRangoFinal").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Crear #isr_TipoDeduccionValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Crear #AsteriscoTipoDeduccion").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Crear #timv_PorcentajeValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Crear #AsteriscoPorcentaje").removeClass("text-danger");

}

//FUNCION: OCULTAR VALIDACIONES DE EDICION
function Vaciar_ModalEditar() {
    //VACIADO DE INPUTS
    $("#Editar #timv_RangoInicio").val("");
    $("#Editar #timv_RangoFin").val("");
    $("#Editar #timv_Rango").val("");
    $("#Editar #tde_IdTipoDedu").val(0);
    $("#Editar #mun_Nombre").val(0);
    $("#Editar #timv_Porcentaje").val("");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Editar #timv_RangoInicioValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoRangoInicio").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Editar #timv_RangoFinValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoRangoFin").removeClass("text-danger");

    //OCULTAR DATAANNOTATIONS
    $("#Editar #timv_RangoValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoRango").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Editar #tde_TipoDeduccionValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoTipoDeduccion").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Editar #mun_NombreValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoMunicipio").removeClass("text-danger");

    //
    //OCULTAR DATAANNOTATIONS
    $("#Editar #timv_PorcentajeValidacion").hide();
    //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
    $("#Editar #AsteriscoPorcentaje").removeClass("text-danger");
}

//FUNCION PARA MOSTRAR O QUITAR DATAANNOTATIONS
function DataAnnotationsCrear(RangoInicio, RangoFin, Rango, TipoDeduccion,  Municipio, Porcentaje) {

    //VARIABLE DE VALIDACION DEL MODELO
    var ModelState = true;

    if (RangoInicial != "-1") {
        //RANGO INICIAL

        if (parseFloat(FormatearMonto(RangoInicial)) >= parseFloat(FormatearMonto($("#Crear #isr_RangoFinal").val()))) {
            $("#Crear #AsteriscoRangoFinal").addClass("text-danger");
            $("#Crear #isr_RangoFinalValidacion").empty();
            $("#Crear #isr_RangoFinalValidacion").html("El campo Rango Final debe ser mayor que el rango inicial.");
            $("#Crear #isr_RangoFinalValidacion").show();
            ModelState = false;
        }
        else {
            $("#Crear #AsteriscoRangoFinal").removeClass("text-danger");
            $("#Crear #isr_RangoFinalValidacion").empty();
            $("#Crear #isr_RangoFinalValidacion").html("El campo Rango Final es requerido.");
            $("#Crear #isr_RangoFinalValidacion").hide();
        }

        if (RangoInicial == "" || RangoInicial == null || RangoInicial == undefined) {
            $("#Crear #AsteriscoRangoInicial").addClass("text-danger");
            $("#Crear #isr_RangoInicialValidacion").show();

            ModelState = false;
        } else {
            $("#Crear #AsteriscoRangoInicial").removeClass("text-danger");
            $("#Crear #isr_RangoInicialValidacion").hide();
            if (parseInt(RangoInicial) < 0 || parseFloat(RangoInicial) < 0.00) {

                $("#Crear #AsteriscoRangoInicial").addClass("text-danger");
                $("#Crear #isr_RangoInicialValidacion").empty();
                $("#Crear #isr_RangoInicialValidacion").html("El campo Rango Inicial no puede ser menor que cero.");
                $("#Crear #isr_RangoInicialValidacion").show();
                ModelState = false;
            } else {
                $("#Crear #isr_RangoInicialValidacion").empty();
                $("#Crear #isr_RangoInicialValidacion").html("El campo Rango Inicial es requerido.");
                $("#Crear #AsteriscoRangoInicial").removeClass("text-danger");
                $("#Crear #isr_RangoInicialValidacion").hide();
            }
        }
    }


    if (RangoFinal != "-1") {
        //RANGO FINAL
        if (RangoFinal == "" || RangoFinal == null || RangoFinal == undefined) {
            $("#Crear #AsteriscoRangoFinal").addClass("text-danger");
            $("#Crear #isr_RangoFinalValidacion").show();

            ModelState = false;
        } else {
            $("#Crear #AsteriscoRangoFinal").removeClass("text-danger");
            $("#Crear #isr_RangoFinalValidacion").hide();

            if (parseFloat(FormatearMonto(RangoFinal)) <= parseFloat(FormatearMonto($("#Crear #isr_RangoInicial").val())) || parseFloat(FormatearMonto(RangoFinal)) == 0) {
                $("#Crear #AsteriscoRangoFinal").addClass("text-danger");
                $("#Crear #isr_RangoFinalValidacion").empty();
                $("#Crear #isr_RangoFinalValidacion").html("El campo Rango Final debe ser mayor que el rango inicial.");
                $("#Crear #isr_RangoFinalValidacion").show();
                ModelState = false;
            } else {
                $("#Crear #isr_RangoFinalValidacion").empty();
                $("#Crear #isr_RangoFinalValidacion").html("El campo Rango Final es requerido.");
                $("#Crear #AsteriscoRangoFinal").removeClass("text-danger");
                $("#Crear #isr_RangoFinalValidacion").hide();
            }

        }
    }


    if (TipoDeduccion != "-1") {
        //Telefono
        if (TipoDeduccion == "" || TipoDeduccion == "0" || TipoDeduccion == 0) {
            //MOSTRAR DATAANNOTATIONS
            $("#Crear #isr_TipoDeduccionValidacion").show();
            //CAMBIAR EL COLOR DEL ASTERISCO A ROJO
            $("#Crear #AsteriscoTipoDeduccion").addClass("text-danger");
            ModelState = false;
        }
        else {
            //OCULTAR DATAANNOTATIONS
            $("#Crear #isr_TipoDeduccionValidacion").hide();
            //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
            $("#Crear #AsteriscoTipoDeduccion").removeClass("text-danger");
        }
    }


    if (Porcentaje != "-1") {
        //PORCENTAJE
        if (Porcentaje == "" || Porcentaje == null || Porcentaje == undefined) {
            $("#Crear #AsteriscoPorcentaje").addClass("text-danger");
            $("#Crear #isr_PorcentajeValidacion").show();

            ModelState = false;
        } else {
            $("#Crear #AsteriscoPorcentaje").removeClass("text-danger");
            $("#Crear #isr_PorcentajeValidacion").hide();
            //CONVERTIR EN DECIMAL EL PORCENTAJE
            Porcentaje = parseFloat(FormatearMonto(Porcentaje));
            if (parseInt(Porcentaje) < 0 || parseFloat(Porcentaje) < 0.00) {
                $("#Crear #AsteriscoPorcentaje").addClass("text-danger");
                $("#Crear #isr_PorcentajeValidacion").empty();
                $("#Crear #isr_PorcentajeValidacion").html("El campo Porcentaje no puede ser menor a 0.");
                $("#Crear #isr_PorcentajeValidacion").show();
                ModelState = false;
            } else if (Porcentaje > 100) {
                $("#Crear #AsteriscoPorcentaje").addClass("text-danger");
                $("#Crear #isr_PorcentajeValidacion").empty();
                $("#Crear #isr_PorcentajeValidacion").html("El campo Porcentaje no puede ser mayor a 100.");
                $("#Crear #isr_PorcentajeValidacion").show();
            } else {
                $("#Crear #isr_PorcentajeValidacion").empty();
                $("#Crear #isr_PorcentajeValidacion").html("El campo Porcentaje es requerido.");
                $("#Crear #AsteriscoPorcentaje").removeClass("text-danger");
                $("#Crear #isr_PorcentajeValidacion").hide();
            }
        }
    }

    //RETURN DEL ESTADO DEL MODELO
    return ModelState;
}

//FUNCION PARA MOSTRAR O QUITAR DATAANNOTATIONS
function DataAnnotationsEditar(CodMuni, TipoDeduccion, RangoInicio, RangoFin, Rango, Impuesto) {

    //VARIABLE DE VALIDACION DEL MODELO
    var ModelState = true;

    if (RangoInicial != "-1") {

        if (parseFloat(FormatearMonto(RangoInicio)) >= parseFloat(FormatearMonto($("#Editar #timv_RangoInicio").val()))) {
            $("#Editar #AsteriscoRangoInicio").addClass("text-danger");
            $("#Editar #timv_RangoInicioValidacion").empty();
            $("#Editar #timv_RangoInicioValidacion").html("El campo Rango Final debe ser mayor que el rango inicial.");
            $("#Editar #timv_RangoInicioValidacion").show();
            ModelState = false;
        }
        else {
            $("#Editar #AsteriscoRangoFin").removeClass("text-danger");
            $("#Editar #timv_RangoFinValidacion").empty();
            $("#Editar #timv_RangoFinValidacion").html("El campo Rango Final es requerido.");
            $("#Editar #timv_RangoFinValidacion").hide();
        }

        //RANGO INICIAL
        if (RangoInicial == "" || RangoInicial == null || RangoInicial == undefined) {
            $("#Editar #AsteriscoRangoFinal").addClass("text-danger");
            $("#Editar #isr_RangoInicialValidacion").show();

            ModelState = false;
        } else {
            $("#Editar #AsteriscoRangoInicial").removeClass("text-danger");
            $("#Editar #isr_RangoInicialValidacion").hide();
            if (parseInt(RangoInicial) < 0 || parseFloat(RangoInicial) < 0.00) {

                $("#Editar #AsteriscoRangoInicial").addClass("text-danger");
                $("#Editar #isr_RangoInicialValidacion").empty();
                $("#Editar #isr_RangoInicialValidacion").html("El campo Rango Final no puede ser menor que cero.");
                $("#Editar #isr_RangoInicialValidacion").show();
                ModelState = false;
            } else {

                $("#Editar #AsteriscoRangoInicial").removeClass("text-danger");
                $("#Editar #isr_RangoInicialValidacion").hide();
            }
        }
    }


    if (RangoFinal != "-1") {
        //RANGO FINAL
        if (RangoFinal == "" || RangoFinal == null || RangoFinal == undefined) {
            $("#Editar #AsteriscoRangoFinal").addClass("text-danger");
            $("#Editar #isr_RangoFinalValidacion").show();

            ModelState = false;
        } else {
            $("#Editar #AsteriscoRangoFinal").removeClass("text-danger");
            $("#Editar #isr_RangoFinalValidacion").hide();

            if (parseFloat(FormatearMonto(RangoFinal)) <= parseFloat(FormatearMonto($("#Editar #isr_RangoInicial").val())) || parseFloat(FormatearMonto(RangoFinal)) == 0) {

                $("#Editar #AsteriscoRangoFinal").addClass("text-danger");
                $("#Editar #isr_RangoFinalValidacion").empty();
                $("#Editar #isr_RangoFinalValidacion").html("El campo Rango Final debe ser mayor que el rango inicial.");
                $("#Editar #isr_RangoFinalValidacion").show();
                ModelState = false;
            } else {
                $("#Editar #isr_RangoFinalValidacion").empty();
                $("#Editar #isr_RangoFinalValidacion").html("El campo Rango Final es requerido.");
                $("#Editar #AsteriscoRangoFinal").removeClass("text-danger");
                $("#Editar #isr_RangoFinalValidacion").hide();
            }

        }
    }


    if (TipoDeduccion != "-1") {
        //Telefono
        if (TipoDeduccion == "" || TipoDeduccion == "0" || TipoDeduccion == 0) {
            //MOSTRAR DATAANNOTATIONS
            $("#Editar #isr_TipoDeduccionValidacion").show();
            //CAMBIAR EL COLOR DEL ASTERISCO A ROJO
            $("#Editar #Asterisco_insf_Telefono").addClass("text-danger");
            ModelState = false;
        }
        else {
            //OCULTAR DATAANNOTATIONS
            $("#Editar #isr_TipoDeduccionValidacion").hide();
            //CAMBIAR EL COLOR DEL ASTERISCO A NEGRO
            $("#Editar #AsteriscoTipoDeduccion").removeClass("text-danger");
        }
    }


    if (Porcentaje != "-1") {
        //PORCENTAJE
        if (Porcentaje == "" || Porcentaje == null || Porcentaje == undefined) {
            $("#Editar #AsteriscoPorcentaje").addClass("text-danger");
            $("#Editar #isr_PorcentajeValidacion").show();

            ModelState = false;
        } else {
            $("#Editar #AsteriscoPorcentaje").removeClass("text-danger");
            $("#Editar #isr_PorcentajeValidacion").hide();
            //CONVERTIR EN DECIMAL EL PORCENTAJE
            Porcentaje = parseFloat(FormatearMonto(Porcentaje));
            if (Porcentaje < 0 || Porcentaje < 0.00) {
                $("#Editar #AsteriscoPorcentaje").addClass("text-danger");
                $("#Editar #isr_PorcentajeValidacion").empty();
                $("#Editar #isr_PorcentajeValidacion").html("El campo Porcentaje no puede ser menor a 0.");
                $("#Editar #isr_PorcentajeValidacion").show();
                ModelState = false;
            } else if (Porcentaje > 100) {
                $("#Editar #AsteriscoPorcentaje").addClass("text-danger");
                $("#Editar #isr_PorcentajeValidacion").empty();
                $("#Editar #isr_PorcentajeValidacion").html("El campo Porcentaje no puede ser mayor a 100.");
                $("#Editar #isr_PorcentajeValidacion").show();
            } else {
                $("#Editar #AsteriscoPorcentaje").removeClass("text-danger");
                $("#Editar #isr_PorcentajeValidacion").hide();
            }
        }
    }

    //RETURN DEL ESTADO DEL MODELO
    return ModelState;
}

//FUNCION: FORMATEAR MONTOS A DECIMAL
function FormatearMonto(StringValue) {
    //SEGMENTAR LA CADENA DE MONTO
    var indices = StringValue.split(",");
    //VARIABLE CONTENEDORA DEL MONTO
    var MontoFormateado = "";
    //ITERAR LOS INDICES DEL ARRAY MONTO
    for (var i = 0; i <= indices.length; i++) {
        //SETEAR LA VARIABLE DE MONTO
        MontoFormateado += indices[i];
    }
    //FORMATEAR A DECIMAL
    MontoFormateado = parseFloat(MontoFormateado);
    //RETORNAR MONTO FORMATEADO
    return MontoFormateado;
}