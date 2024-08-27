using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MasterApp
{

    
    public partial class ThisAddIn
    {
        [DllImport("C:\\Users\\akshi\\Downloads\\ppt_controller\\main_dll\\x64\\Debug\\main_dll.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void fn_test();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
                fn_test();

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //Called on shutting down PowerPoint
            MessageBox.Show("Stopped");
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
