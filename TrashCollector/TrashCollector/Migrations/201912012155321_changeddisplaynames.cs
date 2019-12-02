namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeddisplaynames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Zip", c => c.String());
            DropColumn("dbo.Employees", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "ZipCode", c => c.String());
            DropColumn("dbo.Employees", "Zip");
        }
    }
}
