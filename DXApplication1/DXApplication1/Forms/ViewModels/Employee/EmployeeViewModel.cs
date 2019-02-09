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
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.Name) {
                }



    }
}
