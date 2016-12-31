namespace Web_Crypter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttachmentsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileType = c.String(),
                        FileContent = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attachments");
        }
    }
}
