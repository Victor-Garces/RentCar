﻿using DevExpress.Mvvm.DataModel;
using RentCar.DataLayer;
using RentCar.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DXApplication1.Forms.RentCarContextDataModel {

    /// <summary>
    /// IRentCarContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IRentCarContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Brand entities repository.
        /// </summary>
		IRepository<Brand, int> Brands { get; }
        
        /// <summary>
        /// The Client entities repository.
        /// </summary>
		IRepository<Client, int> Clients { get; }
        
        /// <summary>
        /// The Employee entities repository.
        /// </summary>
		IRepository<Employee, int> Employees { get; }
        
        /// <summary>
        /// The FuelType entities repository.
        /// </summary>
		IRepository<FuelType, int> FuelTypes { get; }
        
        /// <summary>
        /// The Inspection entities repository.
        /// </summary>
		IRepository<Inspection, int> Inspections { get; }
        
        /// <summary>
        /// The Vehicle entities repository.
        /// </summary>
		IRepository<Vehicle, int> Vehicles { get; }
        
        /// <summary>
        /// The Model entities repository.
        /// </summary>
		IRepository<Model, int> Models { get; }
        
        /// <summary>
        /// The VehicleType entities repository.
        /// </summary>
		IRepository<VehicleType, int> VehicleTypes { get; }
        
        /// <summary>
        /// The Rent entities repository.
        /// </summary>
		IRepository<Rent, int> Rents { get; }
    }
}
