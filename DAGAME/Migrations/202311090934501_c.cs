namespace DAGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Category", "SeoTitle");
            DropColumn("dbo.tb_Category", "SeoDescription");
            DropColumn("dbo.tb_Category", "SeoKeywords");
            DropColumn("dbo.tb_OrderDetail", "Quantity");
            DropTable("dbo.tb_Adv");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tb_Adv",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Link = c.String(maxLength: 500),
                        Type = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Modifiedby = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tb_OrderDetail", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.tb_Category", "SeoKeywords", c => c.String(maxLength: 150));
            AddColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 150));
        }
    }
}
