
namespace PayrollPersonnelManagement.View
{
    partial class frmMain
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementModels = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEmployee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementOneAccrual = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPhisicalFace = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPost = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSubdivision = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(415, 62);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1077, 839);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementModels});
            this.accordionControl1.Location = new System.Drawing.Point(0, 62);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(415, 839);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementModels
            // 
            this.accordionControlElementModels.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementEmployee,
            this.accordionControlElementOneAccrual,
            this.accordionControlElementPhisicalFace,
            this.accordionControlElementPost,
            this.accordionControlElementSubdivision});
            this.accordionControlElementModels.Expanded = true;
            this.accordionControlElementModels.Name = "accordionControlElementModels";
            this.accordionControlElementModels.Text = "Таблицы";
            // 
            // accordionControlElementEmployee
            // 
            this.accordionControlElementEmployee.Name = "accordionControlElementEmployee";
            this.accordionControlElementEmployee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementEmployee.Text = "Работники";
            // 
            // accordionControlElementOneAccrual
            // 
            this.accordionControlElementOneAccrual.Name = "accordionControlElementOneAccrual";
            this.accordionControlElementOneAccrual.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementOneAccrual.Text = "Начисления";
            // 
            // accordionControlElementPhisicalFace
            // 
            this.accordionControlElementPhisicalFace.Name = "accordionControlElementPhisicalFace";
            this.accordionControlElementPhisicalFace.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPhisicalFace.Text = "Физические лица";
            // 
            // accordionControlElementPost
            // 
            this.accordionControlElementPost.Name = "accordionControlElementPost";
            this.accordionControlElementPost.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPost.Text = "Post";
            // 
            // accordionControlElementSubdivision
            // 
            this.accordionControlElementSubdivision.Name = "accordionControlElementSubdivision";
            this.accordionControlElementSubdivision.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSubdivision.Text = "Subdivision";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1492, 62);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 901);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная Страница";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementModels;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementEmployee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementOneAccrual;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPhisicalFace;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPost;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSubdivision;
    }
}