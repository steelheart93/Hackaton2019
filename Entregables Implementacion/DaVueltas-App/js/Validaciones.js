tarjetas = 1;
function addTarjeta(){
    var tarjetas = document.getElementById("tarjetas");
    var input = document.createElement("input");
    input.setAttribute("name", "tarjeta" + tarjetas);
    input.setAttribute("type", "text");
    input.setAttribute("class", "form-control");
    input.setAttribute("placeholder", "Tarjeta de crédito o débito");

    var label = document.createElement("label");
    label.setAttribute("for", "tarjeta" + tarjetas);

    tarjetas.appendChild(label);
    tarjetas.appendChild(input);
    tarjetas++;
}