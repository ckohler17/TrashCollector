namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingpropertyfrombooltostringtoconfirmpickup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PickUpCompleted", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PickUpCompleted", c => c.Boolean(nullable: false));
        }
    }
}
