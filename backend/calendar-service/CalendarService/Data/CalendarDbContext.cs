using Microsoft.EntityFrameworkCore;
using CalendarService.Models;

namespace CalendarService.Data
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) { }

        public DbSet<LunarEvent> LunarEvents { get; set; }
    }
}
