using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Infrastructure.ApplicationServices;

/// <summary>
/// 
/// </summary>
public static class HostApplicationExtensions
{
    ///
    extension(List<ITunaApplication> applications)
    {
        /// <summary>
        /// 获取当前活动的应用程序
        /// </summary>
        public ITunaApplication ActivedApplication
        {
            get
            {
                Guid guid = HostApplication.Instance.ApplicationContext.Application.ActiveAddInId.GetGUID();
                ITunaApplication? tunaApplication = null;
                foreach (var application in applications)
                {
                    if (application.ApplicationIdentity.Guid == guid)
                    {
                        tunaApplication = application;
                        break;
                    }
                }

                if (tunaApplication == null)
                {
                    throw new InvalidOperationException("can not find the application");
                }

                return tunaApplication;
            }
        }
    }
}
