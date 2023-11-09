namespace DAGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_News", "SeoTitle");
            DropColumn("dbo.tb_News", "SeoDescription");
            DropColumn("dbo.tb_News", "SeoKeywords");
            DropColumn("dbo.tb_Posts", "SeoTitle");
            DropColumn("dbo.tb_Posts", "SeoDescription");
            DropColumn("dbo.tb_Posts", "SeoKeywords");
            DropColumn("dbo.tb_Product", "SeoTitle");
            DropColumn("dbo.tb_Product", "SeoDescription");
            DropColumn("dbo.tb_Product", "SeoKeywords");
            DropColumn("dbo.tb_ProductCategory", "SeoTitle");
            DropColumn("dbo.tb_ProductCategory", "SeoDescription");
            DropColumn("dbo.tb_ProductCategory", "SeoKeywords");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Posts", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Posts", "SeoDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.tb_Posts", "SeoTitle", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_News", "SeoKeywords", c => c.String());
            AddColumn("dbo.tb_News", "SeoDescription", c => c.String());
            AddColumn("dbo.tb_News", "SeoTitle", c => c.String());
        }
    }
}
