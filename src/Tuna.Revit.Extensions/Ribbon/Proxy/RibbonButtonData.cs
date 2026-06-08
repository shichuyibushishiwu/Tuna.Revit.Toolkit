using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tuna.Revit.Extensions;

/// <summary>
/// <inheritdoc/>
/// </summary>
public class RibbonButtonData : IRibbonButtonData
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? LongDescription { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? ToolTip { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public object? Image { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public object? LargeImage { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public object? ToolTipImage { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public ContextualHelp? ContextualHelp { get; set; }

    internal static void MapTo(IRibbonButtonData originalData, ButtonData revitButton)
    {
        ArgumentNullExceptionUtils.ThrowIfNull(revitButton);

        if (!string.IsNullOrWhiteSpace(originalData.Title) && !EqualityComparer<string>.Default.Equals(revitButton.Text, originalData.Title!))
        {
            revitButton.Text = originalData.Title;
        }

        if (originalData.Image != null)
        {
            var image = RibbonImageResovler.Resolve(originalData.Image, ResourceManager.Instance.IconRootPath);
            if (image != null && !EqualityComparer<ImageSource>.Default.Equals(revitButton.Image, image))
            {
                revitButton.Image = image;
            }
        }

        if (originalData.LargeImage != null)
        {
            var largeImage = RibbonImageResovler.Resolve(originalData.LargeImage, ResourceManager.Instance.IconRootPath);
            if (largeImage != null && !EqualityComparer<ImageSource>.Default.Equals(revitButton.LargeImage, largeImage))
            {
                revitButton.LargeImage = largeImage;
            }
        }

        if (originalData.ToolTipImage != null)
        {
            var toolTipImage = RibbonImageResovler.Resolve(originalData.ToolTipImage, ResourceManager.Instance.IconRootPath);
            if (toolTipImage != null && !EqualityComparer<ImageSource>.Default.Equals(revitButton.ToolTipImage, toolTipImage))
            {
                revitButton.ToolTipImage = toolTipImage;
            }
        }

        if (!string.IsNullOrEmpty(originalData.ToolTip) && !EqualityComparer<string>.Default.Equals(revitButton.ToolTip, originalData.ToolTip!))
        {
            revitButton.ToolTip = originalData.ToolTip;
        }

        if (!string.IsNullOrEmpty(originalData.LongDescription) && !EqualityComparer<string>.Default.Equals(revitButton.LongDescription, originalData.LongDescription!))
        {
            revitButton.LongDescription = originalData.LongDescription;
        }

        ContextualHelp contextualHelp = revitButton.GetContextualHelp();
        if (originalData.ContextualHelp != null && !EqualityComparer<ContextualHelp>.Default.Equals(contextualHelp, originalData.ContextualHelp))
        {
            revitButton.SetContextualHelp(originalData.ContextualHelp);
        }
    }
}
