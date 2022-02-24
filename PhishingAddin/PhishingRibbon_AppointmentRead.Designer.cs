namespace PhishingAddin
{
    partial class Phishing_AppointmentRead : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Phishing_AppointmentRead()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group_Phishing = this.Factory.CreateRibbonGroup();
            this.btn_Phishing = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group_Phishing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabAppointment";
            this.tab1.Groups.Add(this.group_Phishing);
            this.tab1.Label = "TabAppointment";
            this.tab1.Name = "tab1";
            // 
            // group_Phishing
            // 
            this.group_Phishing.Items.Add(this.btn_Phishing);
            this.group_Phishing.Label = "Phishing";
            this.group_Phishing.Name = "group_Phishing";
            this.group_Phishing.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupRespond");
            // 
            // btn_Phishing
            // 
            this.btn_Phishing.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_Phishing.Image = global::PhishingAddin.Properties.Resources.PhishingIcon;
            this.btn_Phishing.Label = "Report As Phishing";
            this.btn_Phishing.Name = "btn_Phishing";
            this.btn_Phishing.ShowImage = true;
            this.btn_Phishing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Phishing_Click);
            // 
            // Phishing_AppointmentRead
            // 
            this.Name = "Phishing_AppointmentRead";
            this.RibbonType = "Microsoft.Outlook.Appointment, Microsoft.Outlook.MeetingRequest.Read, Microsoft.O" +
    "utlook.Post.Compose, Microsoft.Outlook.Post.Read, Microsoft.Outlook.Response.Com" +
    "pose, Microsoft.Outlook.Response.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group_Phishing.ResumeLayout(false);
            this.group_Phishing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_Phishing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Phishing;
    }

    partial class ThisRibbonCollection
    {
        internal Phishing_AppointmentRead Ribbon1
        {
            get { return this.GetRibbon<Phishing_AppointmentRead>(); }
        }
    }
}
