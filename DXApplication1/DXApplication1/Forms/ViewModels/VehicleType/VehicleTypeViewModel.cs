﻿using System;
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
    /// Represents the single VehicleType object view model.
    /// </summary>
    public partial class VehicleTypeViewModel : SingleObjectViewModel<VehicleType, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleTypeViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleTypeViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VehicleTypes, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Vehicles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicle> LookUpVehicles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehicleTypeViewModel x) => x.LookUpVehicles,
                    getRepositoryFunc: x => x.Vehicles);
            }
        }


        /// <summary>
        /// The view model for the VehicleTypeVehicles detail collection.
        /// </summary>
        public CollectionViewModelBase<Vehicle, Vehicle, int, IRentCarContextUnitOfWork> VehicleTypeVehiclesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehicleTypeViewModel x) => x.VehicleTypeVehiclesDetails,
                    getRepositoryFunc: x => x.Vehicles,
                    foreignKeyExpression: x => x.VehicleTypeId,
                    navigationExpression: x => x.VehicleType);
            }
        }
    }
}
