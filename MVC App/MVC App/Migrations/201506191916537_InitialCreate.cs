namespace MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodReviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DishName = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Main = c.String(),
                        Seasonings = c.String(),
                        Other = c.String(),
                        TimeInMin = c.Int(nullable: false),
                        DishName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
              //  AddForeignKey("dbo.Ingredients",;

            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ingredients");
            DropTable("dbo.FoodReviews");
        }
    }
}
