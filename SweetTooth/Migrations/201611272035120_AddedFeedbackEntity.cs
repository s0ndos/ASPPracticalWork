namespace SweetTooth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFeedbackEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.FeedbackId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedbacks");
        }
    }
}
