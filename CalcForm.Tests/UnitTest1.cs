using System;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;
using System.Windows.Automation.AutomationElement

namespace CalcForm.Tests
{
    public class Tests
    {
        private Application _application;

        [Test]
        public void PlusTwoNumbers()
        {
            // открытие калькулятора
            _application = Application.Launch("D:\\Projects\\University\\TESTS\\labs\\TestLabCalcApp\\bin\\Debug\\TestLabCalcApp.exe");
            Assert.IsNotNull(_application);
            GetButton("2").Click();
            GetButton("+").Click();
            GetButton("3").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "5");
            _application.Close();
        }


        /*
        [Test]
        public void MinusTwoNumbers()
        {
            _application = Application.Launch("C:\\Windows\\system32\\calc.exe");
            Assert.IsNotNull(_application);
            GetButton("Clear").Click();
            GetButton("4").Click();
            GetButton("Subtract").Click();
            GetButton("2").Click();
            GetButton("Equals").Click();
            Assert.AreEqual(ResultTextBox(), "2");
            _application.Close();
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            _application = Application.Launch("C:\\Windows\\system32\\calc.exe");
            Assert.IsNotNull(_application);
            GetButton("Clear").Click();
            GetButton("3").Click();
            GetButton("Multiply").Click();
            GetButton("5").Click();
            GetButton("Equals").Click();
            Assert.AreEqual(ResultTextBox(), "15");
            _application.Close();
        }

        [Test]
        public void DevideTwoNumbers()
        {
            _application = Application.Launch("C:\\Windows\\system32\\calc.exe");
            Assert.IsNotNull(_application);
            GetButton("Clear").Click();
            GetButton("8").Click();
            GetButton("Divide").Click();
            GetButton("2").Click();
            GetButton("Equals").Click();
            Assert.AreEqual(ResultTextBox(), "4");
            _application.Close();
        }
        */
        // возврат результата операций 
        private object ResultTextBox()
        {
            //return GetWindow().Get<Label>(SearchCriteria.ByAutomationId("150")).L
            string res = GetWindow().Get<Label>()
        }

        // метод поиска кнопки
        public Button GetButton(string nameWindow)
        {
            for (var i = 0; i < 100; i++)
            {
                var button = GetWindow().Get<Button>(SearchCriteria.ByAutomationId("label1"))..AutomationElement.
                    GetCurrentPropertyValue(AutomationElement.NameProperty).ToString();
                if (button != null) return button;
            }

            return null;
        }

        // метод возврата главного окна калькулятора
        public Window GetWindow()
        {
            return _application.GetWindow("Form1");
        }
    }
}