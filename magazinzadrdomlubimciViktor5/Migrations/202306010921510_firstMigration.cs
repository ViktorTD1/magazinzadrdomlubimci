namespace magazinzadrdomlubimciViktor5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Discription = c.String(),
                        Price = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        AnimalType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalsTypes", t => t.AnimalType_Id)
                .Index(t => t.AnimalType_Id);
            
            CreateTable(
                "dbo.AnimalsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "AnimalType_Id", "dbo.AnimalsTypes");
            DropIndex("dbo.Animals", new[] { "AnimalType_Id" });
            DropTable("dbo.AnimalsTypes");
            DropTable("dbo.Animals");
        }
    }
}
