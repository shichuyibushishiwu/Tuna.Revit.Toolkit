using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tuna.TemplateWizard
{
    /// <summary>
    /// 模板向导选择窗体：选择 Tuna 包版本与多个 Revit 构建配置
    /// </summary>
    public class WizardForm : Form
    {
        private ComboBox _cmbTunaVersion;
        private readonly Dictionary<int, CheckBox> _yearCheckboxes = new();
        private Button _btnOk;
        private Button _btnCancel;

        /// <summary>
        /// 用户选择的 Tuna.Revit.Extensions 包版本
        /// </summary>
        public string SelectedTunaVersion => _cmbTunaVersion.SelectedItem?.ToString() ?? "2025.0.0";

        /// <summary>
        /// 用户选择的 Revit 年份集合
        /// </summary>
        public IEnumerable<int> SelectedRevitYears => _yearCheckboxes.Where(kv => kv.Value.Checked).Select(kv => kv.Key);

        /// <summary>
        /// 初始化窗体
        /// </summary>
        public WizardForm()
        {
            Text = "Tuna Revit 模板向导";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(400, 360);

            var lblVersion = new Label { Text = "选择 Tuna.Revit.Extensions 版本：", AutoSize = true, Location = new Point(16, 16) };
            _cmbTunaVersion = new ComboBox { Location = new Point(20, 40), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            _cmbTunaVersion.Items.AddRange(new object[] { "2024.0.21", "2025.0.0", "2026.0.0" });
            _cmbTunaVersion.SelectedIndex = 1;

            var lblYears = new Label { Text = "选择要添加的 Revit 构建配置（可多选）：", AutoSize = true, Location = new Point(16, 80) };

            int[] years = { 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026 };
            int yOffset = 110;
            foreach (var y in years)
            {
                var cb = new CheckBox { Text = $"Revit {y}", AutoSize = true, Location = new Point(20, yOffset) };
                _yearCheckboxes[y] = cb;
                Controls.Add(cb);
                yOffset += 24;
            }
            _yearCheckboxes[2025].Checked = true;

            _btnOk = new Button { Text = "确定", Location = new Point(220, 300), DialogResult = DialogResult.OK };
            _btnCancel = new Button { Text = "取消", Location = new Point(300, 300), DialogResult = DialogResult.Cancel };
            AcceptButton = _btnOk;
            CancelButton = _btnCancel;

            Controls.Add(lblVersion);
            Controls.Add(_cmbTunaVersion);
            Controls.Add(lblYears);
            Controls.Add(_btnOk);
            Controls.Add(_btnCancel);
        }
    }
}
