
namespace PayrollPersonnelManagement.View.FormSave
{
    partial class PostFormSave
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
            this.CancelSimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SalaryEdit = new DevExpress.XtraEditors.SpinEdit();
            this.NameEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CancelSimpleButton2);
            this.layoutControl1.Controls.Add(this.SaveSimpleButton1);
            this.layoutControl1.Controls.Add(this.SalaryEdit);
            this.layoutControl1.Controls.Add(this.NameEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 318);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CancelSimpleButton2
            // 
            this.CancelSimpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CancelSimpleButton2.Appearance.Options.UseFont = true;
            this.CancelSimpleButton2.Location = new System.Drawing.Point(510, 252);
            this.CancelSimpleButton2.Name = "CancelSimpleButton2";
            this.CancelSimpleButton2.Size = new System.Drawing.Size(496, 54);
            this.CancelSimpleButton2.StyleController = this.layoutControl1;
            this.CancelSimpleButton2.TabIndex = 7;
            this.CancelSimpleButton2.Text = "Отмена";
            this.CancelSimpleButton2.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // SaveSimpleButton1
            // 
            this.SaveSimpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SaveSimpleButton1.Appearance.Options.UseFont = true;
            this.SaveSimpleButton1.Location = new System.Drawing.Point(12, 252);
            this.SaveSimpleButton1.Name = "SaveSimpleButton1";
            this.SaveSimpleButton1.Size = new System.Drawing.Size(494, 54);
            this.SaveSimpleButton1.StyleController = this.layoutControl1;
            this.SaveSimpleButton1.TabIndex = 6;
            this.SaveSimpleButton1.Text = "Сохранить";
            this.SaveSimpleButton1.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // SalaryEdit
            // 
            this.SalaryEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SalaryEdit.Location = new System.Drawing.Point(272, 76);
            this.SalaryEdit.Name = "SalaryEdit";
            this.SalaryEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SalaryEdit.Properties.Appearance.Options.UseFont = true;
            this.SalaryEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SalaryEdit.Properties.MaxValue = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.SalaryEdit.Size = new System.Drawing.Size(734, 60);
            this.SalaryEdit.StyleController = this.layoutControl1;
            this.SalaryEdit.TabIndex = 5;
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(272, 12);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.NameEdit.Properties.Appearance.Options.UseFont = true;
            this.NameEdit.Size = new System.Drawing.Size(734, 60);
            this.NameEdit.StyleController = this.layoutControl1;
            this.NameEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1018, 318);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.NameEdit;
            this.layoutControlItem1.CustomizationFormText = "Наименование";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem1.Text = "Наименование";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(248, 45);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.SalaryEdit;
            this.layoutControlItem3.CustomizationFormText = "Надбавка";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(998, 64);
            this.layoutControlItem3.Text = "Надбавка";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(248, 45);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem2.Control = this.SaveSimpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(498, 58);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CancelSimpleButton2;
            this.layoutControlItem4.Location = new System.Drawing.Point(498, 240);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(500, 58);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 128);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(998, 112);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PostFormSave
            // 
            this.ClientSize = new System.Drawing.Size(1018, 318);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PostFormSave";
            this.Load += new System.EventHandler(this.PostFormSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit SurnameTextEd;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit NameTextEd;
        private DevExpress.Utils.Layout.StackPanel stackPanel4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit PatronymicTextEd;
        private DevExpress.Utils.Layout.StackPanel stackPanel5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit DateBirthDateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit NameEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SpinEdit SalaryEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}