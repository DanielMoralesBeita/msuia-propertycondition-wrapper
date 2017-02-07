using System;
using System.Windows.Automation;
using MS.UIA.PropertyConditions.Wrapper;
using NUnit.Framework;

namespace Ms.UIA.PropertyConditions.Wrapper.Tests
{
    [TestFixture]
    public class WrappedPropertyConditionTests
    {
        [Test]
        public void WithValueRejectsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                new WrappedPropertyCondition<string>(AutomationElement.AutomationIdProperty).WithValue(null);
            });
        }

        [Test]
        public void HasFlagsBuiltConditionIncludesFlags()
        {
            PropertyCondition condition =
                new WrappedPropertyCondition<string>(AutomationElement.AutomationIdProperty).WithFlags(
                    PropertyConditionFlags.IgnoreCase).WithValue("test");

            Assert.That(condition.Flags.HasFlag(PropertyConditionFlags.IgnoreCase));
        }

        [Test]
        public void NoFlagsBuiltConditionHasNoFlags()
        {
            PropertyCondition condition =
                new WrappedPropertyCondition<string>(AutomationElement.AutomationIdProperty).WithValue("test");

            Assert.That(!condition.Flags.HasFlag(PropertyConditionFlags.IgnoreCase));
        }
    }
}
