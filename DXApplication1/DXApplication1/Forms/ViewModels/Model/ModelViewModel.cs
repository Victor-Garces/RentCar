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
using RentCar.DataLayer.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the single Model object view model.
    /// </summary>
    public partial class ModelViewModel : SingleObjectViewModel<Model, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ModelViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ModelViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ModelViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ModelViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ModelViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ModelViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Models, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Brands for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Brand> LookUpBrands {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ModelViewModel x) => x.LookUpBrands,
                    getRepositoryFunc: x => x.Brands);
            }
        }

    }
}
