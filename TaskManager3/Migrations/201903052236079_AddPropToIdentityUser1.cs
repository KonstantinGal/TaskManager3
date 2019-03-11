namespace TaskManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropToIdentityUser1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CustomerTaskId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CustomerTaskId", c => c.Byte(nullable: false));
        }
    }
}
