namespace MoviezApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Add",
                c => new
                    {
                        AddID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddID)
                .ForeignKey("dbo.Movie", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        RelaseYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Add", "MovieID", "dbo.Movie");
            DropIndex("dbo.Add", new[] { "MovieID" });
            DropTable("dbo.Movie");
            DropTable("dbo.Add");
        }
    }
}
