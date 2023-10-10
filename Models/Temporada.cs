public class Temporada{
    public int IdTemporada{get;}
    public int IdSerie{get;set;}
    public int NumeroTemporada{get;set;}
    public string TituloTemporada{get;set;}


public Temporada()
{

}
public Temporada(int idTemporada, int idSerie, int numeroTemporada, string tituloTemporada)
{
    IdTemporada = idTemporada;
    IdSerie = idSerie;
    NumeroTemporada = numeroTemporada;
    TituloTemporada = tituloTemporada;
}
}