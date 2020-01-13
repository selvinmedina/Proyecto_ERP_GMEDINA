﻿//FUNCION GENERICA PARA REUTILIZAR AJAX
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

// REGION DE VARIABLES
var registroID = 0;


//Funcion para refrescar la tabala (Index)
function cargarGridINFS()
{
    var esAdministrador = $("#rol_Usuario").val();
    _ajax(null,
        '/InstitucionesFinancieras/GetData',
        'GET',
        (data) => {
            if (data.length == 0) {
                //Validar si se genera un error al cargar de nuevo el grid
                iziToast.error({
                    title: 'Error',
                    message: 'No se pudo cargar la información, contacte al administrador',
                });
            }
            //GUARDAR EN UNA VARIABLE LA DATA OBTENIDA
            var ListaINFS = data, template = '';
            //RECORRER DATA OBETINA Y CREAR UN "TEMPLATE" PARA REFRESCAR EL TBODY DE LA TABLA DEL INDEX
            for (var i = 0; i < ListaINFS.length; i++) {

                //variable para verificar el estado del registro
                var estadoRegistro = ListaINFS[i].insf_Activo == false ? 'Inactivo' : 'Activo';

                //variable boton detalles
                var botonDetalles = ListaINFS[i].insf_Activo == true ? '<a href="InstitucionesFinancieras/Details?id=' + ListaINFS[i].insf_IdInstitucionFinanciera + 'class="btn btn-primary btn-xs">Detalles</a>' : '';
                                                                     
                                                                     //'<button data-id = "' + ListListaINFSaAuxCes[i].insf_IdInstitucionFinanciera + '" type="button" class="btn btn-primary btn-xs"  id="btnModalDetalles">Detalles</button>'
                //variable boton editar
                var botonEditar = ListaINFS[i].insf_Activo == true ? '<a href="InstitucionesFinancieras/Edit?id=' + ListaINFS[i].insf_IdInstitucionFinanciera + 'class="btn btn-primary btn-xs">Detalles</a>' : '';
                    //'<button data-id = "' + ListaINFS[i].insf_IdInstitucionFinanciera + '" type="button" class="btn btn-default btn-xs"  id="btnModalEdit">Editar</button>' : '';

                //variable donde está el boton activar
                var botonInactivar = ListaINFS[i].insf_Activo == false ? esAdministrador == "1" ? '<button data-id = "' + ListaINFS[i].insf_IdInstitucionFinanciera + '" type="button" class="btn btn-danger btn-xs"  id="btnModalInactivarINFS">Inctivar</button>' : '' : '';
                                                                                                
                //variable donde está el boton activar
                var botonActivar = ListaINFS[i].insf_Activo == false ? esAdministrador == "1" ? '<button data-id = "' + ListaINFS[i].insf_IdInstitucionFinanciera + '" type="button" class="btn btn-primary btn-xs"  id="btnModalActivarINFS">Activar</button>' : '' : '';


                console.log(estadoRegistro);

                template += '<tr data-id = "' + ListaINFS[i].insf_IdInstitucionFinanciera + '">' +
                    '<td>' + ListaINFS[i].insf_DescInstitucionFinanc + '</td>' +
                    '<td>' + ListaINFS[i].insf_Contacto + '</td>' +
                    '<td>' + ListaINFS[i].insf_Telefono + '</td>' +
                    '<td>' + ListaINFS[i].insf_Correo + '</td>' +
                    '<td>' + estadoRegistro + '</td>' +
                     //variable donde está el boton de detalles
                    '<td>' + botonDetalles +

                    //variable donde está el boton de detalles
                     botonEditar +

                     //boton de inactivar
                     botonInactivar +

                    //boton activar 
                    botonActivar
                '</td>' +
                '</tr>';
            }
            //REFRESCAR EL TBODY DE LA TABLA DEL INDEX
            $('#tbodyINFS').html(template);
        });
    FullBody();

}


var ID_in = 0;
// INACTIVAR 
$("#btnModalInactivarINFS").click(function () {
    //$("#frmEditarAuxCes").modal('hide');
    ID_in = $(this).data('id');
    $("#frmInactivarINFS").modal();
});

$("#btnInactivarINFS").click(function () {
    //SERIALIZAR EL FORMULARIO (QUE ESTÁ EN LA VISTA PARCIAL) DEL MODAL, SE PARSEA A FORMATO JSON




    //SE ENVIA EL JSON AL SERVIDOR PARA EJECUTAR LA EDICIÓN
    $.ajax({
        url: "/InstitucionesFinancieras/Inactivar/" + ID_in,
        method: "POST"
    }).done(function (data) {
        if (data == "error") {
            //Cuando traiga un error del backend al guardar la edicion
            iziToast.error({
                title: 'Error',
                message: 'No se logró inactivar el registro, contacte al administrador',
            });
        }
        else {
            $("#btnModalInactivarINFS").modal('hide');
            //$("#frmEditarAuxCes").modal('hide');
            cargarGridINFS();
            //Mensaje de exito de la edicion
            iziToast.success({
                title: 'Exito',
                message: 'El registro se inactivó de forma exitosa!',
            });
        }
    });
    ID_in = 0;
    $("#frmInactivarINFS").modal('hide');
});


// Activar
var activarID = 0;
$(document).on("click", "#btnModalActivarINFS", function () {
    activarID = $(this).data('id');
    $("#frmActivarINFS").modal();
});

//activar ejecutar
$("#btnActivarINFS").click(function () {
    $.ajax({
        url: "/InstitucionesFinancieras/Activar/" + activarID,
        method: "POST",
        data: { id: activarID }
    }).done(function (data) {
        if (data == "error") {
            iziToast.error({
                title: 'Error',
                message: 'No se logró activar el registro, contacte al administrador',
            });
        }
        else {
            cargarGridINFS();
            $("#frmActivarINFS").modal('hide');
            //Mensaje de exito de la edicion
            iziToast.success({
                title: 'Éxito',
                message: '¡El registro se Activó de forma exitosa!',
            });
        }
    });
    activarID = 0;
    $("#frmActivarINFS").modal('hide');
});