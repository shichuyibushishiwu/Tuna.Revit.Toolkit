using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Infrastructure.Commands;
using Autodesk.Revit.Attributes;
using Tuna.Revit.Extensions;

namespace Tuna.Revit.Template.Commands
{
    [CommandButton(LargeImage = "gift32.png", Image = "gift16.png",Title = "Tuna Hello World")]
    [Transaction(TransactionMode.Manual)]
    internal class Command : Infrastructure.Commands.TunaCommand
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
