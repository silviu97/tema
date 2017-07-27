namespace MoviezApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comment1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comment", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comment", "Date", c => c.DateTime(nullable: false));
        }
    }
}
