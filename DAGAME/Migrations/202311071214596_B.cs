namespace DAGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThongKes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThoiGian = c.DateTime(nullable: false),
                        SoTruyCap = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tb_Category", "Link", c => c.String());
            AddColumn("dbo.tb_Order", "Email", c => c.String());
            AddColumn("dbo.tb_Product", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.tb_Product", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Subscribe", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Subscribe", "Email", c => c.String());
            DropColumn("dbo.tb_Product", "ViewCount");
            DropColumn("dbo.tb_Product", "OriginalPrice");
            DropColumn("dbo.tb_Order", "Email");
            DropColumn("dbo.tb_Category", "Link");
            DropTable("dbo.ThongKes");
        }
    }
}
