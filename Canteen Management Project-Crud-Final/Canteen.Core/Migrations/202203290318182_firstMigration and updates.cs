namespace Canteen.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrationandupdates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Address = c.String(),
                        Phone_Number = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodId = c.Int(nullable: false),
                        Expected_Delivary = c.DateTime(nullable: false, storeType: "date"),
                        OrderType = c.String(),
                        OrderedTime = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .Index(t => t.FoodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "UserId", "dbo.Users");
            DropIndex("dbo.OrderDetails", new[] { "FoodId" });
            DropIndex("dbo.Foods", new[] { "UserId" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Foods");
        }
    }
}
