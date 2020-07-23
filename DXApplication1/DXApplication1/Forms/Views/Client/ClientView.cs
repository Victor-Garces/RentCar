using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace DXApplication1.Forms.Views.ClientView{
    public partial class ClientView : XtraUserControl {
        public ClientView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<DXApplication1.Forms.ViewModels.ClientViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                clientViewBindingSource, x => x.Entity, x => x.Update());
						#region Inspections Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(InspectionsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ClientInspectionsDetails.SelectedEntity,
                    args => args.Row as DXApplication1.DataLayer.Models.Inspection,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(InspectionsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ClientInspectionsDetails.Edit(null), x => x.ClientInspectionsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			InspectionsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    InspectionsPopUpMenu.ShowPopup(InspectionsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ClientInspectionsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(InspectionsGridControl, g => g.DataSource, x => x.ClientInspectionsDetails.Entities);
			
														fluentAPI.BindCommand(bbiInspectionsNew, x => x.ClientInspectionsDetails.New());
																													fluentAPI.BindCommand(bbiInspectionsEdit,x => x.ClientInspectionsDetails.Edit(null), x=>x.ClientInspectionsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiInspectionsDelete,x => x.ClientInspectionsDetails.Delete(null), x=>x.ClientInspectionsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiInspectionsRefresh, x => x.ClientInspectionsDetails.Refresh());
																	#endregion
						#region Rents Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(RentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ClientRentsDetails.SelectedEntity,
                    args => args.Row as DXApplication1.DataLayer.Models.Rent,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(RentsGridView, "RowClick")
						 .EventToCommand(
						     x => x.ClientRentsDetails.Edit(null), x => x.ClientRentsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			RentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    RentsPopUpMenu.ShowPopup(RentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ClientRentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(RentsGridControl, g => g.DataSource, x => x.ClientRentsDetails.Entities);
			
														fluentAPI.BindCommand(bbiRentsNew, x => x.ClientRentsDetails.New());
																													fluentAPI.BindCommand(bbiRentsEdit,x => x.ClientRentsDetails.Edit(null), x=>x.ClientRentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiRentsDelete,x => x.ClientRentsDetails.Delete(null), x=>x.ClientRentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiRentsRefresh, x => x.ClientRentsDetails.Refresh());
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
