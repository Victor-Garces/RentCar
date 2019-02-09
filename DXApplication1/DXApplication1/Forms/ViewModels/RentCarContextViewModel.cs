using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.Forms.Localization;using DXApplication1.Forms.RentCarContextDataModel;

namespace DXApplication1.Forms.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the RentCarContext data model.
    /// </summary>
    public partial class RentCarContextViewModel : DocumentsViewModel<RentCarContextModuleDescription, IRentCarContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of RentCarContextViewModel as a POCO view model.
        /// </summary>
        public static RentCarContextViewModel Create() {
            return ViewModelSource.Create(() => new RentCarContextViewModel());
        }

		        static RentCarContextViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<RentCarContextMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the RentCarContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RentCarContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected RentCarContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override RentCarContextModuleDescription[] CreateModules() {
			return new RentCarContextModuleDescription[] {
                new RentCarContextModuleDescription(RentCarContextResources.BrandPlural, "BrandCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Brands)),
                new RentCarContextModuleDescription(RentCarContextResources.ClientPlural, "ClientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Clients)),
                new RentCarContextModuleDescription(RentCarContextResources.EmployeePlural, "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new RentCarContextModuleDescription(RentCarContextResources.FuelTypePlural, "FuelTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.FuelTypes)),
                new RentCarContextModuleDescription(RentCarContextResources.InspectionPlural, "InspectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Inspections)),
                new RentCarContextModuleDescription(RentCarContextResources.VehiclePlural, "VehicleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Vehicles)),
                new RentCarContextModuleDescription(RentCarContextResources.ModelPlural, "ModelCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Models)),
                new RentCarContextModuleDescription(RentCarContextResources.VehicleTypePlural, "VehicleTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.VehicleTypes)),
                new RentCarContextModuleDescription(RentCarContextResources.RentPlural, "RentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Rents)),
			};
        }
                		protected override void OnActiveModuleChanged(RentCarContextModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class RentCarContextModuleDescription : ModuleDescription<RentCarContextModuleDescription> {
        public RentCarContextModuleDescription(string title, string documentType, string group, Func<RentCarContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}