namespace TaskManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskTableAndLink : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerTasks", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.CustomerTasks", new[] { "Customer_Id" });
            DropColumn("dbo.CustomerTasks", "CustomerID");
            DropColumn("dbo.CustomerTasks", "Customer_Id");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerTasks", "Customer_Id", c => c.Int());
            AddColumn("dbo.CustomerTasks", "CustomerID", c => c.Byte(nullable: false));
            CreateIndex("dbo.CustomerTasks", "Customer_Id");
            AddForeignKey("dbo.CustomerTasks", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
