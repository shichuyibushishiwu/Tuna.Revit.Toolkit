using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ApplicationServices;

namespace Tuna.Revit.Infrastructure.Commands;

/// <summary>
/// 
/// </summary>
public abstract class TunaCommand : IExternalCommand, IExternalCommandAvailability, ITunaCommand
{
    /// <inheritdoc/>
    public ICommandContext CommandContext { get; private set; } = default!;

    /// <inheritdoc/>
    public ITunaApplication CurrentApplication { get; private set; } = default!;

    /// <inheritdoc/>
    public HostApplication Host { get; private set; } = default!;

    /// <inheritdoc/>
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        Host = HostApplication.Instance;
        CommandContext = new CommandContext();

        try
        {
            CommandResult commandResult = Execute();

            if (!string.IsNullOrEmpty(commandResult.Message))
            {
                message = commandResult.Message!;
            }

            if (commandResult.ElementSet != null && !commandResult.ElementSet.IsEmpty)
            {
                foreach (Element element in commandResult.ElementSet)
                {
                    elements.Insert(element);
                }
            }
            
            return commandResult.Result;
        }
        catch (Exception exception)
        {
            message = exception.Message;
            return Result.Failed;
        }
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
            return false;
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
