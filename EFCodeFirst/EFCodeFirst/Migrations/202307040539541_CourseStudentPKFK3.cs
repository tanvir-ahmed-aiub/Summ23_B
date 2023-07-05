namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseStudentPKFK3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.CourseStudents", "StudentId");
            AddForeignKey("dbo.CourseStudents", "StudentId", "dbo.Students", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseStudents", "StudentId", "dbo.Students");
            DropIndex("dbo.CourseStudents", new[] { "StudentId" });
        }
    }
}
