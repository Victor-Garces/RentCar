namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Identification = c.String(),
                        CrCard = c.Int(nullable: false),
                        CreditLimit = c.Int(nullable: false),
                        PersonType = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Identification)
                .Index(t => t.PersonType);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Identification = c.String(nullable: false),
                        WorkShift = c.String(nullable: false),
                        PercentCommission = c.Int(nullable: false),
                        AdmissionDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HasCarvings = c.Boolean(nullable: false),
                        FuelAmount = c.Int(nullable: false),
                        HasSpareRubber = c.Boolean(nullable: false),
                        HasACat = c.Boolean(nullable: false),
                        HasGlassBreaks = c.Boolean(nullable: false),
                        StateFirstRubber = c.Boolean(nullable: false),
                        StateSecondRubber = c.Boolean(nullable: false),
                        StateThirdRubber = c.Boolean(nullable: false),
                        StateFourthRubber = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Client_Id = c.Int(),
                        Employee_Id = c.Int(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Vehicle_Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ChassisNumber = c.Int(nullable: false),
                        MotorNumber = c.Int(nullable: false),
                        PlateNumber = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Brand_Id = c.Int(),
                        FuelType_Id = c.Int(),
                        Model_Id = c.Int(),
                        VehicleType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_Id)
                .ForeignKey("dbo.Models", t => t.Model_Id)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleType_Id)
                .Index(t => t.Brand_Id)
                .Index(t => t.FuelType_Id)
                .Index(t => t.Model_Id)
                .Index(t => t.VehicleType_Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Brand_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id)
                .Index(t => t.Brand_Id);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentDateTime = c.DateTime(nullable: false),
                        ReturnDateTime = c.DateTime(nullable: false),
                        AmountPerDay = c.Int(nullable: false),
                        DaysQuantity = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Client_Id = c.Int(),
                        Employee_Id = c.Int(),
                        Vehicle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Vehicle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Rents", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Rents", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Inspections", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "Model_Id", "dbo.Models");
            DropForeignKey("dbo.Models", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.Vehicles", "FuelType_Id", "dbo.FuelTypes");
            DropForeignKey("dbo.Vehicles", "Brand_Id", "dbo.Brands");
            DropForeignKey("dbo.Inspections", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Inspections", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Rents", new[] { "Vehicle_Id" });
            DropIndex("dbo.Rents", new[] { "Employee_Id" });
            DropIndex("dbo.Rents", new[] { "Client_Id" });
            DropIndex("dbo.Models", new[] { "Brand_Id" });
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropIndex("dbo.Vehicles", new[] { "Model_Id" });
            DropIndex("dbo.Vehicles", new[] { "FuelType_Id" });
            DropIndex("dbo.Vehicles", new[] { "Brand_Id" });
            DropIndex("dbo.Inspections", new[] { "Vehicle_Id" });
            DropIndex("dbo.Inspections", new[] { "Employee_Id" });
            DropIndex("dbo.Inspections", new[] { "Client_Id" });
            DropIndex("dbo.Clients", new[] { "PersonType" });
            DropIndex("dbo.Clients", new[] { "Identification" });
            DropTable("dbo.Rents");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Models");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Inspections");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Brands");
        }
    }
}
