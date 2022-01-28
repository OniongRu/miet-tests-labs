using NUnit.Framework;
using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;



namespace WhiteTest
{
    public class Tests
    {

        private Application _application;
        private readonly string PATH = "D:\\Projects\\University\\TESTS\\labs\\TestLabCalcApp\\bin\\Debug\\TestLabCalcApp.exe";

        [Test]
        public void PlusNumbers()
        {
����������� // �������� ������������
����������� _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("2").Click();
            GetButton("+").Click();
            GetButton("3").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "5");
            _application.Close();
        }

        [Test]
        public void DevNumbers()
        {
����������� // �������� ������������
����������� _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("2").Click();
            GetButton("/").Click();
            GetButton("4").Click();
            GetButton("-/+").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "-0,5");
            _application.Close();
        }

        [Test]
        public void DevByZeroNumbers()
        {
����������� // �������� ������������
����������� _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("5").Click();
            GetButton("/").Click();
            GetButton("0").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "DivideByZero");
            _application.Close();
        }

        [Test]
        public void DelSubNumbers()
        {
����������� // �������� ������������
����������� _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("5").Click();
            GetButton("5").Click();
            GetButton("5").Click();
            GetButton("<").Click();
            GetButton("<").Click();
            GetButton("-").Click();
            GetButton("1").Click();
            GetButton("0").Click();
            GetButton("0").Click();
            GetButton("0").Click();
            GetButton("<").Click();
            GetButton("<").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "-5");
            _application.Close();
        }



        // ������� ���������� �������� 
        private object ResultTextBox()
        {
            string str = GetWindow().Get<Label>("label1").Text;
            return str;

        }

������� // ����� ������ ������
������� public Button GetButton(string nameWindow)
        {
            for (var i = 0; i < 100; i++)
            {
                var button = GetWindow().Get<Button>(SearchCriteria.ByText(nameWindow));
                if (button != null) return button;
            }

            return null;
        }

������� // ����� �������� �������� ���� ������������
������� public Window GetWindow()
        {
            return _application.GetWindow("Form1");
        }
    }
}