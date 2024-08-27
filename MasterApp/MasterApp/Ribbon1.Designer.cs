namespace MasterApp
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl15 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl16 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl17 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl18 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl19 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl20 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl21 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl22 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.button2 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.dropDown2 = this.Factory.CreateRibbonDropDown();
            this.button14 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.label1);
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Label = "Group0";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Label = "New Slide";
            this.button1.Name = "button1";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Label = "Label1";
            this.label1.Name = "label1";
            // 
            // button2
            // 
            this.button2.Label = "Delete last Slide";
            this.button2.Name = "button2";
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.label2);
            this.group2.Items.Add(this.dropDown1);
            this.group2.Items.Add(this.dropDown2);
            this.group2.Items.Add(this.button14);
            this.group2.Label = "Group1";
            this.group2.Name = "group2";
            // 
            // label2
            // 
            this.label2.Label = "Label2";
            this.label2.Name = "label2";
            // 
            // dropDown1
            // 
            ribbonDropDownItemImpl1.Label = "0";
            ribbonDropDownItemImpl2.Label = "1";
            ribbonDropDownItemImpl3.Label = "2";
            ribbonDropDownItemImpl4.Label = "3";
            ribbonDropDownItemImpl5.Label = "4";
            ribbonDropDownItemImpl6.Label = "5";
            ribbonDropDownItemImpl7.Label = "6";
            ribbonDropDownItemImpl8.Label = "7";
            ribbonDropDownItemImpl9.Label = "8";
            ribbonDropDownItemImpl10.Label = "9";
            ribbonDropDownItemImpl11.Label = "10";
            this.dropDown1.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl3);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl4);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl5);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl6);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl7);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl8);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl9);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl10);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl11);
            this.dropDown1.Label = "startingSlide";
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown1_SelectionChanged);
            // 
            // dropDown2
            // 
            ribbonDropDownItemImpl12.Label = "0";
            ribbonDropDownItemImpl13.Label = "1";
            ribbonDropDownItemImpl14.Label = "2";
            ribbonDropDownItemImpl15.Label = "3";
            ribbonDropDownItemImpl16.Label = "4";
            ribbonDropDownItemImpl17.Label = "5";
            ribbonDropDownItemImpl18.Label = "6";
            ribbonDropDownItemImpl19.Label = "7";
            ribbonDropDownItemImpl20.Label = "8";
            ribbonDropDownItemImpl21.Label = "9";
            ribbonDropDownItemImpl22.Label = "10";
            this.dropDown2.Items.Add(ribbonDropDownItemImpl12);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl13);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl14);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl15);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl16);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl17);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl18);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl19);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl20);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl21);
            this.dropDown2.Items.Add(ribbonDropDownItemImpl22);
            this.dropDown2.Label = "endingSlide";
            this.dropDown2.Name = "dropDown2";
            this.dropDown2.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown2_SelectionChanged);
            // 
            // button14
            // 
            this.button14.Label = "Restrict";
            this.button14.Name = "button14";
            this.button14.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button14_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button14;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
