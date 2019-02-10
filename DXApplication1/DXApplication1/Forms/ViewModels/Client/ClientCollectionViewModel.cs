﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.Forms.RentCarContextDataModel;
using DXApplication1.Forms.Common;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the Clients collection view model.
    /// </summary>
    public partial class ClientCollectionViewModel : CollectionViewModel<Client, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientCollectionViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientCollectionViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Clients) {
        }
    }
}