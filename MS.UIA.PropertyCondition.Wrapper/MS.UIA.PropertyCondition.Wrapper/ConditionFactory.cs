using System.Globalization;
using System.Windows;
using System.Windows.Automation;

namespace MS.UIA.PropertyConditions.Wrapper
{
    /// <summary>
    /// Provides stronger typing to creating <see cref="PropertyCondition"/>s.
    /// </summary>
    public class ConditionFactory
    {
        public static WrappedPropertyCondition<string> AutomationIdProperty = new WrappedPropertyCondition<string>(AutomationElement.AutomationIdProperty);
        public static WrappedPropertyCondition<bool> IsContentElementProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsContentElementProperty);
        public static WrappedPropertyCondition<ControlType> ControlTypeProperty = new WrappedPropertyCondition<ControlType>(AutomationElement.ControlTypeProperty);
        public static WrappedPropertyCondition<bool> IsControlElementProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsControlElementProperty);
        public static WrappedPropertyCondition<AutomationElement> LabeledByProperty = new WrappedPropertyCondition<AutomationElement>(AutomationElement.LabeledByProperty);
        public static WrappedPropertyCondition<int> NativeWindowHandleProperty = new WrappedPropertyCondition<int>(AutomationElement.NativeWindowHandleProperty);
        public static WrappedPropertyCondition<bool> IsPasswordProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsPasswordProperty);
        public static WrappedPropertyCondition<bool> HasKeyboardFocusProperty = new WrappedPropertyCondition<bool>(AutomationElement.HasKeyboardFocusProperty);
        public static WrappedPropertyCondition<bool> IsKeyboardFocusableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsKeyboardFocusableProperty);
        public static WrappedPropertyCondition<bool> IsEnabledProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsEnabledProperty);
        public static WrappedPropertyCondition<Rect> BoundingRectangleProperty = new WrappedPropertyCondition<Rect>(AutomationElement.BoundingRectangleProperty);
        public static WrappedPropertyCondition<int> ProcessIdProperty = new WrappedPropertyCondition<int>(AutomationElement.ProcessIdProperty);
        public static WrappedPropertyCondition<int[]> RuntimeIdProperty = new WrappedPropertyCondition<int[]>(AutomationElement.RuntimeIdProperty);
        public static WrappedPropertyCondition<Point> ClickablePointProperty = new WrappedPropertyCondition<Point>(AutomationElement.ClickablePointProperty);
        public static WrappedPropertyCondition<CultureInfo> CultureProperty = new WrappedPropertyCondition<CultureInfo>(AutomationElement.CultureProperty);
        public static WrappedPropertyCondition<bool> IsOffscreenProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsOffscreenProperty);
        public static WrappedPropertyCondition<OrientationType> OrientationProperty = new WrappedPropertyCondition<OrientationType>(AutomationElement.OrientationProperty);
        public static WrappedPropertyCondition<bool> IsRequiredForFormProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsRequiredForFormProperty);
        public static WrappedPropertyCondition<bool> IsDockPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsDockPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsExpandCollapsePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsExpandCollapsePatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsGridItemPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsGridItemPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsGridPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsGridPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsInvokePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsInvokePatternAvailableProperty);
        public static WrappedPropertyCondition<string> AcceleratorKeyProperty = new WrappedPropertyCondition<string>(AutomationElement.AcceleratorKeyProperty);
        public static WrappedPropertyCondition<string> AccessKeyProperty = new WrappedPropertyCondition<string>(AutomationElement.AccessKeyProperty);
        public static WrappedPropertyCondition<string> ClassNameProperty = new WrappedPropertyCondition<string>(AutomationElement.ClassNameProperty);
        public static WrappedPropertyCondition<string> FrameworkIdProperty = new WrappedPropertyCondition<string>(AutomationElement.FrameworkIdProperty);
        public static WrappedPropertyCondition<string> HelpTextProperty = new WrappedPropertyCondition<string>(AutomationElement.HelpTextProperty);
        public static WrappedPropertyCondition<bool> IsItemContainerPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsItemContainerPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsMultipleViewPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsMultipleViewPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsRangeValuePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsRangeValuePatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsScrollItemPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsScrollItemPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsScrollPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsScrollPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsSelectionItemPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsSelectionItemPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsSelectionPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsSelectionPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsSynchronizedInputPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsSynchronizedInputPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsTableItemPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsTableItemPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsTablePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsTablePatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsTextPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsTextPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsTogglePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsTogglePatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsTransformPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsTransformPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsValuePatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsValuePatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsVirtualizedItemPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsVirtualizedItemPatternAvailableProperty);
        public static WrappedPropertyCondition<bool> IsWindowPatternAvailableProperty = new WrappedPropertyCondition<bool>(AutomationElement.IsWindowPatternAvailableProperty);
        public static WrappedPropertyCondition<string> ItemStatusProperty = new WrappedPropertyCondition<string>(AutomationElement.ItemStatusProperty);
        public static WrappedPropertyCondition<string> ItemTypeProperty = new WrappedPropertyCondition<string>(AutomationElement.ItemTypeProperty);
        public static WrappedPropertyCondition<string> LocalizedControlTypeProperty = new WrappedPropertyCondition<string>(AutomationElement.LocalizedControlTypeProperty);
        public static WrappedPropertyCondition<string> NameProperty = new WrappedPropertyCondition<string>(AutomationElement.NameProperty);
    }
}
