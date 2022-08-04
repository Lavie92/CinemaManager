namespace CinemaManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class helloKitty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        BillDetailId = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        SeatNumber = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BillDetailId)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .Index(t => t.BillId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Day = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillDetails", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Bills", new[] { "CustomerId" });
            DropIndex("dbo.BillDetails", new[] { "BillId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
        }
    }
}
