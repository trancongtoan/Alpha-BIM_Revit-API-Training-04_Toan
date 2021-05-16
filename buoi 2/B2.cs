#region Namespaces

using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using TCT.buoi_2;
using Application = Autodesk.Revit.ApplicationServices.Application;
#endregion

namespace QApps
{
    [Transaction(TransactionMode.Manual)]
    public class B2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code
            
            // tạo ra 2 Instance
            Person m1 = new Person();
            Person m2 = new Person();

            // Gán giá trị property "CanNang" cho mỗi Instance
            List<double> q = new List<double>();    
            q.Add(m1.CanNang = 5); 
            q.Add(m2.CanNang = 3);

          // Lấy ra giá trị "CanNang" lớn nhất
            double cannang = q.Max();

            // Dùng vòng lặp "For" chạy từ 1 tới "CanNang"
            double a = cannang;
            for (int i = 1; i <= a; i++)
            {
               cannang = cannang * i;
            }

            // Show giá trị 
            MessageBox.Show(cannang.ToString());

            return Result.Succeeded;
        }

    }
}