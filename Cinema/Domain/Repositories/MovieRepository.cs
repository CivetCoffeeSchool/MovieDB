using Model.Configurations;

namespace Domain.Repositories;

public class MovieRepository : ARepository<Movie> {
    public MovieRepository(MovieContext context) :
        base(context) {
    }
}