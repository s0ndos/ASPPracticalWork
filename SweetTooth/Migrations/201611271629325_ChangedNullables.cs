namespace SweetTooth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNullables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Price", c => c.Double());
            AlterColumn("dbo.Products", "QtyStock", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "QtyStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
        }
    }
}
