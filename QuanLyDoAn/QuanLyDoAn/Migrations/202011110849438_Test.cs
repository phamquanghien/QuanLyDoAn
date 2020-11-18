namespace QuanLyDoAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleID", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.Roles", "RoleID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Roles", "RoleID");
        }
    }
}
