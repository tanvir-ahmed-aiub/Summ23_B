namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndTokenAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        Username = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Username)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "Username", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "Username" });
            DropTable("dbo.Users");
            DropTable("dbo.Tokens");
        }
    }
}
