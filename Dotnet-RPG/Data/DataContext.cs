using Dotnet_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_RPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}