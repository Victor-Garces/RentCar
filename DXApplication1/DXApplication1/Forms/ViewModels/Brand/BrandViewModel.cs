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
    /// Represents the single Brand object view model.
    /// </summary>
    public partial class BrandViewModel : SingleObjectViewModel<Brand, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BrandViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BrandViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BrandViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BrandViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BrandViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BrandViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Brands, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BrandModels for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BrandModel> LookUpBrandModels {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BrandViewModel x) => x.LookUpBrandModels,
                    getRepositoryFunc: x => x.BrandModels);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BrandViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }


        /// <summary>
        /// The view model for the BrandBrandModels detail collection.
        /// </summary>
        public CollectionViewModelBase<BrandModel, BrandModel, int, IRentCarContextUnitOfWork> BrandBrandModelsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BrandViewModel x) => x.BrandBrandModelsDetails,
                    getRepositoryFunc: x => x.BrandModels,
                    foreignKeyExpression: x => x.BrandId,
                    navigationExpression: x => x.Brand);
            }
        }

        /// <summary>
        /// The view model for the BrandVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarContextUnitOfWork> BrandVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BrandViewModel x) => x.BrandVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.BrandId,
                    navigationExpression: x => x.Brand);
            }
        }
    }
}
