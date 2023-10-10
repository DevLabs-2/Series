function MostrarTemporadas(IdSerie){
    $.ajax{
        {
            type: 'POST';
            dataType: 'JSON';
            url: '/Home/VerTemporadas'
            data: { IdSerie: IdSerie}
            succes:
                function (response)
                {
                    $("w")
                }
        }
    }
}