using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extensions;

/// <summary>
/// 界面按钮元素
/// </summary>
public interface IRibbonButton : IRibbonItem, IRibbonButtonConfigurable<IRibbonButton>
{

}
