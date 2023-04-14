
namespace PayrollPersonnelManagement.View.FormSave
{
    partial class EmploeeFormSave
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.PhisicalFaceEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.PostEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SubdivisionEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.PhisicalFaceControllItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.PostControllItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SubdivisionControllItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubdivisionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceControllItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostControllItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubdivisionControllItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.PhisicalFaceEdit);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.PostEdit);
            this.layoutControl1.Controls.Add(this.SubdivisionEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(706, 0, 1300, 800);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 399);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // PhisicalFaceEdit
            // 
            this.PhisicalFaceEdit.Location = new System.Drawing.Point(299, 19);
            this.PhisicalFaceEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhisicalFaceEdit.Name = "PhisicalFaceEdit";
            this.PhisicalFaceEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PhisicalFaceEdit.Properties.Appearance.Options.UseFont = true;
            this.PhisicalFaceEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PhisicalFaceEdit.Size = new System.Drawing.Size(701, 60);
            this.PhisicalFaceEdit.StyleController = this.layoutControl1;
            this.PhisicalFaceEdit.TabIndex = 11;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(510, 326);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(490, 54);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Отменить";
            this.simpleButton2.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(18, 326);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(486, 54);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Сохранить";
            this.simpleButton1.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // PostEdit
            // 
            this.PostEdit.Location = new System.Drawing.Point(299, 85);
            this.PostEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostEdit.Name = "PostEdit";
            this.PostEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PostEdit.Properties.Appearance.Options.UseFont = true;
            this.PostEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PostEdit.Size = new System.Drawing.Size(701, 60);
            this.PostEdit.StyleController = this.layoutControl1;
            this.PostEdit.TabIndex = 11;
            // 
            // SubdivisionEdit
            // 
            this.SubdivisionEdit.Location = new System.Drawing.Point(299, 151);
            this.SubdivisionEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubdivisionEdit.Name = "SubdivisionEdit";
            this.SubdivisionEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SubdivisionEdit.Properties.Appearance.Options.UseFont = true;
            this.SubdivisionEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubdivisionEdit.Size = new System.Drawing.Size(701, 60);
            this.SubdivisionEdit.StyleController = this.layoutControl1;
            this.SubdivisionEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.PhisicalFaceControllItem,
            this.PostControllItem,
            this.SubdivisionControllItem});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1018, 399);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(492, 198);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(496, 109);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 198);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(492, 169);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(492, 307);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(496, 60);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // PhisicalFaceControllItem
            // 
            this.PhisicalFaceControllItem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PhisicalFaceControllItem.AppearanceItemCaption.Options.UseFont = true;
            this.PhisicalFaceControllItem.Control = this.PhisicalFaceEdit;
            this.PhisicalFaceControllItem.Location = new System.Drawing.Point(0, 0);
            this.PhisicalFaceControllItem.Name = "PhisicalFaceControllItem";
            this.PhisicalFaceControllItem.Size = new System.Drawing.Size(988, 66);
            this.PhisicalFaceControllItem.Text = "Физ. лицо";
            this.PhisicalFaceControllItem.TextSize = new System.Drawing.Size(263, 45);
            // 
            // PostControllItem
            // 
            this.PostControllItem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PostControllItem.AppearanceItemCaption.Options.UseFont = true;
            this.PostControllItem.Control = this.PostEdit;
            this.PostControllItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PostControllItem.CustomizationFormText = "Должность";
            this.PostControllItem.Location = new System.Drawing.Point(0, 66);
            this.PostControllItem.Name = "PostControllItem";
            this.PostControllItem.Size = new System.Drawing.Size(988, 66);
            this.PostControllItem.Text = "Должность";
            this.PostControllItem.TextSize = new System.Drawing.Size(263, 45);
            // 
            // SubdivisionControllItem
            // 
            this.SubdivisionControllItem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SubdivisionControllItem.AppearanceItemCaption.Options.UseFont = true;
            this.SubdivisionControllItem.Control = this.SubdivisionEdit;
            this.SubdivisionControllItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SubdivisionControllItem.CustomizationFormText = "Подразделение";
            this.SubdivisionControllItem.Location = new System.Drawing.Point(0, 132);
            this.SubdivisionControllItem.Name = "SubdivisionControllItem";
            this.SubdivisionControllItem.Size = new System.Drawing.Size(988, 66);
            this.SubdivisionControllItem.Text = "Подразделение";
            this.SubdivisionControllItem.TextSize = new System.Drawing.Size(263, 45);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 353);
            this.layoutControlGroup2.Name = "LayoutRootGroupForRestore";
            this.layoutControlGroup2.Size = new System.Drawing.Size(590, 35);
            this.layoutControlGroup2.Tag = "LayoutRootGroupForRestore";
            // 
            // EmploeeFormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 399);
            this.Controls.Add(this.layoutControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmploeeFormSave";
            this.Load += new System.EventHandler(this.EmploeeFormSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubdivisionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceControllItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostControllItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubdivisionControllItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.LookUpEdit PhisicalFaceEdit;
        private DevExpress.XtraLayout.LayoutControlItem PhisicalFaceControllItem;
        private DevExpress.XtraEditors.LookUpEdit PostEdit;
        private DevExpress.XtraEditors.LookUpEdit SubdivisionEdit;
        private DevExpress.XtraLayout.LayoutControlItem PostControllItem;
        private DevExpress.XtraLayout.LayoutControlItem SubdivisionControllItem;
    }
}