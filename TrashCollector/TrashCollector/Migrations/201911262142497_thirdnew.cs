namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "name");
        }
    }
}
