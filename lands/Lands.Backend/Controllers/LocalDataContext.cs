namespace Lands.Backend.Controllers
{
    using Domain;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Lands.Domain.User> Users { get; set; }
    }
}