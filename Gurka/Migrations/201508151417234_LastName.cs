namespace Gurka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "LastName");
        }
    }
}
