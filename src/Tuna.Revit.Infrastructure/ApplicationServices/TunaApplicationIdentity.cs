using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

internal class TunaApplicationIdentity : ITunaApplicationIdentity
{
    internal TunaApplicationIdentity(AddInId addInId)
    {
        Guid = addInId.GetGUID();
        Name = addInId.GetAddInName(); 
    }

    public Guid Guid { get; }

    public string Name { get; }

    public override string ToString()
    {
        return Name;
    }
}
