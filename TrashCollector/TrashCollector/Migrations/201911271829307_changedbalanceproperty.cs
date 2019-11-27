namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedbalanceproperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Balance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Balance", c => c.Double(nullable: false));
        }
    }
}
