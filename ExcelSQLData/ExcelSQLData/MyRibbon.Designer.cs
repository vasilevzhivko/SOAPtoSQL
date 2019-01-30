namespace ExcelSQLData
{
    partial class MyRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MyRibbon()
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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tabSQLOperations = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnLoadData = this.Factory.CreateRibbonButton();
            this.btnSaveData = this.Factory.CreateRibbonButton();
            this.tabSQLOperations.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSQLOperations
            // 
            this.tabSQLOperations.Groups.Add(this.group1);
            this.tabSQLOperations.Label = "SQL Server Operations";
            this.tabSQLOperations.Name = "tabSQLOperations";
            // 
            // group1
            // 
            this.group1.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group1.Items.Add(this.btnLoadData);
            this.group1.Items.Add(this.btnSaveData);
            this.group1.Label = "SQL Operations";
            this.group1.Name = "group1";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Label = "Load data";
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Label = "Save data";
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSaveData_Click);
            // 
            // MyRibbon
            // 
            this.Name = "MyRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabSQLOperations);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MyRibbon_Load);
            this.tabSQLOperations.ResumeLayout(false);
            this.tabSQLOperations.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabSQLOperations;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoadData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSaveData;
    }

    partial class ThisRibbonCollection
    {
        internal MyRibbon MyRibbon
        {
            get { return this.GetRibbon<MyRibbon>(); }
        }
    }
}
