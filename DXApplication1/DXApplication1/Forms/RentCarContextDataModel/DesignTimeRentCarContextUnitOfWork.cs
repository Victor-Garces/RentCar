using Core.Models;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using RentCar.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DXApplication1.Forms.RentCarContextDataModel {

    /// <summary>
    /// A RentCarContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IRentCarContextUnitOfWork interface.
    /// </summary>
    public class RentCarContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IRentCarContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the RentCarContextDesignTimeUnitOfWork class.
        /// </summary>
        public RentCarContextDesignTimeUnitOfWork() {
        }

        IRepository<Brand, int> IRentCarContextUnitOfWork.Brands {
            get { return GetRepository((Brand x) => x.Id); }
        }

        IRepository<BrandModel, int> IRentCarContextUnitOfWork.BrandModels {
            get { return GetRepository((BrandModel x) => x.Id); }
        }

        IRepository<Vehicle, int> IRentCarContextUnitOfWork.Vehicles {
            get { return GetRepository((Vehicle x) => x.Id); }
        }

        IRepository<FuelType, int> IRentCarContextUnitOfWork.FuelTypes {
            get { return GetRepository((FuelType x) => x.Id); }
        }

        IRepository<Inspection, int> IRentCarContextUnitOfWork.Inspections {
            get { return GetRepository((Inspection x) => x.Id); }
        }

        IRepository<Client, int> IRentCarContextUnitOfWork.Clients {
            get { return GetRepository((Client x) => x.Id); }
        }

        IRepository<Rent, int> IRentCarContextUnitOfWork.Rents {
            get { return GetRepository((Rent x) => x.Id); }
        }

        IRepository<Employee, int> IRentCarContextUnitOfWork.Employees {
            get { return GetRepository((Employee x) => x.Id); }
        }

        IRepository<VehicleType, int> IRentCarContextUnitOfWork.VehicleTypes {
            get { return GetRepository((VehicleType x) => x.Id); }
        }
    }
}
