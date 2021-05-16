
#region Namespaces
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Application = Autodesk.Revit.ApplicationServices.Application;
#endregion

namespace QApps
{
    [Transaction(TransactionMode.Manual)]
    public class VD1Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code

            using (TransactionGroup transGr = new TransactionGroup(doc))
            {
                transGr.Start("VD1TransGr");

                VD1ViewModel viewModel = new VD1ViewModel(uidoc);
                VD1Window window = new VD1Window(viewModel);
                if (window.ShowDialog() == false) 
                    
                    return Result.Cancelled;
                transGr.Assimilate();
            }

            return Result.Succeeded;
        }
    }
}
