using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace FirstOutlookAddIn
{
    public partial class ThisAddIn
    {
        //Outlook.Inspectors inspectors;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //inspectors = this.Application.Inspectors;
            //inspectors.NewInspector +=
            //new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
        }

        public string TraerID(Office.IRibbonControl control, int index)
        {
            if (control.Id == "comboBox1")

            {

                return index.ToString();

            }

            return string.Empty;
        }

        //void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        //{
        //    Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;
        //    if (mailItem != null)
        //    {
        //        if (mailItem.EntryID == null)
        //        {
        //            mailItem.Subject = "This text was added by using code";
        //            mailItem.Body = "This text was added by using code";
        //        }

        //    }

        //    Outlook.OutlookBarPane outlookBar = Inspector.CurrentItem as Outlook.OutlookBarPane;
        //}

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Nota: Outlook ya no genera este evento. Si tiene código que 
            //    se debe ejecutar cuando Outlook se apaga, consulte https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region Código generado por VSTO

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
