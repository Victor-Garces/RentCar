using Core.Models;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using RentCar.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DXApplication1.Forms.RentCarContextDataModel {

    /// <summary>
    /// A RentCarContextUnitOfWork instance that represents the run-time implementation of the IRentCarContextUnitOfWork interface.
    /// </summary>
    public class RentCarContextUnitOfWork : DbUnitOfWork<RentCarContext>, IRentCarContextUnitOfWork {

        public RentCarContextUnitOfWork(Func<RentCarContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Brand, int> IRentCarContextUnitOfWork.Brands {
            get { return GetRepository(x => x.Set<Brand>(), (Brand x) => x.Id); }
        }

        IRepository<BrandModel, int> IRentCarContextUnitOfWork.BrandModels {
            get { return GetRepository(x => x.Set<BrandModel>(), (BrandModel x) => x.Id); }
        }

        IRepository<Vehicle, int> IRentCarContextUnitOfWork.Vehicles {
            get { return GetRepository(x => x.Set<Vehicle>(), (Vehicle x) => x.Id); }
        }

        IRepository<FuelType, int> IRentCarContextUnitOfWork.FuelTypes {
            get { return GetRepository(x => x.Set<FuelType>(), (FuelType x) => x.Id); }
        }

        IRepository<Inspection, int> IRentCarContextUnitOfWork.Inspections {
            get { return GetRepository(x => x.Set<Inspection>(), (Inspection x) => x.Id); }
        }

        IRepository<Client, int> IRentCarContextUnitOfWork.Clients {
            get { return GetRepository(x => x.Set<Client>(), (Client x) => x.Id); }
        }

        IRepository<Rent, int> IRentCarContextUnitOfWork.Rents {
            get { return GetRepository(x => x.Set<Rent>(), (Rent x) => x.Id); }
        }

        IRepository<Employee, int> IRentCarContextUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.Id); }
        }

        IRepository<VehicleType, int> IRentCarContextUnitOfWork.VehicleTypes {
            get { return GetRepository(x => x.Set<VehicleType>(), (VehicleType x) => x.Id); }
        }
    }
}
