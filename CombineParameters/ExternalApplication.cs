using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace CombineParameters 
{
    class ExternalApplication : IExternalApplication
    {
        //UIControlledApplication is object that has passesd to the method
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication app)
        {
            //Create Ribbon Element
            app.CreateRibbonTab("DAC Project");
            string path = Assembly.GetExecutingAssembly().Location;
            //needs to be string, therefore using quotation marks 
            PushButtonData button = new PushButtonData("QWERTY", "Click to combine parameters", path, "CombineParameters.CombineParameters" );
            //panel - group of commands
            RibbonPanel panel = app.CreateRibbonPanel("DAC Project", "Combining parameters");
            PushButton pushButton = panel.AddItem(button) as PushButton;
      
            return Result.Succeeded;
        }
    }
}
