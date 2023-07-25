namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.NewsContext context)
        {
            var cats = new string[] { "Sports","Business","Entertainment","Current Affairs","International Affairs","Politics"};
            foreach (var c in cats) {
                context.Categories.AddOrUpdate(
                        new EF.Models.Category() { 
                            Name = c
                        }
                    );
            }
            Random random = new Random();
            for (int i = 1; i < 100; i++)
            {
                context.News.AddOrUpdate(
                        new EF.Models.News { 
                            Title = Guid.NewGuid().ToString(),
                            CId = random.Next(1, 7),
                            Date = DateTime.Now.AddDays(random.Next(0,8)*-1)
                        }
                    );
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
