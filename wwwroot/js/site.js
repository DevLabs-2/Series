function MostrarTemporadas(IdSerie, Nombre){
    console.log(IdSerie);
    $.ajax(
            {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerTemporadas',
            data: { IdSerie: IdSerie},
            success:
                function (response)
                {
                    console.log(response);
                    $("#Titulo").html("Cantidad de Temporadas de la Serie " + Nombre + ": " + response.length);
                    let TextoTemporada = "";
                    response.forEach(element => {
                        TextoTemporada += element.tituloTemporada + "<br>";
                    });
                    $("#Cuerpo").html(TextoTemporada);
                }
        });
}
function MostrarActores(IdSerie, Nombre){
    console.log(IdSerie);
    $.ajax(
            {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerActores',
            data: { IdSerie: IdSerie},
            success:
                function (response)
                {
                    console.log(response);
                    $("#Titulo").html("Cantidad de Actores de la Serie " + Nombre + ": " + response.length);
                    let TextoActores = "";
                    response.forEach(element => {
                        TextoActores += element.nombre + "<br>";
                    });
                    $("#Cuerpo").html(TextoActores);
                }
        });
}
function MostrarInfo(IdSerie, Nombre){
    console.log(IdSerie);
    $.ajax(
            {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerInfo',
            data: { IdSerie: IdSerie},
            success:
                function (response)
                {
                    console.log(response);
                    $("#Titulo").html("Más información de la serie " + Nombre);
                    $("#Cuerpo").html("Año de salida" + response.añoInicio + "<br>");
                }
        });
}