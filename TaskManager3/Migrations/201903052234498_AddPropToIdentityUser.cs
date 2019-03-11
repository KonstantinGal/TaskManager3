namespace TaskManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropToIdentityUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CustomerTaskId", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "CustomerTask_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "CustomerTask_Id");
            AddForeignKey("dbo.AspNetUsers", "CustomerTask_Id", "dbo.CustomerTasks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "CustomerTask_Id", "dbo.CustomerTasks");
            DropIndex("dbo.AspNetUsers", new[] { "CustomerTask_Id" });
            DropColumn("dbo.AspNetUsers", "CustomerTask_Id");
            DropColumn("dbo.AspNetUsers", "CustomerTaskId");
        }
    }
}
