namespace TaskManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskIsComplete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerTasks", "IsCompleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerTasks", "IsCompleted");
        }
    }
}
