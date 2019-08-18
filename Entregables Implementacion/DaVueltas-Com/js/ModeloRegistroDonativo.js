/**
 * @author EstamosPensando
 * @version 18/08/2019
 */

class ModeloRegistroDonativo {
    static existeBenefactor(documentoBenefactor) {
        var promesa = $.get("https://localhost:44377/api/ctrl", { documento: documentoBenefactor });

        promesa.done(function (respuesta) {
            var json = JSON.parse(respuesta);
        });

        promesa.fail(function (respuesta) {
            var json = JSON.parse(respuesta);
        });
    }

    static solicitarRegistroDonativo(jsonDonativo) {
        var promesa = $.post("https://localhost:44377/api/ctrl", jsonDonativo);

        promesa.done(function (respuesta) {
            var json = JSON.parse(respuesta);
        });

        promesa.fail(function (respuesta) {
            var json = JSON.parse(respuesta);
        });
    }
}

