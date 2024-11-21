namespace hw4_ef_core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "ProjectId");
            AddForeignKey("dbo.Users", "ProjectId", "dbo.Projects", "ProjectId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Users", new[] { "ProjectId" });
            DropColumn("dbo.Users", "ProjectId");
        }
    }
}
