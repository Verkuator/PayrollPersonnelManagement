
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
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.accScales});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.Size = new System.Drawing.Size(535, 997);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accScales
            // 
            this.accScales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PhisicalFaceTab,
            this.PostTab,
            this.accordionControlElement1});
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
            this.PhisicalFaceTab.Text = "Физ. лицо";
            this.PhisicalFaceTab.Click += new System.EventHandler(this.PhisicalFaceTab_Click);
            // 
            // PostTab
            // 
            this.PostTab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PostTab.ImageOptions.Image")));
            this.PostTab.Name = "PostTab";
            this.PostTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PostTab.Text = "Element1";
            this.PostTab.Click += new System.EventHandler(this.PostTab_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1737, 0);
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(535, 943);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1202, 54);
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem});
            this.ribbonControl2.Location = new System.Drawing.Point(535, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl2.MaxItemId = 1;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.OptionsMenuMinWidth = 660;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(1202, 50);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element1";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 997);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.IconOptions.ImageUri.Uri = "dashboards/weightedpies";
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(870, 550);
            this.Name = "Main";
            this.Text = "Клиент для взвешивания сырых покрышек";
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}