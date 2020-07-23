namespace DXApplication1.Forms.Views.ClientView {
    partial class ClientView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.InspectionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.InspectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.InspectionsBarManager = new DevExpress.XtraBars.BarManager();
			this.InspectionsBar = new DevExpress.XtraBars.Bar();
			this.InspectionsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.InspectionsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiInspectionsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiInspectionsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiInspectionsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiInspectionsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.InspectionsBarManager)).BeginInit();
						this.RentsGridControl = new DevExpress.XtraGrid.GridControl();
			this.RentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.RentsBarManager = new DevExpress.XtraBars.BarManager();
			this.RentsBar = new DevExpress.XtraBars.Bar();
			this.RentsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.RentsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiRentsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiRentsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.RentsBarManager)).BeginInit();
						 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.clientViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientViewBindingSource.DataSource = typeof(DXApplication1.DataLayer.Models.Client);
			this.dataLayoutControl1.DataSource = clientViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//InspectionsGridControl
			//
			this.InspectionsGridControl.MainView = this.InspectionsGridView;
			this.InspectionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectionsGridControl.Name = "InspectionsGridControl";
            this.InspectionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InspectionsGridView});
			//
			//InspectionsGridView
			//
            this.InspectionsGridView.GridControl = this.InspectionsGridControl;
            this.InspectionsGridView.Name = "InspectionsGridView";
            this.InspectionsGridView.OptionsBehavior.Editable = false;
            this.InspectionsGridView.OptionsBehavior.ReadOnly = true;
			this.InspectionsGridView.OptionsView.ShowGroupPanel = false;
			//
			//InspectionsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters InspectionsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleInspectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleInspectionsChildPopulateColumnParameters_NotVisible.FieldName = "Vehicle";
		    VehicleInspectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			InspectionsPopulateColumnsParameters.CustomColumnParameters.Add(VehicleInspectionsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ClientInspectionsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ClientInspectionsChildPopulateColumnParameters_NotVisible.FieldName = "Client";
		    ClientInspectionsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			InspectionsPopulateColumnsParameters.CustomColumnParameters.Add(ClientInspectionsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters InspectionsInspectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            InspectionsInspectionsChildPopulateColumnParameters.FieldName = "InspectionsInspections";
            InspectionsInspectionsChildPopulateColumnParameters.Path = "Inspections.Id";
			InspectionsPopulateColumnsParameters.CustomColumnParameters.Add(InspectionsInspectionsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsInspectionsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsInspectionsChildPopulateColumnParameters.FieldName = "RentsInspections";
            RentsInspectionsChildPopulateColumnParameters.Path = "Rents.Comment";
			InspectionsPopulateColumnsParameters.CustomColumnParameters.Add(RentsInspectionsChildPopulateColumnParameters);
			 
		    this.InspectionsGridView.PopulateColumns(typeof(DXApplication1.DataLayer.Models.Inspection),InspectionsPopulateColumnsParameters);
			//
			//InspectionsBindingSource
			//
			System.Windows.Forms.BindingSource InspectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			InspectionsBindingSource.DataSource = typeof(DXApplication1.DataLayer.Models.Inspection);
            this.InspectionsGridControl.DataSource = InspectionsBindingSource;
			//
			//InspectionsXtraUserControl
			//
            this.InspectionsXtraUserControl.Controls.Add(InspectionsGridControl);
			this.InspectionsXtraUserControl.Name = "InspectionsXtraUserControl";
			this.InspectionsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//InspectionsNew
			//
			this.bbiInspectionsNew.Caption = "New";
			this.bbiInspectionsNew.Name = "bbiInspectionsNew";
			this.bbiInspectionsNew.ImageUri.Uri = "New";
			this.bbiInspectionsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.InspectionsBarManager.Items.Add(this.bbiInspectionsNew);
			this.InspectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsNew));
			this.InspectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsNew));
						//
			//InspectionsEdit
			//
			this.bbiInspectionsEdit.Caption = "Edit";
			this.bbiInspectionsEdit.Name = "bbiInspectionsEdit";
			this.bbiInspectionsEdit.ImageUri.Uri = "Edit";
			this.bbiInspectionsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.InspectionsBarManager.Items.Add(this.bbiInspectionsEdit);
			this.InspectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsEdit));
			this.InspectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsEdit));
						//
			//InspectionsDelete
			//
			this.bbiInspectionsDelete.Caption = "Delete";
			this.bbiInspectionsDelete.Name = "bbiInspectionsDelete";
			this.bbiInspectionsDelete.ImageUri.Uri = "Delete";
			this.bbiInspectionsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.InspectionsBarManager.Items.Add(this.bbiInspectionsDelete);
			this.InspectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsDelete));
			this.InspectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsDelete));
						//
			//InspectionsRefresh
			//
			this.bbiInspectionsRefresh.Caption = "Refresh";
			this.bbiInspectionsRefresh.Name = "bbiInspectionsRefresh";
			this.bbiInspectionsRefresh.ImageUri.Uri = "Refresh";
			this.bbiInspectionsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.InspectionsBarManager.Items.Add(this.bbiInspectionsRefresh);
			this.InspectionsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsRefresh));
			this.InspectionsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiInspectionsRefresh));
						//
			//InspectionsBar
			//
			this.InspectionsBar.BarName = "Inspections";
            this.InspectionsBar.DockCol = 0;
            this.InspectionsBar.DockRow = 0;
            this.InspectionsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.InspectionsBar.OptionsBar.AllowQuickCustomization = false;
            this.InspectionsBar.OptionsBar.DrawDragBorder = false;
            this.InspectionsBar.Text = "Inspections";
			//
			//InspectionsBarManager
			//
			this.InspectionsBarManager.AllowCustomization = false;
            this.InspectionsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.InspectionsBar});
            this.InspectionsBarManager.Form = InspectionsXtraUserControl;
            this.InspectionsBarManager.MainMenu = this.InspectionsBar;
			// 
            // InspectionsPopUpMenu
            // 
            this.InspectionsPopUpMenu.Manager = this.InspectionsBarManager;
            this.InspectionsPopUpMenu.Name = "InspectionsPopUpMenu";
			//
			//InspectionsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters InspectionsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            InspectionsRetriveFieldParameters.FieldName = "Inspections";
            InspectionsRetriveFieldParameters.ControlForField = InspectionsXtraUserControl;
			InspectionsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(InspectionsRetriveFieldParameters);
						//
			//RentsGridControl
			//
			this.RentsGridControl.MainView = this.RentsGridView;
			this.RentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentsGridControl.Name = "RentsGridControl";
            this.RentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.RentsGridView});
			//
			//RentsGridView
			//
            this.RentsGridView.GridControl = this.RentsGridControl;
            this.RentsGridView.Name = "RentsGridView";
            this.RentsGridView.OptionsBehavior.Editable = false;
            this.RentsGridView.OptionsBehavior.ReadOnly = true;
			this.RentsGridView.OptionsView.ShowGroupPanel = false;
			//
			//RentsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters RentsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters EmployeeRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            EmployeeRentsChildPopulateColumnParameters_NotVisible.FieldName = "Employee";
		    EmployeeRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(EmployeeRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters VehicleRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            VehicleRentsChildPopulateColumnParameters_NotVisible.FieldName = "Vehicle";
		    VehicleRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(VehicleRentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ClientRentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ClientRentsChildPopulateColumnParameters_NotVisible.FieldName = "Client";
		    ClientRentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(ClientRentsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters InspectionsRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            InspectionsRentsChildPopulateColumnParameters.FieldName = "InspectionsRents";
            InspectionsRentsChildPopulateColumnParameters.Path = "Inspections.Id";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(InspectionsRentsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters RentsRentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            RentsRentsChildPopulateColumnParameters.FieldName = "RentsRents";
            RentsRentsChildPopulateColumnParameters.Path = "Rents.Comment";
			RentsPopulateColumnsParameters.CustomColumnParameters.Add(RentsRentsChildPopulateColumnParameters);
			 
		    this.RentsGridView.PopulateColumns(typeof(DXApplication1.DataLayer.Models.Rent),RentsPopulateColumnsParameters);
			//
			//RentsBindingSource
			//
			System.Windows.Forms.BindingSource RentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			RentsBindingSource.DataSource = typeof(DXApplication1.DataLayer.Models.Rent);
            this.RentsGridControl.DataSource = RentsBindingSource;
			//
			//RentsXtraUserControl
			//
            this.RentsXtraUserControl.Controls.Add(RentsGridControl);
			this.RentsXtraUserControl.Name = "RentsXtraUserControl";
			this.RentsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//RentsNew
			//
			this.bbiRentsNew.Caption = "New";
			this.bbiRentsNew.Name = "bbiRentsNew";
			this.bbiRentsNew.ImageUri.Uri = "New";
			this.bbiRentsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsNew);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsNew));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsNew));
						//
			//RentsEdit
			//
			this.bbiRentsEdit.Caption = "Edit";
			this.bbiRentsEdit.Name = "bbiRentsEdit";
			this.bbiRentsEdit.ImageUri.Uri = "Edit";
			this.bbiRentsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsEdit);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsEdit));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsEdit));
						//
			//RentsDelete
			//
			this.bbiRentsDelete.Caption = "Delete";
			this.bbiRentsDelete.Name = "bbiRentsDelete";
			this.bbiRentsDelete.ImageUri.Uri = "Delete";
			this.bbiRentsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsDelete);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsDelete));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsDelete));
						//
			//RentsRefresh
			//
			this.bbiRentsRefresh.Caption = "Refresh";
			this.bbiRentsRefresh.Name = "bbiRentsRefresh";
			this.bbiRentsRefresh.ImageUri.Uri = "Refresh";
			this.bbiRentsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.RentsBarManager.Items.Add(this.bbiRentsRefresh);
			this.RentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsRefresh));
			this.RentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiRentsRefresh));
						//
			//RentsBar
			//
			this.RentsBar.BarName = "Rents";
            this.RentsBar.DockCol = 0;
            this.RentsBar.DockRow = 0;
            this.RentsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.RentsBar.OptionsBar.AllowQuickCustomization = false;
            this.RentsBar.OptionsBar.DrawDragBorder = false;
            this.RentsBar.Text = "Rents";
			//
			//RentsBarManager
			//
			this.RentsBarManager.AllowCustomization = false;
            this.RentsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.RentsBar});
            this.RentsBarManager.Form = RentsXtraUserControl;
            this.RentsBarManager.MainMenu = this.RentsBar;
			// 
            // RentsPopUpMenu
            // 
            this.RentsPopUpMenu.Manager = this.RentsBarManager;
            this.RentsPopUpMenu.Name = "RentsPopUpMenu";
			//
			//RentsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters RentsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            RentsRetriveFieldParameters.FieldName = "Rents";
            RentsRetriveFieldParameters.ControlForField = RentsXtraUserControl;
			RentsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(RentsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXApplication1.Forms.ViewModels.ClientViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Client - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//ClientView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ClientView";
						((System.ComponentModel.ISupportInitialize)(this.InspectionsBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.RentsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource clientViewBindingSource;
				private DevExpress.XtraGrid.GridControl InspectionsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView InspectionsGridView;
		private DevExpress.XtraBars.BarManager InspectionsBarManager;
		private DevExpress.XtraBars.Bar InspectionsBar;
		private DevExpress.XtraEditors.XtraUserControl InspectionsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu InspectionsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiInspectionsNew;
				private DevExpress.XtraBars.BarButtonItem bbiInspectionsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiInspectionsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiInspectionsRefresh;
						private DevExpress.XtraGrid.GridControl RentsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView RentsGridView;
		private DevExpress.XtraBars.BarManager RentsBarManager;
		private DevExpress.XtraBars.Bar RentsBar;
		private DevExpress.XtraEditors.XtraUserControl RentsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu RentsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiRentsNew;
				private DevExpress.XtraBars.BarButtonItem bbiRentsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiRentsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiRentsRefresh;
						 
	}
}
