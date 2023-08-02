using Microsoft.EntityFrameworkCore;

namespace WebAPILesson.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        #region DbSet
        public DbSet<Gears> Gears { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<GymBooking> GymBookings { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(e =>
            {
                e.ToTable("Orders");
                e.HasKey(x => x.order_id);
                e.Property(x => x.order_date).HasDefaultValueSql("getutcdate()")
                .IsRequired()
                ;
                e.Property(o => o.total_amount)
                      .IsRequired()
                      .HasColumnType("money"); // TotalAmount là bắt buộc và có kiểu decimal(18, 2)

                e.Property(o => o.order_status)
                      .IsRequired()
                      .HasConversion<int>(); // Chuyển đổi kiểu enum OrderStatus sang int khi lưu xuống cơ sở dữ liệu

                e.Property(o => o.address)
                      .HasMaxLength(100); // Giới hạn độ dài của Address là 100 ký tự

                e.Property(o => o.phone)
                      .HasMaxLength(10); // Giới hạn độ dài của Phone là 20 ký tự


                e.HasOne(x => x.user)
                .WithMany(x => x.orders)
                .HasForeignKey(x => x.user_id)
                .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderItem>(e =>
            {
                e.ToTable("OrderItems");
                e.HasKey(e => e.item_id);

                e.HasOne(e => e.order)
                .WithMany(e => e.orderItems)
                .HasForeignKey(e => e.order_id)
                .HasConstraintName("FK_OrderItem_Order");

                e.HasOne(e => e.gears)
                .WithMany(e => e.orderItems)
                .HasForeignKey(e => e.gear_id)
                .HasConstraintName("FK_OrderItem_Gear");
            });
            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("Users");
                e.HasKey(e => e.user_id);

                e.Property(e => e.username).HasMaxLength(50)
                .IsRequired();
                
                e.Property(e=>e.email).HasMaxLength(50)
                .IsRequired();
                e.Property(e => e.phone).HasMaxLength(10)
                .IsRequired();
                e.Property(e => e.address).HasMaxLength(100)
                .IsRequired();
            });
            modelBuilder.Entity<CourseEnrollment>(e =>
            {
                e.ToTable("CourseEnrollments");
                e.HasKey(e => e.courenroll_id);

                e.Property(e => e.price).IsRequired()
                      .HasColumnType("money");

                e.HasOne(e => e.user)
                .WithMany(e => e.courseEnrollments)
                .HasForeignKey(e => e.user_id)
                .HasConstraintName("FK_CourseEnrollment_User");

                e.HasOne(e => e.course)
                .WithMany(e => e.courseEnrollments)
                .HasForeignKey(e => e.course_id)
                .HasConstraintName("FK_CourseEnrollment_Course");
                
            });
            modelBuilder.Entity<New>(e =>
            {
                e.ToTable("News");
                e.HasKey(e => e.news_id);
                e.Property(e => e.publish_date).HasDefaultValueSql("getutcdate()");
            });
            modelBuilder.Entity<Gym>(e =>
            {
                e.ToTable("Gyms");
                e.HasKey(e => e.gym_id);
                e.Property(e => e.gym_name).HasMaxLength(50)
                .IsRequired();
                e.Property(e => e.address).HasMaxLength(100)
                .IsRequired();
                e.Property(e => e.phone).HasMaxLength(10)
                .IsRequired();
                e.Property(e => e.website_url).HasMaxLength(50);
                e.Property(e => e.email).HasMaxLength(50).IsRequired();

            });
            modelBuilder.Entity<GymBooking>(e =>
            {
                e.ToTable("GymBookings");
                e.HasKey(e=>e.booking_id);
                e.Property(e => e.booking_date).HasDefaultValueSql("getutcdate()")
                .IsRequired();

                e.HasOne(e => e.user)
                .WithMany(e => e.gymBookings)
                .HasForeignKey(e => e.user_id)
                .HasConstraintName("FK_GymBooking_User");


                e.HasOne(e => e.gym)
                .WithMany(e => e.gymBookings)
                .HasForeignKey(e => e.gym_id)
                .HasConstraintName("FK_GymBooking_Gym");
            });
    }
    }
}
