using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using DXApplication1.DataLayer;
using System;
using System.Collections;
using System.Linq;

namespace DXApplication1.Forms.RentCarContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IRentCarContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IRentCarContextUnitOfWork>(() => new RentCarContextUnitOfWork(() => new RentCarContext()));
        }
    }
}