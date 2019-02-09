using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.Forms.RentCarContextDataModel;
using DXApplication1.Forms.Common;
using RentCar.DataLayer.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the Brands collection view model.
    /// </summary>
    public partial class BrandCollectionViewModel : CollectionViewModel<Brand, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BrandCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BrandCollectionViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BrandCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BrandCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BrandCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BrandCollectionViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Brands) {
        }
    }
}