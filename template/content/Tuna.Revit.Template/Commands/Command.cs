using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.Commands;
using Autodesk.Revit.Attributes;

namespace Tuna.Revit.Template.Commands
{    
    [Transaction(TransactionMode.Manual)]
    internal class Command : TunaCommand
    {
        public override CommandResult Execute()
        {
            Views.MainWindow mainWindow = new Views.MainWindow();
            mainWindow.DataContext =new ViewModels.MainWindowViewModel();
            mainWindow.ShowDialog();
           
            return new CommandResult();
        }
    }
}
