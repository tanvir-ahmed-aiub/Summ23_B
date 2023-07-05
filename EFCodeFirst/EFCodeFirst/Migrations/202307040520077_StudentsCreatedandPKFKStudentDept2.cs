namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentsCreatedandPKFKStudentDept2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropColumn("dbo.Students", "DeptId");
            RenameColumn(table: "dbo.Students", name: "Department_Id", newName: "DeptId");
            AlterColumn("dbo.Students", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "DeptId");
            AddForeignKey("dbo.Students", "DeptId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DeptId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DeptId" });
            AlterColumn("dbo.Students", "DeptId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "DeptId", newName: "Department_Id");
            AddColumn("dbo.Students", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Department_Id");
            AddForeignKey("dbo.Students", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
