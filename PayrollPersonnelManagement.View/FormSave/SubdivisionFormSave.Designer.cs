
namespace PayrollPersonnelManagement.View.FormSave
{
    partial class SubdivisionFormSave
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
            this.SalaryEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CancelSimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.NameEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SalaryLine = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryLine)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SalaryEdit);
            this.layoutControl1.Controls.Add(this.CancelSimpleButton2);
            this.layoutControl1.Controls.Add(this.SaveSimpleButton1);
            this.layoutControl1.Controls.Add(this.NameEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(610, 353);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SalaryEdit
            // 
            this.SalaryEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SalaryEdit.Location = new System.Drawing.Point(116, 56);
            this.SalaryEdit.Name = "SalaryEdit";
            this.SalaryEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SalaryEdit.Properties.MaxValue = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.SalaryEdit.Size = new System.Drawing.Size(482, 40);
            this.SalaryEdit.StyleController = this.layoutControl1;
            this.SalaryEdit.TabIndex = 8;
            // 
            // CancelSimpleButton2
            // 
            this.CancelSimpleButton2.Location = new System.Drawing.Point(307, 297);
            this.CancelSimpleButton2.Name = "CancelSimpleButton2";
            this.CancelSimpleButton2.Size = new System.Drawing.Size(291, 44);
            this.CancelSimpleButton2.StyleController = this.layoutControl1;
            this.CancelSimpleButton2.TabIndex = 7;
            this.CancelSimpleButton2.Text = "Отмена";
            this.CancelSimpleButton2.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // SaveSimpleButton1
            // 
            this.SaveSimpleButton1.Location = new System.Drawing.Point(12, 297);
            this.SaveSimpleButton1.Name = "SaveSimpleButton1";
            this.SaveSimpleButton1.Size = new System.Drawing.Size(291, 44);
            this.SaveSimpleButton1.StyleController = this.layoutControl1;
            this.SaveSimpleButton1.TabIndex = 6;
            this.SaveSimpleButton1.Text = "Добавить";
            this.SaveSimpleButton1.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(116, 12);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.NameEdit.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.NameEdit.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.NameEdit.Size = new System.Drawing.Size(482, 40);
            this.NameEdit.StyleController = this.layoutControl1;
            this.NameEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.SalaryLine});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(610, 353);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.NameEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(590, 44);
            this.layoutControlItem1.Text = "Название";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(92, 25);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(295, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(295, 197);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem3.Control = this.SaveSimpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(295, 245);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CancelSimpleButton2;
            this.layoutControlItem4.Location = new System.Drawing.Point(295, 285);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(295, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // SalaryLine
            // 
            this.SalaryLine.Control = this.SalaryEdit;
            this.SalaryLine.Location = new System.Drawing.Point(0, 44);
            this.SalaryLine.Name = "SalaryLine";
            this.SalaryLine.Size = new System.Drawing.Size(590, 44);
            this.SalaryLine.Text = "Зарплата";
            this.SalaryLine.TextSize = new System.Drawing.Size(92, 25);
            // 
            // SubdivisionFormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 353);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubdivisionFormSave";
            this.Load += new System.EventHandler(this.SubdivisionFormSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit NameEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SpinEdit SalaryEdit;
        private DevExpress.XtraLayout.LayoutControlItem SalaryLine;
    }
}