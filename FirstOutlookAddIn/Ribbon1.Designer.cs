namespace FirstOutlookAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.comboBox1 = this.Factory.CreateRibbonComboBox();
            this.comboBox2 = this.Factory.CreateRibbonComboBox();
            this.comboBox3 = this.Factory.CreateRibbonComboBox();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.comboBox4 = this.Factory.CreateRibbonComboBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.editBox2 = this.Factory.CreateRibbonEditBox();
            this.button2 = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.comboBox5 = this.Factory.CreateRibbonComboBox();
            this.comboBox6 = this.Factory.CreateRibbonComboBox();
            this.group7 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.button6 = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group6.SuspendLayout();
            this.group7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group6);
            this.tab1.Groups.Add(this.group7);
            this.tab1.Label = "PROMO";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.comboBox1);
            this.group1.Items.Add(this.comboBox2);
            this.group1.Items.Add(this.comboBox3);
            this.group1.Name = "group1";
            // 
            // comboBox1
            // 
            this.comboBox1.Label = "PROYECTOS";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Text = null;
            // 
            // comboBox2
            // 
            this.comboBox2.Label = "ESPECIALIDAD";
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Text = null;
            // 
            // comboBox3
            // 
            this.comboBox3.Label = "RFQ";
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Text = null;
            // 
            // group2
            // 
            this.group2.Items.Add(this.comboBox4);
            this.group2.Items.Add(this.button1);
            this.group2.Name = "group2";
            // 
            // comboBox4
            // 
            this.comboBox4.Label = "REVISIóN";
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Text = null;
            // 
            // button1
            // 
            this.button1.Label = "Obtener datos email";
            this.button1.Name = "button1";
            // 
            // group3
            // 
            this.group3.Items.Add(this.label2);
            this.group3.Items.Add(this.button8);
            this.group3.Items.Add(this.button9);
            this.group3.Name = "group3";
            // 
            // label2
            // 
            this.label2.Label = "FECHA";
            this.label2.Name = "label2";
            // 
            // button8
            // 
            this.button8.Label = "Sugerir contactos";
            this.button8.Name = "button8";
            // 
            // button9
            // 
            this.button9.Label = "Fecha Comprometida";
            this.button9.Name = "button9";
            // 
            // group4
            // 
            this.group4.Items.Add(this.editBox1);
            this.group4.Items.Add(this.editBox2);
            this.group4.Items.Add(this.button2);
            this.group4.Name = "group4";
            // 
            // editBox1
            // 
            this.editBox1.Label = "Buscar proyecto";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            // 
            // editBox2
            // 
            this.editBox2.Label = "Remitente";
            this.editBox2.Name = "editBox2";
            this.editBox2.Text = null;
            // 
            // button2
            // 
            this.button2.Label = "Registrar mail";
            this.button2.Name = "button2";
            // 
            // group5
            // 
            this.group5.Items.Add(this.button3);
            this.group5.Items.Add(this.button4);
            this.group5.Items.Add(this.button5);
            this.group5.Name = "group5";
            // 
            // button3
            // 
            this.button3.Label = "RUTA IT";
            this.button3.Name = "button3";
            // 
            // button4
            // 
            this.button4.Label = "RUTA IC";
            this.button4.Name = "button4";
            // 
            // button5
            // 
            this.button5.Label = "Referente tecnico";
            this.button5.Name = "button5";
            // 
            // group6
            // 
            this.group6.Items.Add(this.comboBox5);
            this.group6.Items.Add(this.comboBox6);
            this.group6.Name = "group6";
            // 
            // comboBox5
            // 
            this.comboBox5.Label = "CATEGORIA/FLAG";
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Text = null;
            // 
            // comboBox6
            // 
            this.comboBox6.Label = "ANALISIS TECNICO";
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Text = null;
            // 
            // group7
            // 
            this.group7.Items.Add(this.label1);
            this.group7.Items.Add(this.button6);
            this.group7.Items.Add(this.button7);
            this.group7.Name = "group7";
            // 
            // label1
            // 
            this.label1.Label = "ACCIONES RáPIDAS";
            this.label1.Name = "label1";
            // 
            // button6
            // 
            this.button6.Label = "Guardar mail";
            this.button6.Name = "button6";
            // 
            // button7
            // 
            this.button7.Label = "Generar template";
            this.button7.Name = "button7";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group7.ResumeLayout(false);
            this.group7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group7;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox5;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox6;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
