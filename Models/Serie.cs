public class Serie{
    public int IdSerie{get;set;}
    public string Nombre{get;set;}
    public int AñoInicio{get;set;}
    public string Sinopsis{get;set;}
    public string ImagenSerie{get;set;}

    public Serie(){

    }
    public Serie(string nombre, string imagenSerie){
        Nombre = nombre;
        ImagenSerie = imagenSerie;
    }
    public Serie(int idSerie, string nombre, int anioinicio, string sinopsis, string imagenSerie){
        IdSerie = idSerie;
        Nombre = nombre;
        AñoInicio = anioinicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenSerie;
    }
}