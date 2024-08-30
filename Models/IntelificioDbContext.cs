using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intelificio_Back.Models
{
    public class IntelificioDbContext : IdentityDbContext<User, Role, int>
    {
        public IntelificioDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AssignedShift> AssignedShifts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Visit> Visits { get; set; }

        public DbSet<UnitType> UnitTypes { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<ShiftType> ShiftTypes { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<Pet> Pets { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
