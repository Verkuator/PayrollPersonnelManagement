﻿
using DevExpress.XtraGrid.Views.Grid;

namespace PayrollPersonnelManagement.View
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Add = new DevExpress.XtraBars.BarButtonItem();
            this.Delete = new DevExpress.XtraBars.BarButtonItem();
            this.Edit = new DevExpress.XtraBars.BarButtonItem();
            this.BasePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.BaseDataGrid = new DevExpress.XtraGrid.GridControl();
            this.BaseGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.Add,
            this.Delete,
            this.Edit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.BasePage});
            this.ribbon.Size = new System.Drawing.Size(665, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // Add
            // 
            this.Add.Caption = "Добавить";
            this.Add.Id = 1;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.LargeImage")));
            this.Add.Name = "Add";
            // 
            // Delete
            // 
            this.Delete.Caption = "Удалить";
            this.Delete.Id = 2;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.LargeImage")));
            this.Delete.Name = "Delete";
            // 
            // Edit
            // 
            this.Edit.Caption = "Изменить";
            this.Edit.Id = 3;
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.LargeImage")));
            this.Edit.Name = "Edit";
            // 
            // BasePage
            // 
            this.BasePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.BasePage.Name = "BasePage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Add);
            this.ribbonPageGroup1.ItemLinks.Add(this.Edit);
            this.ribbonPageGroup1.ItemLinks.Add(this.Delete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(665, 30);
            // 
            // BaseDataGrid
            // 
            this.BaseDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseDataGrid.Location = new System.Drawing.Point(0, 193);
            this.BaseDataGrid.MainView = this.BaseGridView;
            this.BaseDataGrid.MenuManager = this.ribbon;
            this.BaseDataGrid.Name = "BaseDataGrid";
            this.BaseDataGrid.Size = new System.Drawing.Size(665, 226);
            this.BaseDataGrid.TabIndex = 2;
            this.BaseDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BaseGridView});
            // 
            // BaseGridView
            // 
            this.BaseGridView.GridControl = this.BaseDataGrid;
            this.BaseGridView.Name = "BaseGridView";
            this.BaseGridView.OptionsSelection.MultiSelect = false;
            this.BaseGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            this.BaseGridView.OptionsBehavior.Editable = false;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 449);
            this.Controls.Add(this.BaseDataGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "BaseForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraBars.Ribbon.RibbonPage BasePage;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraBars.BarButtonItem Add;
        public DevExpress.XtraBars.BarButtonItem Delete;
        public DevExpress.XtraBars.BarButtonItem Edit;
        public DevExpress.XtraGrid.GridControl BaseDataGrid;
        public DevExpress.XtraGrid.Views.Grid.GridView BaseGridView;
        public DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}