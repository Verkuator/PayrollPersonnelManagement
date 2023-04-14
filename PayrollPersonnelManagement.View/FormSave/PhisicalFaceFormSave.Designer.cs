
namespace PayrollPersonnelManagement.View.FormSave
{
    partial class PhisicalFaceFormSave
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
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DateBirthDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PatronymicTextEd = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEd = new DevExpress.XtraEditors.TextEdit();
            this.SurnameTextEd = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateBirthDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateBirthDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicTextEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTextEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CancelSimpleButton.Appearance.Options.UseFont = true;
            this.CancelSimpleButton.Location = new System.Drawing.Point(511, 333);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(495, 54);
            this.CancelSimpleButton.StyleController = this.layoutControl1;
            this.CancelSimpleButton.TabIndex = 1;
            this.CancelSimpleButton.Text = "Отмена";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CancelSimpleButton);
            this.layoutControl1.Controls.Add(this.SaveSimpleButton);
            this.layoutControl1.Controls.Add(this.DateBirthDateEdit);
            this.layoutControl1.Controls.Add(this.PatronymicTextEd);
            this.layoutControl1.Controls.Add(this.NameTextEd);
            this.layoutControl1.Controls.Add(this.SurnameTextEd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 399);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SaveSimpleButton.Appearance.Options.UseFont = true;
            this.SaveSimpleButton.Location = new System.Drawing.Point(12, 333);
            this.SaveSimpleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(495, 54);
            this.SaveSimpleButton.StyleController = this.layoutControl1;
            this.SaveSimpleButton.TabIndex = 0;
            this.SaveSimpleButton.Text = "Сохранить";
            this.SaveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // DateBirthDateEdit
            // 
            this.DateBirthDateEdit.EditValue = null;
            this.DateBirthDateEdit.Location = new System.Drawing.Point(285, 204);
            this.DateBirthDateEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateBirthDateEdit.Name = "DateBirthDateEdit";
            this.DateBirthDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.DateBirthDateEdit.Properties.Appearance.Options.UseFont = true;
            this.DateBirthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateBirthDateEdit.Size = new System.Drawing.Size(721, 60);
            this.DateBirthDateEdit.StyleController = this.layoutControl1;
            this.DateBirthDateEdit.TabIndex = 3;
            // 
            // PatronymicTextEd
            // 
            this.PatronymicTextEd.EditValue = "";
            this.PatronymicTextEd.Location = new System.Drawing.Point(285, 140);
            this.PatronymicTextEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatronymicTextEd.Name = "PatronymicTextEd";
            this.PatronymicTextEd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PatronymicTextEd.Properties.Appearance.Options.UseFont = true;
            this.PatronymicTextEd.Size = new System.Drawing.Size(721, 60);
            this.PatronymicTextEd.StyleController = this.layoutControl1;
            this.PatronymicTextEd.TabIndex = 3;
            // 
            // NameTextEd
            // 
            this.NameTextEd.Location = new System.Drawing.Point(285, 76);
            this.NameTextEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextEd.Name = "NameTextEd";
            this.NameTextEd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.NameTextEd.Properties.Appearance.Options.UseFont = true;
            this.NameTextEd.Size = new System.Drawing.Size(721, 60);
            this.NameTextEd.StyleController = this.layoutControl1;
            this.NameTextEd.TabIndex = 3;
            // 
            // SurnameTextEd
            // 
            this.SurnameTextEd.Location = new System.Drawing.Point(285, 12);
            this.SurnameTextEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SurnameTextEd.Name = "SurnameTextEd";
            this.SurnameTextEd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SurnameTextEd.Properties.Appearance.Options.UseFont = true;
            this.SurnameTextEd.Size = new System.Drawing.Size(721, 60);
            this.SurnameTextEd.StyleController = this.layoutControl1;
            this.SurnameTextEd.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1018, 399);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.SurnameTextEd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem1.Text = "Фамилия";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(261, 45);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(499, 256);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(499, 65);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.NameTextEd;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem2.Text = "Имя";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(261, 45);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.PatronymicTextEd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem3.Text = "Отчество";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(261, 45);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.DateBirthDateEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem4.Text = "Дата рождения";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(261, 45);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem5.Control = this.SaveSimpleButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 256);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(499, 123);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CancelSimpleButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(499, 321);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(499, 58);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // PhisicalFaceFormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1018, 399);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhisicalFaceFormSave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Физ. лицо";
            this.Load += new System.EventHandler(this.PhisicalFaceFormSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateBirthDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateBirthDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicTextEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameTextEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit SurnameTextEd;
        private DevExpress.XtraEditors.TextEdit NameTextEd;
        private DevExpress.XtraEditors.DateEdit DateBirthDateEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraEditors.TextEdit PatronymicTextEd;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}