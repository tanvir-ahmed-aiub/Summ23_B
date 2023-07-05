namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseStudentPKFK2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseStudents", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseStudents", new[] { "CourseId" });
            DropTable("dbo.CourseStudents");
        }
    }
}
