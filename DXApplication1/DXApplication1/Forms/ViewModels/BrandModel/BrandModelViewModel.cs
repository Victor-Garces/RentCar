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
using Core.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the single BrandModel object view model.
    /// </summary>
    public partial class BrandModelViewModel : SingleObjectViewModel<BrandModel, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BrandModelViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BrandModelViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BrandModelViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BrandModelViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BrandModelViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BrandModelViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BrandModels, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Brands for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Brand> LookUpBrands {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BrandModelViewModel x) => x.LookUpBrands,
                    getRepositoryFunc: x => x.Brands);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BrandModelViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }


        /// <summary>
        /// The view model for the BrandModelVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarContextUnitOfWork> BrandModelVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BrandModelViewModel x) => x.BrandModelVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.BrandModelId,
                    navigationExpression: x => x.BrandModel);
            }
        }
    }
}
