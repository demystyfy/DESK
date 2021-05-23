using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace CombineParameters
{
    [Transaction(TransactionMode.Manual)]
    [RegenerationAttribute(RegenerationOption.Manual)]

    public class Class : IExternalCommand
    {

        public Result Execute(ExternalCommandData commandData,
                              ref string message,
                              ElementSet elements)

        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            Settings documentSettings = doc.Settings;
            Categories categories = documentSettings.Categories;

            SortedList<string, Category> myCategories = new SortedList<string, Category>();

            
            foreach (Category c in categories)
            {
                myCategories.Add(c.Name, c);
            }


 // CAN I DELETE THIS BECAUSE WHAT IS THE POINT OF IT? 
            /*
            myCategories.Clear();

            foreach (Category c in categories)
            {
                if (c.AllowsBoundParameters)
                myCategories.Add(c.Name, c);
            }
            */

            UserWindow UserWindow = new UserWindow(myCategories);
            UserWindow.Show();


            //ElementCategoryFilter filter = new ElementCategoryFilter(category);
            //FilteredElementCollector collector = new FilteredElementCollector(doc);
            //IList<Element> ListOfParameters = collector.WherePasses(filter);
            //this one doesn't work either
            //IList<Element> ListOfParameters = ListOfParameters.OfClass(typeof(category))





            Set1.Default.SelectingCategory = "myString";
            Set1.Default.Save();









            return Result.Succeeded;
        }
    }
}



// IList<Element> ListOfParameters = collector.WherePasses(filter)
//toElements will retrieve the elements
//IList<Element> FCategoryList = FCategory.WherePasses(filter).WhereElementIsNotElementType().ToElements();





