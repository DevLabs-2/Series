using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";

    public static List<Serie> GetSeries(){
         using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Serie";
                return db.Query<Serie>(sql).ToList();
            } 
    }
    public static Serie GetInfoSerie(int idSerie){
        Serie serie = new Serie();
         using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Serie WHERE IdSerie = @idSerie";
                serie = db.QueryFirstOrDefault<Serie>(sql, new {idSerie = idSerie});
                return serie;
            } 
    }
    public static List<Actor> GetActores(int IdSerie){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Actor WHERE IdSerie = @IdSerie";
                return db.Query<Actor>(sql, new{IdSerie = IdSerie}).ToList();
            } 
    }
    public static List<Temporada> GetTemporadas(int IdSerie){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Temporada WHERE IdSerie = @IdSerie";
                return db.Query<Temporada>(sql, new{IdSerie = IdSerie}).ToList();
            } 
    }
}