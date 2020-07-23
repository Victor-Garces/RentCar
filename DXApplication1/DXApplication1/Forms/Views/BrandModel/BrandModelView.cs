using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace DXApplication1.Forms.Views.BrandModelView{
    public partial class BrandModelView : XtraUserControl {
        public BrandModelView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<DXApplication1.Forms.ViewModels.BrandModelViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                brandModelViewBindingSource, x => x.Entity, x => x.Update());
						#region Vehicles Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(VehiclesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BrandModelVehiclesDetails.SelectedEntity,
                    args => args.Row as DXApplication1.DataLayer.Models.Vehicle,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(VehiclesGridView, "RowClick")
						 .EventToCommand(
						     x => x.BrandModelVehiclesDetails.Edit(null), x => x.BrandModelVehiclesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			VehiclesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    VehiclesPopUpMenu.ShowPopup(VehiclesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BrandModelVehiclesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(VehiclesGridControl, g => g.DataSource, x => x.BrandModelVehiclesDetails.Entities);
			
														fluentAPI.BindCommand(bbiVehiclesNew, x => x.BrandModelVehiclesDetails.New());
																													fluentAPI.BindCommand(bbiVehiclesEdit,x => x.BrandModelVehiclesDetails.Edit(null), x=>x.BrandModelVehiclesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiVehiclesDelete,x => x.BrandModelVehiclesDetails.Delete(null), x=>x.BrandModelVehiclesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiVehiclesRefresh, x => x.BrandModelVehiclesDetails.Refresh());
																	#endregion
									// Binding for Brand LookUp editor
			fluentAPI.SetBinding(BrandLookUpEdit.Properties, p => p.DataSource, x => x.LookUpBrands.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
