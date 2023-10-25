using Microsoft.EntityFrameworkCore;

namespace DonateryWeb_Appr.Models
{
        public partial class disasteralleviationfoundationdbContext : DbContext
        {
            public disasteralleviationfoundationdbContext()
            {
            }

            public disasteralleviationfoundationdbContext(DbContextOptions<disasteralleviationfoundationdbContext> options)
                : base(options)
            {
            }

            public virtual DbSet<ActiveDisaster> ActiveDisasters { get; set; }
            public virtual DbSet<AllocationOfGood> AllocationOfGoods { get; set; }
            public virtual DbSet<AllocationOfMoney> AllocationOfMoneys { get; set; }
            public virtual DbSet<AuthorisedUser> AuthorisedUsers { get; set; }
            public virtual DbSet<DonationOfGood> DonationOfGoods { get; set; }
            public virtual DbSet<DonationOfGoodsCategory> DonationOfGoodsCategories { get; set; }
            public virtual DbSet<DonationsOfMoney> DonationsOfMoneys { get; set; }
            public virtual DbSet<PurchasesOfGood> PurchasesOfGoods { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                optionsBuilder.UseSqlServer("Server=tcp:tshephoscomputer.database.windows.net,1433;Initial Catalog=Appr6312;Persist Security Info=False;User ID=Admin1;Password=Scrobswinks18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

      

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
