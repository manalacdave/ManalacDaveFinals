using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerce.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}