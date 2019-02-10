using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.DataLayer.Models;
using DXApplication1.Forms.RentCarContextDataModel;
using DXApplication1.Forms.Common;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the VehicleTypes collection view model.
    /// </summary>
    public partial class VehicleTypeCollectionViewModel : CollectionViewModel<VehicleType, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehicleTypeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehicleTypeCollectionViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehicleTypeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehicleTypeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehicleTypeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehicleTypeCollectionViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VehicleTypes) {
        }
    }
}