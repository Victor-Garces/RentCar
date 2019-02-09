using DevExpress.Mvvm.DataAnnotations;
using DXApplication1.Forms.Localization;
using RentCar.DataLayer;
using RentCar.DataLayer.Models;

namespace DXApplication1.Forms.RentCarContextDataModel {

    public class RentCarContextMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Brand> builder) {
			builder.DisplayName(RentCarContextResources.Brand);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Brand_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.Brand_Description);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Brand_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Client> builder) {
			builder.DisplayName(RentCarContextResources.Client);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Client_Id);
						builder.Property(x => x.Name).DisplayName(RentCarContextResources.Client_Name);
						builder.Property(x => x.Identification).DisplayName(RentCarContextResources.Client_Identification);
						builder.Property(x => x.CrCard).DisplayName(RentCarContextResources.Client_CrCard);
						builder.Property(x => x.CreditLimit).DisplayName(RentCarContextResources.Client_CreditLimit);
						builder.Property(x => x.PersonType).DisplayName(RentCarContextResources.Client_PersonType);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Client_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Employee> builder) {
			builder.DisplayName(RentCarContextResources.Employee);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Employee_Id);
						builder.Property(x => x.Name).DisplayName(RentCarContextResources.Employee_Name);
						builder.Property(x => x.Identification).DisplayName(RentCarContextResources.Employee_Identification);
						builder.Property(x => x.WorkShift).DisplayName(RentCarContextResources.Employee_WorkShift);
						builder.Property(x => x.PercentCommission).DisplayName(RentCarContextResources.Employee_PercentCommission);
						builder.Property(x => x.AdmissionDate).DisplayName(RentCarContextResources.Employee_AdmissionDate);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Employee_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<FuelType> builder) {
			builder.DisplayName(RentCarContextResources.FuelType);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.FuelType_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.FuelType_Description);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.FuelType_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Inspection> builder) {
			builder.DisplayName(RentCarContextResources.Inspection);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Inspection_Id);
						builder.Property(x => x.HasCarvings).DisplayName(RentCarContextResources.Inspection_HasCarvings);
						builder.Property(x => x.FuelAmount).DisplayName(RentCarContextResources.Inspection_FuelAmount);
						builder.Property(x => x.HasSpareRubber).DisplayName(RentCarContextResources.Inspection_HasSpareRubber);
						builder.Property(x => x.HasACat).DisplayName(RentCarContextResources.Inspection_HasACat);
						builder.Property(x => x.HasGlassBreaks).DisplayName(RentCarContextResources.Inspection_HasGlassBreaks);
						builder.Property(x => x.StateFirstRubber).DisplayName(RentCarContextResources.Inspection_StateFirstRubber);
						builder.Property(x => x.StateSecondRubber).DisplayName(RentCarContextResources.Inspection_StateSecondRubber);
						builder.Property(x => x.StateThirdRubber).DisplayName(RentCarContextResources.Inspection_StateThirdRubber);
						builder.Property(x => x.StateFourthRubber).DisplayName(RentCarContextResources.Inspection_StateFourthRubber);
						builder.Property(x => x.Date).DisplayName(RentCarContextResources.Inspection_Date);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Inspection_Status);
						builder.Property(x => x.Client).DisplayName(RentCarContextResources.Inspection_Client);
						builder.Property(x => x.Employee).DisplayName(RentCarContextResources.Inspection_Employee);
						builder.Property(x => x.Vehicle).DisplayName(RentCarContextResources.Inspection_Vehicle);
			        }
		        public static void BuildMetadata(MetadataBuilder<Vehicle> builder) {
			builder.DisplayName(RentCarContextResources.Vehicle);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Vehicle_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.Vehicle_Description);
						builder.Property(x => x.ChassisNumber).DisplayName(RentCarContextResources.Vehicle_ChassisNumber);
						builder.Property(x => x.MotorNumber).DisplayName(RentCarContextResources.Vehicle_MotorNumber);
						builder.Property(x => x.PlateNumber).DisplayName(RentCarContextResources.Vehicle_PlateNumber);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Vehicle_Status);
						builder.Property(x => x.Brand).DisplayName(RentCarContextResources.Vehicle_Brand);
						builder.Property(x => x.FuelType).DisplayName(RentCarContextResources.Vehicle_FuelType);
						builder.Property(x => x.Model).DisplayName(RentCarContextResources.Vehicle_Model);
						builder.Property(x => x.VehicleType).DisplayName(RentCarContextResources.Vehicle_VehicleType);
			        }
		        public static void BuildMetadata(MetadataBuilder<Model> builder) {
			builder.DisplayName(RentCarContextResources.Model);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Model_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.Model_Description);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Model_Status);
						builder.Property(x => x.Brand).DisplayName(RentCarContextResources.Model_Brand);
			        }
		        public static void BuildMetadata(MetadataBuilder<VehicleType> builder) {
			builder.DisplayName(RentCarContextResources.VehicleType);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.VehicleType_Id);
						builder.Property(x => x.Description).DisplayName(RentCarContextResources.VehicleType_Description);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.VehicleType_Status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Rent> builder) {
			builder.DisplayName(RentCarContextResources.Rent);
						builder.Property(x => x.Id).DisplayName(RentCarContextResources.Rent_Id);
						builder.Property(x => x.RentDateTime).DisplayName(RentCarContextResources.Rent_RentDateTime);
						builder.Property(x => x.ReturnDateTime).DisplayName(RentCarContextResources.Rent_ReturnDateTime);
						builder.Property(x => x.AmountPerDay).DisplayName(RentCarContextResources.Rent_AmountPerDay);
						builder.Property(x => x.DaysQuantity).DisplayName(RentCarContextResources.Rent_DaysQuantity);
						builder.Property(x => x.Comment).DisplayName(RentCarContextResources.Rent_Comment);
						builder.Property(x => x.Status).DisplayName(RentCarContextResources.Rent_Status);
						builder.Property(x => x.Client).DisplayName(RentCarContextResources.Rent_Client);
						builder.Property(x => x.Employee).DisplayName(RentCarContextResources.Rent_Employee);
						builder.Property(x => x.Vehicle).DisplayName(RentCarContextResources.Rent_Vehicle);
			        }
		    }
}