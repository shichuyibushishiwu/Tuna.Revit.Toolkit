using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extensions;
using Tuna.Revit.Infrastructure.ExternalEvent;

namespace Tuna.Revit.Infrastructure;

/// <summary>
/// 
/// </summary>
public class CommandContext : ICommandContext
{
    public IExternalEventService ExternalEventService => throw new NotImplementedException();
}
