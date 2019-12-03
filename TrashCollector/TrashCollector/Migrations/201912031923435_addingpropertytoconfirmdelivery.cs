namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingpropertytoconfirmdelivery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpCompleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Employees", "DayOfWeek");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "DayOfWeek", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "PickUpCompleted");
        }
    }
}
