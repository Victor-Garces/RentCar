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
    /// Represents the single Client object view model.
    /// </summary>
    public partial class ClientViewModel : SingleObjectViewModel<Client, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Clients, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Inspections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Inspection> LookUpInspections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpInspections,
                    getRepositoryFunc: x => x.Inspections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Rents for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Rent> LookUpRents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpRents,
                    getRepositoryFunc: x => x.Rents);
            }
        }


        /// <summary>
        /// The view model for the ClientInspections detail collection.
        /// </summary>
        public CollectionViewModelBase<Inspection, Inspection, int, IRentCarContextUnitOfWork> ClientInspectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientInspectionsDetails,
                    getRepositoryFunc: x => x.Inspections,
                    foreignKeyExpression: x => x.ClientId,
                    navigationExpression: x => x.Client);
            }
        }

        /// <summary>
        /// The view model for the ClientRents detail collection.
        /// </summary>
        public CollectionViewModelBase<Rent, Rent, int, IRentCarContextUnitOfWork> ClientRentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientRentsDetails,
                    getRepositoryFunc: x => x.Rents,
                    foreignKeyExpression: x => x.ClientId,
                    navigationExpression: x => x.Client);
            }
        }
    }
}
