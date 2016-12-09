using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace Domain.Model
{
[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Entities : DbContext
    {
        // 您可以向此文件中添加自定义代码。更改不会被覆盖。
        // 
        // 如果您希望只要更改模型架构，Entity Framework
        // 就会自动删除并重新生成数据库，则将以下
        // 代码添加到 Global.asax 文件中的 Application_Start 方法。
        // 注意: 这将在每次更改模型时销毁并重新创建数据库。
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Domain.Model.FarmContext>());

        //public DbSet<Customer> Customers { get; set; }
        static Entities()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }
        public Entities() : base("name=FarmContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 禁用一对多级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // 禁用多对多级联删除
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Quality> qualities { get; set; }

        public DbSet<Season> Seasons { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Log> Logs { get; set; }
        
    }
     
}
