namespace Gurka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PhoneNumber");
        }
    }
}
