namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingattributestocleanupviews : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "IsSuspended");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSuspended", c => c.Boolean(nullable: false));
        }
    }
}
