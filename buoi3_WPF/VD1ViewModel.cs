#region Namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace QApps
{
    public class VD1ViewModel : ViewModelBase
    {
        public UIDocument UiDoc;
        public Document Doc;

        /// <summary>
        /// Hàm khởi tạo đối tượng VD1ViewModel
        /// </summary>
        /// <param name="uidoc"></param>
        public VD1ViewModel(UIDocument uiDoc)
        {
            // Lưu trữ data từ Revit
            UiDoc = uiDoc;
            Doc = UiDoc.Document;

            // Khởi tạo data cho WPF

            AllGetFamlily = AllSetFamlily = new List<string>();

            AllGetFamlily.Add("Ø6");
            AllGetFamlily.Add("Ø8");
            AllGetFamlily.Add("Ø10");
            AllGetFamlily.Add("Ø12");
            AllGetFamlily.Add("Ø14");
            AllGetFamlily.Add("Ø16");

            GetFamlily = AllGetFamlily[0];
            SetFamlily = AllGetFamlily[0];

            PickOption1 = true;
            ClickToUpper = true;
 

        }

        #region Khai báo Binding Properties 

        public bool PickOption1 { get; set; }
        public bool PickOption2 { get; set; }
        public bool ClickToUpper { get; set; }  
        public bool ClickToLower { get; set; }  
        public List<string>  AllGetFamlily { get; set; } 
        public string GetFamlily { get; set; }
        public List<string> AllSetFamlily { get; set; }  
        public string SetFamlily { get; set; }
        public string textnode { get; set; } = "Trancongtoan";

        #endregion public properties


    }
}
