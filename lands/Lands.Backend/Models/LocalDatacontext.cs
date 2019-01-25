
namespace Lands.Backend.Models
{
    using Lands.Domain;

    public class LocalDatacontext:DataContext
    {
        public System.Data.Entity.DbSet<Lands.Domain.User> Users { get; set; }
    }
}