namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewUnitedSeeding : DbMigration
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
            
            CreateTable(
                "dbo.CategoryResource",
                c => new
                    {
                        CategoryRefId = c.Int(nullable: false),
                        ResourceRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryRefId, t.ResourceRefId })
                .ForeignKey("dbo.Categories", t => t.CategoryRefId, cascadeDelete: true)
                .ForeignKey("dbo.Resources", t => t.ResourceRefId, cascadeDelete: true)
                .Index(t => t.CategoryRefId)
                .Index(t => t.ResourceRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryResource", "ResourceRefId", "dbo.Resources");
            DropForeignKey("dbo.CategoryResource", "CategoryRefId", "dbo.Categories");
            DropForeignKey("dbo.ProblemCategory", "CategoryRefId", "dbo.Categories");
            DropForeignKey("dbo.ProblemCategory", "ProblemRefId", "dbo.Problems");
            DropIndex("dbo.CategoryResource", new[] { "ResourceRefId" });
            DropIndex("dbo.CategoryResource", new[] { "CategoryRefId" });
            DropIndex("dbo.ProblemCategory", new[] { "CategoryRefId" });
            DropIndex("dbo.ProblemCategory", new[] { "ProblemRefId" });
            DropTable("dbo.CategoryResource");
            DropTable("dbo.ProblemCategory");
            DropTable("dbo.DefaultMesseges");
            DropTable("dbo.Resources");
            DropTable("dbo.Problems");
            DropTable("dbo.Categories");
        }
    }
}
