
#region Namespaces

using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;
#endregion

namespace QApps
{
    [Transaction(TransactionMode.Manual)]
    public class Practice_Hello_WorldCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code


       
            Reference r = uidoc.Selection.
                PickObject(ObjectType.Element, 
                    "HAY CHON DOI TUONG");

            Element e = doc.GetElement(r);

            Parameter parameter = e
                .get_Parameter(BuiltInParameter.INSTANCE_LENGTH_PARAM);

            MessageBox.Show(parameter.AsDouble().ToString());


            return Result.Succeeded;
        }
    }
}
 