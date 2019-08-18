/**
 * @author EstamosPensando
 * @version 18/08/2019
 */

class ModeloDaVueltasApp {
    static esBenefactor(documento){
        

        $.ajax({
            url: "http://localhost:44315/api/ctrl",
            type: "post",
            success: function( response ) {
                return response.JSON(response);
            },
            error: function( response ){
                return false;
            }

        });
    }

    static esBenefactor(documento){
        

        $.ajax({
            url: "http://localhost:44315/api/ctrl",
            type: "post",
            success: function( response ) {
                return response.JSON(response);
            },
            error: function( response ){
                return false;
            }

        });
    }

    static existeBenefactor(documentoBenefactor) {
        var promesa = $.get("https://localhost:44377/api/ctrl", { documento: documentoBenefactor });

        promesa.done(function (respuesta) {
            var json = JSON.parse(respuesta);
        });

        promesa.fail(function (respuesta) {
            var json = JSON.parse(respuesta);
        });
    }

    static consultaDonacionesPendientes() {
        var promesa = $.get("https://localhost:44377/api/ctrl");

        promesa.done(function (respuesta) {
            var json = JSON.parse(respuesta);

            var html = "";
            for (donativo of json) {
                html += `<tr> <td>${donativo.id}</td>`;
                html += `<td>${donativo.tarjeta}</td>`
                html += `<td>${donativo.valor}</td>`
                html += `<td>${donativo.nitBeneficiario}</td>`
                html += `<td>${donativo.nombreBeneficiario}</td>`
                html += `<td>${donativo.nitEstablecimiento}</td>`
                html += `<td>${donativo.nombreEstablecimiento}</td>`
                html += ` <td>${donativo.nombreEstablecimiento}</td> </tr>`;
            }
            document.getElementById("tbody").innerHTML = html;
        });

        promesa.fail(function (respuesta) {
            var json = JSON.parse(respuesta);
        });
    }
}

