namespace TaskManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "CustomerTask_Id", "dbo.CustomerTasks");
            DropIndex("dbo.AspNetUsers", new[] { "CustomerTask_Id" });
            DropColumn("dbo.AspNetUsers", "CustomerTask_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CustomerTask_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "CustomerTask_Id");
            AddForeignKey("dbo.AspNetUsers", "CustomerTask_Id", "dbo.CustomerTasks", "Id");
        }
    }
}
