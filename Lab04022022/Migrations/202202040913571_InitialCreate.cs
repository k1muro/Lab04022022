namespace Lab04022022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Olympiads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        CityName = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.PartyInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        DateBirth = c.DateTime(nullable: false),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SportViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportName = c.String(),
                        PartyInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartyInfoes", t => t.PartyInfo_Id)
                .Index(t => t.PartyInfo_Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OlympiadId = c.Int(nullable: false),
                        PartyinfoId = c.Int(nullable: false),
                        SportViewId = c.Int(nullable: false),
                        ResultName = c.String(),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Olympiads", t => t.OlympiadId, cascadeDelete: true)
                .ForeignKey("dbo.PartyInfoes", t => t.PartyinfoId, cascadeDelete: true)
                .ForeignKey("dbo.SportViews", t => t.SportViewId, cascadeDelete: true)
                .Index(t => t.OlympiadId)
                .Index(t => t.PartyinfoId)
                .Index(t => t.SportViewId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeasonName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SportsSetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountSports = c.Int(nullable: false),
                        ResultId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Results", t => t.ResultId, cascadeDelete: true)
                .Index(t => t.ResultId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportsSetings", "ResultId", "dbo.Results");
            DropForeignKey("dbo.Results", "SportViewId", "dbo.SportViews");
            DropForeignKey("dbo.Results", "PartyinfoId", "dbo.PartyInfoes");
            DropForeignKey("dbo.Results", "OlympiadId", "dbo.Olympiads");
            DropForeignKey("dbo.SportViews", "PartyInfo_Id", "dbo.PartyInfoes");
            DropForeignKey("dbo.Olympiads", "CountryId", "dbo.Countries");
            DropIndex("dbo.SportsSetings", new[] { "ResultId" });
            DropIndex("dbo.Results", new[] { "SportViewId" });
            DropIndex("dbo.Results", new[] { "PartyinfoId" });
            DropIndex("dbo.Results", new[] { "OlympiadId" });
            DropIndex("dbo.SportViews", new[] { "PartyInfo_Id" });
            DropIndex("dbo.Olympiads", new[] { "CountryId" });
            DropTable("dbo.SportsSetings");
            DropTable("dbo.Seasons");
            DropTable("dbo.Results");
            DropTable("dbo.SportViews");
            DropTable("dbo.PartyInfoes");
            DropTable("dbo.Olympiads");
            DropTable("dbo.Countries");
        }
    }
}
