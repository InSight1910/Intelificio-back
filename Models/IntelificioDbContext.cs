using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Intelificio_Back.Models
{
    public class IntelificioDbContext : IdentityDbContext<User, Role, int>
    {
        public IntelificioDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AssignedShift> AssignedShifts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Building> Buildings { get; set; }

        public DbSet<Charge> Charges { get; set; }

        public DbSet<ChargeType> ChargeTypes { get; set; }

        public DbSet<CommonSpace> CommonSpaces { get; set; }

        public DbSet<Community> Community { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Expense> Expense { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

        public DbSet<Fine> Fine { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Municipality> Municipality { get; set; }

        public DbSet<Package> Package { get; set; }

        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
