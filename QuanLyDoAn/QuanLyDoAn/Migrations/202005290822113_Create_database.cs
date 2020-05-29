namespace QuanLyDoAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(maxLength: 256),
                        Email = c.String(unicode: false),
                        CreationTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        EmailConfirmed = c.Boolean(),
                        IsDelete = c.Boolean(),
                        DeleteTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        RoleID = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
