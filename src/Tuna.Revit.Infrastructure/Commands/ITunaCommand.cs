using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands;

public interface ITunaCommand
{
    ICommandContext CommandContext { get; }
}
