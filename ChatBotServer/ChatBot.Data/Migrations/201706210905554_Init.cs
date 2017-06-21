namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Problems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProblemName = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DefaultMesseges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MsgRequest = c.String(),
                        MsgResponse = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourceName = c.String(maxLength: 500, unicode: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProblemCategory",
                c => new
                    {
                        ProblemRefId = c.Int(nullable: false),
                        CategoryRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProblemRefId, t.CategoryRefId })
                .ForeignKey("dbo.Problems", t => t.ProblemRefId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryRefId, cascadeDelete: true)
                .Index(t => t.ProblemRefId)
                .Index(t => t.CategoryRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProblemCategory", "CategoryRefId", "dbo.Categories");
            DropForeignKey("dbo.ProblemCategory", "ProblemRefId", "dbo.Problems");
            DropIndex("dbo.ProblemCategory", new[] { "CategoryRefId" });
            DropIndex("dbo.ProblemCategory", new[] { "ProblemRefId" });
            DropTable("dbo.ProblemCategory");
            DropTable("dbo.Resources");
            DropTable("dbo.DefaultMesseges");
            DropTable("dbo.Problems");
            DropTable("dbo.Categories");
        }
    }
}
