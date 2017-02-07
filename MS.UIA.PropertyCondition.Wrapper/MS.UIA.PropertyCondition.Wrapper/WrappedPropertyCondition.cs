using System;
using System.Windows.Automation;

namespace MS.UIA.PropertyConditions.Wrapper
{
    /// <summary>
    /// Handles base operations around a <see cref="PropertyCondition"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WrappedPropertyCondition<T>
    {
        private T _value;
        private readonly AutomationProperty _automationProperty;
        private PropertyConditionFlags? _propertyConditionFlags;

        internal Type AutomationPropertyType => _value.GetType();

        internal WrappedPropertyCondition(AutomationProperty automationProperty)
        {
            _automationProperty = automationProperty;
        }

        /// <summary>
        /// The value used when comparing against the <see cref="AutomationElement"/> <typeparamref name="{T}"/> under test.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public WrappedPropertyCondition<T> WithValue(T value)
        {
            if (value == null)
            { throw new InvalidOperationException("Cannot have a null value as the comparison object for a condition"); }

            _value = value;
            return this;
        }

        /// <summary>
        /// Optional.  Specify <see cref="PropertyConditionFlags"/> to use when performing <see cref="Condition"/> comparison.
        /// </summary>
        /// <param name="propertyConditionFlags"></param>
        /// <returns></returns>
        public WrappedPropertyCondition<T> WithFlags(PropertyConditionFlags propertyConditionFlags)
        {
            _propertyConditionFlags = propertyConditionFlags;
            return this;
        }

        private PropertyCondition Build()
        {
            return _propertyConditionFlags.HasValue ?
                new PropertyCondition(_automationProperty, _value, _propertyConditionFlags.Value) :
                new PropertyCondition(_automationProperty, _value);
        }

        public static implicit operator PropertyCondition(WrappedPropertyCondition<T> wrappedPropertyCondition)
        {
            return wrappedPropertyCondition.Build();
        }
    }
}
