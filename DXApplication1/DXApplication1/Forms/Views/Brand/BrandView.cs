using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace DXApplication1.Forms.Views.BrandView{
    public partial class BrandView : XtraUserControl {
        public BrandView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<DXApplication1.Forms.ViewModels.BrandViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                brandViewBindingSource, x => x.Entity, x => x.Update());
						#region BrandModels Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(BrandModelsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BrandBrandModelsDetails.SelectedEntity,
                    args => args.Row as DXApplication1.DataLayer.Models.BrandModel,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(BrandModelsGridView, "RowClick")
						 .EventToCommand(
						     x => x.BrandBrandModelsDetails.Edit(null), x => x.BrandBrandModelsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			BrandModelsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    BrandModelsPopUpMenu.ShowPopup(BrandModelsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BrandBrandModelsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(BrandModelsGridControl, g => g.DataSource, x => x.BrandBrandModelsDetails.Entities);
			
														fluentAPI.BindCommand(bbiBrandModelsNew, x => x.BrandBrandModelsDetails.New());
																													fluentAPI.BindCommand(bbiBrandModelsEdit,x => x.BrandBrandModelsDetails.Edit(null), x=>x.BrandBrandModelsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiBrandModelsDelete,x => x.BrandBrandModelsDetails.Delete(null), x=>x.BrandBrandModelsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiBrandModelsRefresh, x => x.BrandBrandModelsDetails.Refresh());
																	#endregion
						#region Vehicles Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(VehiclesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.BrandVehiclesDetails.SelectedEntity,
                    args => args.Row as DXApplication1.DataLayer.Models.Vehicle,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(VehiclesGridView, "RowClick")
						 .EventToCommand(
						     x => x.BrandVehiclesDetails.Edit(null), x => x.BrandVehiclesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			VehiclesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    VehiclesPopUpMenu.ShowPopup(VehiclesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the BrandVehiclesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(VehiclesGridControl, g => g.DataSource, x => x.BrandVehiclesDetails.Entities);
			
														fluentAPI.BindCommand(bbiVehiclesNew, x => x.BrandVehiclesDetails.New());
																													fluentAPI.BindCommand(bbiVehiclesEdit,x => x.BrandVehiclesDetails.Edit(null), x=>x.BrandVehiclesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiVehiclesDelete,x => x.BrandVehiclesDetails.Delete(null), x=>x.BrandVehiclesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiVehiclesRefresh, x => x.BrandVehiclesDetails.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
