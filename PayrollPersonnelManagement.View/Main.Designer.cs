
namespace PayrollPersonnelManagement.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accScales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PhisicalFaceTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PostTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.EmployeeTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SubdivisionTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.OneAccrualTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accScales,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.Size = new System.Drawing.Size(272, 638);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accScales
            // 
            this.accScales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PhisicalFaceTab,
            this.PostTab,
            this.EmployeeTab,
            this.SubdivisionTab});
            this.accScales.Expanded = true;
            this.accScales.Hint = "Весы";
            this.accScales.ImageOptions.ImageUri.Uri = "business%20objects/bo_department";
            this.accScales.Name = "accScales";
            this.accScales.Text = "Весы";
            // 
            // PhisicalFaceTab
            // 
            this.PhisicalFaceTab.ImageOptions.ImageUri.Uri = "business%20objects/bo_customer";
            this.PhisicalFaceTab.Name = "PhisicalFaceTab";
            this.PhisicalFaceTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PhisicalFaceTab.Text = "Физические лица";
            this.PhisicalFaceTab.Click += new System.EventHandler(this.PhisicalFaceTab_Click);
            // 
            // PostTab
            // 
            this.PostTab.ImageOptions.ImageUri.Uri = "business%20objects/bo_position_v92";
            this.PostTab.Name = "PostTab";
            this.PostTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PostTab.Text = "Должности";
            this.PostTab.Click += new System.EventHandler(this.PostTab_Click);
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.ImageOptions.ImageUri.Uri = "business%20objects/bo_lead";
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.EmployeeTab.Text = "Сотрудники";
            this.EmployeeTab.Click += new System.EventHandler(this.EmployeeTab_Click);
            // 
            // SubdivisionTab
            // 
            this.SubdivisionTab.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SubdivisionTab.ImageOptions.SvgImage")));
            this.SubdivisionTab.Name = "SubdivisionTab";
            this.SubdivisionTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SubdivisionTab.Text = "Подразделения";
            this.SubdivisionTab.Click += new System.EventHandler(this.SubdivisionTab_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.OneAccrualTab});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.ImageUri.Uri = "business%20objects/bo_dashboard";
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // OneAccrualTab
            // 
            this.OneAccrualTab.ImageOptions.ImageUri.Uri = "icon%20builder/business_cash";
            this.OneAccrualTab.Name = "OneAccrualTab";
            this.OneAccrualTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.OneAccrualTab.Text = "Разовые начисления";
            this.OneAccrualTab.Click += new System.EventHandler(this.OneAccrualTab_Click_1);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1013, 0);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Выход";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem1.Caption = "Окна";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barMdiChildrenListItem1,
            this.barMdiChildrenListItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(730, 0);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem2.Caption = "Окна";
            this.barMdiChildrenListItem2.Id = 10;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barMdiChildrenListItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(272, 605);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(741, 33);
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem});
            this.ribbonControl2.Location = new System.Drawing.Point(272, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl2.MaxItemId = 1;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.OptionsMenuMinWidth = 385;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(741, 31);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 638);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.IconOptions.ImageUri.Uri = "dashboards/weightedpies";
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(870, 550);
            this.Name = "Main";
            this.Text = "Учёт";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accScales;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PhisicalFaceTab;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PostTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement EmployeeTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SubdivisionTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement OneAccrualTab;
    }
}