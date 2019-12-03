namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingpropertytoemployeefordaysofweek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DayOfWeek", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DayOfWeek");
        }
    }
}
