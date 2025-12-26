using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.Commands
{
    /// <summary>
    /// 文档上下文提供者，暴露当前激活的文档上下文
    /// </summary>
    public interface IDocumentContextProvider
    {
        /// <summary>
        /// 当前激活的文档上下文
        /// </summary>
        public IDocumentContext? ActivedDocument { get; }
    }
}
