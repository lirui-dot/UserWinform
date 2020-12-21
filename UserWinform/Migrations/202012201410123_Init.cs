namespace UserWinform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        parentid = c.Int(nullable: false),
                        parentname = c.String(),
                        areacode = c.String(),
                        zipcode = c.String(),
                        depth = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        ProvinceId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Image = c.String(),
                        Url = c.String(),
                        FileUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Provinces");
        }
    }
}
