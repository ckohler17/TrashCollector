namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ExtraPickUpDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ExtraPickUpDate");
        }
    }
}
