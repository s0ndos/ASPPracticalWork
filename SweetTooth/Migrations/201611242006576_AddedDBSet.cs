namespace SweetTooth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDBSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        OfferID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.OfferID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        QtyStock = c.Int(nullable: false),
                        Description = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Offers");
            DropTable("dbo.Categories");
        }
    }
}
