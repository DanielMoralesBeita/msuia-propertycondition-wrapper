using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Windows;
using System.Windows.Automation;
using MS.UIA.PropertyConditions.Wrapper;
using NUnit.Framework;

namespace Ms.UIA.PropertyConditions.Wrapper.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class ConditionFactoryTests
    {
        [Test]
        public void VerifyValueTypingCorrect_AutomationIdProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.AutomationIdProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsContentElementProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsContentElementProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsControlElementProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsControlElementProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_LabeledByProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.LabeledByProperty.WithValue(AutomationElement.RootElement);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_NativeWindowHandleProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.NativeWindowHandleProperty.WithValue(1);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsPasswordProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsPasswordProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_HasKeyboardFocusProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.HasKeyboardFocusProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsKeyboardFocusableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsKeyboardFocusableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsEnabledProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsEnabledProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_BoundingRectangleProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.BoundingRectangleProperty.WithValue(new Rect());
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_ProcessIdProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.ProcessIdProperty.WithValue(1);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_RuntimeIdProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.RuntimeIdProperty.WithValue(new[] { 1, 2 });
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_ClickablePointProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.ClickablePointProperty.WithValue(new Point());
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_CultureProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.CultureProperty.WithValue(Thread.CurrentThread.CurrentCulture);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsOffscreenProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsOffscreenProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_OrientationProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.OrientationProperty.WithValue(OrientationType.Horizontal);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsRequiredForFormProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsRequiredForFormProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsDockPatternAvailablePropertyy()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsDockPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsExpandCollapsePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsExpandCollapsePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsGridItemPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsGridItemPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsInvokePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsInvokePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_AcceleratorKeyProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.AcceleratorKeyProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_AccessKeyProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.AccessKeyProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_ClassNameProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.ClassNameProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_FrameworkIdProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.FrameworkIdProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_HelpTextProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.HelpTextProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsMultipleViewPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsMultipleViewPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsRangeValuePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsRangeValuePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsScrollItemPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsScrollItemPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsScrollPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsScrollPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsSelectionItemPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsSelectionItemPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsSelectionPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsSelectionPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsSynchronizedInputPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsSynchronizedInputPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsTableItemPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsTableItemPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrectIsTablePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsTablePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsTextPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsTextPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsTogglePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsTogglePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsTransformPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsTransformPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsValuePatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsValuePatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsVirtualizedItemPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsVirtualizedItemPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_IsWindowPatternAvailableProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.IsWindowPatternAvailableProperty.WithValue(true);
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_ItemStatusProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.ItemStatusProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_ItemTypeProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.ItemTypeProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_LocalizedControlTypeProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.LocalizedControlTypeProperty.WithValue("test");
            });
        }

        [Test]
        public void VerifyValueTypingCorrect_NameProperty()
        {
            Assert.DoesNotThrow(() =>
            {
                PropertyCondition condition = ConditionFactory.NameProperty.WithValue("test");
            });
        }



    }
}
