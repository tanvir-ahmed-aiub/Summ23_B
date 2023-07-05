namespace EFCodeFirst.Migrations
{
    using EFCodeFirst.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.EF.UMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirst.EF.UMSContext context)
        {
            List<Department> depts = new List<Department>();
            for (int i = 1; i <= 10; i++) { 
                depts.Add(new Department() { 
                    Name = "Department " + i
                });
            }
            context.Departments.AddOrUpdate(depts.ToArray());
            List<Course> courses = new List<Course>();
            Random random = new Random();
            for (int i = 1; i <= 100; i++) {
                courses.Add(new Course()
                {
                    Name = "Course "+i,
                    DeptId = random.Next(1,11)

                });
            }
            context.Courses.AddOrUpdate(courses.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
