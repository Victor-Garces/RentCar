using Core.Models;
using DevExpress.Mvvm.DataAnnotations;
using DXApplication1.Forms.Localization;
using RentCar.DataLayer;

namespace DXApplication1.Forms.RentCarContextDataModel {

    public class RentCarContextMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Brand> builder) {
			builder.DisplayName(RentCarContextResources.Brand);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Brand_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.Brand_Description);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.Brand_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Brand_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Brand_UpdateDate);
			        }
		        public static void BuildMetadata(MetadataBuilder<BrandModel> builder) {
			builder.DisplayName(RentCarContextResources.BrandModel);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.BrandModel_Id);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.BrandModel_IsActive);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.BrandModel_Description);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.BrandModel_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.BrandModel_UpdateDate);
						builder.Property(x => x.Brand).DisplayName(RentCarContextResources.BrandModel_Brand);
			        }
		        public static void BuildMetadata(MetadataBuilder<Vehicle> builder) {
			builder.DisplayName(RentCarContextResources.Vehicle);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Vehicle_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.Vehicle_Description);
						builder.Property(x => x.ChassisNumber).DisplayName(RentCarContextResources.Vehicle_ChassisNumber);
						builder.Property(x => x.MotorNumber).DisplayName(RentCarContextResources.Vehicle_MotorNumber);
						builder.Property(x => x.LicensePlate).DisplayName(RentCarContextResources.Vehicle_LicensePlate);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.Vehicle_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Vehicle_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Vehicle_UpdateDate);
						builder.Property(x => x.Brand).DisplayName(RentCarContextResources.Vehicle_Brand);
						builder.Property(x => x.BrandModel).DisplayName(RentCarContextResources.Vehicle_BrandModel);
						builder.Property(x => x.FuelType).DisplayName(RentCarContextResources.Vehicle_FuelType);
						builder.Property(x => x.VehicleType).DisplayName(RentCarContextResources.Vehicle_VehicleType);
			        }
		        public static void BuildMetadata(MetadataBuilder<FuelType> builder) {
			builder.DisplayName(RentCarContextResources.FuelType);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.FuelType_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.FuelType_Description);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.FuelType_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.FuelType_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.FuelType_UpdateDate);
			        }
		        public static void BuildMetadata(MetadataBuilder<Inspection> builder) {
			builder.DisplayName(RentCarContextResources.Inspection);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Inspection_Id);
						builder.Property(x => x.HasGrazes).DisplayName(RentCarContextResources.Inspection_HasGrazes);
						builder.Property(x => x.FuelQuantity).DisplayName(RentCarContextResources.Inspection_FuelQuantity);
						builder.Property(x => x.RubberOne).DisplayName(RentCarContextResources.Inspection_RubberOne);
						builder.Property(x => x.RubberTwo).DisplayName(RentCarContextResources.Inspection_RubberTwo);
						builder.Property(x => x.RubberThree).DisplayName(RentCarContextResources.Inspection_RubberThree);
						builder.Property(x => x.RubberFour).DisplayName(RentCarContextResources.Inspection_RubberFour);
						builder.Property(x => x.HasReplacementRubber).DisplayName(RentCarContextResources.Inspection_HasReplacementRubber);
						builder.Property(x => x.HasHydraulicJack).DisplayName(RentCarContextResources.Inspection_HasHydraulicJack);
						builder.Property(x => x.HasGlassBreaks).DisplayName(RentCarContextResources.Inspection_HasGlassBreaks);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Inspection_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Inspection_UpdateDate);
						builder.Property(x => x.Client).DisplayName(RentCarContextResources.Inspection_Client);
						builder.Property(x => x.Vehicle).DisplayName(RentCarContextResources.Inspection_Vehicle);
			        }
		        public static void BuildMetadata(MetadataBuilder<Client> builder) {
			builder.DisplayName(RentCarContextResources.Client);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Client_Id);
						builder.Property(x => x.Name).DisplayName(RentCarContextResources.Client_Name);
						builder.Property(x => x.Identification).DisplayName(RentCarContextResources.Client_Identification);
						builder.Property(x => x.CreditCarNumber).DisplayName(RentCarContextResources.Client_CreditCarNumber);
						builder.Property(x => x.CreditLimit).DisplayName(RentCarContextResources.Client_CreditLimit);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.Client_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Client_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Client_UpdateDate);
			        }
		        public static void BuildMetadata(MetadataBuilder<Rent> builder) {
			builder.DisplayName(RentCarContextResources.Rent);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Rent_Id);
						builder.Property(x => x.RentDate).DisplayName(RentCarContextResources.Rent_RentDate);
						builder.Property(x => x.ReturnDate).DisplayName(RentCarContextResources.Rent_ReturnDate);
						builder.Property(x => x.AmountPerDay).DisplayName(RentCarContextResources.Rent_AmountPerDay);
						builder.Property(x => x.DayQuantity).DisplayName(RentCarContextResources.Rent_DayQuantity);
						builder.Property(x => x.Comment).DisplayName(RentCarContextResources.Rent_Comment);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.Rent_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Rent_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Rent_UpdateDate);
						builder.Property(x => x.Client).DisplayName(RentCarContextResources.Rent_Client);
						builder.Property(x => x.Employee).DisplayName(RentCarContextResources.Rent_Employee);
						builder.Property(x => x.Vehicle).DisplayName(RentCarContextResources.Rent_Vehicle);
			        }
		        public static void BuildMetadata(MetadataBuilder<Employee> builder) {
			builder.DisplayName(RentCarContextResources.Employee);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Employee_Id);
						builder.Property(x => x.Name).DisplayName(RentCarContextResources.Employee_Name);
						builder.Property(x => x.Identification).DisplayName(RentCarContextResources.Employee_Identification);
						builder.Property(x => x.IdentificationType).DisplayName(RentCarContextResources.Employee_IdentificationType);
						builder.Property(x => x.Workload).DisplayName(RentCarContextResources.Employee_Workload);
						builder.Property(x => x.PercentCommission).DisplayName(RentCarContextResources.Employee_PercentCommission);
						builder.Property(x => x.AdmissionDate).DisplayName(RentCarContextResources.Employee_AdmissionDate);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.Employee_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.Employee_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.Employee_UpdateDate);
			        }
		        public static void BuildMetadata(MetadataBuilder<VehicleType> builder) {
			builder.DisplayName(RentCarContextResources.VehicleType);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.VehicleType_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.VehicleType_Description);
						builder.Property(x => x.IsActive).DisplayName(RentCarContextResources.VehicleType_IsActive);
						builder.Property(x => x.CreationDate).DisplayName(RentCarContextResources.VehicleType_CreationDate);
						builder.Property(x => x.UpdateDate).DisplayName(RentCarContextResources.VehicleType_UpdateDate);
			        }
		    }
}