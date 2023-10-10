public class Actor{
    public int IdActor{get;}
    public int IdSerie{get;set;}
    public string Nombre{get;set;}

    public Actor(){

    }
    public Actor(int idActor, int idSerie, string nombre){
        IdActor = idActor;
        IdSerie = idSerie;
        Nombre = nombre;
    }
}