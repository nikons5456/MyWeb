namespace MyWeb.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_User_Passage_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passages",
                c => new
                    {
                        UserTelNum = c.String(nullable: false, maxLength: 11),
                        PassageId = c.Long(nullable: false),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        PublishTime = c.DateTime(nullable: false),
                        LastEditTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserTelNum, t.PassageId })
                .ForeignKey("dbo.Users", t => t.UserTelNum, cascadeDelete: true)
                .Index(t => t.UserTelNum);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        TelNum = c.String(nullable: false, maxLength: 11),
                        UserName = c.String(nullable: false, maxLength: 20),
                        PassWord = c.String(nullable: false, maxLength: 16),
                        IsValidated = c.Boolean(nullable: false),
                        QQNum = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.TelNum);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passages", "UserTelNum", "dbo.Users");
            DropIndex("dbo.Passages", new[] { "UserTelNum" });
            DropTable("dbo.Users");
            DropTable("dbo.Passages");
        }
    }
}
