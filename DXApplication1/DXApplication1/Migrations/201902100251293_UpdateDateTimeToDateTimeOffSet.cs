namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTimeToDateTimeOffSet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Brands", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.BrandModels", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.BrandModels", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Vehicles", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Vehicles", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.FuelTypes", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.FuelTypes", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Inspections", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Inspections", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Clients", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Clients", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Rents", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Rents", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Employees", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Employees", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.VehicleTypes", "CreationDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.VehicleTypes", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VehicleTypes", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.VehicleTypes", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rents", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rents", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inspections", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FuelTypes", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FuelTypes", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehicles", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehicles", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BrandModels", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BrandModels", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Brands", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Brands", "CreationDate", c => c.DateTime(nullable: false));
        }
    }
}
