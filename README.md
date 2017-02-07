# PropertyCondition wrapper for Microsoft's UI Automation Framework

Helps make creating PropertyConditions with Microsoft's UIA Framework less painful and more strongly typed.

[![NuGet Package](https://img.shields.io/badge/NuGet-v1-blue.svg)](https://www.nuget.org/packages/MS.UIA.PropertyConditions.Wrapper/1.0.6247.19457)

### What it does

***

Normally, when using the raw MS UIA Framework creating a `PropertyCondition` to find elements on the screen looks like this:

`PropertyCondition myCondition = new PropertyCondition(AutomationElement.AutomationId, "myautomationId");`

`PropertyCondition`'s constructor takes an `AutomationProperty` and the value being tested against when searching as just an `object` type.  At runtime an exception will be thrown if the type of the value being tested is not the expected type.  



This wrapper helps alleviate that pain by creating stronger typing around the value under test. 

Here's an example:

`PropertyCondition myCondition = ConditionFactory.AutomationId.WithValue("myAutomationId");`

and another:

`PropertyCondition myCondition = ConditionFactory.ControlType.WithValue(ControlType.Button);`

Now you don't need to know what `Type` is necessary in your brain.  For full list of all supported `AutomationProperty` types look [here](https://github.com/Frannsoft/msuia-propertycondition-wrapper/blob/master/MS.UIA.PropertyCondition.Wrapper/MS.UIA.PropertyCondition.Wrapper/ConditionFactory.cs)

***

This lib was built with .NET 4.5 in mind.
