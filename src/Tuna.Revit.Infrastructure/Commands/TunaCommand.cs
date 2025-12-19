using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 
/// </summary>
public abstract class TunaCommand : IExternalCommand, IExternalCommandAvailability, ITunaCommand
{
    /// <summary>
    /// 
    /// </summary>
    public ICommandContext CommandContext { get; private set; } = default!;

    /// <inheritdoc/>
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        try
        {
            CommandContext = new CommandContext();
            CommandResult commandResult = Execute();
        }
        catch (Exception)
        {


        }

        return Result.Succeeded;
    }

    /// <inheritdoc/>
    public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
    {
        try
        {
            CanExecute();
        }
        catch (Exception)
        {


        }


        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public abstract CommandResult Execute();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public virtual bool CanExecute() => true;

}
