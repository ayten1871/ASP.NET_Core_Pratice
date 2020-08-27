using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Pratice.Models;

namespace ASP.NET_Core_Pratice.Data
{
    public class ASPNET_Core_PraticeContext : DbContext
    {
        public ASPNET_Core_PraticeContext (DbContextOptions<ASPNET_Core_PraticeContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_Pratice.Models.Movie> Movie { get; set; }
    }
}
