using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.Forms.RentCarContextDataModel;
using DXApplication1.Forms.Common;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the single Vehicle object view model.
    /// </summary>
    public partial class VehicleViewModel : SingleObjectViewModel<Vehicle, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Vehicles, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Brands for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Brand> LookUpBrands {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpBrands,
                    getRepositoryFunc: x => x.Brands);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of BrandModels for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BrandModel> LookUpBrandModels {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpBrandModels,
                    getRepositoryFunc: x => x.BrandModels);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FuelTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FuelType> LookUpFuelTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpFuelTypes,
                    getRepositoryFunc: x => x.FuelTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VehicleTypes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VehicleType> LookUpVehicleTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpVehicleTypes,
                    getRepositoryFunc: x => x.VehicleTypes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Inspections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Inspection> LookUpInspections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpInspections,
                    getRepositoryFunc: x => x.Inspections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }


        /// <summary>
        /// The view model for the VehicleInspections detail collection.
        /// </summary>
        public CollectionViewModelBase<Inspection, Inspection, int, IRentCarContextUnitOfWork> VehicleInspectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleViewModel x) => x.VehicleInspectionsDetails,
                    getRepositoryFunc: x => x.Inspections,
                    foreignKeyExpression: x => x.VehicleId,
                    navigationExpression: x => x.Vehicle);
            }
        }

        /// <summary>
        /// The view model for the VehicleRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentCarContextUnitOfWork> VehicleRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleViewModel x) => x.VehicleRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.VehicleId,
                    navigationExpression: x => x.Vehicle);
            }
        }
    }
}
