using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace UIAutomationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application application = Application.Launch(@"C:\Users\Fabio\Desktop\MeteoBot\MeteoChrome.exe");
            Window window = application.GetWindow("Form1", InitializeOption.NoCache);
            TextBox textBox = window.Get<TextBox>("textBox1");
            textBox.SetValue("Vene");

            Button button = window.Get<Button>("button1");
            button.Click();

            window.Close();
        }
    }
}
