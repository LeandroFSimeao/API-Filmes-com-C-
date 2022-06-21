using FilmesAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI2.Data
{
    public class FilmeContext : DbContext
    {

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }

        public DbSet<Filme> Filmes { get; set; }

    }
}
