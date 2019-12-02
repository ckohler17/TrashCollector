namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingemployeepropertiesagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Name");
        }
    }
}
