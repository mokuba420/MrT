using Microsoft.EntityFrameworkCore;
using MRTshirtAPi.Api.Modles;

namespace MRTshirtAPi.Api.Data
{
    public class information : DbContext
    {
        public information(DbContextOptions<information> options)
            : base(options)
        {
        }

        public DbSet<TShirttable> TShirttable { get; set; }
    }
}