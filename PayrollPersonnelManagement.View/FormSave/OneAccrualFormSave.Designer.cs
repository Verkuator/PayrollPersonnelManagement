
namespace PayrollPersonnelManagement.View.FormSave
{
    partial class OneAccrualFormSave
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
            this.EmployeeEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.HoursEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stackPanel4 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TotalSum = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.CalculateButton = new DevExpress.XtraEditors.SimpleButton();
            this.EmployeeLine = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).BeginInit();
            this.stackPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLine)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.EmployeeEdit);
            this.layoutControl1.Controls.Add(this.HoursEdit);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(802, 0, 1300, 800);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1301, 212);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // EmployeeEdit
            // 
            this.EmployeeEdit.Location = new System.Drawing.Point(324, 135);
            this.EmployeeEdit.Name = "EmployeeEdit";
            this.EmployeeEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.EmployeeEdit.Properties.Appearance.Options.UseFont = true;
            this.EmployeeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeeEdit.Size = new System.Drawing.Size(974, 60);
            this.EmployeeEdit.StyleController = this.layoutControl1;
            this.EmployeeEdit.TabIndex = 9;
            // 
            // HoursEdit
            // 
            this.HoursEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HoursEdit.Location = new System.Drawing.Point(324, 69);
            this.HoursEdit.Name = "HoursEdit";
            this.HoursEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.HoursEdit.Properties.Appearance.Options.UseFont = true;
            this.HoursEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HoursEdit.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.HoursEdit.Size = new System.Drawing.Size(974, 60);
            this.HoursEdit.StyleController = this.layoutControl1;
            this.HoursEdit.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(324, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(974, 60);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.EmployeeLine});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1301, 212);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1301, 66);
            this.layoutControlItem1.Text = "Дата начисления";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(303, 45);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.HoursEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1301, 66);
            this.layoutControlItem2.Text = "Количество часов";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(303, 45);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stackPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 139);
            this.panel1.TabIndex = 1;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.labelControl2);
            this.stackPanel4.Controls.Add(this.TotalSum);
            this.stackPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel4.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel4.Location = new System.Drawing.Point(0, 0);
            this.stackPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(1301, 139);
            this.stackPanel4.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(538, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(224, 45);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Итого сумма:";
            // 
            // TotalSum
            // 
            this.TotalSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalSum.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.TotalSum.Appearance.Options.UseFont = true;
            this.TotalSum.Location = new System.Drawing.Point(620, 60);
            this.TotalSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.Size = new System.Drawing.Size(60, 52);
            this.TotalSum.TabIndex = 0;
            this.TotalSum.Text = "0 р";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CalculateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 72);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 423);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1301, 119);
            this.panel3.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CancelButton.Appearance.Options.UseFont = true;
            this.CancelButton.Location = new System.Drawing.Point(878, 470);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(423, 72);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SaveButton.Appearance.Options.UseFont = true;
            this.SaveButton.Location = new System.Drawing.Point(0, 47);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(387, 72);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.CalculateButton.Appearance.Options.UseFont = true;
            this.CalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateButton.Location = new System.Drawing.Point(0, 0);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(1301, 72);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Расчитать";
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EmployeeLine
            // 
            this.EmployeeLine.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.EmployeeLine.AppearanceItemCaption.Options.UseFont = true;
            this.EmployeeLine.Control = this.EmployeeEdit;
            this.EmployeeLine.Location = new System.Drawing.Point(0, 132);
            this.EmployeeLine.Name = "EmployeeLine";
            this.EmployeeLine.Size = new System.Drawing.Size(1301, 80);
            this.EmployeeLine.Text = "Сотрудник";
            this.EmployeeLine.TextSize = new System.Drawing.Size(303, 45);
            // 
            // OneAccrualFormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 541);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.layoutControl1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OneAccrualFormSave";
            this.Load += new System.EventHandler(this.OneAccrualFormSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).EndInit();
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit HoursEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit EmployeeEdit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraLayout.LayoutControlItem EmployeeLine;
        private DevExpress.XtraEditors.SimpleButton CalculateButton;
        private DevExpress.XtraEditors.LabelControl TotalSum;
    }
}