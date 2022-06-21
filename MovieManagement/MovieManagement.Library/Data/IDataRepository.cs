namespace MovieManagement.Library.Data
{
    public interface IDataRepository<T> where T : class
    {
        List<T> GetMovies();
        T AddMovie(T movie);
        T GetById(int id);
    }
}
