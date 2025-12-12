using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tuna.TemplateWizard
{
    /// <summary>
    /// VS 项目模板交互式向导，实现版本选择与配置生成
    /// </summary>
    public class RevitWizard : IWizard
    {
        private string _tunaVersion = "2025.0.0";
        private readonly HashSet<int> _selectedRvtYears = new HashSet<int>();

        /// <summary>
        /// 模板生成前运行，展示交互式窗口并收集用户选择
        /// </summary>
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
          
            using (var form = new WizardForm())
            {
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                    throw new WizardCancelledException("用户取消了模板创建");

                _tunaVersion = form.SelectedTunaVersion;
                foreach (var year in form.SelectedRevitYears)
                {
                    _selectedRvtYears.Add(year);
                }
            }
        }

        /// <summary>
        /// 项目生成完成后，修改 csproj 以应用选择的版本与构建配置
        /// </summary>
        public void ProjectFinishedGenerating(Project project)
        {
            var csprojPath = project.FullName;
            if (!File.Exists(csprojPath)) return;

            var doc = XDocument.Load(csprojPath);
            XNamespace ns = "http://schemas.microsoft.com/developer/msbuild/2003";
            // SDK-style 项目通常无命名空间
            if (doc.Root?.Name.NamespaceName == string.Empty)
            {
                ns = XNamespace.None;
            }

            // 更新 Tuna.Revit.Extensions 包版本
            var pkgRefs = doc.Descendants(ns + "PackageReference")
                             .Where(e => (string)e.Attribute("Include") == "Tuna.Revit.Extensions");
            foreach (var pkg in pkgRefs)
            {
                pkg.SetAttributeValue("Version", _tunaVersion);
            }

            // 追加构建配置 PropertyGroup
            foreach (var year in _selectedRvtYears)
            {
                var group = new XElement(ns + "PropertyGroup",
                    new XElement(ns + "Configurations", $"$(Configurations);Rvt_{year % 100}_Debug;Rvt_{year % 100}_Release;"));
                doc.Root!.Add(group);
            }

            doc.Save(csprojPath);
        }

        /// <summary>
        /// 运行结束，无额外操作
        /// </summary>
        public void RunFinished() { }

        /// <summary>
        /// 对生成的项目项，无需拦截
        /// </summary>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

        /// <summary>
        /// 始终添加项目项
        /// </summary>
        public bool ShouldAddProjectItem(string filePath) => true;

        /// <summary>
        /// 打开文件前，无需处理
        /// </summary>
        public void BeforeOpeningFile(ProjectItem projectItem) { }
    }
}
