using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class MovieContext : DbContext {
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }
    
    public DbSet<Movie> Movies{ get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Hall> Halls { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Cinema>()
            .HasOne(c => c.Address)
            .WithOne()
            .HasForeignKey<Cinema>(c => c.AddressId);
        
        //Address
        builder.Entity<Address>()
            .HasOne(a => a.Country)
            .WithMany()
            .HasForeignKey(a => a.CountryName);

        builder.Entity<Address>()
            .HasOne(a => a.State)
            .WithMany()
            .HasForeignKey(a => a.StateCode);
        
        //hall
        builder.Entity<Hall>()
            .HasOne(h => h.Cinema)
            .WithMany()
            .HasForeignKey(h => h.CinemaId);
        
        //Person
        builder.Entity<Person>()
            .HasDiscriminator<string>("DISCRIMINATOR")
            .HasValue<Customer>("CUSTOMER")
            .HasValue<Crew>("CREW");
        
        //EntertainmentMovie and docu
        builder.Entity<DocumentaryMovie>().ToTable("DOCU_MOVIES");
        builder.Entity<EntertainmentMovie>().ToTable("ENTERTAINMENT_MOVIES");
    }

}