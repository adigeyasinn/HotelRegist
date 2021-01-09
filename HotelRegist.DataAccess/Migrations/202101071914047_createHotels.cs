namespace HotelRegist.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createHotels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        Price = c.Int(nullable: false),
                        Capasity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hotels");
        }
    }
}
