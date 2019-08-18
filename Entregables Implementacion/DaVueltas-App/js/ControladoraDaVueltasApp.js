/**
 * Controladora de la Vista que serializa el contenido del Formulario 
 * del Registro de un Donativo y lo envía a un Modelo .
 * 
 * @author EstamosPensando
 * @version 18/08/2019
 */
function validarDocumento(){
    var documento = document.getElementById('documento').value;
    ModeloDaVueltasApp.esBenefactor(documento);
}

function validarTarjetas(){
    var documento = document.getElementById('documento').value;
    ModeloDaVueltasApp.esBenefactor(documento);
}

function obtenerInstituciones(){
    instituciones = ModeloDaVueltasApp.obtenerInstituciones();
}

/**
 * Controladora de la Vista que serializa el contenido del Formulario 
 * del Registro de un Donativo y lo envía a un Modelo .
 * 
 * @author EstamosPensando
 * @version 18/08/2019
 */

$(function () {
    $("#registrar").click(function () {
        var $form = $("#formulario");
        var data = getFormData($form);
        var respuesta = ModeloDaVueltasApp.existeBenefactor(data["documento"]);

        if (respuesta) {
            ModeloDaVueltasApp.consultaDonacionesPendientes();
        } else {
            alert("El benefactor no se encuentra registrado en el sistema, por favor verifique.");
        }
    });
});

/**
 * Método obtenido de, https://stackoverflow.com/questions/11338774/serialize-form-data-to-json
 */
function getFormData($form) {
    var unindexed_array = $form.serializeArray();
    var indexed_array = {};

    $.map(unindexed_array, function (n, i) {
        indexed_array[n['name']] = n['value'];
    });

    return indexed_array;
}