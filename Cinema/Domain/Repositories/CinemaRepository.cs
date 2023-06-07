using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories;

public class CinemaRepository : ARepository<Cinema> {
    public CinemaRepository(MovieContext context) :
        base(context) {
    }
}
