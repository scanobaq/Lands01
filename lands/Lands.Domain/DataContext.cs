using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lands.Domain
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }
    }
}
