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
                        Identification = c.String(nullable: false),
                        CrCard = c.Int(nullable: false),
                        CreditLimit = c.Int(nullable: false),
                        PersonType = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        ClientId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
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
                        EmployeeId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ChassisNumber = c.Int(nullable: false),
                        MotorNumber = c.Int(nullable: false),
                        PlateNumber = c.Int(nullable: false),
                        VehicleTypeId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        FuelTypeId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: false)
                .ForeignKey("dbo.FuelTypes", t => t.FuelTypeId, cascadeDelete: false)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: false)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeId, cascadeDelete: false)
                .Index(t => t.VehicleTypeId)
                .Index(t => t.BrandId)
                .Index(t => t.ModelId)
                .Index(t => t.FuelTypeId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: false)
                .Index(t => t.BrandId);
            
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
                        EmployeeId = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        RentDateTime = c.DateTime(nullable: false),
                        ReturnDateTime = c.DateTime(nullable: false),
                        AmountPerDay = c.Int(nullable: false),
                        DaysQuantity = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: false)
                .Index(t => t.EmployeeId)
                .Index(t => t.VehicleId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Rents", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Rents", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Inspections", "Id", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Vehicles", "FuelTypeId", "dbo.FuelTypes");
            DropForeignKey("dbo.Vehicles", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Inspections", "Id", "dbo.Employees");
            DropForeignKey("dbo.Inspections", "Id", "dbo.Clients");
            DropIndex("dbo.Rents", new[] { "ClientId" });
            DropIndex("dbo.Rents", new[] { "VehicleId" });
            DropIndex("dbo.Rents", new[] { "EmployeeId" });
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropIndex("dbo.Vehicles", new[] { "FuelTypeId" });
            DropIndex("dbo.Vehicles", new[] { "ModelId" });
            DropIndex("dbo.Vehicles", new[] { "BrandId" });
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeId" });
            DropIndex("dbo.Inspections", new[] { "Id" });
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
